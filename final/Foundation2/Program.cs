namespace ordering
{

    class Program
    {
        static void Main()
        {
            // Create Address objects
            Address address1 = new Address("123 Main Street", "City1", "State1", "USA");
            Address address2 = new Address("456 Park Avenue", "City2", "State2", "Canada");

            // Create Customer objects
            Customer customer1 = new Customer("Martin Luther", address1);
            Customer customer2 = new Customer("John Lenon", address2);

            // Create Product objects
            Product product1 = new Product("Product1", 1, 10.99m, 2);
            Product product2 = new Product("Product2", 2, 5.99m, 3);

            // Create Order objects
            List<Product> order1Products = new List<Product> { product1, product2 };
            Order order1 = new Order(order1Products, customer1);

            List<Product> order2Products = new List<Product> { product1, product2 };
            Order order2 = new Order(order2Products, customer2);

            // Display the results
            Console.WriteLine("Order 1");
            Console.WriteLine("Total Cost: " + order1.CalculateTotalCost());
            Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());

            Console.WriteLine("\nOrder 2");
            Console.WriteLine("Total Cost: " + order2.CalculateTotalCost());
            Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        }
    }
}