using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Trash.Properties
{
	// Token: 0x0200001A RID: 26
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002B02 File Offset: 0x00000D02
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002B09 File Offset: 0x00000D09
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=GHOSTPC\\SQLEXPRESS;Initial Catalog=POSdb;Integrated Security=True")]
		public string POSdbConnectionString
		{
			get
			{
				return (string)this["POSdbConnectionString"];
			}
		}

		// Token: 0x040000C8 RID: 200
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
