namespace Develop03
{

    class Word
    {   
        // --- Parameters ---
        private bool hidden;
        private string word;

        // --- Constructor ---
        public Word(string word)
        {
            hidden = false;
            this.word = word;
        }

        // --- Methods ---

        public string GetWord()
        {
            // if hidden is true this returns _ at the length of word
            // if false it returns the word as normal
            return hidden ? new string('_', word.Length) : word;
        }

        public bool IsHidden()
        {
            return hidden;
        }

        public void Hide()
        {
            hidden = true;
        }

        public void Show()
        {
            hidden = false;
        }
    }
}