using System;
using System.IO;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Checklist goal progress updated: {_amountCompleted}/{_target}");

        /*if (_amountCompleted >= _target)
        {
            Console.WriteLine("Checklist goal completed! Bonus points awarded.");
        }*/
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_name}: {_description}, Points: {_points}, Target: {_target}, Bonus: {_bonus}, Completed: {_amountCompleted}/{_target}";

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_name}, Progress: {_amountCompleted}/{_target}, Bonus: {_bonus}";
       // return $"ChecklistGoal|{_name}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}