using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Smoke
{
	// Token: 0x0200000D RID: 13
	internal class SmokeMain
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00006760 File Offset: 0x00004960
		public static void TaskChecker(bool loadFlag, bool proxyflag, bool pornhubflag)
		{
			bool flag = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count<Process>() > 1;
			if (flag)
			{
				if (pornhubflag)
				{
					MessageBox.Show("You already have a running Project_Hell process, close it before opening another.");
				}
				Environment.Exit(0);
			}
			string[] array = new string[]
			{
				"Taskmgr"
			};
			foreach (string text in array)
			{
				bool flag2 = Process.GetProcessesByName(text).Length != 0;
				bool flag3 = flag2;
				if (flag3)
				{
					Process[] processesByName = Process.GetProcessesByName(text);
					processesByName[0].Kill();
					MessageBox.Show("No need to have " + text + " open!");
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00006814 File Offset: 0x00004A14
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000681B File Offset: 0x00004A1B
		public static string APILink { get; set; }

		// Token: 0x04000068 RID: 104
		public static int RunningAttacks = 0;

		// Token: 0x04000069 RID: 105
		public static string LogPath = "log.txt";

		// Token: 0x0400006A RID: 106
		public static List<string> RunningAttks = new List<string>();

		// Token: 0x0200001C RID: 28
		public class PlanInfo
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600006C RID: 108 RVA: 0x00007F2A File Offset: 0x0000612A
			// (set) Token: 0x0600006D RID: 109 RVA: 0x00007F32 File Offset: 0x00006132
			public int Level { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600006E RID: 110 RVA: 0x00007F3B File Offset: 0x0000613B
			// (set) Token: 0x0600006F RID: 111 RVA: 0x00007F43 File Offset: 0x00006143
			public int Time { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000070 RID: 112 RVA: 0x00007F4C File Offset: 0x0000614C
			// (set) Token: 0x06000071 RID: 113 RVA: 0x00007F54 File Offset: 0x00006154
			public int Cons { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00007F5D File Offset: 0x0000615D
			// (set) Token: 0x06000073 RID: 115 RVA: 0x00007F65 File Offset: 0x00006165
			public List<string> Methods { get; set; }
		}

		// Token: 0x0200001D RID: 29
		public class CustomPlans
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00007F77 File Offset: 0x00006177
			// (set) Token: 0x06000076 RID: 118 RVA: 0x00007F7F File Offset: 0x0000617F
			public string Username { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000077 RID: 119 RVA: 0x00007F88 File Offset: 0x00006188
			// (set) Token: 0x06000078 RID: 120 RVA: 0x00007F90 File Offset: 0x00006190
			public int Time { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000079 RID: 121 RVA: 0x00007F99 File Offset: 0x00006199
			// (set) Token: 0x0600007A RID: 122 RVA: 0x00007FA1 File Offset: 0x000061A1
			public int Concurrents { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600007B RID: 123 RVA: 0x00007FAA File Offset: 0x000061AA
			// (set) Token: 0x0600007C RID: 124 RVA: 0x00007FB2 File Offset: 0x000061B2
			public List<string> Methods { get; set; }
		}

		// Token: 0x0200001E RID: 30
		public class RootObject
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00007FC4 File Offset: 0x000061C4
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00007FCC File Offset: 0x000061CC
			public List<string> BlacklistedIPS { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000080 RID: 128 RVA: 0x00007FD5 File Offset: 0x000061D5
			// (set) Token: 0x06000081 RID: 129 RVA: 0x00007FDD File Offset: 0x000061DD
			public string DiscordLink { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000082 RID: 130 RVA: 0x00007FE6 File Offset: 0x000061E6
			// (set) Token: 0x06000083 RID: 131 RVA: 0x00007FEE File Offset: 0x000061EE
			public string MOTD { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000084 RID: 132 RVA: 0x00007FF7 File Offset: 0x000061F7
			// (set) Token: 0x06000085 RID: 133 RVA: 0x00007FFF File Offset: 0x000061FF
			public string ToS { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000086 RID: 134 RVA: 0x00008008 File Offset: 0x00006208
			// (set) Token: 0x06000087 RID: 135 RVA: 0x00008010 File Offset: 0x00006210
			public List<SmokeMain.CustomPlans> CustomPlans { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000088 RID: 136 RVA: 0x00008019 File Offset: 0x00006219
			// (set) Token: 0x06000089 RID: 137 RVA: 0x00008021 File Offset: 0x00006221
			public List<SmokeMain.PlanInfo> PlanInfo { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600008A RID: 138 RVA: 0x0000802A File Offset: 0x0000622A
			// (set) Token: 0x0600008B RID: 139 RVA: 0x00008032 File Offset: 0x00006232
			public List<string> Methods { get; set; }
		}
	}
}
