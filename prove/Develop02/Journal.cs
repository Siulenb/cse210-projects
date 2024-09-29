using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry>_entries = new List<Entry>(); 


    public void AddEntry(Entry anEntry)
    {
        // Class method to add entries
        _entries.Add(anEntry);
    }

    public void DisplayAll()
    {
       // Class method to display all entries entered while the program still running.
       foreach (Entry line in _entries)
       {
        Console.WriteLine($"Date: {line._date} - Prompt: {line._promptText}\r\n{line._entryText}");
       }
    }

    public void SaveToFile(string file)
    {
        // Class Method to save all entries into txt file.
        using (StreamWriter outputFile = new StreamWriter (file, true))
        {   
            
            foreach (Entry info in _entries)
            {
                outputFile.WriteLine($"Date: {info._date} - Prompt: {info._promptText} {info._entryText}");
            }
            
            
        }
    }

    public void LoadFromFile(string file)
    {
        // Class method that verify the file exist in the directory and load to iterate a txt file.
        if (!File.Exists(file))
        {
            Console.WriteLine($"File exists: {File.Exists(file)}");
        }
        else
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}