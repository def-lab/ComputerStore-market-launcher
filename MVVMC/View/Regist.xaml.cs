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

namespace MVVMC.View
{
    /// <summary>
    /// Логика взаимодействия для Regist.xaml
    /// </summary>
    public partial class Regist : Page
    {
        AppContext DB;
        public User authuser;
        public bool auth = false;
        public Regist()
        {
            InitializeComponent();
            DB = new AppContext();
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            LogIn.Visibility = Visibility.Collapsed;
            Sign.Visibility = Visibility.Visible;
            
        

        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LogIn.Visibility = Visibility.Visible;
            Sign.Visibility = Visibility.Collapsed;

        }

        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Log1.Text.Length < 5)
            {
                MessageBox.Show("Your Login is very small", "Exeption");

            }
            if(Pass1.Password != RepeatPass1.Password)
            {
                MessageBox.Show("Ваши пароли не равны", "Exeption");
            }
            if(Pass1.Password.Length < 8)
            {
                MessageBox.Show("Ваш пароль слишком короткий", "Exeption");
            }
            if (Log1.Text.Length >= 5 && Pass1.Password == RepeatPass1.Password && Pass1.Password.Length >= 8)
            {
                User u = new User(Log1.Text, Pass1.Password);
                DB.Users.Add(u);
                DB.SaveChanges();
                ((MainWindow)Application.Current.MainWindow).Main.Content = new Gl();
                
                MessageBox.Show("Регистрация прошла успешно");
                
            }

        }

        public void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string login = Log2.Text;
            string password = Pass2.Password;
            AppContext context = new AppContext();
            authuser = null;
            authuser = context.Users.Where(b => b.login == login && b.password == password).FirstOrDefault();
            if(authuser != null)
            {
                ((MainWindow)Application.Current.MainWindow).auth.Visibility = Visibility.Collapsed;
                ((MainWindow)Application.Current.MainWindow).authh = true;
                ((MainWindow)Application.Current.MainWindow).log = authuser.login;
                ((MainWindow)Application.Current.MainWindow).Main.Content = new Gl();
                
                MessageBox.Show("Добро пожаловать!");
               
                
            }
            else
            {
                MessageBox.Show("Данные введены не верно");
            }
        }
        public string getLogin()
        {
            return authuser.login;
        }
    }
}
