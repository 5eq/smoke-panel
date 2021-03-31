using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeGuard;
using theme;

namespace Smoke
{
	// Token: 0x0200000B RID: 11
	public partial class Main : Form
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00004400 File Offset: 0x00002600
		public Main()
		{
			this.InitializeComponent();
			bool flag = !File.Exists(SmokeMain.LogPath);
			if (flag)
			{
				try
				{
					File.Create(SmokeMain.LogPath);
				}
				catch
				{
					MessageBox.Show("Unable to make a logging file, please manually make a file called 'log.txt'");
				}
			}
			bool customPlan = ProgramInformation.CustomPlan;
			if (customPlan)
			{
				try
				{
					SmokeMain.CustomPlans customPlans = (from p in ResponseInformation.RootObject.CustomPlans
					where p.Username.ToLower() == ResponseInformation.loginresponse.UserName.ToLower()
					select p).FirstOrDefault<SmokeMain.CustomPlans>();
					ProgramInformation.Cons = customPlans.Concurrents;
					ProgramInformation.MaxTime = customPlans.Time;
					ProgramInformation.Methods = ResponseInformation.RootObject.Methods;
					bool flag2 = customPlans.Methods != null;
					if (flag2)
					{
						ProgramInformation.Methods = customPlans.Methods;
					}
					this.Methods.Items.Clear();
					this.Methods.DataSource = ProgramInformation.Methods;
				}
				catch
				{
					ProgramInformation.Cons = 0;
					ProgramInformation.MaxTime = 180;
					this.Methods.Items.Clear();
					MessageBox.Show("Unable to load custom plan, please try again later!");
				}
			}
			this.UpdateCons.Start();
			this.VersionLabel.Text = "Version: " + SafeGuard.Update.version;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004570 File Offset: 0x00002770
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = SmokeMain.RunningAttacks != 0;
			if (flag)
			{
				MessageBox.Show("Attack still running, wait to close");
			}
			else
			{
				MessageBox.Show("Thank you for using Project_Hell, updates will come constantly", "Project_Hell");
				DiscordUtils.DiscordLog("logout", ResponseInformation.loginresponse.UserName, Tools.GetClientIP());
				Application.Exit();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000045CA File Offset: 0x000027CA
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Prompting Admin Instagram Contants");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000045D8 File Offset: 0x000027D8
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Redirecting you to Project_Hell's discord server");
			Process.Start(ResponseInformation.RootObject.DiscordLink);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000045F8 File Offset: 0x000027F8
		[DebuggerStepThrough]
		private void button3_Click(object sender, EventArgs e)
		{
			Main.<button3_Click>d__4 <button3_Click>d__ = new Main.<button3_Click>d__4();
			<button3_Click>d__.<>4__this = this;
			<button3_Click>d__.sender = sender;
			<button3_Click>d__.e = e;
			<button3_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button3_Click>d__.<>1__state = -1;
			<button3_Click>d__.<>t__builder.Start<Main.<button3_Click>d__4>(ref <button3_Click>d__);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004640 File Offset: 0x00002840
		private void Main_Load(object sender, EventArgs e)
		{
			bool flag = ResponseInformation.loginresponse.Level != 10;
			if (flag)
			{
				this.Methods.Items.Clear();
				this.Methods.DataSource = ProgramInformation.Methods;
			}
			this.panels.Text = string.Format("0-{0}", ProgramInformation.MaxTime);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000046A8 File Offset: 0x000028A8
		private void panel11_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004709 File Offset: 0x00002909
		private void panel11_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004724 File Offset: 0x00002924
		private void Cooldown_Tick(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				foreach (string text in SmokeMain.RunningAttks)
				{
					string[] array = text.Split(new char[]
					{
						':'
					});
					int num = Convert.ToInt32(array[1]);
					bool flag = num > 1;
					if (flag)
					{
						list.Add(string.Format("{0}:{1}", array[0], Convert.ToInt32(array[1]) - 1));
					}
					else
					{
						SmokeMain.RunningAttacks--;
						this.HistoryLogs.AppendText("Attack on " + array[0] + " - Finished\n");
					}
				}
				SmokeMain.RunningAttks.Clear();
				SmokeMain.RunningAttks = list;
			}
			catch
			{
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004824 File Offset: 0x00002A24
		private void button5_Click(object sender, EventArgs e)
		{
			AttackHistory attackHistory = new AttackHistory();
			attackHistory.ShowDialog();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000483F File Offset: 0x00002A3F
		private void UpdateCons_Tick(object sender, EventArgs e)
		{
			this.label7.Text = string.Format("Concurrents Free: {0}", ProgramInformation.Cons - SmokeMain.RunningAttacks);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004868 File Offset: 0x00002A68
		private void label8_Click(object sender, EventArgs e)
		{
			this.HistoryLogs.Text = "";
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000487C File Offset: 0x00002A7C
		private void button4_Click(object sender, EventArgs e)
		{
			bool flag = false;
			foreach (string text in SmokeMain.RunningAttks)
			{
				bool flag2 = text.Contains(this.IP.Text);
				if (flag2)
				{
					ClientFunctions.AttackRequest(ResponseInformation.loginresponse.UserName, ResponseInformation.Password, ProgramInformation.ProgramId, this.IP.Text, Convert.ToString(1), "STOP", Convert.ToString(1), true);
					string[] array = text.Split(new char[]
					{
						':'
					});
					this.HistoryLogs.AppendText("Attack on " + this.IP.Text + " finished");
					SmokeMain.RunningAttks.Remove(array[0] + ":" + array[1]);
					SmokeMain.RunningAttacks--;
					return;
				}
			}
			bool flag3 = !flag;
			if (flag3)
			{
				this.HistoryLogs.AppendText("IP not found in running attacks, prompting stop hub.");
				string text2 = "To stop an attack, copy and paste an ip and put it into the IP box in the main form, then click \"STOP\"\n\n";
				foreach (string text3 in SmokeMain.RunningAttks)
				{
					string[] array2 = text3.Split(new char[]
					{
						':'
					});
					text2 = string.Concat(new string[]
					{
						text2,
						"IP: ",
						array2[0],
						"\nTime Remaining: ",
						array2[1],
						"\n\n"
					});
				}
				MessageBox.Show(text2 ?? "", "Smoke 'Em's Stop Alert");
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004A54 File Offset: 0x00002C54
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004A60 File Offset: 0x00002C60
		private void button6_Click(object sender, EventArgs e)
		{
			this.button6.Enabled = false;
			DialogResult dialogResult = MessageBox.Show("Would you like to TCPPing? (Yes/No)", "Ping", MessageBoxButtons.YesNo);
			bool flag = dialogResult == DialogResult.No;
			if (flag)
			{
				Tools.Ping(this.IP.Text);
			}
			else
			{
				try
				{
					new Process
					{
						StartInfo = 
						{
							FileName = "paping.exe",
							Arguments = this.IP.Text + " --port " + this.Port.Text
						}
					}.Start();
				}
				catch
				{
					MessageBox.Show("Unable to ping", "Ping error");
				}
			}
			this.button6.Enabled = true;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004B2C File Offset: 0x00002D2C
		[DebuggerStepThrough]
		private Task<string> RequestData(string uri)
		{
			Main.<RequestData>d__16 <RequestData>d__ = new Main.<RequestData>d__16();
			<RequestData>d__.<>4__this = this;
			<RequestData>d__.uri = uri;
			<RequestData>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<RequestData>d__.<>1__state = -1;
			<RequestData>d__.<>t__builder.Start<Main.<RequestData>d__16>(ref <RequestData>d__);
			return <RequestData>d__.<>t__builder.Task;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004B78 File Offset: 0x00002D78
		[DebuggerStepThrough]
		private void button7_Click(object sender, EventArgs e)
		{
			Main.<button7_Click>d__17 <button7_Click>d__ = new Main.<button7_Click>d__17();
			<button7_Click>d__.<>4__this = this;
			<button7_Click>d__.sender = sender;
			<button7_Click>d__.e = e;
			<button7_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button7_Click>d__.<>1__state = -1;
			<button7_Click>d__.<>t__builder.Start<Main.<button7_Click>d__17>(ref <button7_Click>d__);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004BBF File Offset: 0x00002DBF
		private void HistoryLogs_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0400003E RID: 62
		private Point lastPoint;
	}
}
