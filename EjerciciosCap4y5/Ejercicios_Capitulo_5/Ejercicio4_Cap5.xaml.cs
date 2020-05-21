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
    /// Interaction logic for Ejercicio4_Cap5.xaml
    /// </summary>
    public partial class Ejercicio4_Cap5 : Window
    {
        public Ejercicio4_Cap5()
        {
            InitializeComponent();
        }

        private void ButtonClick_Calcular(object sender, RoutedEventArgs e)
        {
            double i, fact = 1, numero;
            numero = double.Parse(Numero.Text);
            for (i = 1; i <= numero; i++)
            {
                fact = fact * i;
            }
            Resultado.Text = Convert.ToString(fact);
        }
    }
}
/**

    int numero;
    int potencia;
        numero = int.Parse(Numero2.Text);
        potencia = int.Parse(Potencia.Text);
        double elevado = Math.Pow(numero, potencia);
    ResultadoEjercicio2.Text = Convert.ToString(elevado);

 */
