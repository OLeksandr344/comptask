using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static complextask.Order;

namespace complextask
{
    public class OrderProcessor
    {
        public OrderProcessor()
        {
            
        }
        public static void ProcessOrder(Order order)
        {
            orderDelegate(order);
        }




    }
}
