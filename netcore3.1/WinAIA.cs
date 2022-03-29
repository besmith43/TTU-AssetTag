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
					if (line.Contains("OWNERNAME"))
					{
						int index = line.IndexOf('=');
						int end = line.Length - index;
						string OwnerNameValue = line.Substring(index, end);

						settings.OwnerName = OwnerNameValue;
					}

					if (line.Contains("DEPARTMENT"))
					{
						int index = line.IndexOf('=');
						int end = line.Length - index;
						string DepartmentValue = line.Substring(index, end);

						settings.Department = DepartmentValue;
					}

					if (line.Contains("LOCATION"))
					{
						int index = line.IndexOf('=');
						int end = line.Length - index;
						string LocationValue = line.Substring(index, end);

						settings.Location = LocationValue;
					}

					if (line.Contains("PHONE_NUMBER"))
					{
						int index = line.IndexOf('=');
						int end = line.Length - index;
						string PhoneNumberValue = line.Substring(index, end);

						settings.PhoneExtension = PhoneNumberValue;
					}

					if (line.Contains("PURCHASE_DATE"))
					{
						int index = line.IndexOf('=');
						int end = line.Length - index;
						string PurchaseDateValue = line.Substring(index, end);

						settings.PurchaseDate = PurchaseDateValue;
					}

					if (line.Contains("WARRANTY_END"))
					{
						int index = line.IndexOf('=');
						int end = line.Length - index;
						string WarrantyEndValue = line.Substring(index, end);

						settings.WarrantyEnd = WarrantyEndValue;
					}

					if (line.Contains("ASSET_NUMBER"))
					{
						int index = line.IndexOf('=');
						int end = line.Length - index;
						string AssetNumberValue = line.Substring(index, end);

						settings.AssetNumber = AssetNumberValue;
					}
				}

				settings.UpdateImageDate();

				File.Delete(SettingsTxt);

				return settings;
			}
			else
			{
				WinAIASettings settings = new WinAIASettings();
				settings.UpdateImageDate();
				return settings;
			}
		}

		public static void SetSettings(WinAIASettings settings)
		{
			// write to file
			string[] lines = { $"OWNERDATA.OWNERNAME={ settings.OwnerName }", $"OWNERDATA.DEPARTMENT={ settings.Department }", $"OWNERDATA.LOCATION={ settings.Location }", $"OWNERDATA.PHONE_NUMBER={ settings.PhoneExtension }", $"USERASSETDATA.PURCHASE_DATE={ settings.PurchaseDate }", $"USERASSETDATA.WARRANTY_END={ settings.WarrantyEnd }", $"USERASSETDATA.ASSET_NUMBER={ settings.AssetNumber }", $"PRELOADPROFILE.IMAGEDATE={ settings.ImageDate }"};

			File.WriteAllLines(SettingsTxt, lines);

			// call winaia.exe on file
			System.Diagnostics.ProcessStartInfo WinAIAProcInfo = new System.Diagnostics.ProcessStartInfo(WinAIAexe, $"-silent -set-from-file \"{ SettingsTxt }\"");
			WinAIAProcInfo.RedirectStandardOutput = true;
			WinAIAProcInfo.UseShellExecute = false;
			WinAIAProcInfo.CreateNoWindow = true;
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo = WinAIAProcInfo;
			process.Start();
			process.WaitForExit();
			var result = process.StandardOutput.ReadToEnd();

			File.Delete(SettingsTxt);
		}
	}
}
