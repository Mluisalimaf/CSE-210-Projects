using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2° Néfi", 31, 16);
        
        Scripture scripture = new Scripture(reference, "And now, my beloved brethren, I know by this that unless a man shall endure to the end, in following the example of the Son of the living God, he cannot be saved");

        while(true)
        {
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to continue or write 'quit' to finish:");
            string userInput = Console.ReadLine();

            if(userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if(scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Everything is hidden.");
                break;
            }

        }
    }
}