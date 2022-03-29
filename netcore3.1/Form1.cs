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
			AssetNumberBox.Text = settings.AssetNumber;
			PurchaseDateBox.Text = settings.PurchaseDate;
			WarrantyEndBox.Text = settings.WarrantyEnd;
			OwnerNameBox.Text = settings.OwnerName;
			DepartmentBox.Text = settings.Department;
			PhoneExtensionBox.Text = settings.PhoneExtension;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			settings.AssetNumber = AssetNumberBox.Text;
			settings.PurchaseDate = PurchaseDateBox.Text;
			settings.WarrantyEnd = WarrantyEndBox.Text;
			string locTemp = Environment.MachineName.ToUpper();
			settings.Location = locTemp.Remove(locTemp.IndexOf('-'));
			settings.OwnerName = OwnerNameBox.Text;
			settings.Department = DepartmentBox.Text;
			settings.PhoneExtension = PhoneExtensionBox.Text;

			WinAIA.SetSettings(settings);
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
	}
}
