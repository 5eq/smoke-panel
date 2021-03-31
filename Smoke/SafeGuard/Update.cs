using System;

namespace SafeGuard
{
	// Token: 0x02000004 RID: 4
	internal static class Update
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002285 File Offset: 0x00000485
		internal static void update()
		{
			ClientFunctions.AutoUpdate(Update.version, ProgramInformation.ProgramId);
		}

		// Token: 0x04000005 RID: 5
		internal static string version = "2.12";
	}
}
