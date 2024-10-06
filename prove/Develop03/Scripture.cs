

public class Scripture
{

    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // visible words arrays
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList(); // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-8.0

        // quantity to hide by counting minimum of visible words
        numberToHide = Math.Min(numberToHide, visibleWords.Count);


        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }

    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - " + 
            string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }


}