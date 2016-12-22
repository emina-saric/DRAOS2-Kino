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
    /// Interaction logic for Hall.xaml
    /// </summary>
    public partial class Hall : Window
    {
        public Hall()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle r = (Rectangle)sender;
            BrushConverter bc = new BrushConverter();

            //ARGB
            if (bc.ConvertToString(r.Fill) == "#FF80FF80")    // zelena
                r.Fill = (Brush)bc.ConvertFromString("#FF8080FF");
            else if (bc.ConvertToString(r.Fill) == "#FF8080FF")    // plava
                r.Fill = (Brush)bc.ConvertFromString("#FFFF8080");
            else
                r.Fill = (Brush)bc.ConvertFromString("#FF80FF80");
        }
    }
}
