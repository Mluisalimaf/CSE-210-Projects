using System;

class Program
{
    static void Main(string[] args)
    {
        //Set the member variables using the dot notation
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer Intern";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Maria Luisa";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}