using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancomat
{
    public class Bancnote
    {
        public int ValoareBancnota { get; set; }
        public int nrBancnote { get; set; }
        
        public Bancnote(int valBanc,int nrBanc)
        {
            this.ValoareBancnota = valBanc;
            this.nrBancnote = nrBanc;
        }

      
    }
}
