class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Heavy Winter Jacket", 17, 159.99, 1);
        Product p2 = new Product("Thermal Socks", 24, 24.99, 2);
        Product p3 = new Product("Heavy Scarf", 37, 42.50, 1);
        Product p4 = new Product("Winter Boots", 7, 175.00, 1);
        Product p5 = new Product("Handheld flashlight", 49, 19.99, 2);

        Address a1 = new Address("429 Scenic Dr", "Henderson", "NV", "USA");
        Address a2 = new Address("4013 Rival BLVD", "Alabang", "Cavite", "PH");

        Customer c1 = new Customer("Reginald Spud", a1);
        Customer c2 = new Customer("Tatay Ben", a2);

        Order o1 = new Order(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);

        Order o2 = new Order(c2);
        o2.AddProduct(p4);
        o2.AddProduct(p5);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(o1.PackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine("\nOrder 1 Total Price: $" + o1.OrderTotal());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(o2.PackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(o2.ShippingLabel());
        Console.WriteLine("\nOrder 2 Total Price: $" + o2.OrderTotal());
    }
}