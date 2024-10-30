using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!\nExercise time!");

        DateTime today = DateTime.Now;

        List<Exercise> activities = new List<Exercise>
        {
            new Running(new DateTime(today.Year, today.Month, today.Day), 30, 4.8), // 37 minutes, 5km
            new StationaryBicycle(new DateTime(today.Year, today.Month, today.Day), 30, 80), // 30 minutes, 80 RPM
            new Swimming(new DateTime(today.Year, today.Month, today.Day), 60, 25) // 60 minutes, 25 laps

        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}