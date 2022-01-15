using System;
using System.Windows.Forms;

namespace Bancomat
{
    public partial class Depunere_Numerar_Form : Form
    {
        public Depunere_Numerar_Form()
        {
            InitializeComponent();
        }

        private void BtnDepunereNumerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtDepunere.Text, out int poz))
            {
                MessageBox.Show("Eroare! Asigurati-va ca ati introdus numere si nu altfel de caractere! ");
            }
            else if (TxtDepunere.Text[0] == '0')
            {
                MessageBox.Show("Numarul este incorect! Nu exista numar care incepe cu 0");
            }
            else if (Convert.ToInt32(TxtDepunere.Text)<10 || Convert.ToInt32(TxtDepunere.Text) > 3000)
            {
                MessageBox.Show("Numerarul pe care doriti sa il depuneti trebuie sa fie mai mare decat 10 si pana in 3000 de lei");
            }
            else
            {
                Conturi.conturi[EcranPrincipal.pozitie].soldCurent += Convert.ToInt32(TxtDepunere.Text);
                MessageBox.Show("Depunere efectuata! ");
                this.Close();
            }
        }

        private void BtnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
