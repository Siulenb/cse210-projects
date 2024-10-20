


public class ListingActivity : Activity
{


    // private int _count;

    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }

    public void Run()
    {
        StartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();

        List<string> userItems = GetListFromUser();
        Console.WriteLine($"You listed {userItems.Count} items.");
        EndingMessage();


    }

    public void GetRandomPrompt()
    {
        var random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"--{prompt}--");
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.Write($"You may begin in:");
        ShowCountDown(3);
        while (DateTime.Now < endTime)
        {
            
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }
        return items;
    }






}