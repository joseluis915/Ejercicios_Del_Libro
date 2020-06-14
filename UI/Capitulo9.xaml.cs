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

namespace Ejercicios_Del_Libro.UI
{
    public partial class Capitulo9 : Window
    {
        public Capitulo9()
        {
            InitializeComponent();
        }
        //——————————————————————————[ Enumeracion de Neumaticos ]——————————————————————————
        enum Neumaticos { Carretera = 1, TodoTerreno, Competicion, Invierno };
        //——————————————————————————[ Estructura de Tienda ]——————————————————————————
        public struct Tienda
        {
            public string Pruductos;
        }
        //——————————————————————————[ Estructura de Dueño ]——————————————————————————
        public struct Duenio
        {
            public string NombreDuenio;
            public int edadDuenio;
        }
        //——————————————————————————[ Estructura de Mascota ]——————————————————————————
        public struct Mascota
        {
            public string EspecieMacosta;
            public string NombreMacosta;
            public int edadMascota;
        }

        //————————————————————————————————————————[ Boton Agregar Productos - Ejercicio #1 ]————————————————————————————————————————
        private void aProductoButton_Click(object sender, RoutedEventArgs e)
        {
            Tienda t = new Tienda();
            t.Pruductos = nProductoTextBox.Text;
            try
            {
                if (t.Pruductos.Trim() != "")
                {
                    ProductosListBox.Items.Add(Convert.ToString(nProductoTextBox.Text));
                    nProductoTextBox.Clear();
                    nProductoTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("El Campo [Productos] esta vacio.\n\nDigite un producto", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                    nProductoTextBox.Focus();
                }
            }
            catch
            { }
        }
        //————————————————————————————————————————[ BOTON GUARDAR - EJERCICIO #3 ]————————————————————————————————————————
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Duenio d = new Duenio();
            Mascota m = new Mascota();
            //——————————————————————————[ Datos del dueño ]——————————————————————————
            d.NombreDuenio = dNombreTextBox.Text;
            d.edadDuenio = Convert.ToInt32(dEdadTextBox.Text);
            //——————————————————————————[ Datos de la Mascota ]——————————————————————————
            m.EspecieMacosta = mEspecieTextBox.Text;
            m.NombreMacosta = mNombreTextBox.Text;
            m.edadMascota = Convert.ToInt32(mEdadTextBox.Text);
            //——————————————————————————[ Resultado ]——————————————————————————
            DuenoMascotaTextBox.Text = ($" Nombre del dueño: {d.NombreDuenio}\n Edad: {d.edadDuenio} \n\n " +
                $"Nombre de la Macosta: {m.NombreMacosta}\n Especie: {m.EspecieMacosta} \n Edad: {m.edadMascota}");
        }

        //——————————————————————————————————————————————[ BOTON BUSCAR - EJERCICIO #4 ]——————————————————————————————————————————————
        private void nBuscarButton_Click(object sender, RoutedEventArgs e)
        {
            int opcion = Convert.ToInt32(CodNeumaticoTextBox.Text);
            Neumaticos n;
            switch (opcion)
            {
                case 1:
                    n = Neumaticos.Carretera;
                    nResultadoTextbox.Text = ($"{n}");
                    break;
                case 2:
                    n = Neumaticos.TodoTerreno;
                    nResultadoTextbox.Text = ($"{n}");
                    break;
                case 3:
                    n = Neumaticos.Competicion;
                    nResultadoTextbox.Text = ($"{n}");
                    break;
                case 4:
                    n = Neumaticos.Invierno;
                    nResultadoTextbox.Text = ($"{n}");
                    break;
            }
        }

        //——————————————————————————————————————————————[ BOTON LIMPIAR ]——————————————————————————————————————————————
        private void LimpiarTodoButton_Click(object sender, RoutedEventArgs e)
        {
            dNombreTextBox.Clear();
            dEdadTextBox.Clear();
            mNombreTextBox.Clear();
            mEspecieTextBox.Clear();
            mEdadTextBox.Clear();
            DuenoMascotaTextBox.Clear();
            ProductosListBox.Items.Clear();
            CodNeumaticoTextBox.Clear();
            nResultadoTextbox.Clear();
        }
    }
}
