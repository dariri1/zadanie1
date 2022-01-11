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

namespace Task_1__Triangle_
{
    /// <summary>
    /// Логика взаимодействия для InputWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {
        public InputWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            if (a + b <= c || b + c <= a || c + a <= b)
            {
                MessageBox.Show("Такого треугольника не существует. Попробуйте снова.");
            }
            else if (checkBox1.IsChecked == true && checkBox2.IsChecked == true)
            {
                MessageBox.Show("Выберите что-то одно: периметр или площадь.");
            }
            else
            {
                if (checkBox1.IsChecked == true)
                {
                    int P = a + b + c;
                    MessageBox.Show("Периметр треугольника равен " + P.ToString());
                }
                if (checkBox2.IsChecked == true)
                {
                    double p = (a + b + c) / 2;
                    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    MessageBox.Show("Площадь треугольника равна " + S.ToString());
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
