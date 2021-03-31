using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SafeGuard;

namespace Smoke
{
	// Token: 0x0200000A RID: 10
	public partial class Login : Form
	{
		// Token: 0x0600001A RID: 26
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600001B RID: 27 RVA: 0x00002BEC File Offset: 0x00000DEC
		public Login()
		{
			this.InitializeComponent();
			base.Region = Region.FromHrgn(Login.CreateRoundRectRgn(0, 0, base.Width, base.Height, 25, 25));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002C27 File Offset: 0x00000E27
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002C30 File Offset: 0x00000E30
		private void button3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C3C File Offset: 0x00000E3C
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002C9D File Offset: 0x00000E9D
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002CB7 File Offset: 0x00000EB7
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			this.textBox2.PasswordChar = '\0';
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002CC7 File Offset: 0x00000EC7
		private void LoginButton_Click(object sender, EventArgs e)
		{
			this.RegisterPanel.Visible = false;
			this.LoginPanel.Visible = true;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002CE4 File Offset: 0x00000EE4
		private void RegisterButton_Click(object sender, EventArgs e)
		{
			this.LoginPanel.Visible = false;
			this.RegisterPanel.Visible = true;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002D01 File Offset: 0x00000F01
		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			this.textBox4.PasswordChar = '\0';
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D14 File Offset: 0x00000F14
		[DebuggerStepThrough]
		private void button4_Click(object sender, EventArgs e)
		{
			Login.<button4_Click>d__11 <button4_Click>d__ = new Login.<button4_Click>d__11();
			<button4_Click>d__.<>4__this = this;
			<button4_Click>d__.sender = sender;
			<button4_Click>d__.e = e;
			<button4_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button4_Click>d__.<>1__state = -1;
			<button4_Click>d__.<>t__builder.Start<Login.<button4_Click>d__11>(ref <button4_Click>d__);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002D5C File Offset: 0x00000F5C
		[DebuggerStepThrough]
		private void button5_Click(object sender, EventArgs e)
		{
			Login.<button5_Click>d__12 <button5_Click>d__ = new Login.<button5_Click>d__12();
			<button5_Click>d__.<>4__this = this;
			<button5_Click>d__.sender = sender;
			<button5_Click>d__.e = e;
			<button5_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button5_Click>d__.<>1__state = -1;
			<button5_Click>d__.<>t__builder.Start<Login.<button5_Click>d__12>(ref <button5_Click>d__);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002DA3 File Offset: 0x00000FA3
		private void label2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(ResponseInformation.RootObject.ToS, "Terms of Service");
		}

		// Token: 0x0400001D RID: 29
		private Point lastPoint;
	}
}
