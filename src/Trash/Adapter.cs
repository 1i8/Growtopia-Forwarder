using System;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Trash
{
	// Token: 0x02000004 RID: 4
	public class Adapter
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002113 File Offset: 0x00000313
		public Adapter(ManagementObject a, string aname, string cname, int n)
		{
			this.adapter = a;
			this.adaptername = aname;
			this.customname = cname;
			this.devnum = n;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002138 File Offset: 0x00000338
		public Adapter(NetworkInterface i) : this(i.Description)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000039CC File Offset: 0x00001BCC
		public Adapter(string aname)
		{
			this.adaptername = aname;
			ManagementObjectCollection source = new ManagementObjectSearcher("select * from win32_networkadapter where Name='" + this.adaptername + "'").Get();
			this.adapter = source.Cast<ManagementObject>().FirstOrDefault<ManagementObject>();
			try
			{
				Match match = Regex.Match(this.adapter.Path.RelativePath, "\\\"(\\d+)\\\"$");
				this.devnum = int.Parse(match.Groups[1].Value);
			}
			catch
			{
				return;
			}
			this.customname = (from i in NetworkInterface.GetAllNetworkInterfaces()
			where i.Description == this.adaptername
			select " (" + i.Name + ")").FirstOrDefault<string>();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002146 File Offset: 0x00000346
		public NetworkInterface ManagedAdapter
		{
			get
			{
				return (from nic in NetworkInterface.GetAllNetworkInterfaces()
				where nic.Description == this.adaptername
				select nic).FirstOrDefault<NetworkInterface>();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public string Mac
		{
			get
			{
				string result;
				try
				{
					result = BitConverter.ToString(this.ManagedAdapter.GetPhysicalAddress().GetAddressBytes()).Replace("-", "").ToUpper();
				}
				catch
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002163 File Offset: 0x00000363
		public string RegistryKey
		{
			get
			{
				return string.Format("SYSTEM\\ControlSet001\\Control\\Class\\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\\{0:D4}", this.devnum);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public string RegistryMac
		{
			get
			{
				string result;
				try
				{
					using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.RegistryKey, false))
					{
						result = registryKey.GetValue("NetworkAddress").ToString();
					}
				}
				catch
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003B58 File Offset: 0x00001D58
		public bool SetRegistryMac(string value)
		{
			bool flag = false;
			bool result;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.RegistryKey, true))
				{
					if (registryKey == null)
					{
						throw new Exception("Failed to open the registry key");
					}
					if (registryKey.GetValue("AdapterModel") as string != this.adaptername && registryKey.GetValue("DriverDesc") as string != this.adaptername)
					{
						throw new Exception("Adapter not found in registry");
					}
					if (MessageBox.Show(string.Format((value.Length > 0) ? "Changing MAC-adress of adapter {0} from {1} to {2}. Proceed?" : "Clearing custom MAC-address of adapter {0}. Proceed?", this.ToString(), this.Mac, value), "Change MAC-address?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						result = false;
					}
					else
					{
						if ((uint)this.adapter.InvokeMethod("Disable", null) != 0U)
						{
							throw new Exception("Failed to disable network adapter.");
						}
						flag = true;
						if (value.Length > 0)
						{
							registryKey.SetValue("NetworkAddress", value, RegistryValueKind.String);
						}
						else
						{
							registryKey.DeleteValue("NetworkAddress");
						}
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				result = false;
			}
			finally
			{
				if (flag && (uint)this.adapter.InvokeMethod("Enable", null) != 0U)
				{
					MessageBox.Show("Failed to re-enable network adapter.");
				}
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000217A File Offset: 0x0000037A
		public override string ToString()
		{
			return this.adaptername + this.customname;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public static string GetNewMac()
		{
			Random random = new Random();
			byte[] array = new byte[6];
			random.NextBytes(array);
			array[0] = (byte)(array[0] | 2);
			array[0] = (byte)(array[0] & 254);
			return Adapter.MacToString(array);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003D20 File Offset: 0x00001F20
		public static bool IsValidMac(string mac, bool actual)
		{
			if (mac.Length != 12)
			{
				return false;
			}
			if (mac != mac.ToUpper())
			{
				return false;
			}
			if (!Regex.IsMatch(mac, "^[0-9A-F]*$"))
			{
				return false;
			}
			if (actual)
			{
				return true;
			}
			char c = mac[1];
			return c == '2' || c == '6' || c == 'A' || c == 'E';
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000218D File Offset: 0x0000038D
		public static bool IsValidMac(byte[] bytes, bool actual)
		{
			return Adapter.IsValidMac(Adapter.MacToString(bytes), actual);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000219B File Offset: 0x0000039B
		public static string MacToString(byte[] bytes)
		{
			return BitConverter.ToString(bytes).Replace("-", "").ToUpper();
		}

		// Token: 0x04000012 RID: 18
		public ManagementObject adapter;

		// Token: 0x04000013 RID: 19
		public string adaptername;

		// Token: 0x04000014 RID: 20
		public string customname;

		// Token: 0x04000015 RID: 21
		public int devnum;
	}
}
