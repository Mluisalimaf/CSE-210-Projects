using System;

class Program
{
    static void Main(string[] args)
    {
        //there are two ways of creating this code:
        //the first one using lists:

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        
        int enterNumber = -1;
        while (enterNumber != 0)
        {
            Console.Write("Enter a number: ");
            
            string answer = Console.ReadLine();
            enterNumber = int.Parse(answer);
            
            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        double average = ((double)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxValue = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }

        Console.WriteLine($"The largest number is: {maxValue}");

        //the second one using just do-while loops:

        /*Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //put the variables you need
        int enterNumber;
        int sum = 0;
        int count = 0; 
        int maxValue = int.MinValue;

        //now do the loops
        do
        {
            Console.Write("Enter number: ");
            enterNumber = int.Parse(Console.ReadLine());

            if (enterNumber != 0)
            {
                sum += enterNumber;
                count++;

                if (enterNumber > maxValue)
                {
                    maxValue = enterNumber;
                } 
            }    
        }while(enterNumber != 0);

        /*You use double when the number can be a decimal value, 
        rather than just an integer.
        The ternary operator (? :) is used here: if count > 0, 
        the average is the sum divided by the number of entries; 
        otherwise, the average is 0*
        double average = count > 0 ? (double)sum / count: 0;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average number is: {average}");
        Console.WriteLine($"The largest number is: {maxValue}");*/
    }
}