namespace Event
{
    class Address
    {
        // --- Parameters ---
        
        private string _street;
        private string _city;
        private string _state;
        private string _zipCode;

        // --- Parameter Constructor ---

        public Address(string street, string city, string state, string zipCode)
        {
            this._street = street;
            this._city = city;
            this._state = state;
            this._zipCode = zipCode;
        }

        // --- Getter ---

        public string GetFullAddress()
        {
            return $"{_street}, {_city}, {_state} {_zipCode}";
        }
    }

}