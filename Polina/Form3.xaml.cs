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
    /// Логика взаимодействия для Form3.xaml
    /// </summary>
    public partial class Form3 : Window
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void hriu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double litr_ = Convert.ToDouble(litr.Text);
                if (litr_ <= 0)
                {
                    rest.Content = "Введите значение больше 0";
                }
                else
                {
                    double c = Convert.ToDouble(litr.Text);

                    double cubMetr = litr_ / 1000;
                    double barreli = litr_ / 163.65;
                    double busheli = litr_ / 36.36872;
                    double gallon = litr_ / 4.55;

                    string result = $"{cubMetr} кубический метр\n{barreli} баррель\n{busheli} бушель\n{gallon} галлон";
                    rest.Content = result;
                }
            }
            catch { rest.Content = "Invalid data"; }
        }

        private void svinea_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void litr_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (litr.Text.Length > 0)
            {
                hriu.IsEnabled = true;
            }
            else { hriu.IsEnabled = false; }
        }

        private void litr_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, @"^[0-9]*(\,[0-9]*)?$");
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
