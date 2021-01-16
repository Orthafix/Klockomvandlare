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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.numH1 = new System.Windows.Forms.NumericUpDown();
            this.numH2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numH4 = new System.Windows.Forms.NumericUpDown();
            this.numH3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rchTotal = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numLun = new System.Windows.Forms.NumericUpDown();
            this.chkLun = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Från klockslag";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(260, 96);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 77);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Räkna antal timmar";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // numH1
            // 
            this.numH1.Location = new System.Drawing.Point(128, 60);
            this.numH1.Margin = new System.Windows.Forms.Padding(4);
            this.numH1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numH1.Name = "numH1";
            this.numH1.Size = new System.Drawing.Size(53, 22);
            this.numH1.TabIndex = 2;
            // 
            // numH2
            // 
            this.numH2.Location = new System.Drawing.Point(189, 60);
            this.numH2.Margin = new System.Windows.Forms.Padding(4);
            this.numH2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numH2.Name = "numH2";
            this.numH2.Size = new System.Drawing.Size(53, 22);
            this.numH2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Antal timmar:";
            // 
            // numH4
            // 
            this.numH4.Location = new System.Drawing.Point(189, 95);
            this.numH4.Margin = new System.Windows.Forms.Padding(4);
            this.numH4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numH4.Name = "numH4";
            this.numH4.Size = new System.Drawing.Size(53, 22);
            this.numH4.TabIndex = 5;
            // 
            // numH3
            // 
            this.numH3.Location = new System.Drawing.Point(128, 95);
            this.numH3.Margin = new System.Windows.Forms.Padding(4);
            this.numH3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numH3.Name = "numH3";
            this.numH3.Size = new System.Drawing.Size(53, 22);
            this.numH3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Till klockslag";
            // 
            // rchTotal
            // 
            this.rchTotal.Location = new System.Drawing.Point(397, 60);
            this.rchTotal.Name = "rchTotal";
            this.rchTotal.ReadOnly = true;
            this.rchTotal.Size = new System.Drawing.Size(323, 365);
            this.rchTotal.TabIndex = 16;
            this.rchTotal.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Räkna ut totalen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 55);
            this.button2.TabIndex = 10;
            this.button2.Text = "Börja Om";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numLun
            // 
            this.numLun.Location = new System.Drawing.Point(189, 151);
            this.numLun.Margin = new System.Windows.Forms.Padding(4);
            this.numLun.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numLun.Name = "numLun";
            this.numLun.Size = new System.Drawing.Size(53, 22);
            this.numLun.TabIndex = 8;
            // 
            // chkLun
            // 
            this.chkLun.AutoSize = true;
            this.chkLun.Location = new System.Drawing.Point(29, 151);
            this.chkLun.Name = "chkLun";
            this.chkLun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLun.Size = new System.Drawing.Size(69, 21);
            this.chkLun.TabIndex = 7;
            this.chkLun.Text = "Lunch";
            this.chkLun.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Antal min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkLun);
            this.Controls.Add(this.numLun);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rchTotal);
            this.Controls.Add(this.numH4);
            this.Controls.Add(this.numH3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numH2);
            this.Controls.Add(this.numH1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Klockslag till timmar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown numH1;
        private System.Windows.Forms.NumericUpDown numH2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numH4;
        private System.Windows.Forms.NumericUpDown numH3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numLun;
        private System.Windows.Forms.CheckBox chkLun;
        private System.Windows.Forms.Label label5;

    }
}

