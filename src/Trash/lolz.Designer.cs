namespace Trash
{
	// Token: 0x02000015 RID: 21
	public partial class lolz : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00002952 File Offset: 0x00000B52
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000A6FC File Offset: 0x000088FC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Trash.lolz));
			this.label1 = new global::System.Windows.Forms.Label();
			this.exitFormButton = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.ipLabel = new global::System.Windows.Forms.Label();
			this.resLabel = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.dateLabel = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.lastworldl = new global::System.Windows.Forms.Label();
			this.computername = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.username = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semilight", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(128, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "trash information";
			this.exitFormButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.exitFormButton.FlatAppearance.BorderSize = 0;
			this.exitFormButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.exitFormButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("exitFormButton.Image");
			this.exitFormButton.Location = new global::System.Drawing.Point(536, 9);
			this.exitFormButton.Name = "exitFormButton";
			this.exitFormButton.Size = new global::System.Drawing.Size(27, 23);
			this.exitFormButton.TabIndex = 4;
			this.exitFormButton.UseVisualStyleBackColor = true;
			this.exitFormButton.Click += new global::System.EventHandler(this.exitFormButton_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(23, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "IP:";
			this.ipLabel.AutoSize = true;
			this.ipLabel.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.ipLabel.ForeColor = global::System.Drawing.Color.White;
			this.ipLabel.Location = new global::System.Drawing.Point(41, 53);
			this.ipLabel.Name = "ipLabel";
			this.ipLabel.Size = new global::System.Drawing.Size(12, 19);
			this.ipLabel.TabIndex = 6;
			this.ipLabel.Text = ".";
			this.resLabel.AutoSize = true;
			this.resLabel.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.resLabel.ForeColor = global::System.Drawing.Color.White;
			this.resLabel.Location = new global::System.Drawing.Point(409, 53);
			this.resLabel.Name = "resLabel";
			this.resLabel.Size = new global::System.Drawing.Size(12, 19);
			this.resLabel.TabIndex = 8;
			this.resLabel.Text = ".";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(287, 122);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(89, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "Stealing date:";
			this.dateLabel.AutoSize = true;
			this.dateLabel.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.dateLabel.ForeColor = global::System.Drawing.Color.White;
			this.dateLabel.Location = new global::System.Drawing.Point(382, 122);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new global::System.Drawing.Size(12, 19);
			this.dateLabel.TabIndex = 10;
			this.dateLabel.Text = ".";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(287, 53);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(116, 19);
			this.label6.TabIndex = 9;
			this.label6.Text = "Screen resolution:";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(12, 88);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(74, 19);
			this.label7.TabIndex = 11;
			this.label7.Text = "Last world:";
			this.lastworldl.AutoSize = true;
			this.lastworldl.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.lastworldl.ForeColor = global::System.Drawing.Color.White;
			this.lastworldl.Location = new global::System.Drawing.Point(92, 88);
			this.lastworldl.Name = "lastworldl";
			this.lastworldl.Size = new global::System.Drawing.Size(12, 19);
			this.lastworldl.TabIndex = 12;
			this.lastworldl.Text = ".";
			this.computername.AutoSize = true;
			this.computername.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.computername.ForeColor = global::System.Drawing.Color.White;
			this.computername.Location = new global::System.Drawing.Point(85, 122);
			this.computername.Name = "computername";
			this.computername.Size = new global::System.Drawing.Size(12, 19);
			this.computername.TabIndex = 14;
			this.computername.Text = ".";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(12, 122);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(67, 19);
			this.label5.TabIndex = 13;
			this.label5.Text = "PC name:";
			this.username.AutoSize = true;
			this.username.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.username.ForeColor = global::System.Drawing.Color.White;
			this.username.Location = new global::System.Drawing.Point(366, 88);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(12, 19);
			this.username.TabIndex = 16;
			this.username.Text = ".";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Segoe UI Semilight", 10f);
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.Location = new global::System.Drawing.Point(287, 88);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(73, 19);
			this.label9.TabIndex = 15;
			this.label9.Text = "Username:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(575, 186);
			base.Controls.Add(this.username);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.computername);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.lastworldl);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.dateLabel);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.resLabel);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.ipLabel);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.exitFormButton);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "lolz";
			this.Text = "trash info";
			base.Load += new global::System.EventHandler(this.lolz_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400009F RID: 159
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Button exitFormButton;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Label ipLabel;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.Label resLabel;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.Label dateLabel;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Label lastworldl;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Label computername;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.Label username;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.Label label9;
	}
}
