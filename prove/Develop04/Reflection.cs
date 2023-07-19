namespace Develop04
{
    class Reflection : Activity
    {
        // --- Parameters ---

        private List<string> _prompts;

        private List<string> _questions;

        // --- Constructers ---

        public Reflection(string description)
                    : base(description)
        {
            _prompts = new List<string>()
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>()
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        // --- Getters ---

        public string GetRandPrompt()
        {
            // Returns a random string pulled from _prompts
            Random rand = new Random();
            int randNum = rand.Next(_prompts.Count);
            return _prompts[randNum];
        }

         public string GetRandQuestion()
        {
            // Returns a random string pulled from _questions
            Random rand = new Random();
            int randNum = rand.Next(_questions.Count);
            return _questions[randNum];
        }

        public string GetResponse(int index)
        {
            return "";
        }
    }
}