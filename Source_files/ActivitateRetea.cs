using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class ActivitateRetea
	{
		public static void CheckNetwork()
		{
			Executor.ChangeStatus("CONNECTING", new string[0]);
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += ActivitateRetea.backgroundWorker_DoWork;
			backgroundWorker.RunWorkerCompleted += ActivitateRetea.backgroundWorker_RunWorkerCompleted;
			if (backgroundWorker.IsBusy)
			{
				MessageBox.Show(DefinitiiText.GetText("UNKNOWNERROR", new object[]
				{
					"CheckNetwork isBusy"
				}));
				Application.Exit();
				return;
			}
			backgroundWorker.RunWorkerAsync();
		}

		private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.OpenRead(DefinireElemente.ServerURL);
				e.Result = true;
			}
			catch
			{
				e.Result = false;
			}
		}

		private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			/*if (!Convert.ToBoolean(e.Result))
			{
				MessageBox.Show(DefinitiiText.GetText("NONETWORK", new object[0]));
				Application.Exit();
				return;
			}*/ 
            /*[Raffael]'s Comented block to avoid application load error.*/
			ListaDescarcare.DownloadList();
		}
	}
}
