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

namespace Hajroitus_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int henkilöAutot = 0;
        private int kuormaAutot = 0;
        public MainWindow()
        {
            InitializeComponent();

            txt_henkiköauto.Text = henkilöAutot.ToString();
            txt_kuormaauto.Text = kuormaAutot.ToString();
        }

        private void Btn_henkilöauto_Click(object sender, RoutedEventArgs e)
        {
            henkilöAutot++;
            txt_henkiköauto.Text = henkilöAutot.ToString();
        }

        private void Btn_kuormaauto_Click(object sender, RoutedEventArgs e)
        {
            kuormaAutot++;
            txt_kuormaauto.Text = kuormaAutot.ToString();
        }
    }
}
