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
using System.Windows.Media;
namespace DOP1
{
    /// <summary>
    /// Логика взаимодействия для Zadanie.xaml
    /// </summary>
    public partial class Zadanie : Window
    {
        public Zadanie()
        {
            InitializeComponent();
            Button button = new Button();
            button.Content = "Knopka";
            button.Width = 150;
            button.Height = 40;
            button.HorizontalAlignment = HorizontalAlignment.Left;
            button.Background = new SolidColorBrush(Colors.Red);


        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            if (textBox1.Text != "")
            {
                Pashalka pashalka = new Pashalka();
                pashalka.Show();
            }
            else
            if (textBox1.Text != "123")
            {
                MessageBox.Show("Hello :)");
               
            }
        }

        private void Zadanie2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadanie2 button = new Zadanie2();
            button.Show();
        }
    }
}
