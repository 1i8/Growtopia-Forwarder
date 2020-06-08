using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Trash
{
	// Token: 0x02000002 RID: 2
	public partial class Bypass : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002D24 File Offset: 0x00000F24
		public Bypass(string mac)
		{
			this.InitializeComponent();
			if (mac != null)
			{
				this.textBox1.Text = mac;
			}
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Bypass.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x06000002 RID: 2
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002D84 File Offset: 0x00000F84
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002070 File Offset: 0x00000270
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002DD8 File Offset: 0x00000FD8
		public static string Get5RND()
		{
			string result;
			try
			{
				RegistryKey registryKey = Registry.CurrentUser;
				registryKey = registryKey.OpenSubKey("Software\\Microsoft", true);
				foreach (string text in registryKey.GetSubKeyNames())
				{
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 5)
					{
						registryKey.DeleteSubKeyTree(text);
						return text;
					}
					if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled))
					{
						int length = text.Length;
					}
				}
				result = "NULL";
			}
			catch
			{
				result = "NULL";
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002E70 File Offset: 0x00001070
		public static string Get9RND()
		{
			string result;
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				foreach (string text in currentUser.GetSubKeyNames())
				{
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 9)
					{
						currentUser.DeleteSubKeyTree(text);
						return text;
					}
					if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled))
					{
						int length = text.Length;
					}
				}
				result = "NULL";
			}
			catch
			{
				result = "NULL";
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002079 File Offset: 0x00000279
		private void exitFormButton_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002081 File Offset: 0x00000281
		private void SetRegistryMac(string mac)
		{
			if ((this.AdaptersComboBox.SelectedItem as Adapter).SetRegistryMac(mac))
			{
				Thread.Sleep(100);
				this.UpdateAddresses();
				MessageBox.Show("Success!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002F00 File Offset: 0x00001100
		private void button2_Click(object sender, EventArgs e)
		{
			string text = this.textBox1.Text.Replace(":", "");
			if (!Adapter.IsValidMac(text, true))
			{
				MessageBox.Show("Entered MAC-address is invalid", "RIP", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			this.SetRegistryMac(text);
			Bypass.Get5RND();
			Bypass.Get9RND();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002F58 File Offset: 0x00001158
		private void Bypass_Load(object sender, EventArgs e)
		{
			bool flag;
			using (WindowsIdentity current = WindowsIdentity.GetCurrent())
			{
				flag = new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator);
			}
			if (flag)
			{
				foreach (NetworkInterface i in from a in NetworkInterface.GetAllNetworkInterfaces()
				where Adapter.IsValidMac(a.GetPhysicalAddress().GetAddressBytes(), true)
				orderby a.Speed descending
				select a)
				{
					this.AdaptersComboBox.Items.Add(new Adapter(i));
				}
				this.AdaptersComboBox.SelectedIndex = 0;
				return;
			}
			if (MessageBox.Show("In order to edit system registry values, trash requires administrator rights. Would you like to restart the program with administrative rights?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Process.Start(new ProcessStartInfo(Process.GetCurrentProcess().MainModule.FileName)
				{
					Verb = "runas"
				});
				Environment.Exit(0);
				return;
			}
			MessageBox.Show("Whelp. You can't use AAP bypass without administrative rights...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			base.Hide();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003098 File Offset: 0x00001298
		private void UpdateAddresses()
		{
			Adapter adapter = this.AdaptersComboBox.SelectedItem as Adapter;
			if (adapter.RegistryMac != null)
			{
				this.ActualMacLabel.Text = adapter.RegistryMac;
			}
			else
			{
				this.ActualMacLabel.Text = "failed";
			}
			this.orig.Text = adapter.Mac;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020BB File Offset: 0x000002BB
		private void AdaptersComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.UpdateAddresses();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020C3 File Offset: 0x000002C3
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private bool _dragging;

		// Token: 0x04000002 RID: 2
		private Point _start_point = new Point(0, 0);
	}
}
