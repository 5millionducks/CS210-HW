using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("12345 Boulder Road", "June Lake", "CA", "United States");
        Address address2 = new("67890 Orchid St", "Bath", "England", "United Kingdom");

        Customer customer1 = new("Evelyn Arasim", address1);
        Customer customer2 = new("Alice Rushton", address2);

        Product product1 = new("Boxed Set - Mistborn - Special Edition 2024", 412, 139.99, 1);
        Product product2 = new("25' Monitor for Desktop", 652, 2199.99, 1);
        Product product3 = new("Custom Soft Tap Board", 106, 82.99, 3);

        Order order1 = new(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product2);

        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Shipping: ${order1.GetShippingCost():0.00}");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Shipping: ${order2.GetShippingCost():0.00}");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
        Console.WriteLine();
    }
}
