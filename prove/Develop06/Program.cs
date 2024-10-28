using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        //bool running = true;
        bool exit = false;

        //while (running)
        while (!exit)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1- Create New Goal");
            Console.WriteLine("2- List Goals");
            Console.WriteLine("3- Save Goals");
            Console.WriteLine("4- Load Goals");
            Console.WriteLine("5- Record Event");
            Console.WriteLine("6- Quit");
            Console.Write("Choose an option (1-6): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;

               case "2":
                    goalManager.ListGoalDetails();
                    break;

                case "3":
                    goalManager.SaveGoals();
                    /*Console.Write("Enter the name of the file to save your goals: ");
                    string saveFile = Console.ReadLine();
                    goalManager.SaveGoals(saveFile);
                    Console.WriteLine("Goals saved!");*/
                    break;

                case "4":
                    goalManager.LoadGoals();
                    /*Console.Write("Enter the name of the file to save your goals: ");
                    string loadFile = Console.ReadLine();
                    goalManager.LoadGoals(loadFile);
                    Console.WriteLine("Goals loaded!");*/
                    break;

                case "5":
                    goalManager.RecordEvent();
                    break;

                case "6":
                    exit = true;
                    //running = false;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalide choice, please, choose an number betweeen 1 and 4.");
                    continue;
            }
        
        
        
        
        
            /*// Save the goals in a file
            goalManager.SaveGoals("goals.txt");

            // Load the goals from a file
            goalManager.LoadGoals("goals.txt");*/
    
        }
    }
}