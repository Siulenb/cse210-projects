


public abstract class Exercise
{

    private DateTime _date;
    private int _minutes;

    public Exercise(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;

    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM YYYY")}: {_minutes} min";
    }
    





}