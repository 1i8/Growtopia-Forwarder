using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Trash
{
	// Token: 0x02000018 RID: 24
	public partial class settings : Form
	{
		// Token: 0x060000FF RID: 255 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		public settings()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(settings.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x06000100 RID: 256
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000101 RID: 257 RVA: 0x000029FD File Offset: 0x00000BFD
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000BD04 File Offset: 0x00009F04
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002A1D File Offset: 0x00000C1D
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002079 File Offset: 0x00000279
		private void exitFormButton_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x040000C0 RID: 192
		private bool _dragging;

		// Token: 0x040000C1 RID: 193
		private Point _start_point = new Point(0, 0);
	}
}
