namespace youtube
{

    public class Video
    {
        // --- Parameters ---

        private string _title;
        private string _author;
        private int _lengthSec;
        private List<Comment> _comments;


        // --- constuctor ---

        public Video(string title, string author, int lengthSec  )
        {
            this._comments = new List<Comment>();
            this._title = title;
            this._author = author;
            this._lengthSec = lengthSec;
        }

        // --- Getters/Setters ---

        public string GetInfo()
        {
            return $"{_title}, {_author}, {_lengthSec}";
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }

        // --- Methods ---
        public void StoreComment(Comment comment)
        {// adds a comment into the list of comments
            if (!(_comments.Contains(comment)))
            {
                _comments.Add(comment);
            }
        }

        public int GetCommentNum()
        {
        return _comments.Count;
        }
    }
}