using Ejercicios_Del_Libro.UI;
using System.Windows;

namespace EjerciciosCap4y5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //——————————————————————————————————————————————————[ CAPITULO #4 ]——————————————————————————————————————————————————
        private void eCapitulo4MenuItemMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Capitulo4 Cap4 = new Capitulo4();
            Cap4.Show();
        }
        //——————————————————————————————————————————————————[ CAPITULO #5 ]——————————————————————————————————————————————————
        private void eCapitulo5MenuItemMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Capitulo5 Cap5 = new Capitulo5();
            Cap5.Show();
        }
        //——————————————————————————————————————————————————[ CAPITULO #6 ]——————————————————————————————————————————————————
        private void eCapitulo6MenuItemMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Capitulo6 Cap6 = new Capitulo6();
            Cap6.Show();
        }
        //——————————————————————————————————————————————————[ CAPITULO #7 ]——————————————————————————————————————————————————
        private void eCapitulo7MenuItemMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Capitulo7 Cap7 = new Capitulo7();
            Cap7.Show();
        }
        //——————————————————————————————————————————————————[ CAPITULO #8 ]——————————————————————————————————————————————————
        private void eCapitulo8MenuItemMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Capitulo8 Cap8 = new Capitulo8();
            Cap8.Show();
        }
        //——————————————————————————————————————————————————[ CAPITULO #9 ]——————————————————————————————————————————————————
        private void eCapitulo9MenuItemMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Capitulo9 Cap9 = new Capitulo9();
            Cap9.Show();
        }
    }
}