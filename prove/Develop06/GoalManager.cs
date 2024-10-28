using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string fileName = "goals.txt";

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalDetails()
    {
        foreach (GoalManager goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    
    public void CreateGoal()
    {
        Console.WriteLine("Choose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the descrition of your goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points fot this goal: ");
        int points = Console.ReadLine();

        switch(choice)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                Console.WriteLine("Simple goal created.");
                break;
            
            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                Console.WriteLine("Eternal goal created.");
                break;

            case "3":
                Conosle.WriteLine("Enter the target number for the checklist: ");
                int target = int.Parse(Console.ReadLine());

                Conosle.WriteLine("Enter the bonus points for completing the goal: ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
                Console.WriteLine("Checklist goal created!");
                break;

            default:
                Console.WriteLine("Invalide choice. Try again.");
                break;

        }
    }

    public void RecordEvent()
    {}

    public void SaveGoals()
    {
        string fileName = "goals.txt";

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            // Save the points
            writer.WriteLine($"Score:{_score}");
            
            // Save each goal
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved to " + fileName);
    }

    public void LoadGoals()
    {
        string fileName = "goals.txt";

        _goals.Clear();
        _score = 0;

        if (File.Exists(fileName))
        {

            using (StreamReader reader = new StreamReader(fileName))
            {
                // Read the points
                string scoreLine = reader.ReadLine();
                if (scoreLine.StartsWith("Score:"))
                {
                    _score = int.Parse(scoreLine.Substring(6));
                }

                // Read each goal
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string goalType = parts[0];

                    if (goalType == "SimpleGoal")
                    {
                        var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        goal.IsComplete = bool.Parse(parts[4]);
                        _goals.Add(goal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        var goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                        _goals.Add(goal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                        goal.AmountCompleted = int.Parse(parts[6]);
                        _goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals loaded from " + fileName);
        }
        else
        {
            Console.WriteLine("No saved goals found to load.");
        }

    }

}