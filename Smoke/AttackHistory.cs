using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Smoke
{
	// Token: 0x02000009 RID: 9
	public partial class AttackHistory : Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002878 File Offset: 0x00000A78
		public AttackHistory()
		{
			this.InitializeComponent();
			string[] array = File.ReadAllLines(SmokeMain.LogPath ?? "");
			foreach (string str in array)
			{
				this.richTextBox1.AppendText(str + "\n");
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028DB File Offset: 0x00000ADB
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
