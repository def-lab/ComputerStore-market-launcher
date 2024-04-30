using MVVMC.View;
using MVVMC.ViewModel;
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
using System.Xml.Schema;

namespace MVVMC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Busket buc = new Busket();
        Product a = new Product(1);
        Product b = new Product(2);
        Product c = new Product(3);
        public bool authh = false;
        public string log;


        public MainWindow()
        {
            
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Carz();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Regist();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Gl();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            buc.addproduct(c);

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            buc.addproduct(a);
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            buc.addproduct(b);
        }
    }
}
