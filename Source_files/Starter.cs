using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class Starter
	{
		public static void Start()
		{
			if (!File.Exists(DefinireElemente.BinaryName))
			{
				MessageBox.Show(DefinitiiText.GetText("MISSINGBINARY", new object[]
				{
					DefinireElemente.BinaryName
				}));
				return;
			}
			try
			{
				new Process
				{
					StartInfo = 
					{
						FileName = DefinireElemente.BinaryName,
						Arguments = DefinireElemente.Arguments,
						UseShellExecute = false
					}
				}.Start();
				Application.Exit();
			}
			catch (Exception ex)
			{
				MessageBox.Show(DefinitiiText.GetText("UNKNOWNERROR", new object[]
				{
					ex.Message
				}));
				Application.Exit();
			}
		}
	}
}
