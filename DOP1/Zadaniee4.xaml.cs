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
    /// Логика взаимодействия для Zadaniee4.xaml
    /// </summary>
    public partial class Zadaniee4 : Window
    {
        public Zadaniee4()
        {
            InitializeComponent();
        }

        private void Zadanie4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Zadanie5_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadaniee5 zadaniee5 = new Zadaniee5();
            zadaniee5.Show();
        }
    }
}
