using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");

        List<string> listOfPrompts = new List<string>
       {
        "What was the best part of my day? ",
        "Did something funny happen? ",
        "What was the impression from the Lord? ",
        "What miracles were you able to notice? ",
        "Did you learn something today? "
       };

       string todayDate = GetDateTime();

       PromptGenerator getPrompt = new PromptGenerator();
       getPrompt._prompts = listOfPrompts;
       string prompt = getPrompt.GetRandomPrompt();
       Console.WriteLine($"Random prompt: {prompt}");
       string answer = Console.ReadLine();

       Entry anEntry = new Entry();
       anEntry._date = todayDate;
       anEntry._promptText = prompt;
       anEntry._entryText = answer;
       anEntry.Display();
    
       Journal theJournal = new Journal();
       theJournal.AddEntry(anEntry);
       theJournal.DisplayAll();
    

    }

    public static string GetDateTime()
       {
            DateTime todayDate = DateTime.Today;
            string date = todayDate.ToString("d");
            
            return date;
        }
}