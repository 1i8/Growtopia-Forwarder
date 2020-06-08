using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Trash
{
	// Token: 0x02000016 RID: 22
	public partial class credentials : Form
	{
		// Token: 0x060000EB RID: 235 RVA: 0x0000B174 File Offset: 0x00009374
		public credentials(List<credentials.Browserz> lol = null)
		{
			this.InitializeComponent();
			int num = 0;
			foreach (credentials.Browserz browserz in lol)
			{
				this.bunifuCustomDataGrid1.Rows.Add();
				this.bunifuCustomDataGrid1.Rows[num].Cells["URL"].Value = browserz.url;
				this.bunifuCustomDataGrid1.Rows[num].Cells["Browser"].Value = browserz.browser;
				this.bunifuCustomDataGrid1.Rows[num].Cells["Password"].Value = browserz.password;
				this.bunifuCustomDataGrid1.Rows[num].Cells["Login"].Value = browserz.login;
				num++;
			}
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(credentials.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x060000EC RID: 236
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x060000ED RID: 237 RVA: 0x00002971 File Offset: 0x00000B71
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000B2C8 File Offset: 0x000094C8
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002991 File Offset: 0x00000B91
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002079 File Offset: 0x00000279
		private void exitFormButton_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000B31C File Offset: 0x0000951C
		private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.bunifuCustomDataGrid1.CurrentRow.Cells["Password"].Value != null)
			{
				Clipboard.SetText(this.bunifuCustomDataGrid1.CurrentRow.Cells["Password"].Value.ToString());
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000B374 File Offset: 0x00009574
		private void copyLoginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.bunifuCustomDataGrid1.CurrentRow.Cells["Login"].Value != null)
			{
				Clipboard.SetText(this.bunifuCustomDataGrid1.CurrentRow.Cells["Login"].Value.ToString());
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000B3CC File Offset: 0x000095CC
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.bunifuCustomDataGrid1.CurrentRow.Cells["URL"].Value != null)
			{
				Clipboard.SetText(this.bunifuCustomDataGrid1.CurrentRow.Cells["URL"].Value.ToString());
			}
		}

		// Token: 0x040000AE RID: 174
		private bool _dragging;

		// Token: 0x040000AF RID: 175
		private Point _start_point = new Point(0, 0);

		// Token: 0x02000017 RID: 23
		[DataContract]
		public class Browserz
		{
			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x000029B9 File Offset: 0x00000BB9
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x000029C1 File Offset: 0x00000BC1
			[DataMember]
			public string browser { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x000029CA File Offset: 0x00000BCA
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x000029D2 File Offset: 0x00000BD2
			[DataMember]
			public string url { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000FA RID: 250 RVA: 0x000029DB File Offset: 0x00000BDB
			// (set) Token: 0x060000FB RID: 251 RVA: 0x000029E3 File Offset: 0x00000BE3
			[DataMember]
			public string password { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000FC RID: 252 RVA: 0x000029EC File Offset: 0x00000BEC
			// (set) Token: 0x060000FD RID: 253 RVA: 0x000029F4 File Offset: 0x00000BF4
			[DataMember]
			public string login { get; set; }
		}
	}
}
