





public class BreathingActivity : Activity
{


    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartingMessage();
        Console.WriteLine();
        int totalTime = _duration;
        int breathCycleTime = totalTime/4;

        while (totalTime > 0)
        {
            Console.WriteLine($"Breathe in");
            ShowCountDown(breathCycleTime);
            Console.WriteLine("Breathe out");
            ShowCountDown(breathCycleTime);

            totalTime -= (breathCycleTime *2);
        }

        EndingMessage();

    }






}