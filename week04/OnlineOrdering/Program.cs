using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - Customer in USA
        Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Notebook", "NB001", 3.99, 5));
        order1.AddProduct(new Product("Pen Pack", "PN012", 1.49, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine(new string('-', 40));

        // Order 2 - Customer outside USA
        Address address2 = new Address("45 Maple Lane", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Liam Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "HP404", 49.99, 1));
        order2.AddProduct(new Product("USB Cable", "USB007", 6.99, 2));
        order2.AddProduct(new Product("Charger", "CHG101", 15.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine(new string('-', 40));
    }
}
