namespace Develop03
{
    class Scripture
    {   
        // --- Parameters ---

        private List<Word> _words = new List<Word>();

        // --- methods ---

        public List<Word> GetWords()
        {
            return _words;
        }

        public void SetWords(string text)
        {   
            // Seperates words by the spaces between them
            string[] wordArray = text.Split(' ');

            // Adds each word into a list
            foreach (string word in wordArray)
            {
                _words.Add(new Word(word));
            }
        }

        public void HideRandomWord()
        {   
            // Creates a list of all true instances of word in the list words 
            List<Word> hiddenWords = _words.FindAll(word => word.IsHidden());

            // Checks if every word is hidden and returns early if they are
            if (hiddenWords.Count == _words.Count)
            {
                return;
            }

            Random random = new Random();

            // Grabs an index from list words and its corresponding value
            Word wordToHide = _words[random.Next(_words.Count)];

            // Keeps looping until a new word is hidden
            while (wordToHide.IsHidden())
            {
                wordToHide = _words[random.Next(_words.Count)];
            }
            wordToHide.Hide();
        }

        public bool allWordsHidden()
        {
                foreach (Word word in GetWords())
                {   
                    // Checks if all words aren't hidden
                    if (!word.IsHidden())
                    {
                        return false;
                    }
                }

                return true;
        }
    }
}