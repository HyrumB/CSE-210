
namespace Develop03
{

    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the scripture reference: ");
            // stores refrence EX(Proverbs 1:6)
            string reference = Console.ReadLine();
            // stores the scripture 
            string text = UserInteraction.EnterScripture();

            // creates a new scripture element
            Scripture scripture = new Scripture();
            scripture.SetWords(text);

            UserInteraction.Display(scripture);

            // Starts a loop that needs to be ended with break
            while (true)
            {
                Console.Write("Press enter to hide more words or type 'quit' to exit: ");
                string userInput = Console.ReadLine();
                
                // Exits if quit is invoked
                if (userInput.ToLower() == "quit")
                {
                    Console.Clear();
                    break;
                }

                scripture.HideRandomWord();
                UserInteraction.Display(scripture);

                //if everything is hidden theirs no point in continuing
                bool allHidden = scripture.allWordsHidden();
                if (allHidden)
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}