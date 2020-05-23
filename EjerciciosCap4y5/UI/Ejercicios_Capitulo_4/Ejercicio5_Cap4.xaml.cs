using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EjerciciosCap4y5
{
    /// <summary>
    /// Interaction logic for Ejercicio5_Cap4.xaml
    /// </summary>
    public partial class Ejercicio5_Cap4 : Window
    {
        public Ejercicio5_Cap4()
        {
            InitializeComponent();
        }

        private void ButtonClick_Ejercicio5_Cap4(object sender, RoutedEventArgs e)
        {
            double edad1 = Convert.ToDouble(Edad1.Text);
            double edad2 = Convert.ToDouble(Edad2.Text);
            double edad3 = Convert.ToDouble(Edad3.Text);
            double edad4 = Convert.ToDouble(Edad4.Text);
            double edad5 = Convert.ToDouble(Edad5.Text);
            double edad6 = Convert.ToDouble(Edad6.Text);
            double edad7 = Convert.ToDouble(Edad7.Text);
            double edad8 = Convert.ToDouble(Edad8.Text);
            double edad9 = Convert.ToDouble(Edad9.Text);
            double edad10 = Convert.ToDouble(Edad10.Text);

            double[] Edades = { edad1, edad2, edad3, edad4, edad5, edad6, edad7, edad8, edad9, edad10 };
            
            Min.Text = Convert.ToString(Edades.Min());
            Max.Text = Convert.ToString(Edades.Max());
            Promedio.Text = Convert.ToString(Edades.Average());
        }

        private void ButtonClick_Ejercicio5_Cap4_Limpiar(object sender, RoutedEventArgs e)
        {
            Edad1.Text = "0";
            Edad2.Text = "0";
            Edad3.Text = "0";
            Edad4.Text = "0";
            Edad5.Text = "0";
            Edad6.Text = "0";
            Edad7.Text = "0";
            Edad8.Text = "0";
            Edad9.Text = "0";
            Edad10.Text = "0";
            Min.Text = string.Empty;
            Max.Text = string.Empty;
            Promedio.Text = string.Empty;
        }

        private void BorrarSeleccion1(object sender, RoutedEventArgs e)
        {
            Edad1.Text = string.Empty;
        }

        private void BorrarSeleccion2(object sender, RoutedEventArgs e)
        {
            Edad2.Text = string.Empty;
        }

        private void BorrarSeleccion3(object sender, RoutedEventArgs e)
        {
            Edad3.Text = string.Empty;
        }

        private void BorrarSeleccion4(object sender, RoutedEventArgs e)
        {
            Edad4.Text = string.Empty;
        }

        private void BorrarSeleccion5(object sender, RoutedEventArgs e)
        {
            Edad5.Text = string.Empty;
        }

        private void BorrarSeleccion6(object sender, RoutedEventArgs e)
        {
            Edad6.Text = string.Empty;
        }

        private void BorrarSeleccion7(object sender, RoutedEventArgs e)
        {
            Edad7.Text = string.Empty;
        }

        private void BorrarSeleccion8(object sender, RoutedEventArgs e)
        {
            Edad8.Text = string.Empty;
        }

        private void BorrarSeleccion9(object sender, RoutedEventArgs e)
        {
            Edad9.Text = string.Empty;
        }

        private void BorrarSeleccion10(object sender, RoutedEventArgs e)
        {
            Edad10.Text = string.Empty;
        }
    }
}
