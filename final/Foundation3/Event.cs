namespace Event
{
    class Event
    {

        // --- Parameters ---
        private string title;
        private string description;
        private string date;
        private string time;
        private Address address;

        // --- Parameters Constuctor ---

        public Event(string title, string description, string date, string time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        // --- Getters ---
        public string GetStandardDetails()
        {
            return $"Event Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetFullAddress()}";
        }

        public virtual string GetFullDetails()
        {
            return $"\n{GetStandardDetails()}\n{GetEventSpecificDetails()}\n\n";
        }

        public string GetShortDescription()
        {
            return $"Event Type: {GetEventType()}\n Event Title: {title}\nDate: {date}";
        }

        // Protected Event Specific Getters to be overwritten in children
        protected virtual string GetEventSpecificDetails()
        {
            return string.Empty;
        }

        protected virtual string GetEventType()
        {
            return string.Empty;
        }
    }
}