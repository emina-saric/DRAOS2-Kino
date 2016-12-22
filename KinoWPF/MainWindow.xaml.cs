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

namespace KinoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            username.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text == "user" && password.Password == "user")
            {
                //MessageBox.Show("Uspješno ste prijavljeni kao korisnik!", "Prijava je uspjela!", MessageBoxButton.OK, MessageBoxImage.Information);
                Window1 w1 = new Window1(false);
                w1.Show();
                this.Hide();
            }
            else if (username.Text == "admin" && password.Password == "admin")
            {
                //MessageBox.Show("Uspješno ste prijavljeni kao administrator!", "Prijava je uspjela!", MessageBoxButton.OK, MessageBoxImage.Information);
                Window1 w1 = new Window1(true);
                w1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Prijava nije uspjela!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void password_GotFocus(object sender, RoutedEventArgs e)
        {
            password.SelectAll();
        }

        private void username_GotFocus(object sender, RoutedEventArgs e)
        {
            username.SelectAll();
        }
    }
}
