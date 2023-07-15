namespace ordering
{

    class Order
    {

        // --- Parameters ---

        private List<Product> products;
        private Customer customer;

        // --- Parameter Constructor ---

        public Order(List<Product> products, Customer customer)
        {
            this.products = products;
            this.customer = customer;
        }

        // --- Methods ---

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;

            foreach (Product product in products)
            {
                totalCost += product.Price * product.Quantity;
            }

            
            totalCost += customer.IsInUSA() ? 5 : 35;

            return totalCost;
        }

        // --- Getters --

        public string GetPackingLabel()
        {
            string packingLabel = "";

            foreach (Product product in products)
            {
                packingLabel += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
            }

            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"Name: {customer.Name}\nAddress: {customer.Address.GetFullAddress()}";
        }
    }
}