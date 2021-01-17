namespace WindowsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetList = new System.Windows.Forms.Button();
            this.btnRmvProjCodeFromList = new System.Windows.Forms.Button();
            this.btnRmvSingle = new System.Windows.Forms.Button();
            this.btnAddCode = new System.Windows.Forms.Button();
            this.btnResetProjHours = new System.Windows.Forms.Button();
            this.btnAddProjHours = new System.Windows.Forms.Button();
            this.btnCalcToProjHours = new System.Windows.Forms.Button();
            this.txtProjHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.rchProjTotal = new System.Windows.Forms.RichTextBox();
            this.lblListProjCodes = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.txtAddProj = new System.Windows.Forms.TextBox();
            this.lblAddProjCode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rchTotal = new System.Windows.Forms.RichTextBox();
            this.numH2 = new System.Windows.Forms.NumericUpDown();
            this.numLun = new System.Windows.Forms.NumericUpDown();
            this.chkLun = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numH1 = new System.Windows.Forms.NumericUpDown();
            this.numH3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numH4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpClockCalc = new System.Windows.Forms.GroupBox();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH4)).BeginInit();
            this.grpClockCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.btnResetList);
            this.grpBox1.Controls.Add(this.btnRmvProjCodeFromList);
            this.grpBox1.Controls.Add(this.btnRmvSingle);
            this.grpBox1.Controls.Add(this.btnAddCode);
            this.grpBox1.Controls.Add(this.btnResetProjHours);
            this.grpBox1.Controls.Add(this.btnAddProjHours);
            this.grpBox1.Controls.Add(this.btnCalcToProjHours);
            this.grpBox1.Controls.Add(this.txtProjHours);
            this.grpBox1.Controls.Add(this.lblHours);
            this.grpBox1.Controls.Add(this.rchProjTotal);
            this.grpBox1.Controls.Add(this.lblListProjCodes);
            this.grpBox1.Controls.Add(this.cmbProjects);
            this.grpBox1.Controls.Add(this.txtAddProj);
            this.grpBox1.Controls.Add(this.lblAddProjCode);
            this.grpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(37, 424);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(905, 396);
            this.grpBox1.TabIndex = 21;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Project code handler";
            // 
            // btnResetList
            // 
            this.btnResetList.Enabled = false;
            this.btnResetList.Location = new System.Drawing.Point(260, 357);
            this.btnResetList.Name = "btnResetList";
            this.btnResetList.Size = new System.Drawing.Size(139, 33);
            this.btnResetList.TabIndex = 23;
            this.btnResetList.Text = "Reset Codelist";
            this.btnResetList.UseVisualStyleBackColor = true;
            this.btnResetList.Click += new System.EventHandler(this.btnResetList_Click);
            // 
            // btnRmvProjCodeFromList
            // 
            this.btnRmvProjCodeFromList.Enabled = false;
            this.btnRmvProjCodeFromList.Location = new System.Drawing.Point(260, 315);
            this.btnRmvProjCodeFromList.Name = "btnRmvProjCodeFromList";
            this.btnRmvProjCodeFromList.Size = new System.Drawing.Size(139, 33);
            this.btnRmvProjCodeFromList.TabIndex = 22;
            this.btnRmvProjCodeFromList.Text = "Remove Code";
            this.btnRmvProjCodeFromList.UseVisualStyleBackColor = true;
            this.btnRmvProjCodeFromList.Click += new System.EventHandler(this.btnRmvProjCodeFromList_Click);
            // 
            // btnRmvSingle
            // 
            this.btnRmvSingle.Location = new System.Drawing.Point(203, 186);
            this.btnRmvSingle.Name = "btnRmvSingle";
            this.btnRmvSingle.Size = new System.Drawing.Size(196, 38);
            this.btnRmvSingle.TabIndex = 16;
            this.btnRmvSingle.Text = "Remove project hours";
            this.btnRmvSingle.UseVisualStyleBackColor = true;
            this.btnRmvSingle.Click += new System.EventHandler(this.btnRmvSingle_Click);
            // 
            // btnAddCode
            // 
            this.btnAddCode.Location = new System.Drawing.Point(297, 269);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(102, 33);
            this.btnAddCode.TabIndex = 15;
            this.btnAddCode.Text = "Add code";
            this.btnAddCode.UseVisualStyleBackColor = true;
            this.btnAddCode.Click += new System.EventHandler(this.btnAddCode_Click);
            // 
            // btnResetProjHours
            // 
            this.btnResetProjHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetProjHours.Location = new System.Drawing.Point(657, 320);
            this.btnResetProjHours.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetProjHours.Name = "btnResetProjHours";
            this.btnResetProjHours.Size = new System.Drawing.Size(143, 54);
            this.btnResetProjHours.TabIndex = 14;
            this.btnResetProjHours.Text = "Reset Project hours";
            this.btnResetProjHours.UseVisualStyleBackColor = true;
            this.btnResetProjHours.Click += new System.EventHandler(this.btnResetProjHours_Click);
            // 
            // btnAddProjHours
            // 
            this.btnAddProjHours.Location = new System.Drawing.Point(203, 140);
            this.btnAddProjHours.Name = "btnAddProjHours";
            this.btnAddProjHours.Size = new System.Drawing.Size(196, 36);
            this.btnAddProjHours.TabIndex = 12;
            this.btnAddProjHours.Text = "Add hours to project";
            this.btnAddProjHours.UseVisualStyleBackColor = true;
            this.btnAddProjHours.Click += new System.EventHandler(this.btnAddProjHours_Click);
            // 
            // btnCalcToProjHours
            // 
            this.btnCalcToProjHours.Location = new System.Drawing.Point(488, 320);
            this.btnCalcToProjHours.Name = "btnCalcToProjHours";
            this.btnCalcToProjHours.Size = new System.Drawing.Size(137, 54);
            this.btnCalcToProjHours.TabIndex = 13;
            this.btnCalcToProjHours.Text = "Calculate Total Project hours";
            this.btnCalcToProjHours.UseVisualStyleBackColor = true;
            this.btnCalcToProjHours.Click += new System.EventHandler(this.btnCalcToProjHours_Click);
            // 
            // txtProjHours
            // 
            this.txtProjHours.Location = new System.Drawing.Point(21, 145);
            this.txtProjHours.Name = "txtProjHours";
            this.txtProjHours.Size = new System.Drawing.Size(147, 27);
            this.txtProjHours.TabIndex = 11;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(17, 122);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(106, 20);
            this.lblHours.TabIndex = 5;
            this.lblHours.Text = "Hour amount";
            // 
            // rchProjTotal
            // 
            this.rchProjTotal.Location = new System.Drawing.Point(415, 26);
            this.rchProjTotal.Name = "rchProjTotal";
            this.rchProjTotal.Size = new System.Drawing.Size(468, 273);
            this.rchProjTotal.TabIndex = 6;
            this.rchProjTotal.Text = "";
            // 
            // lblListProjCodes
            // 
            this.lblListProjCodes.AutoSize = true;
            this.lblListProjCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListProjCodes.Location = new System.Drawing.Point(14, 53);
            this.lblListProjCodes.Name = "lblListProjCodes";
            this.lblListProjCodes.Size = new System.Drawing.Size(231, 18);
            this.lblListProjCodes.TabIndex = 3;
            this.lblListProjCodes.Text = "Select code from Project code list";
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(17, 74);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(382, 28);
            this.cmbProjects.TabIndex = 10;
            this.cmbProjects.Text = "P943103 (Market Improvements)";
            // 
            // txtAddProj
            // 
            this.txtAddProj.Location = new System.Drawing.Point(21, 272);
            this.txtAddProj.Name = "txtAddProj";
            this.txtAddProj.Size = new System.Drawing.Size(271, 27);
            this.txtAddProj.TabIndex = 9;
            // 
            // lblAddProjCode
            // 
            this.lblAddProjCode.AutoSize = true;
            this.lblAddProjCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProjCode.Location = new System.Drawing.Point(18, 235);
            this.lblAddProjCode.Name = "lblAddProjCode";
            this.lblAddProjCode.Size = new System.Drawing.Size(150, 18);
            this.lblAddProjCode.TabIndex = 0;
            this.lblAddProjCode.Text = "Add new project code";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(430, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(610, 305);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hour summary";
            // 
            // rchTotal
            // 
            this.rchTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTotal.Location = new System.Drawing.Point(430, 44);
            this.rchTotal.Name = "rchTotal";
            this.rchTotal.ReadOnly = true;
            this.rchTotal.Size = new System.Drawing.Size(323, 245);
            this.rchTotal.TabIndex = 16;
            this.rchTotal.Text = "";
            // 
            // numH2
            // 
            this.numH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numH2.Location = new System.Drawing.Point(233, 55);
            this.numH2.Margin = new System.Windows.Forms.Padding(4);
            this.numH2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numH2.Name = "numH2";
            this.numH2.Size = new System.Drawing.Size(53, 24);
            this.numH2.TabIndex = 2;
            // 
            // numLun
            // 
            this.numLun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLun.Location = new System.Drawing.Point(232, 142);
            this.numLun.Margin = new System.Windows.Forms.Padding(4);
            this.numLun.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numLun.Name = "numLun";
            this.numLun.Size = new System.Drawing.Size(53, 24);
            this.numLun.TabIndex = 5;
            // 
            // chkLun
            // 
            this.chkLun.AutoSize = true;
            this.chkLun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLun.Location = new System.Drawing.Point(72, 142);
            this.chkLun.Name = "chkLun";
            this.chkLun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLun.Size = new System.Drawing.Size(70, 22);
            this.chkLun.TabIndex = 7;
            this.chkLun.Text = "Lunch";
            this.chkLun.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "To clock time";
            // 
            // numH1
            // 
            this.numH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numH1.Location = new System.Drawing.Point(172, 55);
            this.numH1.Margin = new System.Windows.Forms.Padding(4);
            this.numH1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numH1.Name = "numH1";
            this.numH1.Size = new System.Drawing.Size(53, 24);
            this.numH1.TabIndex = 1;
            // 
            // numH3
            // 
            this.numH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numH3.Location = new System.Drawing.Point(172, 98);
            this.numH3.Margin = new System.Windows.Forms.Padding(4);
            this.numH3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numH3.Name = "numH3";
            this.numH3.Size = new System.Drawing.Size(53, 24);
            this.numH3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Antal min";
            // 
            // numH4
            // 
            this.numH4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numH4.Location = new System.Drawing.Point(233, 98);
            this.numH4.Margin = new System.Windows.Forms.Padding(4);
            this.numH4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numH4.Name = "numH4";
            this.numH4.Size = new System.Drawing.Size(53, 24);
            this.numH4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "From clock time";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(133, 243);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 46);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate hours";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpClockCalc
            // 
            this.grpClockCalc.Controls.Add(this.btnCalculate);
            this.grpClockCalc.Controls.Add(this.rchTotal);
            this.grpClockCalc.Controls.Add(this.label2);
            this.grpClockCalc.Controls.Add(this.numLun);
            this.grpClockCalc.Controls.Add(this.button2);
            this.grpClockCalc.Controls.Add(this.label1);
            this.grpClockCalc.Controls.Add(this.numH2);
            this.grpClockCalc.Controls.Add(this.button1);
            this.grpClockCalc.Controls.Add(this.chkLun);
            this.grpClockCalc.Controls.Add(this.numH4);
            this.grpClockCalc.Controls.Add(this.label3);
            this.grpClockCalc.Controls.Add(this.numH1);
            this.grpClockCalc.Controls.Add(this.label5);
            this.grpClockCalc.Controls.Add(this.numH3);
            this.grpClockCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClockCalc.Location = new System.Drawing.Point(37, 44);
            this.grpClockCalc.Name = "grpClockCalc";
            this.grpClockCalc.Size = new System.Drawing.Size(905, 361);
            this.grpClockCalc.TabIndex = 22;
            this.grpClockCalc.TabStop = false;
            this.grpClockCalc.Text = "Calculate work hours";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 851);
            this.Controls.Add(this.grpClockCalc);
            this.Controls.Add(this.grpBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Clock Work ";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH4)).EndInit();
            this.grpClockCalc.ResumeLayout(false);
            this.grpClockCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label lblListProjCodes;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.TextBox txtAddProj;
        private System.Windows.Forms.Label lblAddProjCode;
        private System.Windows.Forms.RichTextBox rchProjTotal;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtProjHours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchTotal;
        private System.Windows.Forms.NumericUpDown numH2;
        private System.Windows.Forms.NumericUpDown numLun;
        private System.Windows.Forms.CheckBox chkLun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numH1;
        private System.Windows.Forms.NumericUpDown numH3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numH4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpClockCalc;
        private System.Windows.Forms.Button btnResetProjHours;
        private System.Windows.Forms.Button btnCalcToProjHours;
        private System.Windows.Forms.Button btnAddProjHours;
        private System.Windows.Forms.Button btnAddCode;
        private System.Windows.Forms.Button btnRmvSingle;
        private System.Windows.Forms.Button btnRmvProjCodeFromList;
        private System.Windows.Forms.Button btnResetList;
    }
}

