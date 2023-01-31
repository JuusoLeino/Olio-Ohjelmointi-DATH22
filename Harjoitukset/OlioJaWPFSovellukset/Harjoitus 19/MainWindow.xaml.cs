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
using System.Text.RegularExpressions;

namespace Harjoitus_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int kerros;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtgetfloor_Validation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^1-6]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Btn_changefloor_Click(object sender, RoutedEventArgs e)
        {
            kerros = int.Parse(txt_getfloor.Text);
            if (kerros > 6)
            {
                txt_currentfloor.Text = kerros + " Ei ole sopiva kerros";
            }else
            {
                txt_currentfloor.Text = "Olet Kerroksessa: " + kerros;
            }
        }
    }
}
