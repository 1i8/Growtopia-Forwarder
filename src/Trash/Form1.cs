using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Microsoft.Win32;
using Trash.Properties;

namespace Trash
{
	// Token: 0x0200000A RID: 10
	public partial class Form1 : Form
	{
		// Token: 0x0600005D RID: 93
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600005E RID: 94 RVA: 0x00003F08 File Offset: 0x00002108
		public Form1()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002385 File Offset: 0x00000585
		private void button1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003F58 File Offset: 0x00002158
		private string request(NameValueCollection nvc, string action)
		{
			string @string;
			using (WebClient webClient = new WebClient())
			{
				string str = new WebClient().DownloadString("https://raw.githubusercontent.com/N-a-h/trashsrv/master/srvlink.txt");
				MessageBox.Show(str + "/" + action + ".php");
				byte[] bytes = webClient.UploadValues(str + "/" + action + ".php", nvc);
				@string = Encoding.Default.GetString(bytes);
			}
			return @string;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003FD4 File Offset: 0x000021D4
		public string identifier(string wmiClass, string wmiProperty)
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(wmiClass).GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == "")
				{
					try
					{
						text = managementObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000238D File Offset: 0x0000058D
		private void passwordText_OnValueChanged(object sender, EventArgs e)
		{
			this.passwordTextbox.isPassword = true;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004058 File Offset: 0x00002258
		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["check"] = "changelog";
				RichTextBox richTextBox = this.richTextBox1;
				richTextBox.Text += this.request(nameValueCollection, "info");
			}
			catch
			{
				MessageBox.Show("Can't connect to the server. Is your internet connection operational?");
			}
			bool visible;
			using (WindowsIdentity current = WindowsIdentity.GetCurrent())
			{
				visible = new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator);
			}
			this.label7.Visible = visible;
			new Form2
			{
				sad = "retard"
			}.ShowDialog();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000040F8 File Offset: 0x000022F8
		public string hardwareid()
		{
			string str = this.identifier("Win32_DiskDrive", "Model");
			string str2 = this.identifier("Win32_DiskDrive", "Manufacturer");
			string str3 = this.identifier("Win32_DiskDrive", "Signature");
			string str4 = this.identifier("Win32_DiskDrive", "TotalHeads");
			string s = str + str2 + str3 + str4;
			string result;
			using (SHA1Managed sha1Managed = new SHA1Managed())
			{
				byte[] array = sha1Managed.ComputeHash(Encoding.UTF8.GetBytes(s));
				StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
				foreach (byte b in array)
				{
					stringBuilder.Append(b.ToString("X2"));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000239B File Offset: 0x0000059B
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000041D0 File Offset: 0x000023D0
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000023BB File Offset: 0x000005BB
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000023C4 File Offset: 0x000005C4
		private void button2_MouseHover(object sender, EventArgs e)
		{
			this.loginButton.BackColor = Color.Transparent;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000020C3 File Offset: 0x000002C3
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004224 File Offset: 0x00002424
		private string genhash(string input)
		{
			byte[] array = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
			StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004280 File Offset: 0x00002480
		private void loginButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (!(this.usernameTextbox.Text == string.Empty))
				{
					if (!(this.passwordTextbox.Text == string.Empty))
					{
						NameValueCollection nameValueCollection = new NameValueCollection();
						string text2;
						string text = text2 = this.usernameTextbox.Text;
						string value = this.genhash(this.passwordTextbox.Text);
						string value2 = this.hardwareid();
						nameValueCollection["login"] = text2.ToLower();
						nameValueCollection["password"] = value;
						nameValueCollection["identifier"] = value2;
						string text3 = text.ToLower();
						string text4 = this.request(nameValueCollection, "login");
						if (text4.Contains("success"))
						{
							string str = text4.Split(new char[]
							{
								'|'
							}, StringSplitOptions.RemoveEmptyEntries)[1];
							using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
							{
								RegistryKey registryKey2 = registryKey;
								if (registryKey != null)
								{
									registryKey2 = registryKey2.CreateSubKey("trash\\lol");
									registryKey2.SetValue("ownr", text3);
									registryKey2.SetValue("aut", value);
								}
							}
							MessageBox.Show("Logged in successfully. This account expires at " + str, "login page", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							base.Hide();
							new Form2
							{
								sad = text3
							}.ShowDialog();
						}
						else if (text4.Contains("stolen"))
						{
							MessageBox.Show("This is not your account.", "failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
						else if (text4.Contains("ban"))
						{
							MessageBox.Show("You were been blacklisted.", "blacklist", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							Environment.Exit(0);
						}
						else if (text4.Contains("fail"))
						{
							MessageBox.Show("Username/password is wrong. Try again", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						else if (text4.Contains("expired"))
						{
							MessageBox.Show("This trash account has expired. Extend your license in our discord(click the picture below register button).", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
				}
				else
				{
					MessageBox.Show("maybe you should put your password?", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000239B File Offset: 0x0000059B
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this._dragging = true;
			this._start_point = new Point(e.X, e.Y);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000041D0 File Offset: 0x000023D0
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this._dragging)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this._start_point.X, point.Y - this._start_point.Y);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000023BB File Offset: 0x000005BB
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this._dragging = false;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000023D6 File Offset: 0x000005D6
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/phRzqpE");
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000044C4 File Offset: 0x000026C4
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string str = new WebClient().DownloadString("https://raw.githubusercontent.com/N-a-h/trashsrv/master/srvlink.txt");
			Form1.openit(webClient.DownloadString(str + "/dc.php").ToString());
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000023E3 File Offset: 0x000005E3
		public static void openit(string x)
		{
			Process.Start("cmd", "/C start " + x);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004500 File Offset: 0x00002700
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				Regex regex = new Regex("^[a-zA-Z0-9]*$");
				if (!(this.usernameTextbox.Text == string.Empty))
				{
					if (!(this.passwordTextbox.Text == string.Empty))
					{
						if (regex.IsMatch(this.usernameTextbox.Text))
						{
							if (regex.IsMatch(this.passwordTextbox.Text))
							{
								NameValueCollection nameValueCollection = new NameValueCollection();
								string text = this.usernameTextbox.Text;
								string value = this.genhash(this.passwordTextbox.Text);
								string value2 = this.hardwareid();
								nameValueCollection["login"] = text.ToLower();
								nameValueCollection["password"] = value;
								nameValueCollection["identifier"] = value2;
								string text2 = this.request(nameValueCollection, "register");
								if (text2.Contains("success"))
								{
									MessageBox.Show("New account has been registered successfully. You can login now using your username/password!", "Registration successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
								else if (text2.Contains("overuse"))
								{
									MessageBox.Show("You can't register more than one account at one time!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
								else if (text2.Contains("vpn"))
								{
									MessageBox.Show("Turn off your fucking vpn before attempting to register", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
								else if (text2.Contains("fail"))
								{
									MessageBox.Show("Unknown error occured. Try again", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								}
							}
							else
							{
								MessageBox.Show("Password must consist only of alphanumeric characters!", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							}
						}
						else
						{
							MessageBox.Show("Username must consist only of alphanumeric characters!", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
					else
					{
						MessageBox.Show("maybe you should put your password?", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					MessageBox.Show("maybe you should put your username?", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Server is dead or your internet is not working. Try again later", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x04000031 RID: 49
		private bool _dragging;

		// Token: 0x04000032 RID: 50
		private Point _start_point = new Point(0, 0);
	}
}
