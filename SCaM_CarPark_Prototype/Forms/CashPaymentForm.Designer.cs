namespace SCaM_CarPark_Prototype
{
    partial class CashPaymentForm
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
            this.btnPayCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPayCard
            // 
            this.btnPayCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayCard.Location = new System.Drawing.Point(487, 474);
            this.btnPayCard.Name = "btnPayCard";
            this.btnPayCard.Size = new System.Drawing.Size(215, 75);
            this.btnPayCard.TabIndex = 2;
            this.btnPayCard.Text = "Pay By Card";
            this.btnPayCard.UseVisualStyleBackColor = true;
            this.btnPayCard.Click += new System.EventHandler(this.btnPayCard_Click);
            // 
            // CashPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 561);
            this.Controls.Add(this.btnPayCard);
            this.Name = "CashPaymentForm";
            this.Text = "CashPaymentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPayCard;
    }
}