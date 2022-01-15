namespace Bancomat
{
    partial class Depunere_Numerar_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDepunere = new System.Windows.Forms.TextBox();
            this.BtnDepunereNumerar = new System.Windows.Forms.Button();
            this.BtnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valoarea pe care doriti sa o depuneti trebuie sa fie mai mare de 10 lei si pana i" +
    "n 3000 de lei.\r\nDaca doriti sa depuneti o suma mai mare , de preferat sa mergeti" +
    " la ghiseu.\r\nSuma sa fie intreaga.\r\n";
            // 
            // TxtDepunere
            // 
            this.TxtDepunere.Location = new System.Drawing.Point(219, 139);
            this.TxtDepunere.Name = "TxtDepunere";
            this.TxtDepunere.Size = new System.Drawing.Size(128, 22);
            this.TxtDepunere.TabIndex = 1;
            // 
            // BtnDepunereNumerar
            // 
            this.BtnDepunereNumerar.Location = new System.Drawing.Point(236, 184);
            this.BtnDepunereNumerar.Name = "BtnDepunereNumerar";
            this.BtnDepunereNumerar.Size = new System.Drawing.Size(95, 45);
            this.BtnDepunereNumerar.TabIndex = 2;
            this.BtnDepunereNumerar.Text = "Depunere";
            this.BtnDepunereNumerar.UseVisualStyleBackColor = true;
            this.BtnDepunereNumerar.Click += new System.EventHandler(this.BtnDepunereNumerar_Click);
            // 
            // BtnIesire
            // 
            this.BtnIesire.Location = new System.Drawing.Point(460, 274);
            this.BtnIesire.Name = "BtnIesire";
            this.BtnIesire.Size = new System.Drawing.Size(95, 45);
            this.BtnIesire.TabIndex = 3;
            this.BtnIesire.Text = "Iesire";
            this.BtnIesire.UseVisualStyleBackColor = true;
            this.BtnIesire.Click += new System.EventHandler(this.BtnIesire_Click);
            // 
            // Depunere_Numerar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 331);
            this.Controls.Add(this.BtnIesire);
            this.Controls.Add(this.BtnDepunereNumerar);
            this.Controls.Add(this.TxtDepunere);
            this.Controls.Add(this.label1);
            this.Name = "Depunere_Numerar_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depunere_Numerar_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtDepunere;
        private System.Windows.Forms.Button BtnDepunereNumerar;
        private System.Windows.Forms.Button BtnIesire;
    }
}