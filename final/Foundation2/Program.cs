using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- PROGRAM 2: ONLINE ORDERING SYSTEM ---");

        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Wireless Mouse", "M100", 25.50f, 1));
        order1.AddProduct(new Product("Mechanical Keyboard", "K200", 75.00f, 1));
        order1.AddProduct(new Product("AA Batteries (4-pack)", "B50", 5.99f, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine(new string('-', 40));

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("27-inch Monitor", "MON77", 299.99f, 1));
        order2.AddProduct(new Product("HDMI Cable", "HDMI10", 12.50f, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalCost():F2}");
    }
}