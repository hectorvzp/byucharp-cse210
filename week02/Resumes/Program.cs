using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._company = "TechMahindra";
        job1._jobTitle = "Programador";
        job1._starYear = 2023;
        job1._endYear = 2025;

        Jobs job2 = new Jobs();
        job2._company = "Cognizant";
        job2._jobTitle = "Programador";
        job2._starYear = 2025;
        job2._endYear = 2035;

        Resume myResume = new Resume();
        myResume._owner = "Hector Zambrano";
        myResume._myJobs.Add(job1);
        myResume._myJobs.Add(job2);
        myResume.DisplayResume();


    }
}