using Pokedex.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Pokedex.Classes.Type;

namespace Pokedex.Fabrique
{
    class PkmnUsine
    {
        public static Caracteristique CreerCaracteristique(byte id, byte valeur) 
        {
            Caracteristique caracteristique = new Caracteristique();
            caracteristique.valeur = valeur;
            caracteristique.IV = 0;
            caracteristique.EV = 0;
            switch (id)
            {
                //PV
                case 1:
                    caracteristique.statistique = "PV";
                    break;
                //ATT
                case 2:
                    caracteristique.statistique = "ATT";
                    break;
                //ATTSP
                case 3:
                    caracteristique.statistique = "ATTSP";
                    break;
                //DEF
                case 4:
                    caracteristique.statistique = "DEF";
                    break;
                //DEFSP
                case 5:
                    caracteristique.statistique = "DEFSP";
                    break;
                //VIT
                case 6:
                    caracteristique.statistique = "VIT";
                    break;
                //defaut
                default:
                    caracteristique.statistique = "PV";
                    break;
            } 
            return caracteristique;
        }
        public static Statuts CreerStatus(string nom, byte degatsInfliges, byte nombreTour, byte chanceStatus) 
        {
            Statuts statuts = new Statuts(nom, degatsInfliges, nombreTour,chanceStatus);
            return statuts;
        }
        public static Type CreerType(string nom) 
        {
            Type type = new Type(nom);
            return type;
        }
        public static Attaque CreerAttaque(string nom, byte degats, Caracteristique caracteristique, Statuts statuts, byte chanceStatut, byte chanceUtilisatiom, byte nombreUtilisation, Type typeAttaque)
        {
            Attaque attaque = new Attaque(nom, degats, caracteristique, statuts, chanceStatut, chanceUtilisatiom, nombreUtilisation, typeAttaque);
            return attaque;
        }
        public static Pokemon CreerPokemon(string nom, Type type, string image, string description)
        {
            Pokemon pokemon = new Pokemon(nom, type, image, description);   
            return pokemon;
        }
        // Reste les methodes toString() pour chaque objets
    }
}
