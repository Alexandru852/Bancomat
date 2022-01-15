namespace Bancomat
{
    partial class Retragere_numerar_Form
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
            this.TxtElibereazaNumerar = new System.Windows.Forms.TextBox();
            this.BtnElibereazaNumerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtElibereazaNumerar
            // 
            this.TxtElibereazaNumerar.Location = new System.Drawing.Point(141, 91);
            this.TxtElibereazaNumerar.Name = "TxtElibereazaNumerar";
            this.TxtElibereazaNumerar.Size = new System.Drawing.Size(127, 22);
            this.TxtElibereazaNumerar.TabIndex = 0;
            // 
            // BtnElibereazaNumerar
            // 
            this.BtnElibereazaNumerar.Location = new System.Drawing.Point(150, 134);
            this.BtnElibereazaNumerar.Name = "BtnElibereazaNumerar";
            this.BtnElibereazaNumerar.Size = new System.Drawing.Size(102, 52);
            this.BtnElibereazaNumerar.TabIndex = 1;
            this.BtnElibereazaNumerar.Text = "Elibereaza";
            this.BtnElibereazaNumerar.UseVisualStyleBackColor = true;
            this.BtnElibereazaNumerar.Click += new System.EventHandler(this.BtnElibereazaNumerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduceti suma dorita mai jos in lei.\r\nAceasta  sa fie o suma intreaga si mai m" +
    "are de 10 lei ";
            // 
            // BtnIesire
            // 
            this.BtnIesire.Location = new System.Drawing.Point(310, 232);
            this.BtnIesire.Name = "BtnIesire";
            this.BtnIesire.Size = new System.Drawing.Size(102, 52);
            this.BtnIesire.TabIndex = 3;
            this.BtnIesire.Text = "Iesire";
            this.BtnIesire.UseVisualStyleBackColor = true;
            this.BtnIesire.Click += new System.EventHandler(this.BtnIesire_Click);
            // 
            // Retragere_numerar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 296);
            this.Controls.Add(this.BtnIesire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnElibereazaNumerar);
            this.Controls.Add(this.TxtElibereazaNumerar);
            this.Name = "Retragere_numerar_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retragere_numerar_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtElibereazaNumerar;
        private System.Windows.Forms.Button BtnElibereazaNumerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIesire;
    }
}