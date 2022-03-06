using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DesgloseBilletesYMonedas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            int Cant, Cant200, Cant100, Cant50, Cant20, Cant10, Cant5, Cant1;
            Cant200 = Cant100 = Cant50 = Cant20 = Cant10 = Cant5 = Cant1 = 0;
            String Linea=Cantidad.Text;
            float Mone50, Mone25, Mone10, Mone5, Mone1, Cant2;
            Mone50 = Mone25 = Mone10 = Mone5 = Mone1 = 0.00f;
           
                    Cant2 = float.Parse(Linea);
                    Cant = (int)Cant2;
                    Cant2 = Cant2 - Cant;
              
                    
                    if ((Cant >= 200))
                    {
                        Cant200 = (Cant / 200);
                        Cant = Cant - (Cant200 * 200);
                    }
                    if ((Cant >= 100))
                    {
                        Cant100 = (Cant / 100);
                        Cant = Cant - (Cant100 * 100);
                    }
                    if ((Cant >= 50))
                    {
                        Cant50 = (Cant / 50);
                        Cant = Cant - (Cant50 * 50);
                    }
                    if ((Cant >= 20))
                    {
                        Cant20 = (Cant / 20);
                        Cant = Cant - (Cant20 * 20);
                    }
                    if ((Cant >= 10))
                    {
                        Cant10 = (Cant / 10);
                        Cant = Cant - (Cant10 * 10);
                    }
                    if ((Cant5 >= 5))
                    {
                        Cant5 = (Cant / 5);
                        Cant = Cant - (Cant5 * 5);
                    }
                    if ((Cant1 >= 1))
                    {
                        Cant1 = (Cant / 1);
                        Cant = Cant - (Cant1 * 1);
                    }
                    if ((Cant2 >= 0.50))
                    {
                        Mone50 = 1;
                        Cant2 = (Cant2 - 0.50f);
                    }
                    if ((Cant2 >= 0.25))
                    {
                        Mone25 = 1;
                        Cant2 = (Cant2 - 0.25f);
                    }
                    if ((Cant2 >= 0.10))
                    {
                        Mone10 = (Cant2 - (Cant2 % 0.10f)) / 0.10f;
                        Cant2 = (Cant2 % 0.10f);
                        Mone10 = (float)Math.Round(Mone10, 2);
                    }
                    if ((Cant2 >= 0.05))
                    {
                        Mone5 = (Cant2 - (Cant2 % 0.05f)) / 0.05f;
                        Cant2 = Cant2 - (Mone5 % 0.05f);
                        Mone5 = (float)Math.Round(Mone5, 2);
                    }
                    if ((Cant2 >= 0.01))
                    {
                        Mone1 = (Cant2 / 0.01f);
                        Mone1 = (float)Math.Round(Mone1, 2);
                    }

                   
            Result.Text = ((
               
                 "\nEN BILLETES:"
                + "\n"
                + $"\nBILLETES DE Q200: > {Cant200}"
                + $"\nBILLETES DE Q100: > {Cant100}"
                + $"\nBILLETES DE Q50:  > {Cant50}" 
                + $"\nBILLETES DE Q20:  > {Cant20}"
                + $"\nBILLETES DE Q10:  > {Cant10}"
                + $"\nBILLETES DE Q5:   > {Cant5}" 
                + $"\nBILLETES DE Q1:   > {Cant1}"
                + "\n"
                + "\nEN MONEDAS:"
                + "\n"
                + $"\nMONEDAS DE Q0.50 CENTAVOS: > {Mone50}"
                + $"\nMONEDAS DE Q0.25 CENTAVOS: > {Mone25}" +
                ($"\nMONEDAS DE Q0.10 CENTAVOS:  > {Mone10}"
                + $"\nMONEDAS DE Q0.05 CENTAVOS: > {Mone5}"
                + $"\nMONEDAS DE Q0.01 CENTAVOS: > {Mone1}"))); 
            }

        }
        }

        
    

