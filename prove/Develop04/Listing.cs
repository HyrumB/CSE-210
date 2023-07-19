namespace Develop04
{
    class Listing : Activity
    {
        // --- Parameters --- 
        
        private List<string> _questions;
        private List<string> _responses;

        // --- Constructors ---

        public Listing(string startMessage)
                    : base(startMessage)
        {
            _questions = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            _responses = new List<string> {};
        }

        // --- Getters ---

         public string GetRandQuestion()
        {
            // Returns a random string pulled from _questions
            Random rand = new Random();
            int randNum = rand.Next(_questions.Count);
            return _questions[randNum];
        }

        public int GetResponsesNumber() {
            return _responses.Count;
        }

        // --- Methods ---
        public void StoreResponse(string response)
        {
            _responses.Add(response);
        }
    }
}