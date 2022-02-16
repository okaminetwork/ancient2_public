using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class DescarcareFisiere
	{
		public static void DownloadFile()
		{
			if (DefinireElemente.FisiereVechi.Count <= 0)
			{
				Executor.ChangeStatus("CHECKCOMPLETE", new string[0]);
				Executor.EnableStart();
				return;
			}
			if (DescarcareFisiere.curFile >= DefinireElemente.FisiereVechi.Count)
			{
				Executor.ChangeStatus("DOWNLOADCOMPLETE", new string[0]);
				Executor.EnableStart();
				return;
			}
			if (DefinireElemente.FisiereVechi[DescarcareFisiere.curFile].Contains("/"))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(DefinireElemente.FisiereVechi[DescarcareFisiere.curFile]));
			}
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += DescarcareFisiere.webClient_DownloadProgressChanged;
			webClient.DownloadFileCompleted += DescarcareFisiere.webClient_DownloadFileCompleted;
			DescarcareFisiere.stopWatch.Start();
			webClient.DownloadFileAsync(new Uri(DefinireElemente.ServerURL + DefinireElemente.FisiereVechi[DescarcareFisiere.curFile]), DefinireElemente.FisiereVechi[DescarcareFisiere.curFile]);
		}

		private static void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			DescarcareFisiere.currentBytes = DescarcareFisiere.lastBytes + e.BytesReceived;
			Executor.ChangeStatus("DOWNLOADFILE", new string[]
			{
				DefinireElemente.FisiereVechi[DescarcareFisiere.curFile],
				Computer.ComputeDownloadSize((double)e.BytesReceived).ToString("0.00") + " MB ",
				Computer.ComputeDownloadSize((double)e.TotalBytesToReceive).ToString("0.00") + " MB"
			});
			Executor.UpdateCompleteProgress(Computer.Compute(DefinireElemente.completeSize + DescarcareFisiere.currentBytes));
			Executor.UpdateCurrentProgress((long)e.ProgressPercentage, Computer.ComputeDownloadSpeed((double)e.BytesReceived, DescarcareFisiere.stopWatch));
		}

		private static void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			DescarcareFisiere.lastBytes = DescarcareFisiere.currentBytes;
			Executor.UpdateCurrentProgress(100L, 0.0);
			DescarcareFisiere.curFile++;
			DescarcareFisiere.stopWatch.Reset();
			DescarcareFisiere.DownloadFile();
		}

		private static int curFile;
		private static long lastBytes;
		private static long currentBytes;
		private static Stopwatch stopWatch = new Stopwatch();
	}
}
