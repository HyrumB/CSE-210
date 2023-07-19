namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // creating new instances
            UserInterface userInterface = new UserInterface();
            
            string breathingDescription = "This activity will help you relax by having you breath in and out slowly, Clear your mind and get ready to focus on breathing.";
            Breathing breath = new Breathing(breathingDescription);

            string listingDescription = "This activity will help you reflect on the good events in your life by having you list as many things as you can related to one subject.";
            Listing listing = new Listing(listingDescription);

            string reflectionDescription = "This activity will help you reflect on times in your life when you have shown both strength and resilience, hopfully it can also teach to apply these in other areas of your life.";
            Reflection reflection = new Reflection(reflectionDescription);


            // --- meat of the program ---
            int exit = 0;
            while (exit == 0)
            {
                int userChoice = userInterface.Menu();

                switch (userChoice)
                {
                    case 1:
                        userInterface.BreathAct(breath);
                        userInterface.ActEndmessage();
                        break;

                    case 2:
                        userInterface.ListAct(listing);
                        userInterface.ActEndmessage();
                        break;

                    case 3:
                        userInterface.ReflectAct(reflection);
                        userInterface.ActEndmessage();
                        break;

                    case 4:
                        exit = 1;
                        break;
                }
            }
        }
    }
}
