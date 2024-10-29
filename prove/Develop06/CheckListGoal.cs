

public class CheckListGoal : Goal
{
    private int _amountCompleted;

    private int _target;

    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
       _amountCompleted++;
        int pointsEarned = _points;

        if (_amountCompleted >= _target)
        {
            pointsEarned += _bonus;
            Console.WriteLine($"Congratulations! You've completed the checklist goal '{_shortName}' and earned a bonus of {_bonus} points.");
        }
        Console.WriteLine($"Goal '{_shortName}' recorded! You gained {pointsEarned} points.");
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

   public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}