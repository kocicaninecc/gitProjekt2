using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitProjekt2
{
    class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

        public int Vek()
        {
            DateTime dnes = DateTime.Now;
            return (dnes - DatumNarozeni).ToString();
        }
    }
}
