using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbanken
{
    class Artikel
    {
        public int ArtikelOid { get; set; }
        public String ArtikelNr { get; set; }
        public int ArtikelGruppe { get; set; }
        public String Bezeichnung { get; set; }
        public Int16 Bestand { get; set; }
        public Int16 Meldebestand { get; set; }
        public int Verpackung { get; set; }
        public Decimal VkPreis { get; set; }
        public DateTime letzteEntnahme { get; set; }

        public override string ToString()
        {
            string text = ArtikelNr + " : " + Bezeichnung;
            return text;
        }
    }
}
