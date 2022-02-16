using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class Executor
	{
		public static string CalculateMD5Hash(string Name)
		{
			if (Name == string.Empty)
			{
				return null;
			}
			MD5 md = MD5.Create();
			string text = string.Empty;
			try
			{
				using (FileStream fileStream = File.Open(Name, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					foreach (byte b in md.ComputeHash(fileStream))
					{
						text += b.ToString("x2").ToLower();
					}
				}
			}
			catch
			{
				MessageBox.Show("Can't open: " + Name);
			}
			return text;
		}

		public static void ChangeStatus(string Key, params string[] Arguments)
		{
			//Globals.RaffaeL_Work.Status.Text = Texts.GetText(Key, Arguments);
			DefinireElemente.RaffaeL_Work.fileInfo.Text = DefinitiiText.GetText(Key, Arguments);
		}

		public static void UpdateCompleteProgress(long Value)
		{
			if (Value < 0L || Value > 100L)
			{
				return;
			}
			DefinireElemente.RaffaeL_Work.completeProgress.Value = Convert.ToInt32(Value);
			DefinireElemente.RaffaeL_Work.completeProgressText.Text = DefinitiiText.GetText("COMPLETEPROGRESS", new object[]
			{
				Value
			});
			DefinireElemente.RaffaeL_Work.pbTotal.Width = (int)Math.Round((double)(DefinireElemente.RaffaeL_Work.completeProgress.Value) * 4.34);
			if (DefinireElemente.RaffaeL_Work.completeProgress.Value == 100 || DefinireElemente.RaffaeL_Work.pbTotal.Width >= 434)
			{
				DefinireElemente.RaffaeL_Work.pbTotal.Width = 434;
			}
		}

		public static void UpdateCurrentProgress(long Value, double Speed)
		{
			if (Value < 0L || Value > 100L)
			{
				return;
			}
			DefinireElemente.RaffaeL_Work.currentProgress.Value = Convert.ToInt32(Value);
			DefinireElemente.RaffaeL_Work.currentProgressText.Text = DefinitiiText.GetText("CURRENTPROGRESS", new object[]
			{
				Value//,
				//Speed.ToString("0.00")
			});
			DefinireElemente.RaffaeL_Work.currentDownloadSpeed.Text = DefinitiiText.GetText("DOWNLOADSPEED", new object[]
			{
				(Speed / 1000).ToString("0.00")
			});
			DefinireElemente.RaffaeL_Work.pbFile.Width = (int)Math.Round((double)(DefinireElemente.RaffaeL_Work.currentProgress.Value) * 4.34);
			if (DefinireElemente.RaffaeL_Work.currentProgress.Value == 100 || DefinireElemente.RaffaeL_Work.pbFile.Width >= 434)
			{
				DefinireElemente.RaffaeL_Work.pbFile.Width = 434;
			}
		}

		public static void EnableStart()
		{
			DefinireElemente.RaffaeL_Work.Start.Enabled = true;
			DefinireElemente.RaffaeL_Work.Start.Image = Patcher_RaffaeL_Rework.Properties.Resources.btn_start_on;
		}

		public static bool IsGameRunning()
		{
			return Process.GetProcessesByName(DefinireElemente.BinaryName).FirstOrDefault((Process p) => p.MainModule.FileName.StartsWith("")) != null;
		}
	}
}
