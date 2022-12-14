using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokedex.Classes
{
    public class Pokemon
    {
        public string Nom { get; set; }
        public Type Type { get; set; }
        public string Image { get; set; }
        public List<Attaque> Attaques { get; set; }
        public List<Caracteristique> Caracteristiques { get; set; }
        public Boolean vivant { get; set; }
        public Statuts statuts { get; set; }
        public string Description { get; set; }
        
        public Pokemon () 
        {
            this.Nom = "";
            this.Type = new Type();
            this.Image = "";
            this.Attaques = new List<Attaque>();
            this.Caracteristiques = new List<Caracteristique>();
            this.vivant = true;
            this.statuts = new Statuts();
            this.Description = "";
        }
        public Pokemon (string nom, Type type, string image,string description) 
        {
            this.Nom = nom;
            this.Type = type;
            this.Image = image;
            this.Attaques = new List<Attaque> ();
            this.Caracteristiques = new List<Caracteristique> ();
            this.vivant = true;
            this.statuts = new Statuts ();
            this.Description = description;
        }

        public override string ToString()
        {
            var PV = from ca in this.Caracteristiques
                     select new 
                     {
                         Nom = ca.statistique,
                         Value = ca.valeur + ca.IV + ca.EV
                     };
            string res = $"{Nom} - {Type.Nom} " +
                         $"\n {Description} \n";

            foreach (var item in PV)
            {
                res += item.Nom + " " + item.Value + "\n";
            }

            return res;
        }
    }
}
