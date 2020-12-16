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
using System.Windows.Shapes;

namespace DOP1
{
    /// <summary>
    /// Логика взаимодействия для Zadanie2.xaml
    /// </summary>
    public partial class Zadanie2 : Window
    {
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void Zadanie3_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadaniee3 zadaniee3 = new Zadaniee3();
            zadaniee3.Show();
        }

        private void ZadanieNaIzdevatelstvoo_Click(object sender, RoutedEventArgs e)
        {
            ZadanieNaIzdevatelstvo zadanieNaIzdevatelstvo = new ZadanieNaIzdevatelstvo();
            zadanieNaIzdevatelstvo.Show();
        }
    }
}
