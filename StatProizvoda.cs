using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tvpprojekat2
{
    class StatProizvoda
    {
        List<Proizvod> proizvodi;
        
        private DateTime datum;
       
        public StatProizvoda()
        {
            proizvodi = new List<Proizvod>();
        }
        public StatProizvoda(List<Proizvod> proizvodi, DateTime datum)
        {
            this.proizvodi = proizvodi;
            this.datum = datum;
            
        }

        public DateTime Datum { get => datum; set => datum = value; }
        internal List<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }
    }
}
