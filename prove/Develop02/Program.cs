using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        
        // the list of Prompt questions
        List<string> listOfPrompts = new List<string>
       {
        "What was the best part of my day? ",
        "Did something funny happen? ",
        "What was the impression from the Lord? ",
        "What miracles were you able to notice? ",
        "Did you learn something today? "
       };

       Console.WriteLine("Welcome to your journal program!");
       
       // Variable for the While loop.
       bool quit = false;

       // Today date variable run by the Method.
       string todayDate = GetDateTime();

        //    Classes listed
        //    Entry anEntry = new Entry();
       PromptGenerator getPrompt = new PromptGenerator();
       Journal theJournal = new Journal();

       while (quit != true)
       {

            // beginning test program:
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


            // Method that trigger Menu message.
            DisplayMessage();
            // Method that obtain the integer input from the user. 
            int optionNumber = SelectedNumber();


            // If statement that respond with the an integer enter to propmt the classes.
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
        // Method to obtain today date.
        DateTime todayDate = DateTime.Today;
        string date = todayDate.ToString("d");
        
        return date;
    }


    public static void DisplayMessage()
    {
        //Method to Display the menu option for the user to know what to select.
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Write\r\n2. Display\r\n3. Load\r\n4. Save\r\n5. Quit");

    }

     public static int SelectedNumber()
    {
        // Method input for user to select the menu by entering an interger
        Console.Write("What would you like to do? (type the number) ");
        int optionNumber = int.Parse(Console.ReadLine());

        return optionNumber;
    }




}