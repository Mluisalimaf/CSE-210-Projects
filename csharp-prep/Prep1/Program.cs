using System;

class Program
{
    static void Main(string[] args)
    {  
        //Ask a user for their name and display it like the famous James Bond phrase
        Console.WriteLine("What is your fist name?");
        string first = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}