using Patcher_RaffaeL_Rework.Source_files;
using System.Collections.Generic;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class DefinireElemente
	{
        public static string ServerURL = DefinireLinkuri.patcherUrl; //link-ul se afla in fisierul "DefinireLinkuri.cs"
        public static string Arguments = DefinireLinkuri.argumentKeyUrl; //Idem
		public static string PatchlistName = "patchlist.txt";
		public static string BinaryName = "ancient2.bin";
		public static string ConfigName = "config.exe";
		public static RaffaeL_Work RaffaeL_Work;
		public static List<DefinireElemente.File> Files = new List<DefinireElemente.File>();
		public static List<string> FisiereVechi = new List<string>();
		public static long fullSize;
		public static long completeSize;
		public struct File
		{
			public string Name;
			public string Hash;
			public long Size;
		}
	}
}
