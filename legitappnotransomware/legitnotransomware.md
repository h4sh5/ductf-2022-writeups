in strings:


```
C:\Users\Nosurf\source\repos\LegitAppNotRansomware\LegitAppNotRansomware\obj\Release\net6.0\win-x64\LegitAppNotRansomware.pdb
SHA256
<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<assembly xmlns="urn:schemas-microsoft-com:asm.v1" manifestVersion="1.0">
  <assemblyIdentity version="1.0.0.0" name="MyApplication.app"/>
  <trustInfo xmlns="urn:schemas-microsoft-com:asm.v2">
    <security>
      <requestedPrivileges xmlns="urn:schemas-microsoft-com:asm.v3">
        <requestedExecutionLevel level="asInvoker" uiAccess="false"/>
      </requestedPrivileges>
    </security>
  </trustInfo>
</assembly>
  "runtimeTarget": {
    "name": ".NETCoreApp,Version=v6.0/win-x64",
    "signature": ""

```

so dotnet app? 

extract the dotnet app from within the dotnet core app using binwalk

```
binwalk --dd='.*' LegitAppNotRansomware.exe 

DECIMAL       HEXADECIMAL     DESCRIPTION
--------------------------------------------------------------------------------
0             0x0             Microsoft executable, portable (PE)
147419        0x23FDB         XML document, version: "1.0"
148992        0x24600         Microsoft executable, portable (PE)
156635        0x263DB         XML document, version: "1.0"

```

it's the one at 0x24600

`mono dnSpy.Console.exe -o ../dec 24600`

got the src code, with a bunch of base64 strings

```
rg -i decodeme LegitAppNotRansomware/
LegitAppNotRansomware/Program.cs
19:			Console.WriteLine(Program.DecodeMe("SEFIQSB5b3UgaGF2ZSBiZWVuIHRyaWNrZWQgYnkgbXkgMTMzNyBoYXh4MHIgc2tpbGxzIQ=="));
21:			Console.WriteLine(Program.DecodeMe("RW5jcnlwdGluZyA=") + Environment.UserName + Program.DecodeMe("J3MgZmlsZXMgaW4uLi4="));
52:			Console.WriteLine(Program.DecodeMe("Li4uc28geW91IHdhbnQgdG8gZGVjcnlwdCB5b3VyIGZpbGVzPyBFbnRlciB0aGUgcGFzc3dvcmQ6IA=="));
54:			if (Operators.CompareString(Program.EncodeMe(Console.ReadLine()), Program.DecodeMe(string.Concat(new string[]
64:				Console.WriteLine(Program.DecodeMe("VGhhdCdzIGl0ISBUaGF0J3MgdGhlIGZsYWch"));
68:				Console.WriteLine(Program.DecodeMe("V3JvbmcgcGFzc3dvcmQsIGxvb2tzIGxpa2UgeW91ciBmaWxlcyBhcmUgVE9BU1Q="));
107:		public static string DecodeMe(string input)

```

SEFIQSB5b3UgaGF2ZSBiZWVuIHRyaWNrZWQgYnkgbXkgMTMzNyBoYXh4MHIgc2tpbGxzIQ==
RW5jcnlwdGluZyA=
J3MgZmlsZXMgaW4uLi4=
Li4uc28geW91IHdhbnQgdG8gZGVjcnlwdCB5b3VyIGZpbGVzPyBFbnRlciB0aGUgcGFzc3dvcmQ6IA==
VGhhdCdzIGl0ISBUaGF0J3MgdGhlIGZsYWch
V3JvbmcgcGFzc3dvcmQsIGxvb2tzIGxpa2UgeW91ciBmaWxlcyBhcmUgVE9BU1Q=

```
HAHA you have been tricked by my 1337 haxx0r skills!
Encrypting 
's files in...
...so you want to decrypt your files? Enter the password: 
That's it! That's the flag!
Wrong password, looks like your files are TOAST

```

there's a password in the src code (not encoded):

```
private static string z = "Password1";
```

```cs
if (Operators.CompareString(Program.EncodeMe(Console.ReadLine()), Program.DecodeMe(string.Concat(new string[]
			{
				Program.d,
				Program.u,
				Program.c,
				Program.t,
				Program.f,
				"="
			})), false) == 0)
```

d u c t f variables combined + =:

UkZWRFZFWjdaREZrWDNrd2RWOXdZVzR4WTE4d2NsOWpNREJzWDJGelgyTjFZM1Z0WWpOeWZRPT0=

```
echo UkZWRFZFWjdaREZrWDNrd2RWOXdZVzR4WTE4d2NsOWpNREJzWDJGelgyTjFZM1Z0WWpOeWZRPT0=|base64 -d
RFVDVEZ7ZDFkX3kwdV9wYW4xY18wcl9jMDBsX2FzX2N1Y3VtYjNyfQ==
```

decode again:
DUCTF{d1d_y0u_pan1c_0r_c00l_as_cucumb3r}

