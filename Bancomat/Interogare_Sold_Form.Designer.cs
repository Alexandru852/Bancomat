namespace Bancomat
{
    partial class Interogare_Sold_Form
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
            this.lblSold = new System.Windows.Forms.Label();
            this.BtnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Location = new System.Drawing.Point(148, 110);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(0, 16);
            this.lblSold.TabIndex = 0;
            // 
            // BtnIesire
            // 
            this.BtnIesire.Location = new System.Drawing.Point(388, 222);
            this.BtnIesire.Name = "BtnIesire";
            this.BtnIesire.Size = new System.Drawing.Size(97, 38);
            this.BtnIesire.TabIndex = 1;
            this.BtnIesire.Text = "Iesire";
            this.BtnIesire.UseVisualStyleBackColor = true;
            this.BtnIesire.Click += new System.EventHandler(this.BtnIesire_Click);
            // 
            // Interogare_Sold_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(497, 272);
            this.Controls.Add(this.BtnIesire);
            this.Controls.Add(this.lblSold);
            this.Name = "Interogare_Sold_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interogare_Sold_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Button BtnIesire;
    }
}