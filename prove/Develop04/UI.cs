namespace Develop04
{
    class UserInterface
    {
        public int Menu()
        {
            // Display menu options
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflection activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit.");
            Console.Write("Enter a number to select an option: ");

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            return input;
        }
        
        // --- Animation ---
        public void Animation(int runtime)
        {

            string[] animation = { "-", "\\", "|", "/" };
            int count = 0;
            Console.WriteLine("Just a moment...");

            // Looping through the whole
            // animation takes about 5 sec
            while (count != runtime)
            {
                foreach (string value in animation)
                {
                    Thread.Sleep(1000);
                    Console.Write(value);
                    Console.Write("\b");
                }
                count++;
            }
            Console.WriteLine();
        }

        public void CountDown(int runtime)
        {
            
            for (int i = runtime; i > -1; i--)
            {
                Thread.Sleep(1000);
                Console.Write(i);
                Console.Write("\b");
            }
            Console.WriteLine();
        }

        // Outputs a maluable start message
        private int CreateStartMessage(string activityType, string activityDescription)
        {
            Console.WriteLine($"Get ready for {activityType} activity. \n");

            Console.WriteLine($"{activityDescription}\n");

            Console.Write("Enter how long you want the activity to go for in intervals of 5 seconds: ");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return duration;
        }

        
        public void ActEndmessage()
        {
            Console.WriteLine("Activity vanquished");
            Animation(1);
            Console.Clear();
        }

        // --- Breathing activity start --- 

        public void BreathAct(Breathing breath)
        {
            // output Start message
            int duration = CreateStartMessage("breathing", breath.GetActivityDescription());
            breath.SetDuration(duration);

            // setting breath duration
            breath.breathInTime = 3;
            breath.breathOutTime = 3;
            Animation(1);
            Console.Clear();

            // let the user know its going to begin
            Console.WriteLine("Get ready...");
            Console.WriteLine();

            breath.StartTimer();

            // Loop until time has run out
            while (breath.CheckTime() != true)
            {
                Console.Write("Breath In... ");
                CountDown(3);

                Console.Write("Breath Out... ");
                CountDown(5);
            }
        }

        // --- Listing activity start --- 

        public void ListAct(Listing listing)
        {
            // output Start message
            int duration = CreateStartMessage("listing", listing.GetActivityDescription());
            listing.SetDuration(duration);

            // output user's instructions
            Console.WriteLine("input as many response as you can: ");
            Console.WriteLine("When ready to get the next prompt hit ENTER.\n");
            
            Animation(3);
            Console.Clear();

            // Output a question for the user
            listing.GetRandQuestion();
            Console.WriteLine("Hit enter when ready.");

            listing.StartTimer();

            // Loops until time is up
            while (listing.CheckTime() != true)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                listing.StoreResponse(response);
            }

            Console.WriteLine($"You listed {listing.GetResponsesNumber()} items");
        }

        // --- Reflection activity start --- 
        
        public void ReflectAct(Reflection reflect)
        {
            // output Start message
            int duration = CreateStartMessage("reflection", reflect.GetActivityDescription());
            reflect.SetDuration(duration);

            // Output prompt and wait for user
            Console.WriteLine("Please Consider the following prompt.");
            Console.WriteLine($"]> {reflect.GetRandPrompt()}");
            Console.Write("Hit ENTER when ready to answer.");
            Console.ReadLine();
            Console.Clear();

            // let the user know its going to begin 
            Console.WriteLine("Answer each of the following questions in your head as they relate to your experience.");
            Console.Write("You may begin in...");
            CountDown(5);

            reflect.StartTimer();

            // Loops until time is up
            while (reflect.CheckTime() != true)
            {
                Console.WriteLine(reflect.GetRandQuestion());
                CountDown(5);
            }
        }
    }
}