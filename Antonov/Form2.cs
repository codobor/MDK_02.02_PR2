using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Antonov
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double x;
            double y;
            double fx;
            double u;

            try
            {
                x = Convert.ToDouble(textBoxX.Text);
                y = Convert.ToDouble(textBoxY.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите числа в поля");
                return;
            }

            if (radioButton1.Checked)
                fx = Math.Sinh(x);
            else if (radioButton2.Checked)
                fx = Math.Pow(x, 2);
            else if (radioButton3.Checked)
                fx = Math.Pow(Math.E, x);
            else
            {
                MessageBox.Show("Не выбран тип функции");
                return;
            }


            textBoxOutput.Text = "Результаты работы программы " +
                "ст. Антонова П. А. " +
                Environment.NewLine;
            textBoxOutput.Text += "При X = " + textBoxX.Text +
                Environment.NewLine;
            textBoxOutput.Text += "При Y = " + textBoxY.Text +
                Environment.NewLine;

            if (x * y > 0)
                u = Math.Pow(fx + y, 2) - Math.Sqrt(fx * y);
            else if (x * y < 0)
                u = Math.Pow(fx + y, 2) + Math.Sqrt(Math.Abs(fx * y));
            else 
                u = Math.Pow(fx + y, 2) + 1.0;

                        textBoxOutput.Text += "U = " + u.ToString() +
                            Environment.NewLine;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxX.Clear();
            textBoxY.Clear();
            textBoxOutput.Clear();
        }
    }
}
