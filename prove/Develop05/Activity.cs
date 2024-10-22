using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayFirstMessage()
    {
        Console.WriteLine($"Starting the {_name} Activity.");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready!");
    }

    public void DisplayFinalMessage()
    {
        Console.WriteLine("Great job!");
    }

    public void Spinner(int duration)
    {

        // _|-|_|-|
        List<string> animationStrings = new List<string>();
        animationStrings.Add("_");
        animationStrings.Add("|");
        animationStrings.Add("-");
        animationStrings.Add("|");
        animationStrings.Add("_");
        animationStrings.Add("|");
        animationStrings.Add("-");
        animationStrings.Add("|");
        animationStrings.Add("_");
        animationStrings.Add("|");

        //DateTime startTime = DateTime.Now;
        //DateTime endTime = startTime.AddSeconds();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i % animationStrings.Count];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            /*if (i >= animationStrings.Count)
            {
                i = 0;
            }*/
        }
        
        Console.WriteLine("Done");
    }

    public void Countdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b  \b");
        }

        Console.WriteLine("0");
    }
}