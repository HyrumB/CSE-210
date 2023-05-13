namespace Develop02
{
    ///<summary>
    ///the purpose of entry is to record (or store) a prompt,
    ///response, or date
    ///</summary>

    public class Entry{

        public string prompt;
        public string response;
        public string date;

        //returns the variables as string
        public string GetAsString()
        {
            return $"{date}:{prompt}:{response}:";
        }
        public string getFormatedString()
        {
            return $"date:{date} - prompt:{prompt}\n{response}\n";
        }

        //constructor to construct the variables
        public void Store(string prompt, string response, string date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date;

        }   
    }
}