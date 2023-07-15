namespace Event
{

    class Reception : Event
    {   
        // --- Parameters ---
        private string _rsvpEmail;

        // --- Parameter Constructor ---

        public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            this._rsvpEmail = rsvpEmail;
        }


        // --- Getters ---

        protected override string GetEventSpecificDetails()
        {
            return $"Event Type: Reception\nRSVP Email: {_rsvpEmail}";
        }

        protected override string GetEventType()
        {
            return "Reception";
        }
    }
}