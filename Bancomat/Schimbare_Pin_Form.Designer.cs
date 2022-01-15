namespace Bancomat
{
    partial class Schimbare_Pin_Form
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
            this.BtnModifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPinVechi = new System.Windows.Forms.TextBox();
            this.TxtPinNou = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnModifica
            // 
            this.BtnModifica.Location = new System.Drawing.Point(180, 239);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(114, 60);
            this.BtnModifica.TabIndex = 0;
            this.BtnModifica.Text = "Modifica";
            this.BtnModifica.UseVisualStyleBackColor = true;
            this.BtnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pin vechi";
            // 
            // TxtPinVechi
            // 
            this.TxtPinVechi.Location = new System.Drawing.Point(144, 123);
            this.TxtPinVechi.MaxLength = 4;
            this.TxtPinVechi.Name = "TxtPinVechi";
            this.TxtPinVechi.PasswordChar = '*';
            this.TxtPinVechi.Size = new System.Drawing.Size(175, 22);
            this.TxtPinVechi.TabIndex = 2;
            // 
            // TxtPinNou
            // 
            this.TxtPinNou.Location = new System.Drawing.Point(144, 178);
            this.TxtPinNou.MaxLength = 4;
            this.TxtPinNou.Name = "TxtPinNou";
            this.TxtPinNou.PasswordChar = '*';
            this.TxtPinNou.Size = new System.Drawing.Size(175, 22);
            this.TxtPinNou.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pin nou";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pinul trebuie sa contina strict 4 cifre";
            // 
            // BtnIesire
            // 
            this.BtnIesire.Location = new System.Drawing.Point(342, 358);
            this.BtnIesire.Name = "BtnIesire";
            this.BtnIesire.Size = new System.Drawing.Size(114, 60);
            this.BtnIesire.TabIndex = 6;
            this.BtnIesire.Text = "Iesire";
            this.BtnIesire.UseVisualStyleBackColor = true;
            this.BtnIesire.Click += new System.EventHandler(this.BtnIesire_Click);
            // 
            // Schimbare_Pin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 430);
            this.Controls.Add(this.BtnIesire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPinNou);
            this.Controls.Add(this.TxtPinVechi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnModifica);
            this.Name = "Schimbare_Pin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schimbare_Pin_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnModifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtPinVechi;
        public System.Windows.Forms.TextBox TxtPinNou;
        private System.Windows.Forms.Button BtnIesire;
    }
}