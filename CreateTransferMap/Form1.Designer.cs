namespace CreateTransferMap
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
            this.textTextBoxWaferID = new System.Windows.Forms.TextBox();
            this.WaferID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_X = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Stack = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SbsX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SbsY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SubstNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_remainChip = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Stack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SbsX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SbsY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SubstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_remainChip)).BeginInit();
            this.SuspendLayout();
            // 
            // textTextBoxWaferID
            // 
            this.textTextBoxWaferID.Location = new System.Drawing.Point(129, 43);
            this.textTextBoxWaferID.MaxLength = 32;
            this.textTextBoxWaferID.Name = "textTextBoxWaferID";
            this.textTextBoxWaferID.Size = new System.Drawing.Size(243, 23);
            this.textTextBoxWaferID.TabIndex = 0;
            this.textTextBoxWaferID.Text = "WaferID_0001";
            // 
            // WaferID
            // 
            this.WaferID.AutoSize = true;
            this.WaferID.Location = new System.Drawing.Point(63, 46);
            this.WaferID.Name = "WaferID";
            this.WaferID.Size = new System.Drawing.Size(55, 15);
            this.WaferID.TabIndex = 1;
            this.WaferID.Text = "WaferID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "基板配列数X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "基板配列数Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "スタック段数 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "SBS_X :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "SBS_Y :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "基板数 :";
            // 
            // numericUpDown_X
            // 
            this.numericUpDown_X.Location = new System.Drawing.Point(130, 87);
            this.numericUpDown_X.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_X.Name = "numericUpDown_X";
            this.numericUpDown_X.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown_X.TabIndex = 8;
            this.numericUpDown_X.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_Y
            // 
            this.numericUpDown_Y.Location = new System.Drawing.Point(129, 123);
            this.numericUpDown_Y.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Y.Name = "numericUpDown_Y";
            this.numericUpDown_Y.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown_Y.TabIndex = 9;
            this.numericUpDown_Y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_Stack
            // 
            this.numericUpDown_Stack.Location = new System.Drawing.Point(130, 157);
            this.numericUpDown_Stack.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Stack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Stack.Name = "numericUpDown_Stack";
            this.numericUpDown_Stack.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown_Stack.TabIndex = 10;
            this.numericUpDown_Stack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_SbsX
            // 
            this.numericUpDown_SbsX.Location = new System.Drawing.Point(130, 187);
            this.numericUpDown_SbsX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_SbsX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SbsX.Name = "numericUpDown_SbsX";
            this.numericUpDown_SbsX.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown_SbsX.TabIndex = 11;
            this.numericUpDown_SbsX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_SbsY
            // 
            this.numericUpDown_SbsY.Location = new System.Drawing.Point(129, 217);
            this.numericUpDown_SbsY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_SbsY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SbsY.Name = "numericUpDown_SbsY";
            this.numericUpDown_SbsY.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown_SbsY.TabIndex = 12;
            this.numericUpDown_SbsY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_SubstNumber
            // 
            this.numericUpDown_SubstNumber.Location = new System.Drawing.Point(129, 250);
            this.numericUpDown_SubstNumber.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_SubstNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SubstNumber.Name = "numericUpDown_SubstNumber";
            this.numericUpDown_SubstNumber.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown_SubstNumber.TabIndex = 13;
            this.numericUpDown_SubstNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "最終基板チップ数 :";
            // 
            // numericUpDown_remainChip
            // 
            this.numericUpDown_remainChip.Location = new System.Drawing.Point(130, 289);
            this.numericUpDown_remainChip.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_remainChip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_remainChip.Name = "numericUpDown_remainChip";
            this.numericUpDown_remainChip.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown_remainChip.TabIndex = 15;
            this.numericUpDown_remainChip.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 389);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_remainChip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_SubstNumber);
            this.Controls.Add(this.numericUpDown_SbsY);
            this.Controls.Add(this.numericUpDown_SbsX);
            this.Controls.Add(this.numericUpDown_Stack);
            this.Controls.Add(this.numericUpDown_Y);
            this.Controls.Add(this.numericUpDown_X);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaferID);
            this.Controls.Add(this.textTextBoxWaferID);
            this.Name = "Form1";
            this.Text = "WaferID :";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Stack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SbsX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SbsY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SubstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_remainChip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTextBoxWaferID;
        private System.Windows.Forms.Label WaferID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_X;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y;
        private System.Windows.Forms.NumericUpDown numericUpDown_Stack;
        private System.Windows.Forms.NumericUpDown numericUpDown_SbsX;
        private System.Windows.Forms.NumericUpDown numericUpDown_SbsY;
        private System.Windows.Forms.NumericUpDown numericUpDown_SubstNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_remainChip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
