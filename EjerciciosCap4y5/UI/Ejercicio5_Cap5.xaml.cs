using Microsoft.VisualBasic;
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
    /// Interaction logic for Ejercicio5_Cap5.xaml
    /// </summary>
    public partial class Ejercicio5_Cap5 : Window
    {
        ConvertirALetras C = new ConvertirALetras();
        public Ejercicio5_Cap5()
        {
            InitializeComponent();
        }

        private void ButtonClick_Calcular(object sender, RoutedEventArgs e)
        {
            Resultado.Text = C.ALetras(Numero.Text);
        }
    }
}
