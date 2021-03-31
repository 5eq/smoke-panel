using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Smoke.Properties
{
	// Token: 0x0200000F RID: 15
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000690C File Offset: 0x00004B0C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400006D RID: 109
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
