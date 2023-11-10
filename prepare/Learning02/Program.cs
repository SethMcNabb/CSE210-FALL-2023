using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Project Manager";
        job1._company = "Conservice";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Facebook";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Gary Clark";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}