namespace SCaM_CarPark_Prototype
{
    partial class PaymentForm
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
            this.btnPayCash = new System.Windows.Forms.Button();
            this.btnPayCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPayCash
            // 
            this.btnPayCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayCash.Location = new System.Drawing.Point(12, 12);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(215, 75);
            this.btnPayCash.TabIndex = 0;
            this.btnPayCash.Text = "Pay Cash";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // btnPayCard
            // 
            this.btnPayCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayCard.Location = new System.Drawing.Point(12, 93);
            this.btnPayCard.Name = "btnPayCard";
            this.btnPayCard.Size = new System.Drawing.Size(215, 75);
            this.btnPayCard.TabIndex = 1;
            this.btnPayCard.Text = "Pay By Card";
            this.btnPayCard.UseVisualStyleBackColor = true;
            this.btnPayCard.Click += new System.EventHandler(this.btnPayCard_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 183);
            this.Controls.Add(this.btnPayCard);
            this.Controls.Add(this.btnPayCash);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Button btnPayCard;
    }
}