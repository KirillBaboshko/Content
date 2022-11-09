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

namespace Content
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //double d= 5.6;
            //button1.Content = d;
        }
        private void Button1_Clik(object sender, RoutedEventArgs e)
        {
            this.Close();
            //MessageBox.Show("Реклама");
        }
        private void Chek(object sender, RoutedEventArgs e)
        {
            if(Chek1.IsChecked==true)
            {
                MessageBox.Show("Спасибо");
            }
        }
    }
}
