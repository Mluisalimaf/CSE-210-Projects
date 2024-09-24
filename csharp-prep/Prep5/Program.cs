using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
    }
    
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");

            string name = PromptUserName();
            int askingNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(askingNumber);

            DisplayResult(name, squaredNumber);
        }

        //PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        
        //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            return number * number;
        }
        
        //DisplayResult - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of you number is {squaredNumber}");
        }
        
}