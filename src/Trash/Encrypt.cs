using System;
using System.Security.Cryptography;
using System.Text;

namespace Trash
{
	// Token: 0x02000009 RID: 9
	public class Encrypt
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00003D7C File Offset: 0x00001F7C
		public static string EncryptMessage(byte[] text)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 256;
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Key = Encoding.Default.GetBytes("encryptionkeykey");
			rijndaelManaged.GenerateIV();
			string str = "-[--IV-[-" + Encoding.Default.GetString(rijndaelManaged.IV);
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			return Convert.ToBase64String(Encoding.Default.GetBytes(Encoding.Default.GetString(cryptoTransform.TransformFinalBlock(text, 0, text.Length)) + str));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003E28 File Offset: 0x00002028
		public static string DecryptMessage(string text)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 256;
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Key = Encoding.Default.GetBytes("encryptionkeykey");
			text = Encoding.Default.GetString(Convert.FromBase64String(text));
			string text2 = text;
			text2 = text2.Substring(text2.IndexOf("-[--IV-[-") + 9);
			text = text.Replace("-[--IV-[-" + text2, "");
			text = Convert.ToBase64String(Encoding.Default.GetBytes(text));
			rijndaelManaged.IV = Encoding.Default.GetBytes(text2);
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			byte[] array = Convert.FromBase64String(text);
			return Encoding.Default.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}

		// Token: 0x04000030 RID: 48
		private const string key = "encryptionkeykey";
	}
}
