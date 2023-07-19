namespace Develop04
{
    class Activity
    {
        //--- Parameters ---

        private int _duration;
        private string _reflection;
        private string _activityDescription;
        private DateTime _startTime;
        private DateTime _endTime;
        public Activity() { }

        // ---- Constructors ---

        public Activity(string activityDescription)
        {
            _activityDescription = activityDescription;
        }

        // --- Getters ---

        public int GetDuration()
        {
            return _duration;
        }

        public string GetActivityDescription()
        {
            return _activityDescription;
        }

        // --- Setters ---

         public void SetDuration(int duration)
        {
            _duration = duration;
            _endTime = _startTime.AddSeconds(duration);
        }

        public void SetReflection(string reflection)
        {
            _reflection = reflection;
        }

        // --- Methods ---
        public void StartTimer()
        {
            _startTime = DateTime.Now;
            _endTime = _startTime.AddSeconds(_duration);
        }

        public bool CheckTime()
        {
            // Returns true when timer ends
            // else it returns false
            DateTime currentTime = DateTime.Now;

            if (currentTime > _endTime)
            {
                return true;
            }

            return false;
        }
    }
}
