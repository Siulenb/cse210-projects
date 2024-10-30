

public class StationaryBicycle : Exercise
{
    private double _speed;

    public StationaryBicycle(DateTime date, int minutes, double speed) : base( date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60; 
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        
        
        return GetMinutes() / _speed; 
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Stationary bike ({GetMinutes()} min) - " +
               $"Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }




}