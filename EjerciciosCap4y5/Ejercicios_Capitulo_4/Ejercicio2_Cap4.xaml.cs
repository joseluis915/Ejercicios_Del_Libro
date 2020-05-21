using System;
using System.Collections.Generic;
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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2_Cap4 : Window
    {
        public Ejercicio2_Cap4()
        {
            InitializeComponent();
        }

        private void ButtonClick_Ejercicio2_Cap4(object sender, RoutedEventArgs e)
        {
            int numero;
            int potencia;
            numero = int.Parse(Numero2.Text);
            potencia = int.Parse(Potencia.Text);
            double elevado = Math.Pow(numero, potencia);
            ResultadoEjercicio2.Text = Convert.ToString(elevado);
        }
    }
}
