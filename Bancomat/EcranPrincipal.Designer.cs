namespace Bancomat
{
    partial class EcranPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPin = new System.Windows.Forms.TextBox();
            this.BtnLog = new System.Windows.Forms.Button();
            this.BtnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bun venit la bancomatul USV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Va rugam introduceti pin-ul de 4 cifre in casuta de mai jos";
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(271, 184);
            this.TxtPin.MaxLength = 4;
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.PasswordChar = '*';
            this.TxtPin.Size = new System.Drawing.Size(157, 22);
            this.TxtPin.TabIndex = 2;
            // 
            // BtnLog
            // 
            this.BtnLog.Location = new System.Drawing.Point(308, 226);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(91, 34);
            this.BtnLog.TabIndex = 3;
            this.BtnLog.Text = "Logare";
            this.BtnLog.UseVisualStyleBackColor = true;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // BtnIesire
            // 
            this.BtnIesire.Location = new System.Drawing.Point(308, 295);
            this.BtnIesire.Name = "BtnIesire";
            this.BtnIesire.Size = new System.Drawing.Size(91, 34);
            this.BtnIesire.TabIndex = 4;
            this.BtnIesire.Text = "Iesire";
            this.BtnIesire.UseVisualStyleBackColor = true;
            this.BtnIesire.Click += new System.EventHandler(this.BtnIesire_Click);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 528);
            this.Controls.Add(this.BtnIesire);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.TxtPin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EcranPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecran Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLog;
        public System.Windows.Forms.TextBox TxtPin;
        private System.Windows.Forms.Button BtnIesire;
    }
}

