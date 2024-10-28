using System;
using System.IO;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"{_name} - {_description}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"Goal|{_name}|{_description}|{_points}";
    }

}