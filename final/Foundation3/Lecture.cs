namespace Event
{
    class Lecture : Event
    {
        // --- Parameters ---

        private string _speaker;
        private int _capacity;
        private int _maxCapacity;

        // --- Parameter Constructor ---

        public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity, int maxCapacity = 100)
            : base(title, description, date, time, address)
        {
            this._speaker = speaker;
            this._maxCapacity = maxCapacity;

            // handleing excess people
            if (capacity > _maxCapacity)
                this._capacity = _maxCapacity;

            else if (capacity < _maxCapacity)
                this._capacity = capacity;
        }

        // --- Getters ---
        public override string GetFullDetails()
        {
            return $"\n{GetStandardDetails()}\n{GetEventSpecificDetails()}\n\n";
        }

        protected override string GetEventSpecificDetails()
        {
            return $"Event Type: {GetEventType()}\nSpeaker: {_speaker}\nCapacity: {_capacity}/{_maxCapacity}";
        }

        protected override string GetEventType()
        {
            return "Lecture";
        }
    }
}