using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Trash
{
	// Token: 0x02000015 RID: 21
	public partial class lolz : Form
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x0000A60C File Offset: 0x0000880C
		public lolz(string datez = null, string ipz = null, string resolution = null, string lastworld = null, string pc = null, string user = null)
		{
			this.InitializeComponent();
			this.resLabel.Text = resolution;
			this.dateLabel.Text = datez;
			this.ipLabel.Text = ipz;
			this.computername.Text = pc;
			this.username.Text = user;
			this.lastworldl.Text = lastworld;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(lolz.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x060000E3 RID: 227
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x060000E4 RID: 228 RVA: 0x00002929 File Offset: 0x00000B29
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000A6A8 File Offset: 0x000088A8
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002949 File Offset: 0x00000B49
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002079 File Offset: 0x00000279
		private void exitFormButton_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000020C3 File Offset: 0x000002C3
		private void lolz_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400009D RID: 157
		private bool _dragging;

		// Token: 0x0400009E RID: 158
		private Point _start_point = new Point(0, 0);
	}
}
