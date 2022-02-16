using System;
using System.Collections.Generic;

namespace Metin2_MD5_Patcher.Source_files
{
	internal class DefinitiiText
	{
		public static string GetText(string Key, params object[] Arguments)
		{
			foreach (KeyValuePair<string, string> keyValuePair in DefinitiiText.Text)
			{
				if (keyValuePair.Key == Key)
				{
					return string.Format(keyValuePair.Value, Arguments);
				}
			}
			return null;
		}

		private static Dictionary<string, string> Text = new Dictionary<string, string>
		{
			{
				"UNKNOWNERROR",
				"An unknown problem occurred ... Error code: \n{0}"
			},
			{
				"MISSINGBINARY",
				"The game could not start because {0} is missing."
			},
			{
				"CANNOTSTART",
				"I can't start the game. Try disabling the antivirus and trying again."
			},
			{
				"NONETWORK",
				"I can't connect to the server. Please check your internet connection."
			},
			{
				"CONNECTING",
				"I'm connecting to the server ..."
			},
			{
				"LISTDOWNLOAD",
				"I am preparing the download list ..."
			},
			{
				"CHECKFILE",
				"Checking files: {0} ..."
			},
			{
				"DOWNLOADFILE",
				"Downloading: {0} --> {1} / {2}"
			},
			{
				"COMPLETEPROGRESS",
				"Total progress:{0}%"
			},
			{
				"CURRENTPROGRESS",
				"File progress:{0}%"
			},
			{
				"CHECKCOMPLETE",
				"All files have been checked."
			},
			{
				"DOWNLOADCOMPLETE",
				"The client has been updated."
			},
			{
				"DOWNLOADSPEED",
				"Download speed: {0} mb/s"
			}
		};
	}
}
