namespace ExerciseTracking
{
    class Swimming : Exercise
    {

        // --- Parameters ---

        private int _laps;

        // --- Parameter Constructor ---

        public Swimming(DateTime date, int length, int laps) : base(date, length)
        {
            this._laps = laps;
        }

        // --- Getters ---

        public override double GetDistance()
        {
            return _laps * 50.0 / 1000.0;
        }

        public override double GetSpeed()
        {
            return GetDistance() / (GetLength() / 60.0);
        }

        public override double GetPace()
        {
            return GetLength() / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({GetLength()} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
        }
    }
}