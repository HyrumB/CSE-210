namespace ordering
{
    class Product
    {

        // --- Parameters ---

        private string _name;
        private int _productId;
        private decimal _price;
        private int _quantity;

        // --- Parameter Constructor ---

        public Product(string name, int productId, decimal price, int quantity)
        {
            this._name = name;
            this._productId = productId;
            this._price = price;
            this._quantity = quantity;
        }

        // --- Getters/Setters ---
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
    }
}