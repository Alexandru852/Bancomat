using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bancomat
{
    public partial class Schimbare_Pin_Form : Form
    {

       
        public Schimbare_Pin_Form()
        {
            InitializeComponent();
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            int cifre;

            if (Conturi.conturi[Conturi.GasestePozitia(TxtPinVechi.Text)].pin == TxtPinNou.Text)
            {
                MessageBox.Show("Nu puteti reutiliza parola veche! ");
                return;
            }
            for (int i = 0; i < Conturi.conturi.Length; i++)
            {
                if (string.Compare(TxtPinNou.Text, Conturi.conturi[i].pin) == 0)
                {
                    MessageBox.Show("Din motive de securitate va rugam introduceti alt pin! ");
                    return;
                }
            }

            if (string.IsNullOrEmpty(TxtPinVechi.Text) || string.IsNullOrEmpty(TxtPinNou.Text) || string.IsNullOrEmpty(TxtPinVechi.Text) && string.IsNullOrEmpty(TxtPinNou.Text))
            {
                MessageBox.Show("Ambele casute trebuiesc completate! ");
            }
            else if (!int.TryParse(TxtPinVechi.Text, out cifre) || !int.TryParse(TxtPinNou.Text, out cifre) || !int.TryParse(TxtPinVechi.Text, out cifre) && !int.TryParse(TxtPinNou.Text, out cifre))
            {
                MessageBox.Show("Pin-urile trebuie sa contina cifre si nu altfel de caractere! ");
            }
            else if (Conturi.GasestePozitia(TxtPinVechi.Text) == -1)
            {
                MessageBox.Show("Pinul vechi este incorect");
            }
           
            else if (!string.Equals(TxtPinVechi.Text, Conturi.conturi[Conturi.GasestePozitia(TxtPinVechi.Text)].pin))
            {
                MessageBox.Show("Pin-ul vechi nu este corect! ");
            }
            else if (TxtPinNou.Text.Length != 4)
            {
                MessageBox.Show("Pinul nou trebuie sa contina 4 cifre! ");
            }
               
          
            else
            {
                Conturi.conturi[Conturi.GasestePozitia(TxtPinVechi.Text)].pin = TxtPinNou.Text;
                this.Close();
                MessageBox.Show("Pin schimbat cu succes! ");
          
                
            }
        }

        private void BtnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
