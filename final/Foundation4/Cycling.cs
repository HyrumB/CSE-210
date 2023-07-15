namespace ExerciseTracking
{
    class Cycling : Exercise
    {
        // --- Parameters ---
        private double _speed;

        // --- Parameter Constructor ---
        public Cycling(DateTime date, int length, double speed) : base(date, length)
        {
            this._speed = speed;
        }

        // --- Getters ---

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return Math.Round(60.0 / _speed, 2);
        }

        public override string GetSummary()
        {
            return $"{GetDate().ToString("dd MMM yyyy")} Cycling ({GetLength()} min) - Speed: {_speed} kph, Pace: {GetPace()} min per km";
        }
    }
}