using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClickMe
{
	// Token: 0x02000006 RID: 6
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002150 File Offset: 0x00000350
		public Form1()
		{
			base.Load += new EventHandler(this.Form1_Load);
			this.flag = "ZXc9PQ==";
			this.galf = "ZlE9PQ==";
			this.contents = "bmV2ZXIgZ29ubmEgZ2l2ZSB5b3UgdXA=";
			this.I_am_speedrunner = new Stopwatch();
			this.InitializeComponent();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000298C File Offset: 0x00000B8C
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002994 File Offset: 0x00000B94
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PictureBox1_Click);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= eventHandler;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000029D7 File Offset: 0x00000BD7
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000029E0 File Offset: 0x00000BE0
		internal virtual Timer DUCTF
		{
			[CompilerGenerated]
			get
			{
				return this._DUCTF;
			}
			[CompilerGenerated]
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DUCTF_Tick);
				Timer ductf = this._DUCTF;
				if (ductf != null)
				{
					ductf.Tick -= eventHandler;
				}
				this._DUCTF = value;
				ductf = this._DUCTF;
				if (ductf != null)
				{
					ductf.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002A23 File Offset: 0x00000C23
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002A2B File Offset: 0x00000C2B
		internal virtual Label sp33d { get; [MethodImpl(32)] set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002A34 File Offset: 0x00000C34
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002A3C File Offset: 0x00000C3C
		internal virtual Label running { get; [MethodImpl(32)] set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002A45 File Offset: 0x00000C45
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002A4D File Offset: 0x00000C4D
		internal virtual Label reversing { get; [MethodImpl(32)] set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002A56 File Offset: 0x00000C56
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002A5E File Offset: 0x00000C5E
		internal virtual Label lbTutorial { get; [MethodImpl(32)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002A67 File Offset: 0x00000C67
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002A6F File Offset: 0x00000C6F
		internal virtual Label lbWaterLevel { get; [MethodImpl(32)] set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002A78 File Offset: 0x00000C78
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002A80 File Offset: 0x00000C80
		internal virtual Label lbBossFight { get; [MethodImpl(32)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002A89 File Offset: 0x00000C89
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002A94 File Offset: 0x00000C94
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002AD7 File Offset: 0x00000CD7
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002ADF File Offset: 0x00000CDF
		internal virtual Label Label1 { get; [MethodImpl(32)] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002AE8 File Offset: 0x00000CE8
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002AF0 File Offset: 0x00000CF0
		internal virtual Label Label2 { get; [MethodImpl(32)] set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002AF9 File Offset: 0x00000CF9
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002B01 File Offset: 0x00000D01
		internal virtual Label Label3 { get; [MethodImpl(32)] set; }

		// Token: 0x06000029 RID: 41 RVA: 0x00002B0C File Offset: 0x00000D0C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			TimeSpan elapsed = this.I_am_speedrunner.Elapsed;
			if (this.lbTutorial.ForeColor == Color.Green && this.lbWaterLevel.ForeColor == Color.Green)
			{
				this.lbBossFight.Text = elapsed.ToString("mm\\:ss\\:fff");
			}
			if (this.lbTutorial.ForeColor == Color.Green && this.lbWaterLevel.ForeColor != Color.Green)
			{
				this.lbWaterLevel.Text = elapsed.ToString("mm\\:ss\\:fff");
			}
			if (this.lbTutorial.ForeColor != Color.Green)
			{
				this.lbTutorial.Text = elapsed.ToString("mm\\:ss\\:fff");
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002BDD File Offset: 0x00000DDD
		private void Form1_Load(object sender, EventArgs e)
		{
			this.I_am_speedrunner.Start();
			this.Timer1.Start();
		}

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
			if (this.PictureBox1.Size.Height == 75)
			{
				MessageBox.Show("You clicked me again! [EUROBEAT INTENSIFIES]");
				this.PictureBox1.Size = new Size(10, 10);
				this.DUCTF.Interval = 69;
				this.lbBossFight.Text = "00:00:00";
				this.lbWaterLevel.ForeColor = Color.Green;
			}
			if (this.PictureBox1.Size.Height == 100)
			{
				MessageBox.Show("You clicked me! Time to get a bit smaller and faster!");
				this.PictureBox1.Size = new Size(75, 75);
				this.DUCTF.Interval = 420;
				this.lbWaterLevel.Text = "00:00:00";
				this.lbTutorial.ForeColor = Color.Green;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002DBF File Offset: 0x00000FBF
		private void DUCTF_Tick(object sender, EventArgs e)
		{
			this.MovePictureBoxToRandomLocation();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002DC8 File Offset: 0x00000FC8
		private void MovePictureBoxToRandomLocation()
		{
			Random random = new Random();
			this.PictureBox1.Location = new Point(random.Next(0, 1000), random.Next(0, 1000));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002E03 File Offset: 0x00001003
		public string Scramble(string input)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002E15 File Offset: 0x00001015
		public string Unscramble(string input)
		{
			return this.Non_Random_function(Encoding.UTF8.GetString(Convert.FromBase64String(input)));
		}

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

		// Token: 0x04000015 RID: 21
		private string flag;

		// Token: 0x04000016 RID: 22
		private string galf;

		// Token: 0x04000017 RID: 23
		private string contents;

		// Token: 0x04000018 RID: 24
		private Stopwatch I_am_speedrunner;
	}
}
