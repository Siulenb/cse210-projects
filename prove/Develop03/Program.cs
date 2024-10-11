using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
         // Variable
        string book = "";
        int chapter = 0;
        int verse = 0;
        int endVerse = 0;
        string continueLoop = "";
        string text = "";
        
        Console.WriteLine("Memorizer Scripture\r\n");

        // The program allow to enter scripture expression and you can enter run an example:
        Console.WriteLine("Enter the book expression that you want to memorize, for example: Proverbs 3:5-6 \r\nOr click enter to run an exameple:");
        string bookInput = Console.ReadLine();

        // if statement to check null to run default scripture
        if (string.IsNullOrEmpty(bookInput))
        {
            bookInput = "Proverbs 3:5-6"; // Default if the user doesn't enter anything.
            Console.WriteLine("Using default scripture name: " + bookInput);

            text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."; 
            Console.WriteLine("Using default verse(s): " + text);
        }
        else
        {
            // Enter scripture text of all verses that you want to memorize.
            Console.WriteLine("Enter all verses text here:");
            text = Console.ReadLine();
        }
        
        

        // Patter of Proverbs 3:5-6
        string pattern = @"(\d*\s*[A-za-z\s]+)\s(\d+):(\d+)(?:-(\d+))?";

        Match match = Regex.Match(bookInput, pattern);

        
        if (match.Success)
        {
            // Extract the matched groups
            book = match.Groups[1].Value.Trim();         //2 Nefi or Proverbs
            chapter = int.Parse(match.Groups[2].Value); // 3
            verse = int.Parse(match.Groups[3].Value); // 5

            // Check if there's an end verse (Group[4]) or not
            if (match.Groups[4].Success)
            {
                endVerse = int.Parse(match.Groups[4].Value);  // End verse for ranges
                // Testing reference
                // Console.WriteLine("Book: " + book);
                // Console.WriteLine("Chapter: " + chapter);
                // Console.WriteLine("Start Verse: " + verse);
                // Console.WriteLine("End Verse: " + endVerse);
                Reference reference = new Reference(book, chapter, verse, endVerse);
                

                Scripture scripture = new Scripture(reference, text);

                // first text display
                Console.WriteLine(scripture.GetDisplayText());

                // // This will start  clearing #1
                continueLoop = EnterToContinue();

                while (continueLoop.ToLower() != "quit")
                {
                    
                    scripture.HideRandomWords(2);
                    Console.WriteLine(scripture.GetDisplayText());

                    // This will start  clearing over and unless user typed quit #2
                    continueLoop = EnterToContinue();

                    if(scripture.IsCompletelyHidden())
                    {
                        continueLoop = "quit";
                    }
                    // test hidden bool
                    // Console.WriteLine("Is completely hidden? " + scripture.IsCompletelyHidden());


                }

            }
            else
            {
                // Testing reference
                // No end verse, just a single verse
                // Console.WriteLine("Book: " + book);
                // Console.WriteLine("Chapter: " + chapter);
                // Console.WriteLine("Verse: " + verse);
                Reference reference = new Reference(book, chapter, verse);

                Scripture scripture = new Scripture(reference, text);

                // first text display
                Console.WriteLine(scripture.GetDisplayText());

                // This will start  clearing #1
                continueLoop = EnterToContinue();

                while (continueLoop.ToLower() != "quit")
                {
                    
                    scripture.HideRandomWords(2);
                    Console.WriteLine(scripture.GetDisplayText());

                    // This will start  clearing over and unless user typed quit #2
                    continueLoop = EnterToContinue();

                    if(scripture.IsCompletelyHidden())
                    {
                        continueLoop = "quit";
                    }
                    // test hidden bool
                    // Console.WriteLine("Is completely hidden? " + scripture.IsCompletelyHidden());


                }

                // End Message
                Console.WriteLine("Thank You");

            }
        }
        else
        {
            Console.WriteLine("Invalid input format.");
        }


        
        
    }

    public static string EnterToContinue()
    {
        Console.WriteLine("Press enter to continue or type \"quit\" to finish:");
        string continueLoop = Console.ReadLine();

        Console.Clear();

        return continueLoop;

    }
        



        

}