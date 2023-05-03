public class Resume
{
    // Member Variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    
    //class functions
    public void DisplayResume()
    {
        Console.WriteLine($"name: {_name}");
        Console.WriteLine("work experience: ");

        foreach (Job job in _jobs)
        {
            job.DisplayCompanyInfo();
        }
    }

}