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

namespace Harjoitsu_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double km;
        private double maili;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_kmtomile_Click(object sender, RoutedEventArgs e)
        {
            km = double.Parse(txt_kilometri.Text);
            maili = km * 0.621371;
            txt_mailit.Text = maili.ToString();
        }

        private void Btn_miletokm_Click(object sender, RoutedEventArgs e)
        {
            maili = double.Parse(txt_mailit.Text);
            km = maili * 1.609344;
            txt_kilometri.Text = km.ToString();
        }
    }
}
