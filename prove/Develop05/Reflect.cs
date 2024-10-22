using System;
//using System.Runtime.CompilerServices;

public class Reflect : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflect(string name, string description) : base(name, description)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    public void Run() 
    {
        DisplayFirstMessage();

        DisplayPrompt();

        DisplayQuestions();

        //Countdown();

        DisplayFinalMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }

    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
        }
    }
}