using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Hoopla Software";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2015;
        job1._endYear = 2020;       

        Job job2 = new Job();
        job2._company = "Barnacles Development";
        job2._jobTitle = "Lead Software Engineer";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "Jared Dolinar";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}