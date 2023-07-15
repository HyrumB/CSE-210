namespace ordering
{

    class Address
    {

        // --- Parameters ---

        private string street;
        private string city;
        private string state;
        private string country;

        // --- Parameter Constructor ---

        public Address(string street, string city, string state, string country)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        // --- Getters/Setters ---

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string GetFullAddress()
        {
            return $"{street}\n{city}, {state}\n{country}";
        }

        // --- Methods ---

        public bool IsInUSA()
        {
            if (country.ToLower() == "usa")
                return true;
            else
                return false;
        }
    }
}