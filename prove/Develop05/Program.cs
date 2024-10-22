using System;

class Program
{
    static async void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1- Breathing Activity");
            Console.WriteLine("2- Listing Activity");
            Console.WriteLine("3- Reflection Activity: ");
            Console.WriteLine("4- Quit");
            Console.Write("Choose an option (1-4): ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    break;

               case "2":
                    List<string> listingPrompts = new List<string>
                    {
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"
                    };

                    activity = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listingPrompts);
                    break;

                case "3":

                    List<string> reflectPrompts = new List<string>
                    {
                        "Think of a time when you stood up for yourself.",
                        "Think of a time when you overcame a difficult challenge.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something really difficult."
                    };

                    List<string> reflectQuestions = new List<string>
                    {
                        "Why was this experience meaningful to you?",
                        "How did you feel during that experience?",
                        "What did you learn from the experience?",
                        "How can you apply what you learned to future situations?"
                    };

                    activity = new Reflect("Reflect", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    break;

                case "4":
                    Console.WriteLine("Finishing the program. Byee!");
                    return;

                default:
                    Console.WriteLine("Invalide choice, please, choose an number betweeen 1 and 4.");
                    continue;
            }

            Console.Write("Enter the duration (in seconds): ");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                activity.SetDuration(duration);
                activity.Run();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        
        }
    }
}