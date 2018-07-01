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
using System.Windows.Shapes;

namespace PAI_DESKTOP
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void Zamowienia_Click(object sender, RoutedEventArgs e)
        {
            zamowieniaGrid.Visibility = Visibility.Collapsed;
            productsGrid.Visibility = Visibility.Collapsed;
            usersGrid.Visibility = Visibility.Collapsed;

            zamowieniaGrid1.Visibility = Visibility.Visible;
            zamowieniaGrid2.Visibility = Visibility.Visible;
            zamowieniaGrid3.Visibility = Visibility.Visible;
        }

        private void Produkty_Click(object sender, RoutedEventArgs e)
        {
            zamowieniaGrid.Visibility = Visibility.Collapsed;
            productsGrid.Visibility = Visibility.Collapsed;
            usersGrid.Visibility = Visibility.Collapsed;

            productsGrid1.Visibility = Visibility.Visible;
            productsGrid2.Visibility = Visibility.Visible;
            productsGrid3.Visibility = Visibility.Visible;

        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            zamowieniaGrid.Visibility = Visibility.Collapsed;
            productsGrid.Visibility = Visibility.Collapsed;
            usersGrid.Visibility = Visibility.Collapsed;

            usersGrid1.Visibility = Visibility.Visible;
            usersGrid2.Visibility = Visibility.Visible;
            usersGrid3.Visibility = Visibility.Visible;

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); 
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
