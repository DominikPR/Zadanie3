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

namespace Zadanie3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model model = new Model();
        public MainWindow()
        {
            DataContext = model;
            InitializeComponent();
        }
       
        private void Edytuj(object sender, RoutedEventArgs e)
        {
            ListBox lista = (ListBox)FindName("ListaFilmów");
            Film film = (Film)lista.SelectedItem;
            new OknoSzczegółów(film).Show();
            
        }
        private void Dodaj(object sender, RoutedEventArgs e)
        {
            new OknoSzczegółów(model.Nowy()).Show();
        }
    }
}
