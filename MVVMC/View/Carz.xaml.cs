using MVVMC.Models;
using MVVMC.View;
using MVVMC.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

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
                    Button dell = new Button();
                    dell.Width = 15;
                    dell.Click += (sender, e) =>
                    {
                        onestack.Visibility = Visibility.Collapsed;
                        pr -= price * busc.a[1];
                        busc.a.Remove(1);
                        PRICE.Content = "Цена:" + pr;
                        if (pr == 0)
                        {
                            PRICE.Visibility = Visibility.Collapsed;
                            Buttonka.Visibility = Visibility.Collapsed;
                        }
                    };
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
                    onestack.Children.Add(dell);
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
                    Button dell = new Button();
                    dell.Width = 15;
                    dell.Click += (sender, e) =>
                    {
                        twostack.Visibility = Visibility.Collapsed;
                        
                        pr -= price * busc.a[2];
                        busc.a.Remove(2);
                        PRICE.Content = "Цена:" + pr;
                        if (pr == 0)
                        {
                            PRICE.Visibility = Visibility.Collapsed;
                            Buttonka.Visibility = Visibility.Collapsed;
                        }
                    };
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
                    twostack.Children.Add(dell);
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
                    Button dell = new Button();
                    dell.Width = 15;
                    dell.Click += (sender, e) =>
                    {
                        threestack.Visibility = Visibility.Collapsed;
                        pr -= price * busc.a[3];
                        busc.a.Remove(3);
                        PRICE.Content = "Цена:" + pr;
                        if(pr == 0)
                        {
                            PRICE.Visibility = Visibility.Collapsed;
                            Buttonka.Visibility = Visibility.Collapsed;
                        }
                    };
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
                    threestack.Children.Add(dell);
                    threestack.Children.Add(dCount);
                    threestack.Children.Add(dPrice);
                    cr.Children.Add(threestack);
                    

                }
                PRICE.Content = "Цена:" + pr;
                

            }

           
            

        }

        private void Buttonka_Click(object sender, RoutedEventArgs e)
        {
            
            if(((MainWindow)Application.Current.MainWindow).authh == false)
            {
                
                MessageBox.Show("Вы не авторизировались");

            }
            else
            {
                string text = ((MainWindow)Application.Current.MainWindow).log;
                if (busc.a.ContainsKey(1))
                {
                    text += "\t" + "Игровой компьютер XYJTV:" + busc.a[1];
                }
                if (busc.a.ContainsKey(2))
                {
                    text += "\t" + "HyperPC Lumen:" + busc.a[2];
                }
                if (busc.a.ContainsKey(3))
                {
                    text += "\t" + "GamingPC:" + busc.a[3];
                }
                MessageBox.Show("Заказ оформлен, скоро мы с вами свяжемся");
                
                StreamWriter sw = new StreamWriter("C:\\Users\\Aogiri\\source\\repos\\MVVMC\\MVVMC\\Resources\\oreder.txt",true);
                sw.WriteLine(text);
                sw.Close();

                
            }

        }
        
        
    }
}
