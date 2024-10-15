using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("75 Main St", "Jordan", "UT", "USA");
        Address address2 = new Address("15 Alfred St", "Virginia", "TX", "USA");
        Address address3 = new Address("1600 Cândido Benício St", "Rio de Janeiro", "RJ", "BR");

        Customer customer1 = new Customer("Jason Manson", address1);
        Customer customer2 = new Customer("Oliver Phelps", address2);
        Customer customer3 = new Customer("Marina Ferreira", address3);

        Product product1 = new Product ("Chair", "45367", 129.99, 6);
        Console.WriteLine(product1.GetName + " " + product1.GetProductId());
        
        Product product2 = new Product ("Table", "78653", 499.99, 1);
        Console.WriteLine(product2.GetName + " " + product2.GetProductId());
        
        Product product3 = new Product ("Sofa", "34986", 2589.99, 2);
        Console.WriteLine(product3.GetName + " " + product3.GetProductId());

        List<Product> productList = new List<Product> {product1, product2, product3};

        Order order1 = new Order(customer1, new List<Product>{product1});
        Order order2 = new Order(customer2, new List<Product>{product2});
        Order order3 = new Order(customer3, new List<Product>{product3});

        Console.WriteLine(order1.GetProductDetails());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotal()}");

        Console.WriteLine(order2.GetProductDetails());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotal()}");

        Console.WriteLine(order3.GetProductDetails());
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order3.CalculateTotal()}");

    }
}