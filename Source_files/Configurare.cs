using System;
using System.Diagnostics;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class Configurare
	{
		public static void Start()
		{
			new Process
			{
				StartInfo = 
				{
					FileName = DefinireElemente.ConfigName,
					UseShellExecute = false
				}
			}.Start();
		}
	}
}
