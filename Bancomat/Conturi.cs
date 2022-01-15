using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancomat
{
    public class Conturi
    {
        /// <summary>
        /// Acest vector simuleaza o baza de date pentru conturile oamenilor.
        /// </summary>
        public static  Login[] conturi = new Login[]
        {
            new Login("Prisacaru", "Alexandru", "1234", 1200),
            new Login("Barzu", "Cosmin", "2215", 500),
            new Login("Axinia","Razvan","4422",700),
            new Login("Ionescu","Ion","1221",400)
        };
        /// <summary>
        /// Acest vector simuleaza magazia de bancnote a bancomatului.
        /// </summary>
        public static Bancnote[] BancnoteDisponibile = new Bancnote[]
        {
            new Bancnote(500,1),
            new Bancnote(200,7),
            new Bancnote(100,6),
            new Bancnote(50,10),
            new Bancnote(20,7),
            new Bancnote(10,15),
            new Bancnote(5,13),
            new Bancnote(1,25)

        };
        
        public static int numardeconturi = 0;

        public static Login VerificaPin(string pin)
        {
           for(int i = 0; i<conturi.Length;i++)
            {
                if(conturi[i].pin == pin)
                {
                    return conturi[i];
                }
            }
            return null;
        }
        public static int GasestePozitia(string pin)
        {
            
            for(int i = 0; i < conturi.Length; i++)
            {
                if(pin == conturi[i].pin)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
