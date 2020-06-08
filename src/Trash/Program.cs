using System;
using System.Windows.Forms;

namespace Trash
{
	// Token: 0x02000014 RID: 20
	internal static class Program
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00002912 File Offset: 0x00000B12
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
