namespace ordering
{
    class Customer
    {

        // --- Parameters ---

        private string _name;
        private Address _address;

        // --- Parameter Constructor ---

        public Customer(string name, Address address)
        {
            this._name = name;
            this._address = address;
        }

        // --- Methods ---

        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }

        // --- Getters and Setters ---

            public string Name
        {
            get => _name;
            set => _name = value;
        }

         public Address Address
        {
            get => _address;
            set => _address = value;
        }



    }   
}