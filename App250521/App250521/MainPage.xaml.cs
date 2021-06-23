using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App250521
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int suma = n1 + n2;
            string resultado = suma.ToString();

            DisplayAlert("Mensaje", suma.ToString(), "Total Suma");
        }
        private void btn2_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int suma = n1 - n2;

            DisplayAlert("Mensaje", suma.ToString(), "Total Resta");
        }
        private void btn3_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int suma = n1 * n2;

            DisplayAlert("Mensaje", suma.ToString(), "Total Multiplicacion");
        }
        private void btn4_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int suma = n1 / n2;

            DisplayAlert("Mensaje", suma.ToString(), "Total Division");
        }
    }
}
