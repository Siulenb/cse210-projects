


public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // Class to hold the entries data for Journal class

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\r\n{_entryText}");
    }
}