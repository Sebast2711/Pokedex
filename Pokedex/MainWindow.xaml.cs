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
            pokemonList = Fabrique.PkmnCreation.FabriquePkmn();

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
