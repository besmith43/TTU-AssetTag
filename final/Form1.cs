using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTU_AssetTag
{
    public partial class Form1 : Form
    {
		public WinAIASettings settings;

        public Form1(WinAIASettings _settings)
        {
			settings = _settings;
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			if (settings.AssetNumber != null)
			{
				AssetNumberBox.Text = settings.AssetNumber;
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private async void button2_Click(object sender, EventArgs e)
		{
			settings.AssetNumber = AssetNumberBox.Text;
			/*
			var pbar = new ProgressBar();

			pbar.Visible = true;
			pbar.Minimum = 1;
			pbar.Maximum = 5;
			pbar.Value = 1;
			pbar.Step = 1;
			*/
			await DoWork();
			/*
			for (int x = 1; x <= 5; x++)
			{
				Thread.Sleep();
				pbar.PerformStep();
			}
			*/
			Application.Exit();
		}

		private async Task DoWork()
		{
			await Task.Run(async () =>
		   {
			   WinAIA.SetSettings(settings);
		   });
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
