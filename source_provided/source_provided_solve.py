#!/usr/bin/env python3
enc = '\xc4\xda\xc5\xdb\xce\x80\xf8\x3e\x82\xe8\xf7\x82\xef\xc0\xf3\x86\x89\xf0\xc7\xf9\xf7\x92\xca\x8c\xfb\xfc\xff\x89\xff\x93\xd1\xd7\x84\x80\x87\x9a\x9b\xd8\x97\x89\x94\xa6\x89\x9d\xdd\x94\x9a\xa7\xf3\xb2'

for i in range(len(enc)):
	ci = enc[i]
	for k in range(0,128):
		newk = k + i
		newk += 0x42
		newk ^= 0x42
		newk &= 0xff
		newk = chr(newk)
		# i = chr(i)
		# print(newk, ci)
		if newk == ci:
			print(chr(k), end='')
print()