using MVVMC.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MVVMC
{
    /// <summary>
    /// Логика взаимодействия для Carz.xaml
    /// </summary>
    public partial class Carz : Page
    {
        Busket busc = ((MainWindow)Application.Current.MainWindow).buc;
        int pr = 0;
        public Carz()
        {
            InitializeComponent();
            foreach (int a in busc.a.Keys)
            {
                
                if(a == 1)
                {
                    PRICE.Visibility=Visibility.Visible; 
                    Buttonka.Visibility = Visibility.Visible;
                    int price = 92000;
                    StackPanel onestack = new StackPanel();
                    onestack.Orientation = Orientation.Horizontal;
                    Label b = new Label();
                    b.Content = "Игровой пк XAJTY";
                    b.FontWeight = FontWeights.Bold;
                    Label bCount = new Label();
                    bCount.Content = busc.a[1].ToString();
                    bCount.HorizontalAlignment = HorizontalAlignment.Right;
                    Label aPrice = new Label();
                    aPrice.Content = price * busc.a[1];
                    aPrice.FontWeight = FontWeights.Bold;
                    pr += price * busc.a[1];
                    onestack.Children.Add(b);
                    onestack.Children.Add(bCount);
                    onestack.Children.Add(aPrice);
                    cr.Children.Add(onestack);
                    
                }
                if(a == 2)
                {
                    PRICE.Visibility = Visibility.Visible;
                    Buttonka.Visibility = Visibility.Visible;
                    int price = 237900;
                    StackPanel twostack = new StackPanel();
                    twostack.Orientation = Orientation.Horizontal;
                    Label c = new Label();
                    c.Content = "HyperPC Lumen";
                    c.FontWeight = FontWeights.Bold;
                    Label cCount = new Label();
                    cCount.Content = busc.a[2].ToString();
                    cCount.HorizontalAlignment = HorizontalAlignment.Center;
                    Label cPrice = new Label();
                    cPrice.Content = price * busc.a[2];
                    cPrice.FontWeight = FontWeights.Bold;
                    pr += price * busc.a[2];
                    twostack.Children.Add(c);
                    twostack.Children.Add(cCount);
                    twostack.Children.Add(cPrice);
                    cr.Children.Add(twostack);
                    
                    
                }
                if (a == 3)
                {
                    PRICE.Visibility = Visibility.Visible;
                    Buttonka.Visibility = Visibility.Visible;
                    int price = 75000;
                    StackPanel threestack = new StackPanel();
                    threestack.Orientation = Orientation.Horizontal;
                    Label d = new Label();
                    d.Content = "GamingPC";
                    d.FontWeight = FontWeights.Bold;
                    Label dCount = new Label();
                    dCount.Content = busc.a[3].ToString();
                    dCount.HorizontalAlignment = HorizontalAlignment.Right;
                    Label dPrice = new Label();
                    dPrice.Content = price * busc.a[3];
                    dPrice.FontWeight = FontWeights.Bold;
                    pr += price * busc.a[3];
                    threestack.Children.Add(d);
                    threestack.Children.Add(dCount);
                    threestack.Children.Add(dPrice);
                    cr.Children.Add(threestack);
                    

                }
                
                

            }

            PRICE.Content = "Цена:" + pr;
            

        }
        

        
    }
}
