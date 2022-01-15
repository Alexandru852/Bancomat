namespace Bancomat
{
    partial class Meniu
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
            this.LblAnunt = new System.Windows.Forms.Label();
            this.BtnInterogareSold = new System.Windows.Forms.Button();
            this.BtnRetragereNr = new System.Windows.Forms.Button();
            this.BtnDepunereNr = new System.Windows.Forms.Button();
            this.BtnSchimbarePin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnunt
            // 
            this.LblAnunt.AutoSize = true;
            this.LblAnunt.Location = new System.Drawing.Point(238, 58);
            this.LblAnunt.Name = "LblAnunt";
            this.LblAnunt.Size = new System.Drawing.Size(0, 16);
            this.LblAnunt.TabIndex = 0;
            // 
            // BtnInterogareSold
            // 
            this.BtnInterogareSold.Location = new System.Drawing.Point(420, 138);
            this.BtnInterogareSold.Name = "BtnInterogareSold";
            this.BtnInterogareSold.Size = new System.Drawing.Size(88, 49);
            this.BtnInterogareSold.TabIndex = 1;
            this.BtnInterogareSold.Text = "Interogare sold";
            this.BtnInterogareSold.UseVisualStyleBackColor = true;
            this.BtnInterogareSold.Click += new System.EventHandler(this.BtnInterogareSold_Click);
            // 
            // BtnRetragereNr
            // 
            this.BtnRetragereNr.Location = new System.Drawing.Point(96, 138);
            this.BtnRetragereNr.Name = "BtnRetragereNr";
            this.BtnRetragereNr.Size = new System.Drawing.Size(88, 49);
            this.BtnRetragereNr.TabIndex = 2;
            this.BtnRetragereNr.Text = "Retragere numerar";
            this.BtnRetragereNr.UseVisualStyleBackColor = true;
            this.BtnRetragereNr.Click += new System.EventHandler(this.BtnRetragereNr_Click);
            // 
            // BtnDepunereNr
            // 
            this.BtnDepunereNr.Location = new System.Drawing.Point(96, 217);
            this.BtnDepunereNr.Name = "BtnDepunereNr";
            this.BtnDepunereNr.Size = new System.Drawing.Size(88, 49);
            this.BtnDepunereNr.TabIndex = 5;
            this.BtnDepunereNr.Text = "Depunere numerar";
            this.BtnDepunereNr.UseVisualStyleBackColor = true;
            this.BtnDepunereNr.Click += new System.EventHandler(this.BtnDepunereNr_Click);
            // 
            // BtnSchimbarePin
            // 
            this.BtnSchimbarePin.Location = new System.Drawing.Point(420, 217);
            this.BtnSchimbarePin.Name = "BtnSchimbarePin";
            this.BtnSchimbarePin.Size = new System.Drawing.Size(88, 49);
            this.BtnSchimbarePin.TabIndex = 6;
            this.BtnSchimbarePin.Text = "Schimbare Pin";
            this.BtnSchimbarePin.UseVisualStyleBackColor = true;
            this.BtnSchimbarePin.Click += new System.EventHandler(this.BtnSchimbarePin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(256, 311);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(88, 49);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Iesire";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 448);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSchimbarePin);
            this.Controls.Add(this.BtnDepunereNr);
            this.Controls.Add(this.BtnRetragereNr);
            this.Controls.Add(this.BtnInterogareSold);
            this.Controls.Add(this.LblAnunt);
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblAnunt;
        private System.Windows.Forms.Button BtnInterogareSold;
        private System.Windows.Forms.Button BtnRetragereNr;
        private System.Windows.Forms.Button BtnDepunereNr;
        private System.Windows.Forms.Button BtnSchimbarePin;
        private System.Windows.Forms.Button BtnExit;
    }
}