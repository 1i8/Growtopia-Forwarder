namespace Trash
{
	// Token: 0x02000018 RID: 24
	public partial class settings : global::System.Windows.Forms.Form
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00002A26 File Offset: 0x00000C26
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000BD58 File Offset: 0x00009F58
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Trash.settings));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.exitFormButton = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semilight", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(27, 19);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(102, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "trash settings";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semilight", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(194, 97);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(148, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Got u, there's none! ";
			this.exitFormButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.exitFormButton.FlatAppearance.BorderSize = 0;
			this.exitFormButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.exitFormButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("exitFormButton.Image");
			this.exitFormButton.Location = new global::System.Drawing.Point(495, 12);
			this.exitFormButton.Name = "exitFormButton";
			this.exitFormButton.Size = new global::System.Drawing.Size(27, 23);
			this.exitFormButton.TabIndex = 4;
			this.exitFormButton.UseVisualStyleBackColor = true;
			this.exitFormButton.Click += new global::System.EventHandler(this.exitFormButton_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(534, 225);
			base.Controls.Add(this.exitFormButton);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "settings";
			this.Text = "settings";
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000C2 RID: 194
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Button exitFormButton;
	}
}
