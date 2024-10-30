

public class Running : Exercise
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance/GetMinutes())*60;
    }

    public override double GetPace() => (GetMinutes()/GetDistance());

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Running ({GetMinutes()} min) - " +
               $"Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }



}