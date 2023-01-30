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

namespace Harjoitus_17__KT_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double lämpötila;
        private bool keittiöValot = false;
        private bool olohuoneValot = false;
        private bool ovenLukko = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_ovenlukko_Click(object sender, RoutedEventArgs e)
        {
            if(ovenLukko == false)
            {
                ovenLukko = true;
                btn_ovenlukko.Content = "Kiinni";
            }else if (ovenLukko == true)
            {
                ovenLukko = false;
                btn_ovenlukko.Content = "Auki";
            }
        }

        private void Btn_keittiövalot_Click(object sender, RoutedEventArgs e)
        {
            if (keittiöValot == false)
            {
                keittiöValot = true;
                btn_keittiövalot.Content = "Päällä";
            }
            else if (keittiöValot == true)
            {
                keittiöValot = false;
                btn_keittiövalot.Content = "Pois Päältä";
            }
        }

        private void Btn_olohuonevalot_Click(object sender, RoutedEventArgs e)
        {
            if (olohuoneValot == false)
            {
                olohuoneValot = true;
                btn_olohuonevalot.Content = "Päällä";
            }
            else if (olohuoneValot == true)
            {
                olohuoneValot = false;
                btn_olohuonevalot.Content = "Pois Päältä";
            }
        }

        private void Sldr_Lämpötila_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lämpötila = sldr_Lämpötila.Value;
        }
    }
}
