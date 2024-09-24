using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

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

        //You use double when the number can be a decimal value, rather than just an integer
        double average = count > 0 ? (double)sum / count: 0;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average number is: {average}");
        Console.WriteLine($"The largest number is: {maxValue}");
    }
}