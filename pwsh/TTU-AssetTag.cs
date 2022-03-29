using System;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace TTU_AssetTag
{
    [Cmdlet(VerbsCommon.Set,"LenovoAssetTag")]
    public class TTUAssetTagCommand : PSCmdlet
    {
        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            string WinAIAexe = $"{Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)}/resources/WinAIA.exe";

            System.Diagnostics.ProcessStartInfo WinAIAProcInfo = new System.Diagnostics.ProcessStartInfo(WinAIAexe, $"/?");
			WinAIAProcInfo.RedirectStandardOutput = true;
			WinAIAProcInfo.UseShellExecute = false;
			WinAIAProcInfo.CreateNoWindow = true;
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo = WinAIAProcInfo;
			process.Start();
			process.WaitForExit();
			var result = process.StandardOutput.ReadToEnd();
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
