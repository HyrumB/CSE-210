namespace youtube
{

    public class Comment
    {
        // --- Parameters ---

        private string _comAuthor;
        private string _text;

        // --- Constructor ---
        
        public Comment(string comAuthor, string text)
        {
            this._comAuthor = comAuthor;
            this._text = text;
        }
    }

}