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
    /// Логика взаимодействия для Zadaniee6.xaml
    /// </summary>
    public partial class Zadaniee6 : Window
    {
        public Zadaniee6()
        {
            InitializeComponent();
        }

        private void Zadanie7_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadaniee7 zadaniee7 = new Zadaniee7();
            zadaniee7.Show();
        }
    }
}
