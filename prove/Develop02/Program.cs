using System;
using System.Collections.Generic;
using System.IO;

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

       Console.WriteLine("Welcome to your journal program!");

        bool quit = false;

       string todayDate = GetDateTime();

    //    Classes listed

    //    Entry anEntry = new Entry();

       PromptGenerator getPrompt = new PromptGenerator();

       Journal theJournal = new Journal();

       while (quit != true)
       {

            DisplayMessage();
            // if statement to trigger the option
            int optionNumber = SelectedNumber();

            // test program:
            // PromptGenerator getPrompt = new PromptGenerator();
            // getPrompt._prompts = listOfPrompts;
            // string prompt = getPrompt.GetRandomPrompt();
            // Console.WriteLine($"Random prompt: {prompt}");
            // string answer = Console.ReadLine();

            // Entry anEntry = new Entry();
            // anEntry._date = todayDate;
            // anEntry._promptText = prompt;
            // anEntry._entryText = answer;
            // anEntry.Display();
            
            // Journal theJournal = new Journal();
            // theJournal.AddEntry(anEntry);
            // theJournal.DisplayAll();
            // theJournal.SaveToFile("ListOfEntries.txt");
            // theJournal.LoadFromFile("ListOfEntries.txt");

            if (optionNumber == 1)
            {
                // PromptGenerator getPrompt = new PromptGenerator();
                getPrompt._prompts = listOfPrompts;
                string prompt = getPrompt.GetRandomPrompt();
                Console.WriteLine($"Random prompt: {prompt}");
                string answer = Console.ReadLine();

                Entry anEntry = new Entry();
                anEntry._date = todayDate;
                anEntry._promptText = prompt;
                anEntry._entryText = answer;
                // anEntry.Display();

                theJournal.AddEntry(anEntry);
                
            }
            else if (optionNumber == 2)
            {
                theJournal.DisplayAll();
            }
            else if (optionNumber == 3)
            {
                theJournal.LoadFromFile("ListOfEntries.txt");
            }
            else if (optionNumber == 4)
            {
                theJournal.SaveToFile("ListOfEntries.txt");
            }
            else if (optionNumber == 5)
            {
                quit = true;
            }

       }

    }

    public static string GetDateTime()
    {
        DateTime todayDate = DateTime.Today;
        string date = todayDate.ToString("d");
        
        return date;
    }


    public static void DisplayMessage()
    {
        
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Write\r\n2. Display\r\n3. Load\r\n4. Save\r\n5. Quit");

    }

     public static int SelectedNumber()
    {
        Console.Write("What would you like to do? (type the number) ");
        int optionNumber = int.Parse(Console.ReadLine());

        return optionNumber;
    }




}