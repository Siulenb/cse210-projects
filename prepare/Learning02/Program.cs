using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Jobs job1 = new Jobs();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2016;
        job1._endYear = 2020;
        // job1.Display();

        Jobs job2 = new Jobs();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2020;
        job2._endYear = 2025;
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Luis Navarro";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
        

        


    }
}                   