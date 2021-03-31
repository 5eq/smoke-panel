using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Smoke.Properties
{
	// Token: 0x0200000E RID: 14
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00006848 File Offset: 0x00004A48
		internal Resources()
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00006854 File Offset: 0x00004A54
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Smoke.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000689C File Offset: 0x00004A9C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000068B3 File Offset: 0x00004AB3
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000068BC File Offset: 0x00004ABC
		internal static UnmanagedMemoryStream female_scream
		{
			get
			{
				return Resources.ResourceManager.GetStream("female_scream", Resources.resourceCulture);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000068E4 File Offset: 0x00004AE4
		internal static UnmanagedMemoryStream wrong_answer_sound_effect
		{
			get
			{
				return Resources.ResourceManager.GetStream("wrong_answer_sound_effect", Resources.resourceCulture);
			}
		}

		// Token: 0x0400006B RID: 107
		private static ResourceManager resourceMan;

		// Token: 0x0400006C RID: 108
		private static CultureInfo resourceCulture;
	}
}
