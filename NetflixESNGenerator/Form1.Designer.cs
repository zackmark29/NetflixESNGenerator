
namespace NetflixESNGenerator {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.cboDeviceType = new System.Windows.Forms.ComboBox();
            this.cboDeviceSubType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUHD = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeviceSystemId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeviceModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeviceManufacturer = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopyEsn = new System.Windows.Forms.Button();
            this.chkAutoGenerate = new System.Windows.Forms.CheckBox();
            this.txtESNOutput = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Type:";
            // 
            // cboDeviceType
            // 
            this.cboDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeviceType.FormattingEnabled = true;
            this.cboDeviceType.Items.AddRange(new object[] {
            "Android",
            "Browser"});
            this.cboDeviceType.Location = new System.Drawing.Point(81, 5);
            this.cboDeviceType.Name = "cboDeviceType";
            this.cboDeviceType.Size = new System.Drawing.Size(70, 23);
            this.cboDeviceType.TabIndex = 1;
            this.cboDeviceType.SelectedIndexChanged += new System.EventHandler(this.cboDeviceType_SelectedIndexChanged);
            // 
            // cboDeviceSubType
            // 
            this.cboDeviceSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeviceSubType.FormattingEnabled = true;
            this.cboDeviceSubType.Items.AddRange(new object[] {
            "Phone",
            "Tablet",
            "TV"});
            this.cboDeviceSubType.Location = new System.Drawing.Point(226, 5);
            this.cboDeviceSubType.Name = "cboDeviceSubType";
            this.cboDeviceSubType.Size = new System.Drawing.Size(62, 23);
            this.cboDeviceSubType.TabIndex = 3;
            this.cboDeviceSubType.SelectedIndexChanged += new System.EventHandler(this.cboDeviceSubType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUHD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDeviceSystemId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDeviceModel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDeviceManufacturer);
            this.groupBox1.Location = new System.Drawing.Point(5, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Info:";
            // 
            // chkUHD
            // 
            this.chkUHD.AutoSize = true;
            this.chkUHD.BackColor = System.Drawing.Color.Transparent;
            this.chkUHD.Location = new System.Drawing.Point(239, 72);
            this.chkUHD.Name = "chkUHD";
            this.chkUHD.Size = new System.Drawing.Size(44, 19);
            this.chkUHD.TabIndex = 10;
            this.chkUHD.Text = "4K?";
            this.chkUHD.UseVisualStyleBackColor = false;
            this.chkUHD.CheckedChanged += new System.EventHandler(this.chkUHD_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "System ID:";
            // 
            // txtDeviceSystemId
            // 
            this.txtDeviceSystemId.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDeviceSystemId.Location = new System.Drawing.Point(89, 71);
            this.txtDeviceSystemId.Name = "txtDeviceSystemId";
            this.txtDeviceSystemId.Size = new System.Drawing.Size(57, 20);
            this.txtDeviceSystemId.TabIndex = 8;
            this.txtDeviceSystemId.TextChanged += new System.EventHandler(this.txtDeviceSystemId_TextChanged);
            this.txtDeviceSystemId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeviceSystemId_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(4, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model:";
            // 
            // txtDeviceModel
            // 
            this.txtDeviceModel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDeviceModel.Location = new System.Drawing.Point(90, 44);
            this.txtDeviceModel.Name = "txtDeviceModel";
            this.txtDeviceModel.Size = new System.Drawing.Size(187, 20);
            this.txtDeviceModel.TabIndex = 6;
            this.txtDeviceModel.TextChanged += new System.EventHandler(this.txtDeviceModel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manufacturer:";
            // 
            // txtDeviceManufacturer
            // 
            this.txtDeviceManufacturer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDeviceManufacturer.Location = new System.Drawing.Point(90, 18);
            this.txtDeviceManufacturer.Name = "txtDeviceManufacturer";
            this.txtDeviceManufacturer.Size = new System.Drawing.Size(187, 20);
            this.txtDeviceManufacturer.TabIndex = 0;
            this.txtDeviceManufacturer.TextChanged += new System.EventHandler(this.txtDeviceManufacturer_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(5, 139);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopyEsn
            // 
            this.btnCopyEsn.Location = new System.Drawing.Point(86, 139);
            this.btnCopyEsn.Name = "btnCopyEsn";
            this.btnCopyEsn.Size = new System.Drawing.Size(75, 23);
            this.btnCopyEsn.TabIndex = 12;
            this.btnCopyEsn.Text = "Copy ESN";
            this.btnCopyEsn.UseVisualStyleBackColor = true;
            this.btnCopyEsn.Click += new System.EventHandler(this.btnCopyEsn_Click);
            // 
            // chkAutoGenerate
            // 
            this.chkAutoGenerate.AutoSize = true;
            this.chkAutoGenerate.Location = new System.Drawing.Point(192, 141);
            this.chkAutoGenerate.Name = "chkAutoGenerate";
            this.chkAutoGenerate.Size = new System.Drawing.Size(102, 19);
            this.chkAutoGenerate.TabIndex = 13;
            this.chkAutoGenerate.Text = "Auto Generate";
            this.chkAutoGenerate.UseVisualStyleBackColor = true;
            // 
            // txtESNOutput
            // 
            this.txtESNOutput.Location = new System.Drawing.Point(5, 168);
            this.txtESNOutput.Multiline = true;
            this.txtESNOutput.Name = "txtESNOutput";
            this.txtESNOutput.ReadOnly = true;
            this.txtESNOutput.Size = new System.Drawing.Size(283, 55);
            this.txtESNOutput.TabIndex = 14;
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVersion.ForeColor = System.Drawing.Color.DimGray;
            this.txtVersion.Location = new System.Drawing.Point(192, 226);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(101, 14);
            this.txtVersion.TabIndex = 11;
            this.txtVersion.Text = "v1.0.0 | 2022-01-09";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(2, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "©zackmark29";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(77, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "|  Credit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 245);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtESNOutput);
            this.Controls.Add(this.chkAutoGenerate);
            this.Controls.Add(this.btnCopyEsn);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboDeviceSubType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDeviceType);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netflix ESN Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDeviceType;
        private System.Windows.Forms.ComboBox cboDeviceSubType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeviceSystemId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeviceModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeviceManufacturer;
        private System.Windows.Forms.CheckBox chkUHD;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopyEsn;
        private System.Windows.Forms.CheckBox chkAutoGenerate;
        private System.Windows.Forms.TextBox txtESNOutput;
        private System.Windows.Forms.Label txtVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

