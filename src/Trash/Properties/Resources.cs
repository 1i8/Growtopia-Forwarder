using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Trash.Properties
{
	// Token: 0x02000019 RID: 25
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000107 RID: 263 RVA: 0x000020F0 File Offset: 0x000002F0
		internal Resources()
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002A45 File Offset: 0x00000C45
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Trash.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002A71 File Offset: 0x00000C71
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002A78 File Offset: 0x00000C78
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00002A80 File Offset: 0x00000C80
		internal static string Code
		{
			get
			{
				return Resources.ResourceManager.GetString("Code", Resources.resourceCulture);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002A96 File Offset: 0x00000C96
		internal static Bitmap dclogo
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("dclogo", Resources.resourceCulture);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002AB1 File Offset: 0x00000CB1
		internal static Bitmap dclogo1
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("dclogo1", Resources.resourceCulture);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002ACC File Offset: 0x00000CCC
		internal static Bitmap toolbox
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("toolbox", Resources.resourceCulture);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002AE7 File Offset: 0x00000CE7
		internal static Bitmap tools_512
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("tools-512", Resources.resourceCulture);
			}
		}

		// Token: 0x040000C6 RID: 198
		private static ResourceManager resourceMan;

		// Token: 0x040000C7 RID: 199
		private static CultureInfo resourceCulture;
	}
}
