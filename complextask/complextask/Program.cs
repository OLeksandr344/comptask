using complextask;
using System;
try
{

    Book b1 = new Book("Lord of the Rings: The Fellowship of the Ring", 500, "J. R. R. Tolkien", 500, 20);
    Electronics e1 = new Electronics("Iphone 11", 20000, 128, 10);
    var productCollection = new ProductCollection<IProduct>();
    productCollection.AddProduct(b1);
    productCollection.AddProduct(e1);
    foreach (var product in productCollection)
    {
        Console.WriteLine(product);
    }
    Console.WriteLine(e1.CountDiscount());
    Console.WriteLine(b1.CountDiscount());
    Order order = new Order(1, new List<Product> { b1, e1 });
    
    OrderProcessor orderProcessor = new OrderProcessor();
    NotificationService notificationService = new NotificationService();
    OrderProcessor.ProcessOrder(order);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
