using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;

        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (_isComplete == true)
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetStringRepresentation()},{_isComplete}";
    }
}