namespace Smoke
{
	// Token: 0x0200000A RID: 10
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002DBC File Offset: 0x00000FBC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002DF4 File Offset: 0x00000FF4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Smoke.Login));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.radioButton1 = new global::System.Windows.Forms.RadioButton();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LoginButton = new global::System.Windows.Forms.Button();
			this.RegisterButton = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.LoginPanel = new global::System.Windows.Forms.Panel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.button4 = new global::System.Windows.Forms.Button();
			this.radioButton2 = new global::System.Windows.Forms.RadioButton();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.RegisterPanel = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.panel10 = new global::System.Windows.Forms.Panel();
			this.button5 = new global::System.Windows.Forms.Button();
			this.radioButton3 = new global::System.Windows.Forms.RadioButton();
			this.panel9 = new global::System.Windows.Forms.Panel();
			this.textBox6 = new global::System.Windows.Forms.TextBox();
			this.panel8 = new global::System.Windows.Forms.Panel();
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.panel7 = new global::System.Windows.Forms.Panel();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.panel6 = new global::System.Windows.Forms.Panel();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.LoginPanel.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.RegisterPanel.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(-60, -106);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(578, 142);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new global::System.Drawing.Point(0, 0);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new global::System.Drawing.Size(85, 17);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(63, 108);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(33, 30);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.button3.Location = new global::System.Drawing.Point(412, 111);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(25, 25);
			this.button3.TabIndex = 4;
			this.button3.Text = "_";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.Color.Coral;
			this.button2.Location = new global::System.Drawing.Point(277, 59);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(25, 25);
			this.button2.TabIndex = 3;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = true;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.Coral;
			this.button1.Location = new global::System.Drawing.Point(437, 111);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(25, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Brown;
			this.label1.Location = new global::System.Drawing.Point(226, 115);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(94, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Project_Hell";
			this.LoginButton.FlatAppearance.BorderSize = 0;
			this.LoginButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LoginButton.ForeColor = global::System.Drawing.Color.Black;
			this.LoginButton.Location = new global::System.Drawing.Point(12, 42);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new global::System.Drawing.Size(111, 60);
			this.LoginButton.TabIndex = 1;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new global::System.EventHandler(this.LoginButton_Click);
			this.RegisterButton.FlatAppearance.BorderSize = 0;
			this.RegisterButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.RegisterButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RegisterButton.ForeColor = global::System.Drawing.Color.Black;
			this.RegisterButton.Location = new global::System.Drawing.Point(12, 108);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new global::System.Drawing.Size(111, 60);
			this.RegisterButton.TabIndex = 2;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = true;
			this.RegisterButton.Click += new global::System.EventHandler(this.RegisterButton_Click);
			this.panel2.BackColor = global::System.Drawing.Color.Black;
			this.panel2.Location = new global::System.Drawing.Point(129, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(1, 122);
			this.panel2.TabIndex = 3;
			this.LoginPanel.Controls.Add(this.panel5);
			this.LoginPanel.Controls.Add(this.radioButton2);
			this.LoginPanel.Controls.Add(this.panel4);
			this.LoginPanel.Controls.Add(this.panel3);
			this.LoginPanel.Location = new global::System.Drawing.Point(136, 45);
			this.LoginPanel.Name = "LoginPanel";
			this.LoginPanel.Size = new global::System.Drawing.Size(264, 119);
			this.LoginPanel.TabIndex = 4;
			this.panel5.BackColor = global::System.Drawing.Color.Black;
			this.panel5.Controls.Add(this.button4);
			this.panel5.Location = new global::System.Drawing.Point(94, 85);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(84, 29);
			this.panel5.TabIndex = 6;
			this.button4.BackColor = global::System.Drawing.Color.Brown;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new global::System.Drawing.Point(2, 2);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(80, 25);
			this.button4.TabIndex = 5;
			this.button4.Text = "Login";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new global::System.Drawing.Point(87, 62);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new global::System.Drawing.Size(101, 17);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Show Password";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new global::System.EventHandler(this.radioButton2_CheckedChanged);
			this.panel4.BackColor = global::System.Drawing.Color.Black;
			this.panel4.Controls.Add(this.textBox2);
			this.panel4.Location = new global::System.Drawing.Point(64, 31);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(146, 27);
			this.panel4.TabIndex = 3;
			this.textBox2.BackColor = global::System.Drawing.Color.Brown;
			this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new global::System.Drawing.Point(2, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '•';
			this.textBox2.Size = new global::System.Drawing.Size(141, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "Password";
			this.panel3.BackColor = global::System.Drawing.Color.Black;
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Location = new global::System.Drawing.Point(64, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(146, 27);
			this.panel3.TabIndex = 0;
			this.textBox1.BackColor = global::System.Drawing.Color.Brown;
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new global::System.Drawing.Point(2, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(141, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "Username";
			this.RegisterPanel.Controls.Add(this.label2);
			this.RegisterPanel.Controls.Add(this.panel10);
			this.RegisterPanel.Controls.Add(this.radioButton3);
			this.RegisterPanel.Controls.Add(this.panel9);
			this.RegisterPanel.Controls.Add(this.panel8);
			this.RegisterPanel.Controls.Add(this.panel7);
			this.RegisterPanel.Controls.Add(this.panel6);
			this.RegisterPanel.Location = new global::System.Drawing.Point(136, 45);
			this.RegisterPanel.Name = "RegisterPanel";
			this.RegisterPanel.Size = new global::System.Drawing.Size(264, 119);
			this.RegisterPanel.TabIndex = 7;
			this.RegisterPanel.Visible = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.DodgerBlue;
			this.label2.Location = new global::System.Drawing.Point(152, 101);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(27, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "ToS";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.panel10.BackColor = global::System.Drawing.Color.Black;
			this.panel10.Controls.Add(this.button5);
			this.panel10.Location = new global::System.Drawing.Point(159, 34);
			this.panel10.Name = "panel10";
			this.panel10.Size = new global::System.Drawing.Size(92, 49);
			this.panel10.TabIndex = 7;
			this.button5.BackColor = global::System.Drawing.Color.Brown;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new global::System.Drawing.Point(3, 3);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(86, 43);
			this.button5.TabIndex = 5;
			this.button5.Text = "Register";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.radioButton3.AutoSize = true;
			this.radioButton3.BackColor = global::System.Drawing.Color.Brown;
			this.radioButton3.ForeColor = global::System.Drawing.Color.Brown;
			this.radioButton3.Location = new global::System.Drawing.Point(130, 37);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new global::System.Drawing.Size(14, 13);
			this.radioButton3.TabIndex = 5;
			this.radioButton3.TabStop = true;
			this.radioButton3.UseVisualStyleBackColor = false;
			this.radioButton3.CheckedChanged += new global::System.EventHandler(this.radioButton3_CheckedChanged);
			this.panel9.BackColor = global::System.Drawing.Color.Black;
			this.panel9.Controls.Add(this.textBox6);
			this.panel9.Location = new global::System.Drawing.Point(3, 87);
			this.panel9.Name = "panel9";
			this.panel9.Size = new global::System.Drawing.Size(146, 27);
			this.panel9.TabIndex = 4;
			this.textBox6.BackColor = global::System.Drawing.Color.Brown;
			this.textBox6.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new global::System.Drawing.Point(2, 3);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new global::System.Drawing.Size(141, 20);
			this.textBox6.TabIndex = 2;
			this.textBox6.Text = "Register Token";
			this.panel8.BackColor = global::System.Drawing.Color.Black;
			this.panel8.Controls.Add(this.textBox5);
			this.panel8.Location = new global::System.Drawing.Point(3, 59);
			this.panel8.Name = "panel8";
			this.panel8.Size = new global::System.Drawing.Size(146, 27);
			this.panel8.TabIndex = 3;
			this.textBox5.BackColor = global::System.Drawing.Color.Brown;
			this.textBox5.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new global::System.Drawing.Point(2, 3);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new global::System.Drawing.Size(141, 20);
			this.textBox5.TabIndex = 2;
			this.textBox5.Text = "Email";
			this.panel7.BackColor = global::System.Drawing.Color.Black;
			this.panel7.Controls.Add(this.textBox4);
			this.panel7.Location = new global::System.Drawing.Point(3, 31);
			this.panel7.Name = "panel7";
			this.panel7.Size = new global::System.Drawing.Size(146, 27);
			this.panel7.TabIndex = 2;
			this.textBox4.BackColor = global::System.Drawing.Color.Brown;
			this.textBox4.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new global::System.Drawing.Point(2, 3);
			this.textBox4.Name = "textBox4";
			this.textBox4.PasswordChar = '•';
			this.textBox4.Size = new global::System.Drawing.Size(141, 20);
			this.textBox4.TabIndex = 2;
			this.textBox4.Text = "Password";
			this.panel6.BackColor = global::System.Drawing.Color.Black;
			this.panel6.Controls.Add(this.textBox3);
			this.panel6.Location = new global::System.Drawing.Point(3, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new global::System.Drawing.Size(146, 27);
			this.panel6.TabIndex = 1;
			this.textBox3.BackColor = global::System.Drawing.Color.Brown;
			this.textBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new global::System.Drawing.Point(2, 3);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(141, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Username";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Brown;
			base.ClientSize = new global::System.Drawing.Size(412, 176);
			base.Controls.Add(this.LoginButton);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.RegisterPanel);
			base.Controls.Add(this.LoginPanel);
			base.Controls.Add(this.RegisterButton);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.LoginPanel.ResumeLayout(false);
			this.LoginPanel.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.RegisterPanel.ResumeLayout(false);
			this.RegisterPanel.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001E RID: 30
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Button LoginButton;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Button RegisterButton;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Panel LoginPanel;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Panel RegisterPanel;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.RadioButton radioButton3;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Panel panel9;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.TextBox textBox6;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Panel panel8;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Panel panel10;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label2;
	}
}
