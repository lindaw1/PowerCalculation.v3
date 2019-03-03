namespace PowerCalculation
{
    partial class frmLindaPowCal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblResidential = new System.Windows.Forms.Label();
            this.txtResPower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnCalculateRes = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radRes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radInd = new System.Windows.Forms.RadioButton();
            this.radCom = new System.Windows.Forms.RadioButton();
            this.lblCommercial = new System.Windows.Forms.Label();
            this.lblIndPeak = new System.Windows.Forms.Label();
            this.lblIndOffPeak = new System.Windows.Forms.Label();
            this.txtComPower = new System.Windows.Forms.TextBox();
            this.txtIndPeakPower = new System.Windows.Forms.TextBox();
            this.txtIndOffPeakPower = new System.Windows.Forms.TextBox();
            this.btnCalculateCom = new System.Windows.Forms.Button();
            this.btnCalculateInd = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustNumber = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustNumber = new System.Windows.Forms.TextBox();
            this.lblCustTotal = new System.Windows.Forms.Label();
            this.txtSumAll = new System.Windows.Forms.TextBox();
            this.lblSumAll = new System.Windows.Forms.Label();
            this.txtSumComCharges = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSumResCharges = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSumIndCharges = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Power Calculator";
            // 
            // lblResidential
            // 
            this.lblResidential.AutoSize = true;
            this.lblResidential.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidential.Location = new System.Drawing.Point(49, 291);
            this.lblResidential.Name = "lblResidential";
            this.lblResidential.Size = new System.Drawing.Size(153, 25);
            this.lblResidential.TabIndex = 21;
            this.lblResidential.Text = "Enter your kWh:";
            // 
            // txtResPower
            // 
            this.txtResPower.Location = new System.Drawing.Point(318, 290);
            this.txtResPower.Name = "txtResPower";
            this.txtResPower.Size = new System.Drawing.Size(100, 26);
            this.txtResPower.TabIndex = 0;
            this.txtResPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "The cost of your power is:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(479, 550);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(225, 26);
            this.txtCost.TabIndex = 24;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculateRes
            // 
            this.btnCalculateRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalculateRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateRes.Location = new System.Drawing.Point(479, 284);
            this.btnCalculateRes.Name = "btnCalculateRes";
            this.btnCalculateRes.Size = new System.Drawing.Size(225, 39);
            this.btnCalculateRes.TabIndex = 1;
            this.btnCalculateRes.Text = "Calculate";
            this.btnCalculateRes.UseVisualStyleBackColor = false;
            this.btnCalculateRes.Click += new System.EventHandler(this.btnCalculateRes_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(418, 611);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(584, 611);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 39);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radRes
            // 
            this.radRes.AutoSize = true;
            this.radRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radRes.Checked = true;
            this.radRes.Location = new System.Drawing.Point(19, 61);
            this.radRes.MinimumSize = new System.Drawing.Size(200, 50);
            this.radRes.Name = "radRes";
            this.radRes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.radRes.Size = new System.Drawing.Size(200, 50);
            this.radRes.TabIndex = 20;
            this.radRes.TabStop = true;
            this.radRes.Text = "Residential";
            this.radRes.UseVisualStyleBackColor = false;
            this.radRes.CheckedChanged += new System.EventHandler(this.radRes_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.radInd);
            this.groupBox1.Controls.Add(this.radCom);
            this.groupBox1.Controls.Add(this.radRes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(473, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 240);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Customer Type";
            // 
            // radInd
            // 
            this.radInd.AutoSize = true;
            this.radInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radInd.Location = new System.Drawing.Point(19, 173);
            this.radInd.MinimumSize = new System.Drawing.Size(200, 50);
            this.radInd.Name = "radInd";
            this.radInd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.radInd.Size = new System.Drawing.Size(200, 50);
            this.radInd.TabIndex = 28;
            this.radInd.TabStop = true;
            this.radInd.Text = "Industrial";
            this.radInd.UseVisualStyleBackColor = false;
            this.radInd.CheckedChanged += new System.EventHandler(this.radInd_CheckedChanged);
            // 
            // radCom
            // 
            this.radCom.AutoSize = true;
            this.radCom.BackColor = System.Drawing.Color.LightSeaGreen;
            this.radCom.Location = new System.Drawing.Point(19, 117);
            this.radCom.MinimumSize = new System.Drawing.Size(200, 50);
            this.radCom.Name = "radCom";
            this.radCom.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.radCom.Size = new System.Drawing.Size(200, 50);
            this.radCom.TabIndex = 23;
            this.radCom.TabStop = true;
            this.radCom.Text = "Commercial";
            this.radCom.UseVisualStyleBackColor = false;
            this.radCom.CheckedChanged += new System.EventHandler(this.radCom_CheckedChanged);
            // 
            // lblCommercial
            // 
            this.lblCommercial.AutoSize = true;
            this.lblCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommercial.Location = new System.Drawing.Point(49, 351);
            this.lblCommercial.Name = "lblCommercial";
            this.lblCommercial.Size = new System.Drawing.Size(153, 25);
            this.lblCommercial.TabIndex = 9;
            this.lblCommercial.Text = "Enter your kWh:";
            this.lblCommercial.Visible = false;
            // 
            // lblIndPeak
            // 
            this.lblIndPeak.AutoSize = true;
            this.lblIndPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndPeak.Location = new System.Drawing.Point(49, 434);
            this.lblIndPeak.Name = "lblIndPeak";
            this.lblIndPeak.Size = new System.Drawing.Size(206, 25);
            this.lblIndPeak.TabIndex = 10;
            this.lblIndPeak.Text = "Enter Your Peak kWh:";
            this.lblIndPeak.Visible = false;
            // 
            // lblIndOffPeak
            // 
            this.lblIndOffPeak.AutoSize = true;
            this.lblIndOffPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndOffPeak.Location = new System.Drawing.Point(49, 470);
            this.lblIndOffPeak.Name = "lblIndOffPeak";
            this.lblIndOffPeak.Size = new System.Drawing.Size(237, 25);
            this.lblIndOffPeak.TabIndex = 11;
            this.lblIndOffPeak.Text = "Enter Your Off-peak kWh:";
            this.lblIndOffPeak.Visible = false;
            // 
            // txtComPower
            // 
            this.txtComPower.Location = new System.Drawing.Point(318, 350);
            this.txtComPower.Name = "txtComPower";
            this.txtComPower.Size = new System.Drawing.Size(100, 26);
            this.txtComPower.TabIndex = 2;
            this.txtComPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComPower.Visible = false;
            // 
            // txtIndPeakPower
            // 
            this.txtIndPeakPower.Location = new System.Drawing.Point(318, 433);
            this.txtIndPeakPower.Name = "txtIndPeakPower";
            this.txtIndPeakPower.Size = new System.Drawing.Size(100, 26);
            this.txtIndPeakPower.TabIndex = 4;
            this.txtIndPeakPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIndPeakPower.Visible = false;
            // 
            // txtIndOffPeakPower
            // 
            this.txtIndOffPeakPower.Location = new System.Drawing.Point(318, 470);
            this.txtIndOffPeakPower.Name = "txtIndOffPeakPower";
            this.txtIndOffPeakPower.Size = new System.Drawing.Size(100, 26);
            this.txtIndOffPeakPower.TabIndex = 5;
            this.txtIndOffPeakPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIndOffPeakPower.Visible = false;
            // 
            // btnCalculateCom
            // 
            this.btnCalculateCom.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCalculateCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCom.Location = new System.Drawing.Point(479, 344);
            this.btnCalculateCom.Name = "btnCalculateCom";
            this.btnCalculateCom.Size = new System.Drawing.Size(225, 39);
            this.btnCalculateCom.TabIndex = 3;
            this.btnCalculateCom.Text = "Calculate";
            this.btnCalculateCom.UseVisualStyleBackColor = false;
            this.btnCalculateCom.Visible = false;
            this.btnCalculateCom.Click += new System.EventHandler(this.btnCalculateCom_Click);
            // 
            // btnCalculateInd
            // 
            this.btnCalculateInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCalculateInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateInd.Location = new System.Drawing.Point(479, 451);
            this.btnCalculateInd.Name = "btnCalculateInd";
            this.btnCalculateInd.Size = new System.Drawing.Size(225, 39);
            this.btnCalculateInd.TabIndex = 6;
            this.btnCalculateInd.Text = "Calculate";
            this.btnCalculateInd.UseVisualStyleBackColor = false;
            this.btnCalculateInd.Visible = false;
            this.btnCalculateInd.Click += new System.EventHandler(this.btnCalculateInd_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(753, 129);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(424, 324);
            this.lstCustomers.TabIndex = 26;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(738, 32);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(124, 20);
            this.lblCustomerName.TabIndex = 27;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustNumber
            // 
            this.lblCustNumber.AutoSize = true;
            this.lblCustNumber.Location = new System.Drawing.Point(738, 79);
            this.lblCustNumber.Name = "lblCustNumber";
            this.lblCustNumber.Size = new System.Drawing.Size(138, 20);
            this.lblCustNumber.TabIndex = 28;
            this.lblCustNumber.Text = "Customer Number";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(903, 21);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(121, 26);
            this.txtCustName.TabIndex = 29;
            // 
            // txtCustNumber
            // 
            this.txtCustNumber.Location = new System.Drawing.Point(903, 73);
            this.txtCustNumber.Name = "txtCustNumber";
            this.txtCustNumber.Size = new System.Drawing.Size(121, 26);
            this.txtCustNumber.TabIndex = 30;
            // 
            // lblCustTotal
            // 
            this.lblCustTotal.AutoSize = true;
            this.lblCustTotal.Location = new System.Drawing.Point(767, 462);
            this.lblCustTotal.Name = "lblCustTotal";
            this.lblCustTotal.Size = new System.Drawing.Size(203, 20);
            this.lblCustTotal.TabIndex = 31;
            this.lblCustTotal.Text = "Total Number of Customers";
            // 
            // txtSumAll
            // 
            this.txtSumAll.Enabled = false;
            this.txtSumAll.Location = new System.Drawing.Point(932, 634);
            this.txtSumAll.Name = "txtSumAll";
            this.txtSumAll.Size = new System.Drawing.Size(121, 26);
            this.txtSumAll.TabIndex = 33;
            this.txtSumAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSumAll
            // 
            this.lblSumAll.AutoSize = true;
            this.lblSumAll.Location = new System.Drawing.Point(767, 636);
            this.lblSumAll.Name = "lblSumAll";
            this.lblSumAll.Size = new System.Drawing.Size(145, 20);
            this.lblSumAll.TabIndex = 32;
            this.lblSumAll.Text = "Sum of All Charges";
            // 
            // txtSumComCharges
            // 
            this.txtSumComCharges.Enabled = false;
            this.txtSumComCharges.Location = new System.Drawing.Point(932, 542);
            this.txtSumComCharges.Name = "txtSumComCharges";
            this.txtSumComCharges.Size = new System.Drawing.Size(121, 26);
            this.txtSumComCharges.TabIndex = 35;
            this.txtSumComCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(767, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Sum of Com Charges";
            // 
            // txtSumResCharges
            // 
            this.txtSumResCharges.Enabled = false;
            this.txtSumResCharges.Location = new System.Drawing.Point(932, 496);
            this.txtSumResCharges.Name = "txtSumResCharges";
            this.txtSumResCharges.Size = new System.Drawing.Size(121, 26);
            this.txtSumResCharges.TabIndex = 37;
            this.txtSumResCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(767, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Sum of Res Charges";
            // 
            // txtSumIndCharges
            // 
            this.txtSumIndCharges.Enabled = false;
            this.txtSumIndCharges.Location = new System.Drawing.Point(932, 588);
            this.txtSumIndCharges.Name = "txtSumIndCharges";
            this.txtSumIndCharges.Size = new System.Drawing.Size(121, 26);
            this.txtSumIndCharges.TabIndex = 39;
            this.txtSumIndCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(767, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sum of Ind Charges";
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(1079, 32);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(166, 47);
            this.btnAddCust.TabIndex = 40;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // frmLindaPowCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 679);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.txtSumIndCharges);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSumResCharges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSumComCharges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSumAll);
            this.Controls.Add(this.lblSumAll);
            this.Controls.Add(this.lblCustTotal);
            this.Controls.Add(this.txtCustNumber);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustNumber);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateInd);
            this.Controls.Add(this.btnCalculateCom);
            this.Controls.Add(this.txtIndOffPeakPower);
            this.Controls.Add(this.txtIndPeakPower);
            this.Controls.Add(this.txtComPower);
            this.Controls.Add(this.lblIndOffPeak);
            this.Controls.Add(this.lblIndPeak);
            this.Controls.Add(this.lblCommercial);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateRes);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResPower);
            this.Controls.Add(this.lblResidential);
            this.Name = "frmLindaPowCal";
            this.Text = "Power Calculator by Linda";
            this.Load += new System.EventHandler(this.frmLindaPowCal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResidential;
        private System.Windows.Forms.TextBox txtResPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnCalculateRes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radInd;
        private System.Windows.Forms.RadioButton radCom;
        private System.Windows.Forms.Label lblCommercial;
        private System.Windows.Forms.Label lblIndPeak;
        private System.Windows.Forms.Label lblIndOffPeak;
        private System.Windows.Forms.TextBox txtComPower;
        private System.Windows.Forms.TextBox txtIndPeakPower;
        private System.Windows.Forms.TextBox txtIndOffPeakPower;
        private System.Windows.Forms.Button btnCalculateCom;
        private System.Windows.Forms.Button btnCalculateInd;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustNumber;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustNumber;
        private System.Windows.Forms.Label lblCustTotal;
        private System.Windows.Forms.TextBox txtSumAll;
        private System.Windows.Forms.Label lblSumAll;
        private System.Windows.Forms.TextBox txtSumComCharges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSumResCharges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSumIndCharges;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCust;
        //       private System.Windows.Forms.Button btnAddCustomer;
    }
}

