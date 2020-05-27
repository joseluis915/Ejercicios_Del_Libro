using System.Windows;

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
