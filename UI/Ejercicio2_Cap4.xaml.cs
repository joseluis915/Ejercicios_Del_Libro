using System;
using System.Windows;

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
            double numero;
            double potencia;
            numero = int.Parse(Numero2.Text);
            potencia = int.Parse(Potencia.Text);
            double elevado = Math.Pow(numero, potencia);
            ResultadoEjercicio2.Text = Convert.ToString(elevado);
        }
    }
}
