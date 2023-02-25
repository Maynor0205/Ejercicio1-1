using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage   
    {
        int numero_1;
        int numero_2;
        int resultado;
        
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnsuma_Clicked(object sender, EventArgs e)
        {
            numero_1 = int.Parse(txtnum1.Text);
            numero_2 = int.Parse(txtnum2.Text);

            resultado = numero_1 + numero_2;
         

            
            DisplayAlert("El Resultado Es: ", resultado.ToString(), "OK");
        }

        private void btnresta_Clicked(object sender, EventArgs e)
        {
            numero_1 = int.Parse(txtnum1.Text);
            numero_2 = int.Parse(txtnum2.Text);

            resultado = numero_1 - numero_2;



            DisplayAlert("El Resultado Es: ", resultado.ToString(), "OK");
        }

        private void btndivision_Clicked(object sender, EventArgs e)
        {
            numero_1 = int.Parse(txtnum1.Text);
            numero_2 = int.Parse(txtnum2.Text);

            resultado = numero_1 / numero_2;



            DisplayAlert("El Resultado Es: ", resultado.ToString(), "OK");
        }

        private void btnmultiplicar_Clicked(object sender, EventArgs e)
        {
            numero_1 = int.Parse(txtnum1.Text);
            numero_2 = int.Parse(txtnum2.Text);

            resultado = numero_1 * numero_2;



            DisplayAlert("El Resultado Es: ", resultado.ToString(), "OK");
        }

     
    }
}
