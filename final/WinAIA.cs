using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTU_AssetTag
{
	public static class WinAIA
	{
		private static string WinAIAexe = $"{Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)}/resources/WinAIA.exe";

		private static string SettingsTxt = $"{Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)}/{Environment.MachineName.ToUpper()}.txt";

		public static WinAIASettings GetSettings()
		{
			System.Diagnostics.ProcessStartInfo WinAIAProcInfo = new System.Diagnostics.ProcessStartInfo(WinAIAexe, $"-silent -output-file \"{ SettingsTxt }\" -get");
			WinAIAProcInfo.RedirectStandardOutput = true;
			WinAIAProcInfo.UseShellExecute = false;
			WinAIAProcInfo.CreateNoWindow = true;
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo = WinAIAProcInfo;
			process.Start();
			process.WaitForExit();
			var result = process.StandardOutput.ReadToEnd();

			if (File.Exists(SettingsTxt))
			{
				string[] lines = File.ReadAllLines(SettingsTxt);

				WinAIASettings settings = new WinAIASettings();

				foreach (string line in lines)
				{
					if (line.Contains("ASSET_NUMBER"))
					{
						int index = line.IndexOf('=');
						int end = line.Length - index - 1;
						index = index + 1;

						string AssetNumberValue = line.Substring(index, end);

						settings.AssetNumber = AssetNumberValue;
					}
				}

				File.Delete(SettingsTxt);

				return settings;
			}
			else
			{
				WinAIASettings settings = new WinAIASettings();
				return settings;
			}
		}

		public static void SetSettings(WinAIASettings settings)
		{
			System.Diagnostics.ProcessStartInfo WinAIAProcInfo = new System.Diagnostics.ProcessStartInfo(WinAIAexe, $"-silent -set \"USERASSETDATA.ASSET_NUMBER={ settings.AssetNumber }\"");
			WinAIAProcInfo.RedirectStandardOutput = true;
			WinAIAProcInfo.UseShellExecute = false;
			WinAIAProcInfo.CreateNoWindow = true;
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo = WinAIAProcInfo;
			process.Start();
			process.WaitForExit();
			var result = process.StandardOutput.ReadToEnd();
		}
	}
}
