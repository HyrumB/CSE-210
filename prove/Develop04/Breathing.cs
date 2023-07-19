namespace Develop04
{
    class Breathing : Activity
    {   
        // --- Parameters ---

        private int _breathInTime;
        private int _breathOutTime;

        // --- Constructors ---

        public Breathing(string description) : base(description) 
        { 

        }

        // -- Getters & Setters

        public int breathInTime
        {
            get => _breathInTime;
            set => _breathInTime = value;
        }

        public int breathOutTime
        {
            get => _breathOutTime;
            set => _breathOutTime = value;
        }

    }
}