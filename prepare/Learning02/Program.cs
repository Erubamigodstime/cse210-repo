using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Facilty Manager";
        job1._company = " Max-Migold";
        job1._startYear = 2000;
        job1._endYear = 2022;
        // job1.DisplayJobDetails();
        Job job2 = new Job();
        job2._jobTitle = "Software devlopment";
        job2._company = "Tesbo Rapids";
        job2._startYear = 2017;
        job2._endYear = 2001;
        // job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._personName = "Godstime";
        resume1._job.Add(job1);
        resume1._job.Add(job2);
        resume1.DisplayResumeDetails();

    }                                                                                                                                                                          
    
}