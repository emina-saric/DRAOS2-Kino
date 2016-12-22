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
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (oldpass.Password == "")
                MessageBox.Show("Lozinka koju ste unijeli nije ispravna!", "Greška prilikom promjene lozinke", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (newpass.Password == "" || newpass.Password != confirmpass.Password)
                MessageBox.Show("Nova lozinka nije ispravno unesena oba puta!", "Greška prilikom promjene lozinke", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
