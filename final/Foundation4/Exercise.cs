namespace  ExerciseTracking
{
using System;

    class Exercise
    {
        //--- Parameters ---
        private DateTime _date;
        private int _length;

        //--- Parameter Constructor ---

        public Exercise(DateTime date, int length)
        {
            this._date = date;
            this._length = length;
        }

        // --- Getters ---

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public virtual string GetSummary()
        {
            return "";
        }

        public int GetLength()
        {
            return _length;
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }

    



    
}