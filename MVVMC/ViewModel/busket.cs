using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMC.ViewModel
{
    public class Busket
    {
        public Dictionary<int, int> a = new Dictionary<int, int>();
        public void addproduct(Product b)
        {
            if (a.ContainsKey(b.product))
            {
                b.PlusCount();
                a[b.product] = b.getCount();


            }
            else
            {
                a.Add(b.product, 1);
            }

        }
        public void getproduct()
        {
            MessageBox.Show(a[1].ToString());
        }
        
    }
}
