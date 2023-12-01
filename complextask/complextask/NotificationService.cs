using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static complextask.Order;

namespace complextask
{
    public class NotificationService
    {
        public NotificationService() 
        {
            orderDelegate += new OrderStatusDelegate(sendNotification);
        }
        
        public static void sendNotification(Order order)
        {
            Console.WriteLine($"Статус замовлення {order.OrderId} змінено - {order.status}");
            
        }
        
    }
}
