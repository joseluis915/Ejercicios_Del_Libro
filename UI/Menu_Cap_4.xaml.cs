using System.Windows;

namespace EjerciciosCap4y5
{
    /// <summary>
    /// Interaction logic for EjerciciosCap4.xaml
    /// </summary> 
    public partial class Capitulo4 : Window
    {
        public Capitulo4()
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
            Ejercicio5_Cap4 e5 = new Ejercicio5_Cap4();
            e5.Show();
            this.Close();
        }
    }
}
