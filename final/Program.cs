using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTU_AssetTag
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!CheckManufacturer())
			{
                MessageBox.Show("This computer is not made by Lenovo", "Invalid Manufacturer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}

            if (!IsAdministrator())
			{
                MessageBox.Show("Please run this with administrative privileges", "Invalid Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(WinAIA.GetSettings()));
        }

        public static bool CheckManufacturer()
        {
            System.Diagnostics.ProcessStartInfo ManufacturerInfo = new System.Diagnostics.ProcessStartInfo("wmic", "computersystem get manufacturer");
            ManufacturerInfo.RedirectStandardOutput = true;
            ManufacturerInfo.UseShellExecute = false;
            ManufacturerInfo.CreateNoWindow = true;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = ManufacturerInfo;
            process.Start();
            process.WaitForExit();
            var result = process.StandardOutput.ReadToEnd();
            
            if (result.Contains("LENOVO"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static WinAIASettings GetCurrentSettings()
		{
            return WinAIA.GetSettings();
        }

        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                 .IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
