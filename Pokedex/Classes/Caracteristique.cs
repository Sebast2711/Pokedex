using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Classes
{
    class Caracteristique
    {
        public string statistique { get; set; }
        public byte valeur { get; set; }
        public byte IV { get; set; }
        public byte EV { get; set; }

        public Caracteristique()
        {
            this.statistique = "";
            this.valeur = 0;
            this.IV = 0;
            this.EV = 0;
        }
        public Caracteristique(string statistique, byte valeur, byte IV, byte EV)
        {
            this.statistique = statistique;
            this.valeur = valeur;
            this.IV = IV;
            this.EV = EV;
        }
        public Caracteristique(string statistique, byte valeur)
        {
            this.statistique = statistique;
            this.valeur = valeur;
        }

    }
}
