using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Classes
{
    public class Type
    {
        public string Nom { get; set; }
        List<Type> AvantageAttaque { get; set; }
        List<Type> AvantageDefense { get; set; }
        List<Type> FaiblesseAttaque { get; set; }
        List<Type> FaiblesseDefense { get; set; }

        public Type() 
        {
            Nom = "";
            AvantageAttaque = new List<Type>();
            AvantageDefense = new List<Type>();
            FaiblesseAttaque = new List<Type>();
            FaiblesseDefense = new List<Type>();

        }
        public Type(string nom)
        {
            Nom = nom;
            AvantageAttaque = new List<Type>();
            AvantageDefense = new List<Type>();
            FaiblesseAttaque = new List<Type>();
            FaiblesseDefense = new List<Type>();
        }
        public void AddAvantageAttaque(Type type) 
        {
            AvantageAttaque.Add(type);
        }
        public void AddAvantageDefense(Type type)
        {
            AvantageDefense.Add(type);
        }
        public void AddFaiblesseAttaque(Type type)
        {
            FaiblesseAttaque.Add(type);
        }
        public void AddFaiblesseDefense(Type type)
        {
            FaiblesseDefense.Add(type);
        }
        public void RemoveAvantageAttaque(Type type)
        {
            AvantageAttaque.Remove(type);
        }
        public void RemoveAvantageDefense(Type type)
        {
            AvantageDefense.Remove(type);
        }
        public void RemoveFaiblesseAttaque(Type type)
        {
            FaiblesseAttaque.Remove(type);
        }
        public void RemoveFaiblesseDefense(Type type)
        {
            FaiblesseDefense.Remove(type);
        }

    }
}
