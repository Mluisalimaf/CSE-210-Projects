using System;
using System.Threading.Tasks;

public class Breathing : Activity
{
    public Breathing(string name, string description) : base(name, description)
    {

    }


    public async Task Run() //override async Task
    {
        Console.WriteLine("This activity need, at least, 12 seconds.");
        
        DisplayFirstMessage();

        Console.WriteLine("Let's take a moment to focus on your breathing.");
        Console.WriteLine("Get ready");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            await Task.Delay(4000); 

            Console.WriteLine("Hold...");
            await Task.Delay(4000); 

            Console.WriteLine("Breathe out...");
            await Task.Delay(4000); 
        }

        DisplayFinalMessage();
    }
}