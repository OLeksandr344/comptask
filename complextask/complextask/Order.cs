using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complextask
{
    public class Order
    {
        public bool status = false;
        public int OrderId { get; set; }
        public List<Product> Products { get; set; }
        public double cost = 0;
        public Order(int id, List<Product> p)
        {
            OrderId = id;
            Products = p;
            foreach (Product product in p)
            {
                cost += product.Price;
            }
        }
        public static void OrderStatusChange(Order order)
        {
            order.status = true;         
        }
        public delegate void OrderStatusDelegate(Order order);
        public static OrderStatusDelegate orderDelegate = new OrderStatusDelegate(OrderStatusChange);
        
        
    } 
}
