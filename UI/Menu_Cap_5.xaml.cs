using System.Windows;

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

        private void ButtonClick_Ejercicio5(object sender, RoutedEventArgs e)
        {
            Ejercicio5_Cap5 e5 = new Ejercicio5_Cap5();
            e5.Show();
            this.Close();
        }
    }
}
