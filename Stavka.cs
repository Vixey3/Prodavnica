using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tvpprojekat2
{
    class Stavka
    {
        private string naziv;
        private int id;
        private int kolicina;
        private double procenat;

        public Stavka(string naziv, int id, int kolicina, double procenat)
        {
            this.naziv = naziv;
            this.id = id;
            this.kolicina = kolicina;
            this.procenat = procenat;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public int Id { get => id; set => id = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public double Procenat { get => procenat; set => procenat = value; }

        public override string ToString()
        {
            return $"{naziv}: Prodato {kolicina} procentualno: {Math.Round(procenat,2)}%";
        }
    }
}
