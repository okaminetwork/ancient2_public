using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class VerificareFisiere
	{
		public static void CheckFiles()
		{
			VerificareFisiere.backgroundWorker.WorkerReportsProgress = true;
			VerificareFisiere.backgroundWorker.DoWork += VerificareFisiere.backgroundWorker_DoWork;
			VerificareFisiere.backgroundWorker.ProgressChanged += VerificareFisiere.backgroundWorker_ProgressChanged;
			VerificareFisiere.backgroundWorker.RunWorkerCompleted += VerificareFisiere.backgroundWorker_RunWorkerCompleted;
			if (VerificareFisiere.backgroundWorker.IsBusy)
			{
				MessageBox.Show(DefinitiiText.GetText("UNKNOWNERROR", new object[]
				{
					"CheckFiles isBusy"
				}));
				Application.Exit();
				return;
			}
			VerificareFisiere.backgroundWorker.RunWorkerAsync();
		}
		private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			foreach (DefinireElemente.File file in DefinireElemente.Files)
			{
				DefinireElemente.fullSize += file.Size;
				VerificareFisiere.backgroundWorker.ReportProgress(0, Path.GetFileName(file.Name));
				if (!File.Exists(file.Name) || Executor.CalculateMD5Hash(file.Name) != file.Hash)
				{
					DefinireElemente.FisiereVechi.Add(file.Name);
				}
				else
				{
					DefinireElemente.completeSize += file.Size;
					VerificareFisiere.backgroundWorker.ReportProgress(1);
				}
			}
		}

		private static void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (e.ProgressPercentage == 0)
			{
				Executor.ChangeStatus("CHECKFILE", new string[]
				{
					e.UserState.ToString()
				});
				return;
			}
			Executor.UpdateCompleteProgress(Computer.Compute(DefinireElemente.completeSize));
		}

		private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			DescarcareFisiere.DownloadFile();
		}

		private static BackgroundWorker backgroundWorker = new BackgroundWorker();

		private enum State
		{
			REPORT_NAME,
			REPORT_PROGRESS
		}
	}
}
