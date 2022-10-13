using Pokedex.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Type = Pokedex.Classes.Type;

namespace Pokedex.Fabrique
{
    class PkmnCreation
    {
        public static List<Caracteristique> CaracteristiquePkmn(byte pv, byte att, byte attSp, byte def, byte defSp, byte vit) 
        {
            List<Caracteristique> StatPokemon = new List<Caracteristique>();
            StatPokemon.Add(PkmnUsine.CreerCaracteristique(1, pv));
            StatPokemon.Add(PkmnUsine.CreerCaracteristique(2, att));
            StatPokemon.Add(PkmnUsine.CreerCaracteristique(3, attSp));
            StatPokemon.Add(PkmnUsine.CreerCaracteristique(4, def));
            StatPokemon.Add(PkmnUsine.CreerCaracteristique(5, defSp));
            StatPokemon.Add(PkmnUsine.CreerCaracteristique(6, vit));

            return StatPokemon;
        } 
        public static List<Statuts> StatusPkmn()
        {
            List<Statuts> Statuts = new List<Statuts>();
            Statuts.Add(PkmnUsine.CreerStatus("Paralysie", 0,255,25));
            Statuts.Add(PkmnUsine.CreerStatus("Brulure", 10, 255, 100));
            Statuts.Add(PkmnUsine.CreerStatus("Gel", 0, 255, 100));
            Statuts.Add(PkmnUsine.CreerStatus("Empoissonnemet", 10, 255, 100));
            Statuts.Add(PkmnUsine.CreerStatus("Sommeil", 0, 3, 100));

            return Statuts;
        }
        public static List<Type> TypesPkmn()
        {
            List <Type> Types = new List<Type>();
            Types.Add(PkmnUsine.CreerType("Eau"));
            Types.Add(PkmnUsine.CreerType("Feu"));
            Types.Add(PkmnUsine.CreerType("Plante"));
            Types.Add(PkmnUsine.CreerType("Insecte"));
            Types.Add(PkmnUsine.CreerType("Vol"));
            Types.Add(PkmnUsine.CreerType("Electrique"));
            Types.Add(PkmnUsine.CreerType("Sol"));
            Types.Add(PkmnUsine.CreerType("Roche"));
            Types.Add(PkmnUsine.CreerType("Acier"));
            Types.Add(PkmnUsine.CreerType("Combat"));
            Types.Add(PkmnUsine.CreerType("Psy"));
            Types.Add(PkmnUsine.CreerType("Spectre"));
            Types.Add(PkmnUsine.CreerType("Ténèbre"));
            Types.Add(PkmnUsine.CreerType("Dragon"));
            Types.Add(PkmnUsine.CreerType("Fée"));
            Types.Add(PkmnUsine.CreerType("Glace"));
            Types.Add(PkmnUsine.CreerType("Normal"));
            Types.Add(PkmnUsine.CreerType("Poison"));

            return Types;
        }
        public static List<Attaque> AttaquePkmn() 
        {
            Caracteristique StatAtt = PkmnUsine.CreerCaracteristique(2, 255);
            Caracteristique StatAttSp = PkmnUsine.CreerCaracteristique(3, 255);
            List<Statuts> StatusAttaque = StatusPkmn();
            Statuts NoStatuts = new Statuts();
            List<Type> TypeAttaque = TypesPkmn();

            List<Attaque> Attaques = new List<Attaque>();
            Attaques.Add(PkmnUsine.CreerAttaque("Aéroblast",100,StatAttSp,NoStatuts,0,95,5,TypeAttaque.ElementAt(5)));

            return Attaques;
        }

        public static List<Pokemon> FabriquePkmn()
        {
            List<Type> TypePokemon = TypesPkmn();
            List<Attaque> AttaquePokemon = AttaquePkmn();
            List<Pokemon> pokemons = new List<Pokemon>();
            pokemons.Add(PkmnUsine.CreerPokemon("Pikachu",TypePokemon.ElementAt(6), "https://www.pokepedia.fr/images/7/76/Pikachu-DEPS.png", 
                "Un Pokémon capable " +
                "de condenser l'électricité. Il doit décharger l'énergie accumulée de temps en temps au risque " +
                "d'accroître son stress."));
            pokemons[0].Caracteristiques = CaracteristiquePkmn(35, 55, 40, 50, 50, 90);
            pokemons[0].Attaques.Add(AttaquePokemon[0]);
            pokemons.Add(PkmnUsine.CreerPokemon("Poussacha", TypePokemon.ElementAt(3), "https://www.pokepedia.fr/images/5/51/Poussacha-EV.png",
                " Poussacha est connu pour aimer être le centre de l'attention. Il peut se montrer " +
                "particulièrement jaloux, surtout lorsque son Dresseur montre de l'affection et de " +
                "la tendresse pour un autre Pokémon."));
            pokemons[1].Caracteristiques = CaracteristiquePkmn(45,49,65,49,65,45);
            pokemons[1].Attaques.Add(AttaquePokemon[0]);
            pokemons.Add(PkmnUsine.CreerPokemon("Lugia", TypePokemon.ElementAt(5), "https://www.pokepedia.fr/images/c/c0/Lugia-HGSS.png",
                "On le surnomme " +
                "« le gardien des mers ». Sa puissance est si dévastatrice qu'il préfère généralement s'isoler " +
                "dans sa demeure au fond de l'océan, où il dort paisiblement."));
            pokemons[2].Caracteristiques = CaracteristiquePkmn(106, 90, 130, 90, 154, 110);
            pokemons[2].Attaques.Add(AttaquePokemon[0]);

            return pokemons;
        }
    }
}
