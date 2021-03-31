namespace Smoke
{
	// Token: 0x0200000B RID: 11
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00004BC4 File Offset: 0x00002DC4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004BFC File Offset: 0x00002DFC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Smoke.Main));
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label8 = new global::System.Windows.Forms.Label();
			this.HistoryLogs = new global::System.Windows.Forms.RichTextBox();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.panel12 = new global::System.Windows.Forms.Panel();
			this.button7 = new global::System.Windows.Forms.Button();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.button6 = new global::System.Windows.Forms.Button();
			this.VersionLabel = new global::System.Windows.Forms.Label();
			this.panel7 = new global::System.Windows.Forms.Panel();
			this.button4 = new global::System.Windows.Forms.Button();
			this.panel8 = new global::System.Windows.Forms.Panel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.panel6 = new global::System.Windows.Forms.Panel();
			this.Methods = new global::theme.FlatComboBox();
			this.panels = new global::System.Windows.Forms.Panel();
			this.Time = new global::theme.FlatTextBox();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.Port = new global::theme.FlatTextBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.IP = new global::theme.FlatTextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.panel9 = new global::System.Windows.Forms.Panel();
			this.button5 = new global::System.Windows.Forms.Button();
			this.panel10 = new global::System.Windows.Forms.Panel();
			this.label6 = new global::System.Windows.Forms.Label();
			this.panel11 = new global::System.Windows.Forms.Panel();
			this.Cooldown = new global::System.Windows.Forms.Timer(this.components);
			this.UpdateCons = new global::System.Windows.Forms.Timer(this.components);
			this.label7 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panels.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			this.panel9.SuspendLayout();
			this.panel11.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Black;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Brown;
			this.label1.Location = new global::System.Drawing.Point(189, 45);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(94, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Project_Hell";
			this.pictureBox1.BackColor = global::System.Drawing.Color.Black;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(70, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.button1.BackColor = global::System.Drawing.Color.Black;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.Brown;
			this.button1.Location = new global::System.Drawing.Point(402, 40);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(32, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.Black;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.Color.DarkGray;
			this.button2.Location = new global::System.Drawing.Point(364, 40);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(32, 32);
			this.button2.TabIndex = 4;
			this.button2.Text = "_";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.panel1.BackColor = global::System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.HistoryLogs);
			this.panel1.Location = new global::System.Drawing.Point(218, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(143, 161);
			this.panel1.TabIndex = 5;
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Brown;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(109, 145);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(31, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Clear";
			this.label8.Click += new global::System.EventHandler(this.label8_Click);
			this.HistoryLogs.BackColor = global::System.Drawing.Color.Brown;
			this.HistoryLogs.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.HistoryLogs.Location = new global::System.Drawing.Point(3, 3);
			this.HistoryLogs.Name = "HistoryLogs";
			this.HistoryLogs.ReadOnly = true;
			this.HistoryLogs.Size = new global::System.Drawing.Size(137, 155);
			this.HistoryLogs.TabIndex = 0;
			this.HistoryLogs.Text = "";
			this.HistoryLogs.TextChanged += new global::System.EventHandler(this.HistoryLogs_TextChanged);
			this.panel5.Controls.Add(this.panel12);
			this.panel5.Controls.Add(this.panel4);
			this.panel5.Controls.Add(this.VersionLabel);
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.panels);
			this.panel5.Controls.Add(this.panel3);
			this.panel5.Controls.Add(this.panel2);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Location = new global::System.Drawing.Point(12, 43);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(200, 295);
			this.panel5.TabIndex = 9;
			this.panel12.BackColor = global::System.Drawing.Color.Black;
			this.panel12.Controls.Add(this.button7);
			this.panel12.Location = new global::System.Drawing.Point(103, 252);
			this.panel12.Name = "panel12";
			this.panel12.Size = new global::System.Drawing.Size(92, 32);
			this.panel12.TabIndex = 19;
			this.button7.BackColor = global::System.Drawing.Color.Brown;
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button7.Location = new global::System.Drawing.Point(1, 1);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(90, 30);
			this.button7.TabIndex = 10;
			this.button7.Text = "Geo IP";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.panel4.BackColor = global::System.Drawing.Color.Black;
			this.panel4.Controls.Add(this.button6);
			this.panel4.Location = new global::System.Drawing.Point(5, 253);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(92, 32);
			this.panel4.TabIndex = 18;
			this.button6.BackColor = global::System.Drawing.Color.Brown;
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button6.Location = new global::System.Drawing.Point(1, 1);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(90, 30);
			this.button6.TabIndex = 10;
			this.button6.Text = "Ping";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.VersionLabel.AutoSize = true;
			this.VersionLabel.Location = new global::System.Drawing.Point(132, 5);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new global::System.Drawing.Size(54, 13);
			this.VersionLabel.TabIndex = 10;
			this.VersionLabel.Text = "Version: 1";
			this.panel7.BackColor = global::System.Drawing.Color.Black;
			this.panel7.Controls.Add(this.button4);
			this.panel7.Location = new global::System.Drawing.Point(103, 216);
			this.panel7.Name = "panel7";
			this.panel7.Size = new global::System.Drawing.Size(92, 32);
			this.panel7.TabIndex = 18;
			this.button4.BackColor = global::System.Drawing.Color.Brown;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button4.Location = new global::System.Drawing.Point(1, 1);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(90, 30);
			this.button4.TabIndex = 10;
			this.button4.Text = "Stop";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.panel8.BackColor = global::System.Drawing.Color.Black;
			this.panel8.Controls.Add(this.button3);
			this.panel8.Location = new global::System.Drawing.Point(5, 216);
			this.panel8.Name = "panel8";
			this.panel8.Size = new global::System.Drawing.Size(92, 32);
			this.panel8.TabIndex = 17;
			this.button3.BackColor = global::System.Drawing.Color.Brown;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new global::System.Drawing.Point(1, 1);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(90, 30);
			this.button3.TabIndex = 10;
			this.button3.Text = "Start";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.panel6.BackColor = global::System.Drawing.Color.Black;
			this.panel6.Controls.Add(this.Methods);
			this.panel6.Location = new global::System.Drawing.Point(9, 183);
			this.panel6.Name = "panel6";
			this.panel6.Size = new global::System.Drawing.Size(180, 30);
			this.panel6.TabIndex = 16;
			this.Methods.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 48);
			this.Methods.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Methods.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Methods.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Methods.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.Methods.ForeColor = global::System.Drawing.Color.White;
			this.Methods.FormattingEnabled = true;
			this.Methods.HoverColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.Methods.ItemHeight = 18;
			this.Methods.Location = new global::System.Drawing.Point(3, 3);
			this.Methods.Name = "Methods";
			this.Methods.Size = new global::System.Drawing.Size(174, 24);
			this.Methods.TabIndex = 10;
			this.panels.BackColor = global::System.Drawing.Color.Black;
			this.panels.Controls.Add(this.Time);
			this.panels.Location = new global::System.Drawing.Point(9, 129);
			this.panels.Name = "panels";
			this.panels.Size = new global::System.Drawing.Size(180, 35);
			this.panels.TabIndex = 15;
			this.Time.BackColor = global::System.Drawing.Color.Black;
			this.Time.Location = new global::System.Drawing.Point(3, 3);
			this.Time.MaxLength = 32767;
			this.Time.Multiline = false;
			this.Time.Name = "Time";
			this.Time.ReadOnly = false;
			this.Time.Size = new global::System.Drawing.Size(174, 29);
			this.Time.TabIndex = 10;
			this.Time.Text = "30";
			this.Time.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Time.TextColor = global::System.Drawing.Color.Brown;
			this.Time.UseSystemPasswordChar = false;
			this.panel3.BackColor = global::System.Drawing.Color.Black;
			this.panel3.Controls.Add(this.Port);
			this.panel3.Location = new global::System.Drawing.Point(9, 75);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(180, 35);
			this.panel3.TabIndex = 12;
			this.Port.BackColor = global::System.Drawing.Color.Black;
			this.Port.Location = new global::System.Drawing.Point(3, 3);
			this.Port.MaxLength = 32767;
			this.Port.Multiline = false;
			this.Port.Name = "Port";
			this.Port.ReadOnly = false;
			this.Port.Size = new global::System.Drawing.Size(174, 29);
			this.Port.TabIndex = 10;
			this.Port.Text = "80";
			this.Port.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Port.TextColor = global::System.Drawing.Color.Brown;
			this.Port.UseSystemPasswordChar = false;
			this.panel2.BackColor = global::System.Drawing.Color.Black;
			this.panel2.Controls.Add(this.IP);
			this.panel2.Location = new global::System.Drawing.Point(9, 21);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(180, 35);
			this.panel2.TabIndex = 11;
			this.IP.BackColor = global::System.Drawing.Color.Black;
			this.IP.Location = new global::System.Drawing.Point(3, 3);
			this.IP.MaxLength = 32767;
			this.IP.Multiline = false;
			this.IP.Name = "IP";
			this.IP.ReadOnly = false;
			this.IP.Size = new global::System.Drawing.Size(174, 29);
			this.IP.TabIndex = 10;
			this.IP.Text = "0.0.0.0";
			this.IP.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.IP.TextColor = global::System.Drawing.Color.Brown;
			this.IP.UseSystemPasswordChar = false;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(9, 167);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(51, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Methods:";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(9, 113);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(33, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Time:";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(9, 59);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Port:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(9, 5);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(20, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "IP:";
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(218, 225);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(65, 65);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.pictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new global::System.Drawing.Point(296, 225);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(65, 65);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new global::System.EventHandler(this.pictureBox3_Click);
			this.panel9.BackColor = global::System.Drawing.Color.Black;
			this.panel9.Controls.Add(this.button5);
			this.panel9.Location = new global::System.Drawing.Point(241, 300);
			this.panel9.Name = "panel9";
			this.panel9.Size = new global::System.Drawing.Size(92, 32);
			this.panel9.TabIndex = 18;
			this.button5.BackColor = global::System.Drawing.Color.Brown;
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button5.Location = new global::System.Drawing.Point(1, 1);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(90, 30);
			this.button5.TabIndex = 10;
			this.button5.Text = "Previous Atks";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.panel10.BackColor = global::System.Drawing.Color.Black;
			this.panel10.Location = new global::System.Drawing.Point(209, 43);
			this.panel10.Name = "panel10";
			this.panel10.Size = new global::System.Drawing.Size(1, 295);
			this.panel10.TabIndex = 19;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(216, 40);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(42, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "History:";
			this.panel11.BackColor = global::System.Drawing.Color.Black;
			this.panel11.Controls.Add(this.pictureBox1);
			this.panel11.Controls.Add(this.label1);
			this.panel11.Controls.Add(this.button1);
			this.panel11.Controls.Add(this.button2);
			this.panel11.Location = new global::System.Drawing.Point(-65, -35);
			this.panel11.Name = "panel11";
			this.panel11.Size = new global::System.Drawing.Size(522, 75);
			this.panel11.TabIndex = 1;
			this.panel11.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel11_MouseDown);
			this.panel11.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel11_MouseMove);
			this.Cooldown.Interval = 1000;
			this.Cooldown.Tick += new global::System.EventHandler(this.Cooldown_Tick);
			this.UpdateCons.Interval = 1000;
			this.UpdateCons.Tick += new global::System.EventHandler(this.UpdateCons_Tick);
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(238, 334);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(91, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Concurrents Free:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Brown;
			base.ClientSize = new global::System.Drawing.Size(371, 346);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.panel11);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.panel10);
			base.Controls.Add(this.panel9);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			this.Text = "Main";
			base.Load += new global::System.EventHandler(this.Main_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel12.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panels.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			this.panel9.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003F RID: 63
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.RichTextBox HistoryLogs;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x0400004C RID: 76
		private global::theme.FlatComboBox Methods;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Panel panels;

		// Token: 0x0400004E RID: 78
		private global::theme.FlatTextBox Time;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000050 RID: 80
		private global::theme.FlatTextBox Port;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000052 RID: 82
		private global::theme.FlatTextBox IP;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label VersionLabel;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Panel panel8;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Panel panel9;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Panel panel10;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Panel panel11;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Timer Cooldown;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Timer UpdateCons;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Panel panel12;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Button button7;
	}
}
