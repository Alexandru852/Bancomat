using System;
using System.Windows.Forms;

namespace Bancomat
{
    public partial class Meniu : Form
    {
        public static EcranPrincipal ecr = new EcranPrincipal();
        
        public Meniu()
        { 
            InitializeComponent();
        }


        private void BtnInterogareSold_Click(object sender, EventArgs e)
        {
            Interogare_Sold_Form intr = new Interogare_Sold_Form();
            this.Hide();
            intr.ShowDialog();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
                                                                       
        private void BtnSchimbarePin_Click(object sender, EventArgs e)
        {
            Schimbare_Pin_Form sc = new Schimbare_Pin_Form();
            this.Hide();
            sc.ShowDialog();
            this.Close();
        }

        private void BtnRetragereNr_Click(object sender, EventArgs e)
        {
            Retragere_numerar_Form ret = new Retragere_numerar_Form();
            this.Hide();
            ret.ShowDialog();
            this.Close();
        }

        private void BtnDepunereNr_Click(object sender, EventArgs e)
        {
            Depunere_Numerar_Form dep = new Depunere_Numerar_Form();
            this.Hide();
            dep.ShowDialog();
            this.Close();
        }
        
    }
}
