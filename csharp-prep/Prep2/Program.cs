using System;

class Program
{
    static void Main(string[] args)
    {
        //create an a program that determines the letter grade for a course

        //start asking the grade percentage
        Console.WriteLine("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        /*scale:
        int grade >= 90;
        int grade >= 80;
        int grade >= 70;
        int grade >= 60;
        int grade < 60;*/

        //a series of if-elif-else statements to print 
        //out the appropriate letter grade:

        /*if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }*/

        //create a new variable called letter
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //determine the grade letter
        Console.WriteLine($"Your grade is: {letter}");

        //determine if the user passed the course
        if (grade >=70)
        {
            Console.WriteLine("Congratulations!! You passed this semester!");
        }
        else
        {
            Console.WriteLine("You didn't pass this semester, you can do better the next.");
        }
    }
}