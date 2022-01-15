using System;
using System.Windows.Forms;

namespace Bancomat
{
    public partial class Interogare_Sold_Form : Form
    {
        public Meniu mn = new Meniu();
        
        public Interogare_Sold_Form()
        {
            InitializeComponent();
            lblSold.Text = Conturi.VerificaPin(EcranPrincipal.PinIntrodus).Sold();
        }

        private void BtnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
