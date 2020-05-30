using Ejercicios_Del_Libro.UI;
using System.Windows;

namespace EjerciciosCap4y5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick_Cap4_MenuPrincipal(object sender, RoutedEventArgs e)
        {
            Menu_Cap_4 ec4 = new Menu_Cap_4();
            ec4.Show();
        }

        private void ButtonClick_Cap5_MenuPrincipal(object sender, RoutedEventArgs e)
        {
            Menu_Cap_5 ec5 = new Menu_Cap_5();
            ec5.Show();
        }

        private void ButtonClick_Cap6_MenuPrincipal(object sender, RoutedEventArgs e)
        {
            Cap6_Ejercicios Cap6 = new Cap6_Ejercicios();
            Cap6.Show();
        }

        private void ButtonClick_Cap7_MenuPrincipal(object sender, RoutedEventArgs e)
        {
            Cap7_Ejercicios Cap7 = new Cap7_Ejercicios();
            Cap7.Show();
        }
    }
}
