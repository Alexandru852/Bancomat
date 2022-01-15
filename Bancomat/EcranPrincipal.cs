using System;
using System.Windows.Forms;

namespace Bancomat
{
    public partial class EcranPrincipal : Form
    {
        public static int pozitie;
        public static string PinIntrodus = "";
        
       
        public EcranPrincipal()
        {
            InitializeComponent();  
        }
        private void BtnLog_Click(object sender, EventArgs e)
        {
          
            if (Conturi.VerificaPin(TxtPin.Text)!=null)
            {
                 Meniu mn = new Meniu();
                 PinIntrodus = TxtPin.Text;
                 mn.LblAnunt.Text = Conturi.VerificaPin(TxtPin.Text).Afisare();
                 pozitie = Conturi.GasestePozitia(TxtPin.Text);
                 TxtPin.Text = null;
                 this.Hide();
                 Meniu.ecr = this;
                 mn.ShowDialog();
                 this.Show();
            }
            else
            {
                MessageBox.Show("Pinul introdus nu este corect");
            }
        }

        private void BtnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
