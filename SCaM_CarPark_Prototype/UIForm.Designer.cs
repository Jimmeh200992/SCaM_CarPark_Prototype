namespace SCaM_CarPark_Prototype
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
            this.btnEnter.Location = new System.Drawing.Point(12, 304);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(215, 75);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter Car Park";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Visible = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnPin
            // 
            this.btnPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPin.Location = new System.Drawing.Point(12, 223);
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
            this.btnPark.Location = new System.Drawing.Point(12, 385);
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
            this.btnPayFee.Location = new System.Drawing.Point(233, 223);
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
            this.btnLeaveCarPark.Location = new System.Drawing.Point(233, 385);
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
            this.btnPayment.Location = new System.Drawing.Point(233, 304);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(215, 75);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Pay Fee";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Visible = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 677);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnLeaveCarPark);
            this.Controls.Add(this.btnPayFee);
            this.Controls.Add(this.btnPark);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnDispenseCoin);
            this.Name = "UIForm";
            this.Text = "UI";
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
    }
}