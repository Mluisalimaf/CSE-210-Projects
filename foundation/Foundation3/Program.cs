using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(95, DateTime.Now, 5.0));
        activities.Add(new Cycling(42, DateTime.Now, 2.0));
        activities.Add(new Swimming(38, DateTime.Now, 8));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}