namespace Smoke
{
	// Token: 0x02000009 RID: 9
	public partial class AttackHistory : global::System.Windows.Forms.Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000028E8 File Offset: 0x00000AE8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002920 File Offset: 0x00000B20
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Smoke.AttackHistory));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Location = new global::System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(198, 360);
			this.panel1.TabIndex = 0;
			this.richTextBox1.BackColor = global::System.Drawing.Color.Brown;
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new global::System.Drawing.Point(3, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(192, 350);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.button1.BackColor = global::System.Drawing.Color.Black;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.Brown;
			this.button1.Location = new global::System.Drawing.Point(173, -1);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(25, 25);
			this.button1.TabIndex = 1;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Brown;
			base.ClientSize = new global::System.Drawing.Size(202, 364);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "AttackHistory";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AttackHistory";
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000019 RID: 25
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button button1;
	}
}
