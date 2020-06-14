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

namespace Ejercicios_Del_Libro.UI
{
    /// <summary>
    /// Interaction logic for Cap8_Ejercicios.xaml
    /// </summary>
    public partial class Capitulo8 : Window
    {
        public Capitulo8()
        {
            InitializeComponent();
        }
        //——————————————————————————————————————————————[ EJERCICIO #3 ]——————————————————————————————————————————————
        private void MostarButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime Hoy = DateTime.Now;
            HoraTextBox.Text = Hoy.ToString("hh:mm:ss tt");
            FechaTextBox.Text = Hoy.ToString("dd/MMMMM/yyyy");

            //——————[ Mostrar la fecha y hora actual con el formato que tiene la hora del sistema. ]——————

            //HoraTextBox.Text = Hoy.ToShortTimeString();
            //FechaTextBox.Text = Hoy.ToShortDateString();
        }
        //——————————————————————————————————————————————[ EJERCICIO #5 ]——————————————————————————————————————————————
        private void OrdenarButton_Click(object sender, RoutedEventArgs e)
        {
            string cadena = Cadena1TextBox.Text + Cadena2TextBox.Text; 
            string ordenado = new String(cadena.OrderBy(z => z).ToArray());
            OrdenadoTextBox.Text = Convert.ToString(ordenado);
        }
        //——————————————————————————————————————————————[ BOTON LIMPIAR ]——————————————————————————————————————————————
        private void LimpiarTodoButton_Click(object sender, RoutedEventArgs e)
        {
            Cadena1TextBox.Clear();
            Cadena2TextBox.Clear();
            HoraTextBox.Clear();
            FechaTextBox.Clear();
            OrdenadoTextBox.Clear();
        }
    }
}
