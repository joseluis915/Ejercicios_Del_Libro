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
        double min = 0;
        double max = 0;
        double avg = 0;
        private void AddEdades_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(EdadTextbox.Text.Trim() != "")
                {
                    EdadesListBox.Items.Add(double.Parse(EdadTextbox.Text));
                    EdadTextbox.Text = "";
                    EdadTextbox.Focus();
                }
                else
                {
                    MessageBox.Show("El Campo (Edades) esta vacio.\n\nDigite una edad", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                    EdadTextbox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("El valor digitado en el campo (Edades) no es un numero.\n\nPorfavor, digite un numero.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                EdadTextbox.Text = "";
                EdadTextbox.Focus();
            }
        }
        private void ButtonClick_Ejercicio5_Cap4_Limpiar(object sender, RoutedEventArgs e)
        {
            Min.Text = string.Empty;
            Max.Text = string.Empty;
            Promedio.Text = string.Empty;
            EdadesListBox.Items.Clear();
        }
        private void ButtonClick_Ejercicio5_Cap4_Calcular(object sender, RoutedEventArgs e)
        {
            ///Minimo
            min = Convert.ToDouble(EdadesListBox.Items[0]);
            for(int i=0; i<EdadesListBox.Items.Count; i++)
            {
                if(min>Convert.ToDouble(EdadesListBox.Items[i]))
                {
                    min = Convert.ToDouble(EdadesListBox.Items[i]);
                }
            }
            Min.Text = Convert.ToString(min);
///============================================[ Maximo ]============================================
            max = Convert.ToDouble(EdadesListBox.Items[0]);
            for (int i = 0; i < EdadesListBox.Items.Count; i++)
            {
                if (max < Convert.ToDouble(EdadesListBox.Items[i]))
                {
                    max = Convert.ToDouble(EdadesListBox.Items[i]);
                }
            }
            Max.Text = Convert.ToString(max);
///============================================[ Promedio ]============================================
            double suma = 0;
            for (int i = 0; i < EdadesListBox.Items.Count; i++)
            {
                suma += Convert.ToDouble(EdadesListBox.Items[i]);
                avg = Math.Round(suma / EdadesListBox.Items.Count, 2);
            }
            Promedio.Text = Convert.ToString(avg);
        }
    }
}
/**private void ButtonClick_Ejercicio5_Cap4(object sender, RoutedEventArgs e)
{
    double edades = Convert.ToDouble(Edad1.Text);

    double[] Edades = { edades };

    Min.Text = Convert.ToString(Edades.Min());
    Max.Text = Convert.ToString(Edades.Max());
    Promedio.Text = Convert.ToString(Edades.Average());
}*/
