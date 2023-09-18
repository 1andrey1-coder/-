using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        double firstNumber;
        string operation;


        public MainPage()
        {
            InitializeComponent();
            CE(this, null);
        }


        private void Zifra(object sender, EventArgs e)
        {
            if (resultEntry.Text == "0" && resultEntry.Text != null)
            {
              resultEntry.Text = "";
            }
            Button button = (Button)sender;
            resultEntry.Text += button.Text;

        }

        private void Ravno(object sender, EventArgs e)
        {
            double expression = double.Parse(resultEntry.Text);
            double result = 0;

            switch (operation)
            {
                
                case "/":
                    result = firstNumber / expression;
                    break;
                case "*":
                    result = firstNumber * expression;
                    break;
                case "+":
                    result = firstNumber + expression;
                    break;
                case "-":
                    result = firstNumber - expression;
                    break;
                case "%":
                    result = Math.Round((double) (firstNumber * expression / 100));
                    break;
            }
            resultEntry.Text = result.ToString();
        }

        private void Zapitai(object sender, EventArgs e)
        {
            if (!resultEntry.Text.Contains("."))
            {
                resultEntry.Text += ".";
            }
        }

        private void Plus(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultEntry.Text);
            operation = "+";
            resultEntry.Text = " ";

        }


        private void Minus(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultEntry.Text);
            operation = "-";
            resultEntry.Text = " ";

        }

        private void Umnog(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultEntry.Text);
            operation = "*";
            resultEntry.Text = " ";

        }

        private void Delenie(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultEntry.Text);
            operation = "/";
            resultEntry.Text = " ";

        }

        private void Skidka(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultEntry.Text);
            operation = "%";
            resultEntry.Text = " ";
        }

        private void Koren(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultEntry.Text);

            double resultKor;
            resultKor = Math.Sqrt(firstNumber);
            resultEntry.Text = resultKor.ToString();
        }

        private void C(object sender, EventArgs e)
        {
            firstNumber = 0;
            this.resultEntry.Text = "0";
        }


        private void CE(object sender, EventArgs e)
        {
            this.resultEntry.Text = "0";
        }

        private void PluMn(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultEntry.Text);

            double resultPM;
            resultPM = firstNumber * -1;
            resultEntry.Text = resultPM.ToString();
        }

        private void Obrat(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultEntry.Text);

            double resultObrat;
            resultObrat = 1/firstNumber;
            resultEntry.Text = resultObrat.ToString();
        }

        private void Strelka(object sender, EventArgs e)
        {

        } 
    }
}
