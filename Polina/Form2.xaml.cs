using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для Form2.xaml
    /// </summary>
    public partial class Form2 : Window
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void svinea_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void hriu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double c = Convert.ToDouble(degress.Text);

                double Kelvin = c + 273.15;
                double Farengeit = (c * 9 / 5) + 32;
                double Reomeiru = c * 4 / 5;
                double Rankinu = (c + 273.15) * (9 / 5);

                res.Content = $"По Кельвину - {Kelvin}" +
                    $"\nПо Фаренгейту - {Farengeit}" +
                    $"\nПо Реомюру - {Reomeiru}" +
                    $"\nПо Ранкину - {Rankinu}";
            }
            catch { res.Content = "Invalid data"; }
        }

        private void degress_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, @"^-?[0-9]*(\,[0-9]*)?$");
        }

        private void degress_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (degress.Text.Length > 0)
            {
                hriu.IsEnabled = true;
            }
            else { hriu.IsEnabled = false; }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
