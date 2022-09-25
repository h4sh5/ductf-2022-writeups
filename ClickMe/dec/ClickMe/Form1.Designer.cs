namespace ClickMe
{
	// Token: 0x02000006 RID: 6
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000021A8 File Offset: 0x000003A8
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021E8 File Offset: 0x000003E8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ClickMe.Form1));
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.DUCTF = new global::System.Windows.Forms.Timer(this.components);
			this.sp33d = new global::System.Windows.Forms.Label();
			this.running = new global::System.Windows.Forms.Label();
			this.reversing = new global::System.Windows.Forms.Label();
			this.lbTutorial = new global::System.Windows.Forms.Label();
			this.lbWaterLevel = new global::System.Windows.Forms.Label();
			this.lbBossFight = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.PictureBox1.BeginInit();
			base.SuspendLayout();
			this.PictureBox1.BackColor = global::System.Drawing.SystemColors.Desktop;
			this.PictureBox1.Location = new global::System.Drawing.Point(1337, 1337);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(100, 100);
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.DUCTF.Enabled = true;
			this.DUCTF.Interval = 1420;
			this.sp33d.AutoSize = true;
			this.sp33d.BackColor = global::System.Drawing.Color.Transparent;
			this.sp33d.Font = new global::System.Drawing.Font("Segoe UI", 10f, 1, 3);
			this.sp33d.ForeColor = global::System.Drawing.SystemColors.Control;
			this.sp33d.Location = new global::System.Drawing.Point(12, 9);
			this.sp33d.Name = "sp33d";
			this.sp33d.Size = new global::System.Drawing.Size(86, 28);
			this.sp33d.TabIndex = 1;
			this.sp33d.Text = "Tutorial";
			this.running.AutoSize = true;
			this.running.BackColor = global::System.Drawing.Color.Transparent;
			this.running.Font = new global::System.Drawing.Font("Segoe UI", 10f, 1, 3);
			this.running.ForeColor = global::System.Drawing.SystemColors.Control;
			this.running.Location = new global::System.Drawing.Point(12, 45);
			this.running.Name = "running";
			this.running.Size = new global::System.Drawing.Size(124, 28);
			this.running.TabIndex = 2;
			this.running.Text = "Water Level";
			this.reversing.AutoSize = true;
			this.reversing.BackColor = global::System.Drawing.Color.Transparent;
			this.reversing.Font = new global::System.Drawing.Font("Segoe UI", 10f, 1, 3);
			this.reversing.ForeColor = global::System.Drawing.SystemColors.Control;
			this.reversing.Location = new global::System.Drawing.Point(12, 81);
			this.reversing.Name = "reversing";
			this.reversing.Size = new global::System.Drawing.Size(109, 28);
			this.reversing.TabIndex = 3;
			this.reversing.Text = "Boss Fight";
			this.lbTutorial.AutoSize = true;
			this.lbTutorial.BackColor = global::System.Drawing.Color.Transparent;
			this.lbTutorial.Font = new global::System.Drawing.Font("Segoe UI", 10f, 1, 3);
			this.lbTutorial.ForeColor = global::System.Drawing.Color.Firebrick;
			this.lbTutorial.Location = new global::System.Drawing.Point(177, 9);
			this.lbTutorial.Name = "lbTutorial";
			this.lbTutorial.Size = new global::System.Drawing.Size(65, 28);
			this.lbTutorial.TabIndex = 4;
			this.lbTutorial.Text = "00:00";
			this.lbWaterLevel.AutoSize = true;
			this.lbWaterLevel.BackColor = global::System.Drawing.Color.Transparent;
			this.lbWaterLevel.Font = new global::System.Drawing.Font("Segoe UI", 10f, 1, 3);
			this.lbWaterLevel.ForeColor = global::System.Drawing.Color.Firebrick;
			this.lbWaterLevel.Location = new global::System.Drawing.Point(177, 45);
			this.lbWaterLevel.Name = "lbWaterLevel";
			this.lbWaterLevel.Size = new global::System.Drawing.Size(65, 28);
			this.lbWaterLevel.TabIndex = 5;
			this.lbWaterLevel.Text = "00:00";
			this.lbBossFight.AutoSize = true;
			this.lbBossFight.BackColor = global::System.Drawing.Color.Transparent;
			this.lbBossFight.Font = new global::System.Drawing.Font("Segoe UI", 10f, 1, 3);
			this.lbBossFight.ForeColor = global::System.Drawing.Color.Firebrick;
			this.lbBossFight.Location = new global::System.Drawing.Point(177, 81);
			this.lbBossFight.Name = "lbBossFight";
			this.lbBossFight.Size = new global::System.Drawing.Size(65, 28);
			this.lbBossFight.TabIndex = 6;
			this.lbBossFight.Text = "00:00";
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(1119, 1184);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(336, 25);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "576B64736131677A62485A6B55543039";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(1117, 1219);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(254, 25);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "57444E57656C70574F44303D";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(1115, 1254);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(255, 25);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "57565935565646575453383D";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(10f, 25f);
			base.AutoScaleMode = 1;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = 3;
			base.ClientSize = new global::System.Drawing.Size(978, 944);
			base.ControlBox = false;
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.lbBossFight);
			base.Controls.Add(this.lbWaterLevel);
			base.Controls.Add(this.lbTutorial);
			base.Controls.Add(this.reversing);
			base.Controls.Add(this.running);
			base.Controls.Add(this.sp33d);
			base.Controls.Add(this.PictureBox1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(1000, 1000);
			base.MdiChildrenMinimizedAnchorBottom = false;
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(1000, 1000);
			base.Name = "Form1";
			this.Text = "ClickMe!!";
			this.PictureBox1.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components;
	}
}
