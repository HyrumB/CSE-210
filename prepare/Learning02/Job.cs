public class Job 
{
    // Member Variables
    // the _ indicates its a member variable
    public string _companyName = "";
    public string _jobTitle = "";
    public int _jobStart = 0;
    public int _jobEnd = 0;

    //class functions
    public void DisplayCompanyInfo()
        {
            Console.WriteLine($"{_jobTitle} ({_companyName}) {_jobStart}-{_jobEnd}");
        }
}