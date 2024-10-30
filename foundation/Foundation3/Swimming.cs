


public class Swimming : Exercise
{
    private double _laps;

    public Swimming(DateTime date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; 
    }

    public override double GetPace()
    {
        
        return GetMinutes() / GetDistance(); 
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({GetMinutes()} min) - " +
               $"Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }







}