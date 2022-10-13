using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Classes
{
    class Statuts
    {
        public string Nom { get; set; }
        public byte DegatsInfliges { get; set; }
        public byte NombreTour { get; set; }
        public byte ChanceStatus { get; set; }

        public Statuts() 
        {
            this.Nom = "";
            this.DegatsInfliges = 0;
            this.NombreTour = 0;
            this.ChanceStatus = 0;

        }
        public Statuts(string nom, byte degatsInfliges, byte nombreTour, byte chanceStatus)
        {
            this.Nom = nom;
            this.DegatsInfliges = degatsInfliges;
            this.NombreTour = nombreTour;
            this.ChanceStatus = chanceStatus;
        }
    }
}
