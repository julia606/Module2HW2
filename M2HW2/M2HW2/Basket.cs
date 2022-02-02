using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW2
{
    internal class Basket
    {
        List<Product> products;
        public Basket(List<Product> productToOrder)
        {
            products = productToOrder;
        }
        public List<Product> Products { get=>products; }
        public decimal Total()
        {
            decimal summa = 0;
            foreach (var item in products)
            {
                summa += item.Price;
            }
            return summa;
        }
        Random Random = new Random();
        public int Id => Random.Next(123456, 789012);
    }
}
