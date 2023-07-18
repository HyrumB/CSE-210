namespace Develop03
{

    class UserInteraction
    {

        // --- Methods ---

        public static string EnterScripture()
        {   
            // takes and returns user input
            Console.WriteLine("Enter the scripture text: ");
            return Console.ReadLine();
        }

        public static void Display(Scripture scripture)
        {   
            Console.Clear();
            Console.WriteLine("");
            foreach (Word word in scripture.GetWords())
            {   
                Console.Write(word.GetWord() + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
