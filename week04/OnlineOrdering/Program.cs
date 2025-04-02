using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Product productOne = new Product("Laptop", 1001, 899, 2);
         Product productTwo = new Product("Display", 1002, 25, 3);
        Product productThree = new Product("Keyboard", 1003, 45, 1);
        Product productFour = new Product("Monitor", 1004, 199, 2);

        //make up addresses
        Address usaAddress = new Address("123 Main St", "Seattle", "WA", "USA");
        Address nonUsaAddress = new Address("456 Queen St", "Toronto", "Ontario", "Canada");

        // several exemples of customers
        Customer usaCustomer = new Customer("John Smith", usaAddress);
         Customer noUsaCustomer = new Customer("Emilly Jhonson-Ivanova", nonUsaAddress);

     
        List<Product> orderItems1 = new List<Product> { productOne, productTwo };
        Order order1 = new Order(orderItems1, usaCustomer);

        List<Product> orderItems2 = new List<Product> { productThree, productFour };
        Order order2 = new Order(orderItems2, noUsaCustomer);

        //for Order 1
        Console.WriteLine("Order 1:");
        Console.WriteLine("---");
        
        Console.WriteLine("PackingLabel:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShippingLabel:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotalPrice: ${order1.CalculateTotalCost()}");





        Console.WriteLine("\n===\n");

        // for Order 2
        Console.WriteLine("Order 2:");
         Console.WriteLine("---");
         Console.WriteLine("PackingLabel:");
         Console.WriteLine(order2.GetPackingLabel());
         Console.WriteLine("\nShippingLabel:");
         Console.WriteLine(order2.GetShippingLabel());
         Console.WriteLine($"\nTotalPrice: ${order2.CalculateTotalCost()}");
    }
}
