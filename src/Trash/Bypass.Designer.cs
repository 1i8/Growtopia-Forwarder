namespace Trash
{
	// Token: 0x02000002 RID: 2
	public partial class Bypass : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000020C5 File Offset: 0x000002C5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000030F4 File Offset: 0x000012F4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Trash.Bypass));
			this.exitFormButton = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.AdaptersComboBox = new global::System.Windows.Forms.ComboBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.ActualMacLabel = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.orig = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.exitFormButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.exitFormButton.FlatAppearance.BorderSize = 0;
			this.exitFormButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.exitFormButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("exitFormButton.Image");
			this.exitFormButton.Location = new global::System.Drawing.Point(397, 10);
			this.exitFormButton.Name = "exitFormButton";
			this.exitFormButton.Size = new global::System.Drawing.Size(27, 23);
			this.exitFormButton.TabIndex = 6;
			this.exitFormButton.UseVisualStyleBackColor = true;
			this.exitFormButton.Click += new global::System.EventHandler(this.exitFormButton_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semilight", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(95, 21);
			this.label1.TabIndex = 5;
			this.label1.Text = "trash bypass";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semilight", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(27, 47);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(48, 21);
			this.label2.TabIndex = 7;
			this.label2.Text = "MAC:";
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new global::System.Drawing.Font("Times New Roman", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(81, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(164, 20);
			this.textBox1.TabIndex = 8;
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(81, 137);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(264, 31);
			this.button2.TabIndex = 17;
			this.button2.Text = "Bypass AAP";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.AdaptersComboBox.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.AdaptersComboBox.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.AdaptersComboBox.ForeColor = global::System.Drawing.Color.White;
			this.AdaptersComboBox.FormattingEnabled = true;
			this.AdaptersComboBox.Location = new global::System.Drawing.Point(119, 95);
			this.AdaptersComboBox.Name = "AdaptersComboBox";
			this.AdaptersComboBox.Size = new global::System.Drawing.Size(200, 21);
			this.AdaptersComboBox.TabIndex = 18;
			this.AdaptersComboBox.SelectedIndexChanged += new global::System.EventHandler(this.AdaptersComboBox_SelectedIndexChanged);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(26, 95);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(87, 19);
			this.label4.TabIndex = 19;
			this.label4.Text = "Pick adapter:";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI Semilight", 9f);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(12, 190);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(77, 15);
			this.label6.TabIndex = 22;
			this.label6.Text = "Current MAC:";
			this.label6.Click += new global::System.EventHandler(this.label6_Click);
			this.ActualMacLabel.AutoSize = true;
			this.ActualMacLabel.Font = new global::System.Drawing.Font("Segoe UI Semilight", 9f);
			this.ActualMacLabel.ForeColor = global::System.Drawing.Color.White;
			this.ActualMacLabel.Location = new global::System.Drawing.Point(95, 190);
			this.ActualMacLabel.Name = "ActualMacLabel";
			this.ActualMacLabel.Size = new global::System.Drawing.Size(0, 15);
			this.ActualMacLabel.TabIndex = 23;
			this.ActualMacLabel.UseMnemonic = false;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI Semilight", 9f);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(239, 190);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(80, 15);
			this.label5.TabIndex = 24;
			this.label5.Text = "Original MAC:";
			this.orig.AutoSize = true;
			this.orig.Font = new global::System.Drawing.Font("Segoe UI Semilight", 9f);
			this.orig.ForeColor = global::System.Drawing.Color.White;
			this.orig.Location = new global::System.Drawing.Point(325, 190);
			this.orig.Name = "orig";
			this.orig.Size = new global::System.Drawing.Size(23, 15);
			this.orig.TabIndex = 25;
			this.orig.Text = "idk";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(435, 211);
			base.Controls.Add(this.orig);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.ActualMacLabel);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.AdaptersComboBox);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.exitFormButton);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Bypass";
			this.Text = "Bypass";
			base.Load += new global::System.EventHandler(this.Bypass_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button exitFormButton;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.ComboBox AdaptersComboBox;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label ActualMacLabel;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label orig;
	}
}
