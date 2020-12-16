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
    /// Логика взаимодействия для Zadaniee8.xaml
    /// </summary>
    public partial class Zadaniee8 : Window
    {
        public Zadaniee8()
        {
            InitializeComponent();
        }

        private void Zadanie9_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadaniee9 zadaniee9 = new Zadaniee9();
            zadaniee9.Show();
        }
    }
}
