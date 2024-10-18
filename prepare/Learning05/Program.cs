using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment mathassig1 = new MathAssignment("Leonardo Perez", "Division", "7.3", "8-19");
        Console.WriteLine(mathassig1.GetSummary()); 
        Console.WriteLine(mathassig1.GetHomeworkList());

        WritingAssignment writ1 = new WritingAssignment(
            "Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writ1.GetSummary());
        Console.WriteLine(writ1.GetWritingInformation());

    }
}