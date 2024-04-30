using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMC.ViewModel
{
   public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public User() { }
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        
    }
}
