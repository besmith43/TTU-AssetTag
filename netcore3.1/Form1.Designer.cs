namespace TTU_AssetTag
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.WarrantyEndBox = new System.Windows.Forms.DateTimePicker();
			this.PurchaseDateBox = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AssetNumberBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.PhoneExtensionBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.DepartmentBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.OwnerNameBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.WarrantyEndBox);
			this.groupBox1.Controls.Add(this.PurchaseDateBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.AssetNumberBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(15, 9);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(374, 202);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User Asset Data";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// WarrantyEndBox
			// 
			this.WarrantyEndBox.Location = new System.Drawing.Point(7, 161);
			this.WarrantyEndBox.Name = "WarrantyEndBox";
			this.WarrantyEndBox.Size = new System.Drawing.Size(352, 35);
			this.WarrantyEndBox.TabIndex = 7;
			// 
			// PurchaseDateBox
			// 
			this.PurchaseDateBox.Location = new System.Drawing.Point(8, 104);
			this.PurchaseDateBox.Name = "PurchaseDateBox";
			this.PurchaseDateBox.Size = new System.Drawing.Size(351, 35);
			this.PurchaseDateBox.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 27);
			this.label3.TabIndex = 4;
			this.label3.Text = "Warranty End";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 27);
			this.label2.TabIndex = 2;
			this.label2.Text = "Purchase Date";
			// 
			// AssetNumberBox
			// 
			this.AssetNumberBox.Location = new System.Drawing.Point(7, 49);
			this.AssetNumberBox.Name = "AssetNumberBox";
			this.AssetNumberBox.Size = new System.Drawing.Size(352, 35);
			this.AssetNumberBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Asset Number";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.PhoneExtensionBox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.DepartmentBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.OwnerNameBox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(15, 241);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(374, 200);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Owner Data";
			// 
			// PhoneExtensionBox
			// 
			this.PhoneExtensionBox.Location = new System.Drawing.Point(7, 160);
			this.PhoneExtensionBox.Name = "PhoneExtensionBox";
			this.PhoneExtensionBox.Size = new System.Drawing.Size(352, 35);
			this.PhoneExtensionBox.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 137);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(175, 27);
			this.label6.TabIndex = 4;
			this.label6.Text = "Phone Extension";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// DepartmentBox
			// 
			this.DepartmentBox.Location = new System.Drawing.Point(7, 105);
			this.DepartmentBox.Name = "DepartmentBox";
			this.DepartmentBox.Size = new System.Drawing.Size(352, 35);
			this.DepartmentBox.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(126, 27);
			this.label5.TabIndex = 2;
			this.label5.Text = "Department";
			// 
			// OwnerNameBox
			// 
			this.OwnerNameBox.Location = new System.Drawing.Point(7, 49);
			this.OwnerNameBox.Name = "OwnerNameBox";
			this.OwnerNameBox.Size = new System.Drawing.Size(352, 35);
			this.OwnerNameBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 27);
			this.label4.TabIndex = 0;
			this.label4.Text = "Owner Name";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(280, 447);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 31);
			this.button1.TabIndex = 2;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(156, 447);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(109, 31);
			this.button2.TabIndex = 3;
			this.button2.Text = "Apply";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 489);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Form1";
			this.Text = "TTU Asset Tag";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker WarrantyEndBox;
		private System.Windows.Forms.DateTimePicker PurchaseDateBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox AssetNumberBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox PhoneExtensionBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox DepartmentBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox OwnerNameBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

