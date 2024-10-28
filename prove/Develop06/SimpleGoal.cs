using System;
using System.IO;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        //_isComplete = true;
        if (!_isComplete)
        {
            _isComplete = true; // Mark as complete
            Console.WriteLine("Simple goal completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{_name}: {_description}, Points: {_points}, Complete: {_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }

}