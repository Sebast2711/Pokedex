using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Classes
{
    class Attaque
    {
        public string Nom { get; set; }
        public byte Degats { get; set; }
        public Caracteristique Caracteristique { get; set; }
        public Statuts Statuts { get; set; }
        public byte ChanceStatut { get; set; }
        public byte ChanceUtilisatiom { get; set; }
        public byte NombreUtilisation { get; set; }
        public Type TypeAttaque { get; set; }


        public Attaque()
        {
            this.Nom = "";
            this.Degats = 0;
            this.Caracteristique = new Caracteristique();
            this.Statuts = new Statuts();
            this.ChanceStatut = 0;
            this.ChanceUtilisatiom = 0;
            this.NombreUtilisation = 0;
            this.TypeAttaque = new Type();
        }

        public Attaque(string nom, byte degats, Caracteristique caracteristique, Statuts statuts, byte chanceStatut, byte chanceUtilisatiom, byte nombreUtilisation, Type typeAttaque)
        {
            this.Nom = nom;
            this.Degats = degats;
            this.Caracteristique = caracteristique;
            this.Statuts = statuts;
            this.ChanceStatut = chanceStatut;
            this.ChanceUtilisatiom = chanceUtilisatiom;
            this.NombreUtilisation = nombreUtilisation;
            this.TypeAttaque = typeAttaque;
        }

        public Attaque(string nom, byte degats)
        {
            this.Nom = nom;
            this.Degats = degats;
            this.Caracteristique = new Caracteristique();
            this.Statuts = new Statuts();
            this.ChanceStatut = 0;
            this.ChanceUtilisatiom = 0;
            this.NombreUtilisation = 0;
            this.TypeAttaque = new Type();
        }



    }
}
