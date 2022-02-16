using System;
using System.Diagnostics;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class Computer
	{
		public static long Compute(long Size)
		{
			return Size * 100L / DefinireElemente.fullSize;
		}

		public static double ComputeDownloadSize(double Size)
		{
			return Size / 1024.0 / 1024.0;
		}

		public static double ComputeDownloadSpeed(double Size, Stopwatch stopWatch)
		{
			return Size / 1024.0 / stopWatch.Elapsed.TotalSeconds;
		}
	}
}
