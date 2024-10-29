


public class GoalManager
{
    public List<Goal> _goals;
    public int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Main program loop
        string input;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        } while (input != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    private void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            if (goal is CheckListGoal checklistGoal)
            {
                Console.WriteLine($" -- Currently completed: {checklistGoal.GetDetailsString()}");
            }
        }
    }

    public void ListGoals()
    {
        ListGoalNames();
        DisplayPlayerInfo();
    }

    public void CreateGoal()
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());

        Goal goal = null;
        if (choice == 1)
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (choice == 2)
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (choice == 3)
        {
            Console.Write("Enter the target number of completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points for completing the goal: ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new CheckListGoal(name, description, points, target, bonus);
        }

        if (goal != null)
        {
            _goals.Add(goal);
            Console.WriteLine("Goal created successfully.");
        }
    }

        // RecordEvent - Asks the user which goal they have done and records the event.
    public void RecordEvent()
    {
        Console.WriteLine("Which goal have you completed? (Enter goal number):");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int choice = int.Parse(Console.ReadLine());
        if (choice > 0 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent(); // Call RecordEvent without expecting points to be returned
            

            Console.WriteLine($"Event recorded for goal {selectedGoal.GetDetailsString()}. Current score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score); // Save the score at the top
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation()); // Save the string representation of each goal
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
       if (File.Exists("goals.txt"))
        {
            _goals.Clear(); // Clear current goals before loading new ones
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine()); // Load the score
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(','); // Split by comma
                    string type = parts[0]; // Get the type of the goal (SimpleGoal, EternalGoal, ChecklistGoal)
                    string shortName = parts[1]; // Goal short name
                    string description = parts[2]; // Goal description
                    int points = int.Parse(parts[3]); // Points value

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]); // Load completion status
                            var simpleGoal = new SimpleGoal(shortName, description, points);
                            if (isComplete)
                            {
                                simpleGoal.RecordEvent(); // Mark the goal as complete if it was marked
                            }
                            _goals.Add(simpleGoal);
                            break;

                        case "EternalGoal":
                            _goals.Add(new EternalGoal(shortName, description, points));
                            break;

                        case "ChecklistGoal":
                            int amountCompleted = int.Parse(parts[4]); // Amount completed
                            int target = int.Parse(parts[5]); // Target completions
                            int bonus = int.Parse(parts[6]); // Bonus points
                            var checklistGoal = new CheckListGoal(shortName, description, points, target, bonus);
                            for (int i = 0; i < amountCompleted; i++)
                            {
                                checklistGoal.RecordEvent(); // Mark progress of the checklist goal
                            }
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
        
    }



}