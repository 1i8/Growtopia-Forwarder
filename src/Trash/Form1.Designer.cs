namespace Trash
{
	// Token: 0x0200000A RID: 10
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000023FB File Offset: 0x000005FB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000046F4 File Offset: 0x000028F4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Trash.Form1));
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.usernameTextbox = new global::Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.passwordTextbox = new global::Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.loginButton = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label2.Location = new global::System.Drawing.Point(306, 39);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(84, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Username:";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label3.Location = new global::System.Drawing.Point(306, 110);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(79, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password:";
			this.button1.BackColor = global::System.Drawing.Color.Transparent;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.Red;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Black;
			this.button1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.Transparent;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			this.button1.Location = new global::System.Drawing.Point(567, 5);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(25, 28);
			this.button1.TabIndex = 5;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.usernameTextbox.BackColor = global::System.Drawing.Color.GhostWhite;
			this.usernameTextbox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.usernameTextbox.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.usernameTextbox.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.usernameTextbox.HintForeColor = global::System.Drawing.Color.Empty;
			this.usernameTextbox.HintText = "";
			this.usernameTextbox.isPassword = false;
			this.usernameTextbox.LineFocusedColor = global::System.Drawing.Color.MediumSpringGreen;
			this.usernameTextbox.LineIdleColor = global::System.Drawing.Color.Gray;
			this.usernameTextbox.LineMouseHoverColor = global::System.Drawing.Color.DodgerBlue;
			this.usernameTextbox.LineThickness = 3;
			this.usernameTextbox.Location = new global::System.Drawing.Point(310, 64);
			this.usernameTextbox.Margin = new global::System.Windows.Forms.Padding(4);
			this.usernameTextbox.Name = "usernameTextbox";
			this.usernameTextbox.Size = new global::System.Drawing.Size(232, 33);
			this.usernameTextbox.TabIndex = 7;
			this.usernameTextbox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.passwordTextbox.BackColor = global::System.Drawing.Color.GhostWhite;
			this.passwordTextbox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.passwordTextbox.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.passwordTextbox.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.passwordTextbox.HintForeColor = global::System.Drawing.Color.Empty;
			this.passwordTextbox.HintText = "";
			this.passwordTextbox.isPassword = false;
			this.passwordTextbox.LineFocusedColor = global::System.Drawing.Color.MediumSpringGreen;
			this.passwordTextbox.LineIdleColor = global::System.Drawing.Color.Gray;
			this.passwordTextbox.LineMouseHoverColor = global::System.Drawing.Color.DodgerBlue;
			this.passwordTextbox.LineThickness = 3;
			this.passwordTextbox.Location = new global::System.Drawing.Point(310, 135);
			this.passwordTextbox.Margin = new global::System.Windows.Forms.Padding(4);
			this.passwordTextbox.Name = "passwordTextbox";
			this.passwordTextbox.Size = new global::System.Drawing.Size(232, 33);
			this.passwordTextbox.TabIndex = 8;
			this.passwordTextbox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(-19, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(265, 440);
			this.panel1.TabIndex = 9;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI Light", 8f);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(76, 19);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(72, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "(administrator)";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI Light", 9f);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(20, 48);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(64, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "Changelog:";
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.ForeColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.richTextBox1.Location = new global::System.Drawing.Point(23, 66);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(239, 198);
			this.richTextBox1.TabIndex = 12;
			this.richTextBox1.Text = "";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Light", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(29, 10);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(50, 25);
			this.label4.TabIndex = 12;
			this.label4.Text = "trash";
			this.label1.BackColor = global::System.Drawing.Color.White;
			this.label1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.label1.Location = new global::System.Drawing.Point(20, 276);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(169, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "(c) n4h";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.loginButton.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.loginButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.loginButton.ForeColor = global::System.Drawing.Color.GhostWhite;
			this.loginButton.Location = new global::System.Drawing.Point(315, 184);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new global::System.Drawing.Size(218, 30);
			this.loginButton.TabIndex = 11;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new global::System.EventHandler(this.loginButton_Click);
			this.label5.BackColor = global::System.Drawing.Color.White;
			this.label5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.label5.Location = new global::System.Drawing.Point(492, 299);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(100, 19);
			this.label5.TabIndex = 12;
			this.label5.Text = "ver 0.19";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.pictureBox1.Image = global::Trash.Properties.Resources.dclogo;
			this.pictureBox1.Location = new global::System.Drawing.Point(315, 268);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(204, 50);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click_1);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.GhostWhite;
			this.button2.Location = new global::System.Drawing.Point(315, 220);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(218, 30);
			this.button2.TabIndex = 14;
			this.button2.Text = "Register";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.GhostWhite;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(604, 317);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.loginButton);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.passwordTextbox);
			base.Controls.Add(this.usernameTextbox);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "trash login";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000033 RID: 51
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000037 RID: 55
		private global::Bunifu.Framework.UI.BunifuMaterialTextbox usernameTextbox;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Button loginButton;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003B RID: 59
		private global::Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextbox;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button button2;
	}
}
