using System;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random;

    public Listing(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = new List<string>();
        _count = 0;
        _random = new Random();
    } 

    public string GetRandom()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public override void Run()
    {
        DisplayFirstMessage();

        string prompt = GetRandom();
        Console.WriteLine(prompt); 

        Countdown(5);

        List<string> userResponses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Start listing items:");

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                userResponses.Add(response);
                _count++;
            }
        }

    }

    public void GetListUser(List<string> userResponse, int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration); 

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                userResponse.Add(response);
                _count++;
            }
        }

        Console.WriteLine($"You listed {_count} items.");
        DisplayFinalMessage();
    }
}