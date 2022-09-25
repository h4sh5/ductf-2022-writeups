# ClickMe.exe

```
strings ClickMe.exe
...
mpilationOptions": {},
  "targets": {
    ".NETCoreApp,Version=v6.0": {},
    ".NETCoreApp,Version=v6.0/win-x64": {
      "ClickMe/1.0.0": {
        "runtime": {
          "ClickMe.dll": {}
        }
      }
    }
...
```

its another .net core app! extract + decompile:

```
binwalk --dd=.* ClickMe.exe
mkdir dec
mono dnSpy.Console.exe -o dec _ClickMe.exe.extracted/24600
```

looks like the main flag code is in Form1.cs

(around line 184-206)

```cs

		// Token: 0x0600002B RID: 43 RVA: 0x00002BF8 File Offset: 0x00000DF8
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			if (this.PictureBox1.Size.Height == 1)
			{
				MessageBox.Show("Here's the link! https://bit.ly/3MfBhmD");
			}
			if (this.PictureBox1.Size.Height == 10)
			{
				this.Timer1.Stop();
				this.lbBossFight.ForeColor = Color.Green;
				MessageBox.Show(string.Concat(new string[]
				{
					"How did you do this?!?! ",
					this.Unscramble("UkZWRFZFWT0="),
					this.Unscramble(this.flag),
					this.Unscramble(this.Random_function(this.Label1.Text)),
					this.Unscramble(this.Random_function(this.Label2.Text)),
					this.Unscramble(this.Random_function(this.Label3.Text)),
					"_ZGVhZGIzM2ZjYWZl",
					this.Unscramble(this.galf)
				}));
			}
```

Umscramble function:

```cs

// Token: 0x06000030 RID: 48 RVA: 0x00002E2D File Offset: 0x0000102D
		public string Random_function(string input)
		{
			return Encoding.UTF8.GetString(Convert.FromHexString(input));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002E3F File Offset: 0x0000103F
		public string Non_Random_function(string input)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(input));
		}

// Token: 0x0600002F RID: 47 RVA: 0x00002E15 File Offset: 0x00001015
		public string Unscramble(string input)
		{
			return this.Non_Random_function(Encoding.UTF8.GetString(Convert.FromBase64String(input)));
		}
```


so Random_function is just hex, Non_Random_function is base64

Umscramble is also just b64

flag ordering: (Label1/2/.. text can be found in Form1.Designer.cs)

```
UkZWRFZFWT0=
ZXc9PQ==
576B64736131677A62485A6B55543039
57444E57656C70574F44303D
57565935565646575453383D
_ZGVhZGIzM2ZjYWZl (plain)
ZlE9PQ==
```


