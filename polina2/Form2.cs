using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polina2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double km = Convert.ToDouble(textBox1.Text);
                if(km <= 0)
                {
                    label2.Text = "Введите значение больше 0";
                }
                else
                {
                    double mili = km / 1.609344;
                    double liga = km / 4.828032;
                    double lie = km / 4.44;
                    double fut = km / 0.3048;

                    string res = $"{mili} миль\n{liga} лиг\n{lie} льё\n{fut} фут";
                    label2.Text = res;

                }
            }
            catch
            {
                label2.Text = "Invalid data";
            }
        }
    }
}
