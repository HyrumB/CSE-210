namespace Event
{
class Program
{
    static void Main(string[] args)
    {   
        
        Address address = new Address("123 Main Street", "Cityville", "Stateville", "12345");
        
        // Creating child objects
        Event lecture = new Lecture("Intro to Assasination", "Learn the basics of Being assasinated", "2023-08-15", "10:00 AM", address, "John Lennon", 200, 100);
        Event outdoorGathering = new OutdoorGathering("Picnic", "Have a snack with friends", "2023-08-15", "10:00 AM", address, "stormy", 50);
        Event reception = new Reception("Networking Event", "An evening of networking and socializing", "2023-09-20", "6:00 PM", address, "info@example.com");
        
        // Display the results
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
    }
}
}