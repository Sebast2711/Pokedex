using Pokedex.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Type = Pokedex.Classes.Type;

namespace Pokedex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pokemon> pokemonList = new List<Pokemon>();


        public MainWindow()
        {
            Type Electrique = new Type("Electrique");
            Type Sol = new Type("Sol");
            Electrique.AddFaiblesseAttaque(Sol);
            Sol.AddAvantageAttaque(Electrique);
            Electrique.AddAvantageDefense(Electrique);
            Statuts Paralyse = new Statuts("Paralysie", 0, 0, 25);
            Caracteristique PV = new Caracteristique("PV",35,255,31);
            Caracteristique AttSp = new Caracteristique("AttSp",50,255,31);
            Attaque Tonnerre = new Attaque("Tonnerre", 90, AttSp, Paralyse, 30, 100, 24, Electrique );
            Pokemon Pikachu = new Pokemon("Pikachu", Electrique, "", 
                "Chaque fois que Pikachu découvre quelque chose de nouveau, " +
                "il envoie un arc électrique. Lorsqu'on tombe sur une Baie carbonisée, " +
                "ça signifie sans doute qu'un de ces Pokémon a envoyé une charge trop forte.");
            Pikachu.Caracteristiques.Add(PV);
            Pikachu.Caracteristiques.Add(AttSp);

            pokemonList.Add(Pikachu);



            

            InitializeComponent();
            foreach (Pokemon pokemon in pokemonList)
                ListBoxPkmn.Items.Add(pokemon);

        }

        private void affpkmn(object sender, RoutedEventArgs e)
        {
            // ListBoxPkmn.Items.Add (ListBoxPkmn.SelectedValue.ToString());
            frame.Content = new Detail( (Pokemon) ListBoxPkmn.SelectedValue);
        }
    }
}
