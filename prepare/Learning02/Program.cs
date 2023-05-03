using System;

class Program
{
    static void Main(string[] args)
    {
        // create an instance of job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobStart = 2019;
        job1._jobEnd = 2022;
        job1._companyName = "microsoft";

        // create a second instance of job 
        Job job2 = new Job();
        job2._jobTitle = "Hardware Riveter";
        job2._jobStart = 2021;
        job2._jobEnd = 2023;
        job2._companyName = "Apple";

        //create a new instance of Resume
        Resume resume1 = new Resume();
        resume1._name = "Bob Nonexistant";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        //Output using resume's displayfunction
        resume1.DisplayResume();

    }
}