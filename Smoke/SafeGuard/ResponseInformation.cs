using System;
using Smoke;

namespace SafeGuard
{
	// Token: 0x02000005 RID: 5
	internal static class ResponseInformation
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000022A4 File Offset: 0x000004A4
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000022AB File Offset: 0x000004AB
		public static SmokeMain.RootObject RootObject { get; internal set; }

		// Token: 0x04000006 RID: 6
		internal static string Password;

		// Token: 0x04000007 RID: 7
		internal static LoginResponse loginresponse;

		// Token: 0x04000008 RID: 8
		internal static RegisterInformationObject registerinfo;

		// Token: 0x0400000A RID: 10
		internal static Count count;
	}
}
