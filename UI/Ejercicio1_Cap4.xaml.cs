﻿using System.Windows;

namespace EjerciciosCap4y5
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1_Cap4 : Window
    {
        public Ejercicio1_Cap4()
        {
            InitializeComponent();
        }

        private void ButtonClick_Calcular_Ejercicio1(object sender, RoutedEventArgs e)
        {
            ResultadoEjercicio1.Items.Clear();
            int numero;
            numero = int.Parse(NumeroDigitado.Text);

            for (int n = numero; n <= numero; n++)
            {
                for (int tabla = 1; tabla <= 10; tabla++)
                    ResultadoEjercicio1.Items.Add(n + "x" + tabla + " = " + (n * tabla) + "\t");
            }
        }
    }
}
