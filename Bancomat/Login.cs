using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancomat
{
    public  class Login
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public int soldCurent { get; set; }
        public string pin { get; set; }


        public Login(string _nume,string _prenume,string _pin,int _soldCurent)
        {
            this.nume = _nume;
            this.soldCurent = _soldCurent;
            this.prenume = _prenume;
            this.pin = _pin;
        }
       public string Afisare()
        {
            return "Buna ziua " + nume + " " + prenume;
        }
        public string Sold()
        {
            return "Soldul dumneavoastra este de "+ soldCurent+" lei";
        }
    }
}
