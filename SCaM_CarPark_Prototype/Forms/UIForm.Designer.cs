﻿namespace SCaM_CarPark_Prototype
{
    partial class UIForm
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
            this.btnDispenseCoin = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnPark = new System.Windows.Forms.Button();
            this.btnPayFee = new System.Windows.Forms.Button();
            this.btnLeaveCarPark = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnPinClear = new System.Windows.Forms.Button();
            this.btnPinEnter = new System.Windows.Forms.Button();
            this.btnAsterisk = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.txtEnterPin = new System.Windows.Forms.TextBox();
            this.grpBxPinEntry = new System.Windows.Forms.GroupBox();
            this.grpBxPinEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDispenseCoin
            // 
            this.btnDispenseCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispenseCoin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDispenseCoin.Location = new System.Drawing.Point(12, 12);
            this.btnDispenseCoin.Name = "btnDispenseCoin";
            this.btnDispenseCoin.Size = new System.Drawing.Size(215, 75);
            this.btnDispenseCoin.TabIndex = 0;
            this.btnDispenseCoin.Text = "Dispense Coin";
            this.btnDispenseCoin.UseVisualStyleBackColor = true;
            this.btnDispenseCoin.Click += new System.EventHandler(this.btnDispenseCoin_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(12, 174);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(215, 75);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter Car Park";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Visible = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click_1);
            // 
            // btnPin
            // 
            this.btnPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPin.Location = new System.Drawing.Point(12, 93);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(215, 75);
            this.btnPin.TabIndex = 2;
            this.btnPin.Text = "Secure Pin Entry";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Visible = false;
            this.btnPin.Click += new System.EventHandler(this.BtnPinEntry_Click);
            // 
            // btnPark
            // 
            this.btnPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPark.Location = new System.Drawing.Point(12, 255);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(215, 75);
            this.btnPark.TabIndex = 3;
            this.btnPark.Text = "Park Car";
            this.btnPark.UseVisualStyleBackColor = true;
            this.btnPark.Visible = false;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // btnPayFee
            // 
            this.btnPayFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFee.Location = new System.Drawing.Point(233, 93);
            this.btnPayFee.Name = "btnPayFee";
            this.btnPayFee.Size = new System.Drawing.Size(215, 75);
            this.btnPayFee.TabIndex = 4;
            this.btnPayFee.Text = "Enter Pin To Pay Fee";
            this.btnPayFee.UseVisualStyleBackColor = true;
            this.btnPayFee.Visible = false;
            this.btnPayFee.Click += new System.EventHandler(this.btnPayFee_Click);
            // 
            // btnLeaveCarPark
            // 
            this.btnLeaveCarPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveCarPark.Location = new System.Drawing.Point(233, 255);
            this.btnLeaveCarPark.Name = "btnLeaveCarPark";
            this.btnLeaveCarPark.Size = new System.Drawing.Size(215, 75);
            this.btnLeaveCarPark.TabIndex = 5;
            this.btnLeaveCarPark.Text = "Leave Car Park";
            this.btnLeaveCarPark.UseVisualStyleBackColor = true;
            this.btnLeaveCarPark.Visible = false;
            this.btnLeaveCarPark.Click += new System.EventHandler(this.btnLeaveCarPark_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(233, 174);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(215, 75);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Pay Fee";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Visible = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnPinClear
            // 
            this.btnPinClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPinClear.Location = new System.Drawing.Point(6, 325);
            this.btnPinClear.Name = "btnPinClear";
            this.btnPinClear.Size = new System.Drawing.Size(125, 55);
            this.btnPinClear.TabIndex = 30;
            this.btnPinClear.Text = "Clear";
            this.btnPinClear.UseVisualStyleBackColor = true;
            this.btnPinClear.Click += new System.EventHandler(this.btnPinClear_Click);
            // 
            // btnPinEnter
            // 
            this.btnPinEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPinEnter.Location = new System.Drawing.Point(149, 325);
            this.btnPinEnter.Name = "btnPinEnter";
            this.btnPinEnter.Size = new System.Drawing.Size(125, 55);
            this.btnPinEnter.TabIndex = 29;
            this.btnPinEnter.Text = "Enter";
            this.btnPinEnter.UseVisualStyleBackColor = true;
            this.btnPinEnter.Click += new System.EventHandler(this.btnPinEnter_Click);
            // 
            // btnAsterisk
            // 
            this.btnAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsterisk.Location = new System.Drawing.Point(219, 264);
            this.btnAsterisk.Name = "btnAsterisk";
            this.btnAsterisk.Size = new System.Drawing.Size(55, 55);
            this.btnAsterisk.TabIndex = 28;
            this.btnAsterisk.Text = "*";
            this.btnAsterisk.UseVisualStyleBackColor = true;
            this.btnAsterisk.Click += new System.EventHandler(this.btnAsterisk_Click_1);
            // 
            // btnHash
            // 
            this.btnHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHash.Location = new System.Drawing.Point(6, 264);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(55, 55);
            this.btnHash.TabIndex = 27;
            this.btnHash.Text = "#";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.Location = new System.Drawing.Point(113, 264);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(55, 55);
            this.btnNum0.TabIndex = 26;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(219, 203);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(55, 55);
            this.btnNum9.TabIndex = 25;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(113, 203);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(55, 55);
            this.btnNum8.TabIndex = 24;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.Location = new System.Drawing.Point(6, 203);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(55, 55);
            this.btnNum7.TabIndex = 23;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.Location = new System.Drawing.Point(219, 142);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(55, 55);
            this.btnNum6.TabIndex = 22;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(113, 142);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(55, 55);
            this.btnNum5.TabIndex = 21;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(6, 142);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(55, 55);
            this.btnNum4.TabIndex = 20;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(219, 81);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(55, 55);
            this.btnNum3.TabIndex = 19;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(113, 81);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(55, 55);
            this.btnNum2.TabIndex = 18;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(6, 81);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(55, 55);
            this.btnNum1.TabIndex = 17;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click_1);
            // 
            // txtEnterPin
            // 
            this.txtEnterPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterPin.Location = new System.Drawing.Point(11, 30);
            this.txtEnterPin.Name = "txtEnterPin";
            this.txtEnterPin.Size = new System.Drawing.Size(258, 29);
            this.txtEnterPin.TabIndex = 16;
            this.txtEnterPin.Text = "Please Enter Your Secure Pin";
            // 
            // grpBxPinEntry
            // 
            this.grpBxPinEntry.Controls.Add(this.txtEnterPin);
            this.grpBxPinEntry.Controls.Add(this.btnPinEnter);
            this.grpBxPinEntry.Controls.Add(this.btnPinClear);
            this.grpBxPinEntry.Controls.Add(this.btnNum1);
            this.grpBxPinEntry.Controls.Add(this.btnNum2);
            this.grpBxPinEntry.Controls.Add(this.btnAsterisk);
            this.grpBxPinEntry.Controls.Add(this.btnNum3);
            this.grpBxPinEntry.Controls.Add(this.btnNum0);
            this.grpBxPinEntry.Controls.Add(this.btnHash);
            this.grpBxPinEntry.Controls.Add(this.btnNum4);
            this.grpBxPinEntry.Controls.Add(this.btnNum5);
            this.grpBxPinEntry.Controls.Add(this.btnNum9);
            this.grpBxPinEntry.Controls.Add(this.btnNum6);
            this.grpBxPinEntry.Controls.Add(this.btnNum8);
            this.grpBxPinEntry.Controls.Add(this.btnNum7);
            this.grpBxPinEntry.Location = new System.Drawing.Point(698, 12);
            this.grpBxPinEntry.Name = "grpBxPinEntry";
            this.grpBxPinEntry.Size = new System.Drawing.Size(283, 391);
            this.grpBxPinEntry.TabIndex = 31;
            this.grpBxPinEntry.TabStop = false;
            this.grpBxPinEntry.Text = "Pin Entry";
            this.grpBxPinEntry.Visible = false;
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 677);
            this.Controls.Add(this.grpBxPinEntry);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnLeaveCarPark);
            this.Controls.Add(this.btnPayFee);
            this.Controls.Add(this.btnPark);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnDispenseCoin);
            this.Name = "UIForm";
            this.Text = "UI";
            this.grpBxPinEntry.ResumeLayout(false);
            this.grpBxPinEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDispenseCoin;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnPark;
        private System.Windows.Forms.Button btnPayFee;
        private System.Windows.Forms.Button btnLeaveCarPark;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnPinClear;
        private System.Windows.Forms.Button btnPinEnter;
        private System.Windows.Forms.Button btnAsterisk;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.TextBox txtEnterPin;
        private System.Windows.Forms.GroupBox grpBxPinEntry;
    }
}