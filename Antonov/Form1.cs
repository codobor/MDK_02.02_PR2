using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antonov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double x;
            double y;
            double z;
            double u;

            try
            {
                x = Convert.ToDouble(textBoxX.Text);
                y = Convert.ToDouble(textBoxY.Text);
                z = Convert.ToDouble(textBoxZ.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите числа в поля");
                return;
            }

            textBoxOutput.Text = "Результаты работы программы " +
                "ст. Антонова П. А. " +
                Environment.NewLine;
            textBoxOutput.Text += "При X = " + textBoxX.Text +
                Environment.NewLine;
            textBoxOutput.Text += "При Y = " + textBoxY.Text +
                Environment.NewLine;
            textBoxOutput.Text += "При Z = " + textBoxZ.Text +
                Environment.NewLine;

            if ((z - x) == 0)
                u = y * Math.Sin(x) * Math.Sin(x) + z;
            else
                if ((z - x) < 0)
                u = y * Math.Exp(Math.Sin(x)) - z;
            else
                u = y * Math.Sin(Math.Sin(x)) + z;

            textBoxOutput.Text += "U = " + u.ToString() +
                Environment.NewLine;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxX.Clear();
            textBoxY.Clear();
            textBoxZ.Clear();
            textBoxOutput.Clear();
        }
    }
}
