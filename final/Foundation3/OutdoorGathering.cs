namespace Event
{
    class OutdoorGathering : Event
    {
        // --- Parameters ---

        private string _weather;
        private int _capacity;

        // --- Parameter Constructor ---

        public OutdoorGathering(string title, string description, string date, string time, Address address, string weather, int capacity)
            : base(title, description, date, time, address)
        {
            this._weather = weather;
            this._capacity = capacity;
        }

        // --- Getters ---

        protected override string GetEventSpecificDetails()
        {
            return $"Event Type: {GetEventType()}\nWeather: {_weather}\nCapacity: {_capacity}";
        }

        protected override string GetEventType()
        {
            return "Outdoor Gathering";
        }
    }
}