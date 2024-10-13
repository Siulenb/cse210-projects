using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Order");
        Console.WriteLine();

        // Create products
        Product product1 = new Product("Laptop", "123", 1000m, 1);
        Product product2 = new Product("Mouse", "456", 25m, 2);

        // Create address and customer
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create an order with products and customer
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);

        // Output the packing label, shipping label, and total price
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");


        Console.WriteLine();
        // Second order example
        Product product3 = new Product("Headphones", "789", 50m, 1);
        Address address2 = new Address("456 Elm St", "London", "England", "UK");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(new List<Product> { product1, product3 }, customer2);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}