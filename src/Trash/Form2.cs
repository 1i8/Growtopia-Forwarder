using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace Trash
{
	// Token: 0x0200000B RID: 11
	public partial class Form2 : Form
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000550C File Offset: 0x0000370C
		public Form2()
		{
			this.InitializeComponent();
			this.SidePanel.Height = this.button1.Height;
			this.SidePanel.Top = this.button1.Top;
			this.homeControl1.BringToFront();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Form2.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x06000076 RID: 118
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000077 RID: 119 RVA: 0x0000241A File Offset: 0x0000061A
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000055A0 File Offset: 0x000037A0
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000243A File Offset: 0x0000063A
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002443 File Offset: 0x00000643
		private void button1_Click(object sender, EventArgs e)
		{
			this.SidePanel.Height = this.button1.Height;
			this.SidePanel.Top = this.button1.Top;
			this.homeControl1.BringToFront();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000247C File Offset: 0x0000067C
		private void button2_Click(object sender, EventArgs e)
		{
			this.SidePanel.Height = this.button2.Height;
			this.SidePanel.Top = this.button2.Top;
			this.other1.BringToFront();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002385 File Offset: 0x00000585
		private void exitFormButton_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000020C3 File Offset: 0x000002C3
		private void homeControl1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000024B5 File Offset: 0x000006B5
		private void settingsButton_Click(object sender, EventArgs e)
		{
			new settings().ShowDialog();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000024C2 File Offset: 0x000006C2
		private void button3_Click(object sender, EventArgs e)
		{
			this.SidePanel.Height = this.button3.Height;
			this.SidePanel.Top = this.button3.Top;
			this.credits1.BringToFront();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000024FB File Offset: 0x000006FB
		private void Form2_Load(object sender, EventArgs e)
		{
			AutoUpdater.Start(new WebClient().DownloadString("https://raw.githubusercontent.com/N-a-h/trashsrv/master/srvlink.txt") + "/autupd.xml", null);
			AutoUpdater.DownloadPath = Path.GetTempPath();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000020C3 File Offset: 0x000002C3
		private void credits1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000043 RID: 67
		public string sad = "";

		// Token: 0x04000044 RID: 68
		private bool _dragging;

		// Token: 0x04000045 RID: 69
		private Point _start_point = new Point(0, 0);
	}
}
