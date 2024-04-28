using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMC.ViewModel
{
    public class Product
    {
        public int product;
        private int count;
        public Product(int product)
        {
            this.product = product;
        }
        public void PlusCount()
        {
            count++;
        }
        public int getCount()
        {
            return count;
        }
    }
}
