


public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // public void SetDuration(int duration)
    // {

    // }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
           Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b/");
            Thread.Sleep(500);
            Console.Write("\b-");
            Thread.Sleep(500);
            Console.Write("\b\\");
            Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\b...{i}");
            System.Threading.Thread.Sleep(1000);  // Pause for 1 second
        }
        Console.WriteLine();  // Move to the next line after countdown
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Get ready...");
        ShowSpinner(3);
    }

    public void EndingMessage()
    {
        Console.WriteLine($"Well done! by completing the {_name} activity in {_duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine();
    }















}