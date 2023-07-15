namespace ExerciseTracking
{
    class Running : Exercise
    {   
        
        // --- Parameters ---

        private double _distance;

        // --- Parameter Constructor ---

        public Running(DateTime date, int length, double distance) : base(date, length)
        {
            this._distance = distance;
        }

        // --- Getters ---

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return _distance / (GetLength() / 60.0);
        }

        public override double GetPace()
        {
            return GetLength() / _distance;
        }

        public override string GetSummary()
        {
            return $"{GetDate().ToString("dd MMM yyyy")} Running ({GetLength()} min) - Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        }
    }
}