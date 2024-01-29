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

namespace Polina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void form1_btn_Click(object sender, RoutedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void svinea_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void form2_Click(object sender, RoutedEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void form3_Click(object sender, RoutedEventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
    }
}
