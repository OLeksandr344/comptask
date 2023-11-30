using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complextask
{

    public class ProductCollection<T> : IEnumerable<T> where T : IProduct
    {

        private List<T> products;

        public ProductCollection()
        {
            products = new List<T>();
        }
        public void AddProduct(T product)
        {
            products.Add(product);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return products.GetEnumerator();
        }

        // Реалізація інтерфейсу IEnumerable для підтримки foreach
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
