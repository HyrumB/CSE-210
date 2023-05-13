using System.Collections.Generic;
using System;



namespace Develop02
{
    ///<summary>
    ///the purpose of Journal is to store entries
    ///</summary>

    public class Journal{
        
        public List<Entry> entries;
        
        //creates the class and the list
        public Journal()
        {
            entries = new List<Entry>();
        }

        // returns all entries within the list
        public List<Entry> GetAllEntries()
        {
            return entries;
        }

        // adds entries to the list
        public void StoreEntry(Entry entry)
        {
            //Console.WriteLine(entries.Count);// debugging
            if (!(entries.Contains(entry)))
            {
                entries.Add(entry);

                //entries.Add(entry);//debugging
                //Console.WriteLine(entries.Count);//debugging
            }
        }
    }
}