namespace youtube
{
    class Program
    {
        static void Main(string[] args)
        {
            // create video objects
            Video video1 = new Video("powerwash sim ep 1", "markman", 1920);
            Video video2 = new Video("tomagachi review", "yoko", 1920);
            Video video3 = new Video("epic darksouls bow trolling", "ballord1934", 1920);

            // create comment objects
            Comment v1comment1 = new Comment("james", "you rotate the nozzle with the r key");
            Comment v1comment2 = new Comment("john lenon", "have any of you been to the dakota in ny?");
            Comment v2comment1 = new Comment("clickme", "im 100% not a bot");
            Comment v2comment2 = new Comment("clem", "@clickme your obviosly a bot");
            Comment v3comment1 = new Comment("clickme", "im 100% not a bot");
            Comment v3comment2 = new Comment("lork", "why are their so many bots lately");


            // Add comment objects
            video1.StoreComment(v1comment1);
            video1.StoreComment(v1comment2);
            video2.StoreComment(v2comment1);
            video2.StoreComment(v2comment2);
            video3.StoreComment(v3comment1);
            video3.StoreComment(v3comment2);

            // Display the results
            Console.WriteLine($"{video1.GetInfo()} \n  Total Comments:{video1.GetCommentNum} \n comments: " );
            video1.GetComments();
            Console.WriteLine($"{video2.GetInfo()} \n  Total Comments:{video2.GetCommentNum} \n comments: " );
            video2.GetComments();
            Console.WriteLine($"{video3.GetInfo()} \n  Total Comments:{video3.GetCommentNum} \n comments: " );
            video3.GetComments();
        }

    }
}