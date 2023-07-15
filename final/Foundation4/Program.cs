namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();


            // Creating Running Event
            DateTime date1 = new DateTime(2022, 11, 3);
            Exercise running = new Running(date1, 30, 3.0);
            exercises.Add(running);

            // Creating Cycling Event
            DateTime date2 = new DateTime(2022, 11, 3);
            Exercise cycling = new Cycling(date2, 30, 9.7);
            exercises.Add(cycling);

            // Creating Swimming Event
            DateTime date3 = new DateTime(2022, 11, 3);
            Exercise swimming = new Swimming(date3, 30, 10);
            exercises.Add(swimming);

            // Outputting
            Console.WriteLine("\n");
            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine($"{exercise.GetSummary()} \n");
            }
        }
    }
}