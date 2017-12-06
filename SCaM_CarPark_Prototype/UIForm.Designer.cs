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
            this.SuspendLayout();
            // 
            // btnDispenseCoin
            // 
            this.btnDispenseCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispenseCoin.Location = new System.Drawing.Point(12, 12);
            this.btnDispenseCoin.Name = "btnDispenseCoin";
            this.btnDispenseCoin.Size = new System.Drawing.Size(215, 75);
            this.btnDispenseCoin.TabIndex = 0;
            this.btnDispenseCoin.Text = "Dispense Coin";
            this.btnDispenseCoin.UseVisualStyleBackColor = true;
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
            this.btnPin.Click += new System.EventHandler(this.btnPinEntry_Click);
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
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 677);
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
    }
}