namespace LittleEconomicTask
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
            this.label6 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiscountBox = new System.Windows.Forms.NumericUpDown();
            this.ResultBox = new System.Windows.Forms.Label();
            this.PickStart = new System.Windows.Forms.NumericUpDown();
            this.StartRateHelper = new System.Windows.Forms.Label();
            this.SpeedRateHelper = new System.Windows.Forms.Label();
            this.PickSpeed = new System.Windows.Forms.NumericUpDown();
            this.SpeedRateHeader = new System.Windows.Forms.Label();
            this.StartRateHeader = new System.Windows.Forms.Label();
            this.PickRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaturityBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.CalcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaturityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Amount";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(27, 44);
            this.AmountBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AmountBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(200, 22);
            this.AmountBox.TabIndex = 43;
            this.AmountBox.Value = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "0.01 x ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Discount";
            // 
            // DiscountBox
            // 
            this.DiscountBox.Location = new System.Drawing.Point(294, 178);
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(89, 22);
            this.DiscountBox.TabIndex = 40;
            this.DiscountBox.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // ResultBox
            // 
            this.ResultBox.AutoSize = true;
            this.ResultBox.Location = new System.Drawing.Point(166, 361);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(170, 17);
            this.ResultBox.TabIndex = 39;
            this.ResultBox.Text = "Result will be here soon...";
            // 
            // PickStart
            // 
            this.PickStart.Location = new System.Drawing.Point(263, 252);
            this.PickStart.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.PickStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PickStart.Name = "PickStart";
            this.PickStart.Size = new System.Drawing.Size(120, 22);
            this.PickStart.TabIndex = 38;
            this.PickStart.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // StartRateHelper
            // 
            this.StartRateHelper.AutoSize = true;
            this.StartRateHelper.Location = new System.Drawing.Point(199, 252);
            this.StartRateHelper.Name = "StartRateHelper";
            this.StartRateHelper.Size = new System.Drawing.Size(58, 17);
            this.StartRateHelper.TabIndex = 37;
            this.StartRateHelper.Text = "0.001 x ";
            // 
            // SpeedRateHelper
            // 
            this.SpeedRateHelper.AutoSize = true;
            this.SpeedRateHelper.Location = new System.Drawing.Point(199, 307);
            this.SpeedRateHelper.Name = "SpeedRateHelper";
            this.SpeedRateHelper.Size = new System.Drawing.Size(58, 17);
            this.SpeedRateHelper.TabIndex = 36;
            this.SpeedRateHelper.Text = "0.001 x ";
            // 
            // PickSpeed
            // 
            this.PickSpeed.Location = new System.Drawing.Point(263, 305);
            this.PickSpeed.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.PickSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PickSpeed.Name = "PickSpeed";
            this.PickSpeed.Size = new System.Drawing.Size(120, 22);
            this.PickSpeed.TabIndex = 35;
            this.PickSpeed.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // SpeedRateHeader
            // 
            this.SpeedRateHeader.AutoSize = true;
            this.SpeedRateHeader.Location = new System.Drawing.Point(213, 285);
            this.SpeedRateHeader.Name = "SpeedRateHeader";
            this.SpeedRateHeader.Size = new System.Drawing.Size(111, 17);
            this.SpeedRateHeader.TabIndex = 34;
            this.SpeedRateHeader.Text = "Speed of growth";
            // 
            // StartRateHeader
            // 
            this.StartRateHeader.AutoSize = true;
            this.StartRateHeader.Location = new System.Drawing.Point(213, 232);
            this.StartRateHeader.Name = "StartRateHeader";
            this.StartRateHeader.Size = new System.Drawing.Size(105, 17);
            this.StartRateHeader.TabIndex = 33;
            this.StartRateHeader.Text = "Start rate value";
            // 
            // PickRate
            // 
            this.PickRate.FormattingEnabled = true;
            this.PickRate.Location = new System.Drawing.Point(27, 232);
            this.PickRate.Name = "PickRate";
            this.PickRate.Size = new System.Drawing.Size(166, 24);
            this.PickRate.TabIndex = 32;
            this.PickRate.SelectedIndexChanged += new System.EventHandler(this.PickRate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Maturity";
            // 
            // MaturityBox
            // 
            this.MaturityBox.Location = new System.Drawing.Point(294, 110);
            this.MaturityBox.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.MaturityBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaturityBox.Name = "MaturityBox";
            this.MaturityBox.Size = new System.Drawing.Size(89, 22);
            this.MaturityBox.TabIndex = 30;
            this.MaturityBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Bond rebuying day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bond issuance day";
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(27, 178);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(200, 22);
            this.EndTime.TabIndex = 27;
            this.EndTime.Value = new System.DateTime(2002, 4, 12, 0, 0, 0, 0);
            this.EndTime.ValueChanged += new System.EventHandler(this.EndTime_ValueChanged);
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(27, 110);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(200, 22);
            this.StartTime.TabIndex = 26;
            this.StartTime.Value = new System.DateTime(1988, 12, 25, 0, 0, 0, 0);
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(38, 356);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(98, 27);
            this.CalcButton.TabIndex = 25;
            this.CalcButton.Text = "Calc";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiscountBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.PickStart);
            this.Controls.Add(this.StartRateHelper);
            this.Controls.Add(this.SpeedRateHelper);
            this.Controls.Add(this.PickSpeed);
            this.Controls.Add(this.SpeedRateHeader);
            this.Controls.Add(this.StartRateHeader);
            this.Controls.Add(this.PickRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaturityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.CalcButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaturityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown AmountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DiscountBox;
        private System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.NumericUpDown PickStart;
        private System.Windows.Forms.Label StartRateHelper;
        private System.Windows.Forms.Label SpeedRateHelper;
        private System.Windows.Forms.NumericUpDown PickSpeed;
        private System.Windows.Forms.Label SpeedRateHeader;
        private System.Windows.Forms.Label StartRateHeader;
        private System.Windows.Forms.ComboBox PickRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MaturityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.Button CalcButton;
    }
}

