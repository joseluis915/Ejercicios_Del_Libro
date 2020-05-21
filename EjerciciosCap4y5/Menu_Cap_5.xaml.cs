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
    /// Interaction logic for Menu_Ejercicios_Cap_5.xaml
    /// </summary>
    public partial class Menu_Cap_5 : Window
    {
        public Menu_Cap_5()
        {
            InitializeComponent();
        }

        private void ButtonClick_Ejercicio4(object sender, RoutedEventArgs e)
        {
            Ejercicio4_Cap5 e4 = new Ejercicio4_Cap5();
            e4.Show();
            this.Close();
        }
    }
}
