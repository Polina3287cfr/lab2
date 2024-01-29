using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Polina
{
    /// <summary>
    /// Логика взаимодействия для Form1.xaml
    /// </summary>
    public partial class Form1 : Window
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void svinea_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void hriu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double km_ = Convert.ToDouble(km.Text);
                if (km_ <= 0)
                {
                    res.Content = "Введите значение больше 0";
                }
                else
                {
                    double mili = km_ / 1.609344;
                    double liga = km_ / 4.828032;
                    double lie = km_ / 4.44;
                    double fut = km_ / 0.3048;

                    string result = $"{mili} миль\n{liga} лиг\n{lie} льё\n{fut} фут";
                    res.Content = result;
                }
            }
            catch { res.Content = "Invalid data"; }


        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            e.Handled = !Regex.IsMatch(e.Text, @"^[0-9]*(\,[0-9]*)?$");
        }

        private void km_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (km.Text.Length > 0)
            {
                hriu.IsEnabled = true;
            }
            else
            {
                hriu.IsEnabled = false;
            }
        }
    }
}