using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class ListaDescarcare
	{
		public static void DownloadList()
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			Executor.ChangeStatus("LISTDOWNLOAD", new string[0]);
			backgroundWorker.DoWork += ListaDescarcare.backgroundWorker_DoWork;
			backgroundWorker.RunWorkerCompleted += ListaDescarcare.backgroundWorker_RunWorkerCompleted;
			if (backgroundWorker.IsBusy)
			{
				MessageBox.Show(DefinitiiText.GetText("UNKNOWNERROR", new object[]
				{
					"DownloadList isBusy"
				}));
				Application.Exit();
				return;
			}
			backgroundWorker.RunWorkerAsync();
		}

		private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			WebClient webClient = new WebClient();
			Stream stream = webClient.OpenRead(DefinireElemente.ServerURL + DefinireElemente.PatchlistName);
			StreamReader streamReader = new StreamReader(stream);
			while (!streamReader.EndOfStream)
			{
				ProcesareLista.AddFile(streamReader.ReadLine());
			}
		}

		private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			VerificareFisiere.CheckFiles();
		}
	}
}
