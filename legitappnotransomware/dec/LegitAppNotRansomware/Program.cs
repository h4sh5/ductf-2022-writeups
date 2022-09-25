using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace LegitAppNotRansomware
{
	// Token: 0x02000002 RID: 2
	[StandardModule]
	internal sealed class Program
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002150 File Offset: 0x00000350
		[STAThread]
		public static void Main(string[] args)
		{
			Console.WriteLine("");
			Console.WriteLine(Program.DecodeMe("SEFIQSB5b3UgaGF2ZSBiZWVuIHRyaWNrZWQgYnkgbXkgMTMzNyBoYXh4MHIgc2tpbGxzIQ=="));
			Console.WriteLine("");
			Console.WriteLine(Program.DecodeMe("RW5jcnlwdGluZyA=") + Environment.UserName + Program.DecodeMe("J3MgZmlsZXMgaW4uLi4="));
			Thread.Sleep(1000);
			Console.WriteLine("...5");
			Thread.Sleep(1000);
			Console.WriteLine("...4");
			Thread.Sleep(1000);
			Console.WriteLine("...3");
			Thread.Sleep(1000);
			Console.WriteLine("...2");
			Thread.Sleep(1000);
			Console.WriteLine("...1");
			Thread.Sleep(1000);
			List<string> list = Program.SearchForFiles("C:\\Users\\" + Environment.UserName, new string[]
			{
				"*.png",
				"*.docx"
			});
			try
			{
				foreach (string text in list)
				{
					Console.WriteLine(text);
					Thread.Sleep(10);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				enumerator.Dispose();
			}
			Console.WriteLine("");
			Console.WriteLine(Program.DecodeMe("Li4uc28geW91IHdhbnQgdG8gZGVjcnlwdCB5b3VyIGZpbGVzPyBFbnRlciB0aGUgcGFzc3dvcmQ6IA=="));
			Console.WriteLine("");
			if (Operators.CompareString(Program.EncodeMe(Console.ReadLine()), Program.DecodeMe(string.Concat(new string[]
			{
				Program.d,
				Program.u,
				Program.c,
				Program.t,
				Program.f,
				"="
			})), false) == 0)
			{
				Console.WriteLine(Program.DecodeMe("VGhhdCdzIGl0ISBUaGF0J3MgdGhlIGZsYWch"));
			}
			else
			{
				Console.WriteLine(Program.DecodeMe("V3JvbmcgcGFzc3dvcmQsIGxvb2tzIGxpa2UgeW91ciBmaWxlcyBhcmUgVE9BU1Q="));
			}
			Console.ReadLine();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000231C File Offset: 0x0000051C
		public static List<string> SearchForFiles(string RootFolder, string[] FileFilter)
		{
			List<string> list = new List<string>();
			Stack<string> stack = new Stack<string>();
			stack.Push(RootFolder);
			while (stack.Count > 0)
			{
				string text = stack.Pop();
				try
				{
					foreach (string text2 in Directory.GetDirectories(text))
					{
						stack.Push(text2);
					}
					foreach (string text3 in FileFilter)
					{
						list.AddRange(Directory.GetFiles(text, text3));
					}
				}
				catch (Exception ex)
				{
				}
			}
			return list;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000023C4 File Offset: 0x000005C4
		public static string EncodeMe(string input)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000023D6 File Offset: 0x000005D6
		public static string DecodeMe(string input)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(input));
		}

		// Token: 0x04000001 RID: 1
		private static string a = "d3Jvbmdv";

		// Token: 0x04000002 RID: 2
		private static string b = "aHR0cHM6Ly9iaXQubHkvM05SMkVvYg==";

		// Token: 0x04000003 RID: 3
		private static string c = "OXdZV";

		// Token: 0x04000004 RID: 4
		private static string d = "UkZWRFZF";

		// Token: 0x04000005 RID: 5
		private static string e = "J1mM7";

		// Token: 0x04000006 RID: 6
		private static string f = "elgyTjFZM1Z0WWpOeWZRPT0";

		// Token: 0x04000007 RID: 7
		private static string g = "4n680y";

		// Token: 0x04000008 RID: 8
		private static string h = "VHlwZSAhZmxhZyBpbiBkaXNjb3JkIGZvciB0aGUgU0VDUkVUIEVORElORw==";

		// Token: 0x04000009 RID: 9
		private static string i = "SG93IG1hbnkgdGltZXMgd2lsbCB5b3UgdXNlIFJTQSBpbiB0aGUgd29ya3BsYWNlPyA6RA==";

		// Token: 0x0400000A RID: 10
		private static string j = "KHNvbWUgb2YgdGhlc2UgZG9uJ3Qgd29yaywganVzdCBpZ25vcmUuLi5vciBtYXliZSBkb24ndD8p";

		// Token: 0x0400000B RID: 11
		private static string l = "SGF2ZSB5b3Ugc3R1ZGllZCBmb3IgT1NDUCB0b2RheT8=";

		// Token: 0x0400000C RID: 12
		private static string m = "aHR0cHM6Ly9iaXQubHkvM01sdmpSOQ==";

		// Token: 0x0400000D RID: 13
		private static string n = "DUCTF{";

		// Token: 0x0400000E RID: 14
		private static string o = "no}";

		// Token: 0x0400000F RID: 15
		private static string p = "4n6grl";

		// Token: 0x04000010 RID: 16
		private static string q = "RUFUIFNMRUVQIENURiBSRVBFQVQ=";

		// Token: 0x04000011 RID: 17
		private static string r = "UmVkIFRlYW0gPiBCbHVlIFRlYW0=";

		// Token: 0x04000012 RID: 18
		private static string s = "U3RhbmQgYmFjayBldmVyeW9uZSwgSSdtIGNlcnRpZmllZCE=";

		// Token: 0x04000013 RID: 19
		private static string t = "zR4WTE4d2NsOWpNREJzWDJG";

		// Token: 0x04000014 RID: 20
		private static string u = "WjdaREZrWDNrd2RW";

		// Token: 0x04000015 RID: 21
		private static string v = "SVNPMjcwMDEgU0FWRSBVUw==";

		// Token: 0x04000016 RID: 22
		private static string w = "Qmx1ZSBUZWFtID4gUmVkIFRlYW0=";

		// Token: 0x04000017 RID: 23
		private static string x = "Z2hpZHJhIHNhdmUgbWUh";

		// Token: 0x04000018 RID: 24
		private static string y = "QXJlIHlvdSBkZWNvZGluZyBhbGwgb2YgdGhlc2U/IFdoYXQgYSBjaGFtcCE=";

		// Token: 0x04000019 RID: 25
		private static string z = "Password1";
	}
}
