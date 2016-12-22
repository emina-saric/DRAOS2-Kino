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

namespace KinoWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(bool admin)
        {
            InitializeComponent();
            if (!admin)
            {
                admintab.Visibility = System.Windows.Visibility.Collapsed;
                kinotab.Focus();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NewUser nu = new NewUser();
            nu.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izbrisati korisnika?", "Potvrdite brisanje", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {

            }
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Color green;
            //green.A = 0xff;
            //green.R = 0x80;
            //green.G = 0xff;
            //green.B = 0x80;

            //Color blue;
            //blue.A = 0xff;
            //blue.R = 0x80;
            //blue.G = 0x80;
            //blue.B = 0xff;

            //Color red;
            //red.A = 0xff;
            //red.R = 0xff;
            //red.G = 0x80;
            //red.B = 0x80;

            BrushConverter bc = new BrushConverter();

            //ARGB
            if (bc.ConvertToString(((Rectangle)sender).Fill) == "#FF80FF80")    // zelena
                ((Rectangle)sender).Fill = (Brush)bc.ConvertFromString("#FF8080FF");
            else if (bc.ConvertToString(((Rectangle)sender).Fill) == "#FF8080FF")    // plava
                ((Rectangle)sender).Fill = (Brush)bc.ConvertFromString("#FFFF8080");
            else
                ((Rectangle)sender).Fill = (Brush)bc.ConvertFromString("#FF80FF80");
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Hall h = new Hall();
            h.Show();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Hall h = new Hall();
            h.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Provjerite još jednom da li ste ispravno unijeli podatke o novoj projekciji", "Porovjerite unos", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {

            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EditProjections ep = new EditProjections();
            ep.Show();
        }
    }
}
