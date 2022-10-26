using Pokedex.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Pokedex
{
    /// <summary>
    /// Logique d'interaction pour Detail.xaml
    /// </summary>
    public partial class Detail : Page
    {
        Pokemon pkmn = new Pokemon();

        public Detail(Pokemon pkmn)
        {
            InitializeComponent();

            Pokemon pokemon = pkmn;
            final.Text = pkmn.ToString();
        }


    }
}
