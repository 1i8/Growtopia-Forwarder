using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Trash.Properties;

namespace Trash
{
	// Token: 0x0200000D RID: 13
	public class Credits : UserControl
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002572 File Offset: 0x00000772
		public Credits()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002580 File Offset: 0x00000780
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Credits.openit(new WebClient().DownloadString("http://n4hispoor.000webhostapp.com/dc.php").ToString());
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000023E3 File Offset: 0x000005E3
		public static void openit(string x)
		{
			Process.Start("cmd", "/C start " + x);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000259B File Offset: 0x0000079B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00007FAC File Offset: 0x000061AC
		private void InitializeComponent()
		{
			this.components = new Container();
			this.timer1 = new Timer(this.components);
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.label7 = new Label();
			this.label8 = new Label();
			this.pictureBox1 = new PictureBox();
			this.label9 = new Label();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Light", 20f);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(274, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(90, 37);
			this.label1.TabIndex = 8;
			this.label1.Text = "credits";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Light", 14f);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(85, 48);
			this.label2.Name = "label2";
			this.label2.Size = new Size(482, 25);
			this.label2.TabIndex = 9;
			this.label2.Text = "So, if you're reading this, means trash successfully started =)";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI Light", 12f);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(35, 86);
			this.label3.Name = "label3";
			this.label3.Size = new Size(573, 21);
			this.label3.TabIndex = 10;
			this.label3.Text = "NOTE: this project is raw af so just report existent bugs and don't cry if it doesn't work";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Segoe UI Light", 12f);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(35, 119);
			this.label4.Name = "label4";
			this.label4.Size = new Size(582, 21);
			this.label4.TabIndex = 11;
			this.label4.Text = "This will be free until I give this proper support or the server dies(i'm using free host fyi)";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Segoe UI Light", 12f);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(50, 152);
			this.label5.Name = "label5";
			this.label5.Size = new Size(567, 21);
			this.label5.TabIndex = 12;
			this.label5.Text = "I would like to thank my nigger friend Hack4fun for all the help and support he gave";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Segoe UI Light", 12f);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(102, 182);
			this.label6.Name = "label6";
			this.label6.Size = new Size(418, 21);
			this.label6.TabIndex = 13;
			this.label6.Text = "And Boost for supporting and testing this whenever I needed";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI Light", 12f);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(162, 212);
			this.label7.Name = "label7";
			this.label7.Size = new Size(300, 21);
			this.label7.TabIndex = 14;
			this.label7.Text = "also i would thank myself for making this, lol";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Segoe UI Light", 12f);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(76, 242);
			this.label8.Name = "label8";
			this.label8.Size = new Size(503, 21);
			this.label8.TabIndex = 15;
			this.label8.Text = "I'll add more shit in the future, suggest new shit to add there in my discord";
			this.pictureBox1.Image = Resources.dclogo;
			this.pictureBox1.Location = new Point(316, 278);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(204, 50);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += this.pictureBox1_Click;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Segoe UI Light", 20f);
			this.label9.ForeColor = Color.White;
			this.label9.Location = new Point(124, 278);
			this.label9.Name = "label9";
			this.label9.Size = new Size(186, 37);
			this.label9.TabIndex = 17;
			this.label9.Text = "Join (clickable):";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(68, 68, 68);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Name = "Credits";
			base.Size = new Size(670, 331);
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000071 RID: 113
		private IContainer components;

		// Token: 0x04000072 RID: 114
		private Timer timer1;

		// Token: 0x04000073 RID: 115
		private Label label1;

		// Token: 0x04000074 RID: 116
		private Label label2;

		// Token: 0x04000075 RID: 117
		private Label label3;

		// Token: 0x04000076 RID: 118
		private Label label4;

		// Token: 0x04000077 RID: 119
		private Label label5;

		// Token: 0x04000078 RID: 120
		private Label label6;

		// Token: 0x04000079 RID: 121
		private Label label7;

		// Token: 0x0400007A RID: 122
		private Label label8;

		// Token: 0x0400007B RID: 123
		private PictureBox pictureBox1;

		// Token: 0x0400007C RID: 124
		private Label label9;
	}
}
