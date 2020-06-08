namespace Trash
{
	// Token: 0x0200000B RID: 11
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00002526 File Offset: 0x00000726
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000055F4 File Offset: 0x000037F4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Trash.Form2));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.SidePanel = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.settingsButton = new global::System.Windows.Forms.Button();
			this.exitFormButton = new global::System.Windows.Forms.Button();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.credits1 = new global::Trash.Credits();
			this.other1 = new global::Trash.Other();
			this.homeControl1 = new global::Trash.HomeControl();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.SidePanel);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(205, 383);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.panel1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semilight", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(73, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "trash v0.1";
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new global::System.Drawing.Point(16, 186);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(130, 60);
			this.button3.TabIndex = 4;
			this.button3.Text = "Other";
			this.button3.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new global::System.Drawing.Point(16, 120);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(130, 60);
			this.button2.TabIndex = 3;
			this.button2.Text = "Builder";
			this.button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.SidePanel.BackColor = global::System.Drawing.Color.FromArgb(21, 142, 251);
			this.SidePanel.Location = new global::System.Drawing.Point(0, 54);
			this.SidePanel.Name = "SidePanel";
			this.SidePanel.Size = new global::System.Drawing.Size(10, 59);
			this.SidePanel.TabIndex = 2;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new global::System.Drawing.Point(16, 54);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(118, 60);
			this.button1.TabIndex = 0;
			this.button1.Text = "Home";
			this.button1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.panel2.BackColor = global::System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new global::System.Drawing.Point(205, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(659, 10);
			this.panel2.TabIndex = 1;
			this.panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.panel2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.panel2.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.panel3.Location = new global::System.Drawing.Point(1, 7);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(659, 34);
			this.panel3.TabIndex = 8;
			this.settingsButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.settingsButton.FlatAppearance.BorderSize = 0;
			this.settingsButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.settingsButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.settingsButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.settingsButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("settingsButton.Image");
			this.settingsButton.Location = new global::System.Drawing.Point(597, 5);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new global::System.Drawing.Size(26, 23);
			this.settingsButton.TabIndex = 6;
			this.settingsButton.UseVisualStyleBackColor = true;
			this.settingsButton.Click += new global::System.EventHandler(this.settingsButton_Click);
			this.exitFormButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.exitFormButton.FlatAppearance.BorderSize = 0;
			this.exitFormButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.exitFormButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("exitFormButton.Image");
			this.exitFormButton.Location = new global::System.Drawing.Point(629, 5);
			this.exitFormButton.Name = "exitFormButton";
			this.exitFormButton.Size = new global::System.Drawing.Size(27, 23);
			this.exitFormButton.TabIndex = 3;
			this.exitFormButton.UseVisualStyleBackColor = true;
			this.exitFormButton.Click += new global::System.EventHandler(this.exitFormButton_Click);
			this.panel4.Controls.Add(this.exitFormButton);
			this.panel4.Controls.Add(this.settingsButton);
			this.panel4.Location = new global::System.Drawing.Point(205, 7);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(677, 37);
			this.panel4.TabIndex = 8;
			this.panel4.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.panel4.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.panel4.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.credits1.BackColor = global::System.Drawing.Color.FromArgb(68, 68, 68);
			this.credits1.Location = new global::System.Drawing.Point(206, 41);
			this.credits1.Name = "credits1";
			this.credits1.Size = new global::System.Drawing.Size(658, 341);
			this.credits1.TabIndex = 9;
			this.credits1.Load += new global::System.EventHandler(this.credits1_Load);
			this.other1.BackColor = global::System.Drawing.Color.FromArgb(68, 68, 68);
			this.other1.Location = new global::System.Drawing.Point(205, 44);
			this.other1.Name = "other1";
			this.other1.Size = new global::System.Drawing.Size(660, 339);
			this.other1.TabIndex = 7;
			this.homeControl1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.homeControl1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.homeControl1.Location = new global::System.Drawing.Point(205, 44);
			this.homeControl1.Name = "homeControl1";
			this.homeControl1.Size = new global::System.Drawing.Size(660, 389);
			this.homeControl1.TabIndex = 2;
			this.homeControl1.Load += new global::System.EventHandler(this.homeControl1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.ClientSize = new global::System.Drawing.Size(864, 383);
			base.Controls.Add(this.credits1);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.other1);
			base.Controls.Add(this.homeControl1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "trash main";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000046 RID: 70
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Panel SidePanel;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400004C RID: 76
		private global::Trash.HomeControl homeControl1;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Button exitFormButton;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Button settingsButton;

		// Token: 0x0400004F RID: 79
		private global::Trash.Other other1;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000054 RID: 84
		private global::Trash.Credits credits1;
	}
}
