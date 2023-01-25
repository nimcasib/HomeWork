using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ
{
    public partial class Form1 : Form
    {
        double calculation=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberInput = 0; //переменная, считывающая введённой число
            double root = 0; //переменная для извлечения квадратного корня из введённого числа

            if(NumberInput.Text!="")
                numberInput = Convert.ToInt32(NumberInput.Text); //преобразование типов данных

            root = Math.Sqrt(numberInput); //расчтет квадратного корня из введённого числа 
            calculation += root; //сложение суммы квадратных корней введённых чисел
            calculation= Math.Round(calculation, 0); // округление
            Result.Text = calculation.ToString(); //преобразование инта в стринг
            NumberInput.Text = null; //сбрасывание строки ввода при нажатии на кнопку
        }
    }
}
