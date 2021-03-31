using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SafeGuard;

namespace Smoke
{
	// Token: 0x0200000C RID: 12
	internal static class Program
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000066D8 File Offset: 0x000048D8
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			SmokeMain.TaskChecker(false, false, true);
			Tools.ProcessCheck();
			Update.update();
			try
			{
				ResponseInformation.RootObject = JsonConvert.DeserializeObject<SmokeMain.RootObject>(Tools.getRequest("https://pastebin.com/raw/eayPQkDN"));
			}
			catch
			{
				MessageBox.Show("Unable to download required items, please try again later!");
				return;
			}
			MessageBox.Show(ResponseInformation.RootObject.MOTD, "Message of the day");
			Application.Run(new Login());
		}
	}
}
