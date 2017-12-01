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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter Car Park";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnDispenseCoin);
            this.Name = "UI";
            this.Text = "UI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDispenseCoin;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button button1;
    }
}