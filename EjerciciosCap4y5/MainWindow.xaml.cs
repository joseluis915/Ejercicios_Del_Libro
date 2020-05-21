using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            Menu_Ejercicios_Cap_4 ec4 = new Menu_Ejercicios_Cap_4();
            ec4.Show();
        }

        private void ButtonClick_Cap5_MenuPrincipal(object sender, RoutedEventArgs e)
        {

        }
    }
}
