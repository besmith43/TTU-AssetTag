using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTU_AssetTag
{
	public class WinAIASettings
	{
		public string AssetNumber { get; set; }
		public string PurchaseDate { get; set; }
		public string WarrantyEnd { get; set; }
		public string Location { get; set; }
		public string OwnerName { get; set; }
		public string Department { get; set; }
		public string PhoneExtension { get; set; }
		public string ImageDate { get; set; }

		public WinAIASettings()
		{

		}

		public void UpdateImageDate()
		{
			System.Diagnostics.ProcessStartInfo ImageDateInfo = new System.Diagnostics.ProcessStartInfo("wmic", "os get installdate");
			ImageDateInfo.RedirectStandardOutput = true;
			ImageDateInfo.UseShellExecute = false;
			ImageDateInfo.CreateNoWindow = true;
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo = ImageDateInfo;
			process.Start();
			process.WaitForExit();
			var result = process.StandardOutput.ReadToEnd();

			char[] trimAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '\n' };

			result = result.ToLower();

			result = result.Trim(trimAlphabet);

			ImageDate = result.Substring(8);
		}
	}
}
