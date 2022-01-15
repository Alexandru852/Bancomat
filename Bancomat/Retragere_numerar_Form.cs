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
    public partial class Retragere_numerar_Form : Form
    {
        Meniu mn = new Meniu();
        public Retragere_numerar_Form()
        {
            InitializeComponent();
        }

        private void BtnElibereazaNumerar_Click(object sender, EventArgs e)
        {
            
            string BancnoteEliberate = "";
            int NumarDeBancnoteEliberate=0;
            bool ValideazaExtragere;
          
            if(!int.TryParse(TxtElibereazaNumerar.Text, out int poz))
            {
                MessageBox.Show("Eroare! Asigurati-va ca ati introdus numere si nu altfel de caractere! ");
            }
            else if(TxtElibereazaNumerar.Text[0] == '0' )
            {
                MessageBox.Show("Numarul este incorect! Nu exista numar care incepe cu 0");
            }
            else if(Convert.ToInt32(TxtElibereazaNumerar.Text) <10 || Convert.ToInt32(TxtElibereazaNumerar.Text)>3000)
            {
                MessageBox.Show("Numerarul pe care doriti sa il retrageti trebuie sa fie mai mare decat 10 si pana in 3000 de lei");
            }
            else if(Convert.ToInt32(TxtElibereazaNumerar.Text) > Conturi.conturi[EcranPrincipal.pozitie].soldCurent)
            {
                MessageBox.Show("Soldul dvs nu dispune de aceasta suma! ");
            }
            else if (Convert.ToInt32(TxtElibereazaNumerar.Text) <= Conturi.conturi[EcranPrincipal.pozitie].soldCurent)
            {
                double Valoare = double.Parse(TxtElibereazaNumerar.Text);
                Conturi.conturi[EcranPrincipal.pozitie].soldCurent = Conturi.conturi[EcranPrincipal.pozitie].soldCurent - Convert.ToInt32(TxtElibereazaNumerar.Text);
                for(int i = 0; i<Conturi.BancnoteDisponibile.Length;i++)
                {
                    ValideazaExtragere = false;
                    while(Valoare!=0)
                    {
                     
                        if(Conturi.BancnoteDisponibile[i].nrBancnote == 0)
                        {
                            break;
                        }
                        if (Valoare<Conturi.BancnoteDisponibile[i].ValoareBancnota)
                        {
                            break;
                        }
                        else
                        {
                            NumarDeBancnoteEliberate++;
                            Conturi.BancnoteDisponibile[i].nrBancnote--;
                            Valoare = Valoare - Conturi.BancnoteDisponibile[i].ValoareBancnota;
                            ValideazaExtragere = true;
                        }
                     
                    }
                    if (ValideazaExtragere)
                    {
                        BancnoteEliberate = BancnoteEliberate +"\nValoare: "+ Conturi.BancnoteDisponibile[i].ValoareBancnota+" lei" + "     Numar bancnote: " + NumarDeBancnoteEliberate ;
                        NumarDeBancnoteEliberate = 0;
                    }
                    if (Valoare == 0)
                        break; 
                }
                MessageBox.Show("Tranzactie reusita ! Imediat o sa va apara sub forma tabelara valoarea bancnotei si numarul de bancnote eliberate ");
                MessageBox.Show("Bancomatul o sa va elibereze: "+BancnoteEliberate);
                this.Close();
               

            }
        }

        private void BtnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
