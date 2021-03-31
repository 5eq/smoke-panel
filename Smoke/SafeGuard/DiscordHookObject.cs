using System;

namespace SafeGuard
{
	// Token: 0x02000003 RID: 3
	internal class DiscordHookObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002240 File Offset: 0x00000440
		public string Message { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002249 File Offset: 0x00000449
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002251 File Offset: 0x00000451
		public string Title { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000225A File Offset: 0x0000045A
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002262 File Offset: 0x00000462
		public string Picture { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000226B File Offset: 0x0000046B
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002273 File Offset: 0x00000473
		public string ProgramId { get; set; }
	}
}
