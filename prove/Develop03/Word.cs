namespace Develop03
{

    class Word
    {   
        // --- Parameters ---
        private bool _hidden;
        private string _word;

        // --- Constructor ---
        public Word(string _word)
        {
            _hidden = false;
            this._word = _word;
        }

        // --- Methods ---

        public string GetWord()
        {
            // If hidden is true this returns _ at the length of word
            // If false it returns the word as normal
            return _hidden ? new string('_', _word.Length) : _word;
        }

        public bool IsHidden()
        {
            return _hidden;
        }

        public void Hide()
        {
            _hidden = true;
        }

        public void Show()
        {
            _hidden = false;
        }
    }
}