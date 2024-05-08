using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab20_oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double side1 = double.Parse(textBox1.Text);
                double side2 = double.Parse(textBox2.Text);
                double side3 = double.Parse(textBox3.Text);

                // Обчислення площі трикутника
                double area = CalculateArea(side1, side2, side3);

                textBox4.Text = area.ToString("F3");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено неправильний формат числа.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private double CalculateArea(double side1, double side2, double side3)
        {
            double area = 0;

            // Обчислення площі за формулою Герона
            double semiPerimeter = (side1 + side2 + side3) / 2;
            area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

            if (double.IsNaN(area) || double.IsInfinity(area))
            {
                throw new ArgumentException("Неможливо обчислити площу трикутника. Такого трикутника не існує!");
            }

            return area;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
