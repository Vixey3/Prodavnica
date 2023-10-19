using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tvpprojekat2
{
    class Proizvod
    {
        private int pid;
        private int kolicina;

        public Proizvod(int pid, int kolicina)
        {
            this.Pid = pid;
            this.Kolicina = kolicina;
        }
        public int Pid { get => pid; set => pid = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
    }
}
