﻿using System;
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
    /// Interaction logic for EjerciciosCap4.xaml
    /// </summary>
    public partial class Menu_Ejercicios_Cap_4 : Window
    {
        public Menu_Ejercicios_Cap_4()
        {
            InitializeComponent();
        }

        private void ButtonClick_Ejercicio1(object sender, RoutedEventArgs e)
        {
            Ejercicio1_Cap4 e1 = new Ejercicio1_Cap4();
            e1.Show();
            this.Close();
        }

        private void ButtonClick_Ejercicio2(object sender, RoutedEventArgs e)
        {
            Ejercicio2_Cap4 e2 = new Ejercicio2_Cap4();
            e2.Show();
            this.Close();
        }

        private void ButtonClick_Ejercicio5(object sender, RoutedEventArgs e)
        {

        }
    }
}
