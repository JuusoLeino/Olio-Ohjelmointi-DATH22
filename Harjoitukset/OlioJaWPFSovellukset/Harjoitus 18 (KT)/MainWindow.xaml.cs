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

namespace Harjoitus_18__KT_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int luku1;
        private int luku2;
        private int laskuToimitus;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_summa_Click(object sender, RoutedEventArgs e)
        {
            luku1 = int.Parse(txt_luku1.Text);
            luku2 = int.Parse(txt_luku2.Text);

            laskuToimitus = luku1 + luku2;

            txt_laskutoimitus.Text = laskuToimitus.ToString();
        }

        private void Btn_erotus_Click(object sender, RoutedEventArgs e)
        {
            luku1 = int.Parse(txt_luku1.Text);
            luku2 = int.Parse(txt_luku2.Text);

            laskuToimitus = luku1 - luku2;

            txt_laskutoimitus.Text = laskuToimitus.ToString();
        }

        private void Btn_tulo_Click(object sender, RoutedEventArgs e)
        {
            luku1 = int.Parse(txt_luku1.Text);
            luku2 = int.Parse(txt_luku2.Text);

            laskuToimitus = luku1 * luku2;

            txt_laskutoimitus.Text = laskuToimitus.ToString();
        }

        private void Btn_osamäärä_Click(object sender, RoutedEventArgs e)
        {
            luku1 = int.Parse(txt_luku1.Text);
            luku2 = int.Parse(txt_luku2.Text);

            laskuToimitus = luku1 / luku2;

            txt_laskutoimitus.Text = laskuToimitus.ToString();
        }
    }
}
