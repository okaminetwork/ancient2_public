using System;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class ProcesareLista
	{
		public static void AddFile(string File)
		{
			DefinireElemente.File item = default(DefinireElemente.File);
			item.Name = File.Split(new char[]
			{
				' '
			})[0];
			item.Hash = File.Split(new char[]
			{
				' '
			})[1];
			item.Size = Convert.ToInt64(File.Split(new char[]
			{
				' '
			})[2]);
			DefinireElemente.Files.Add(item);
		}
	}
}
