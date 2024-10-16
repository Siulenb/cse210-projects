


public class MathAssignment : Assignment
{
    
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSecton, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSecton;
        _problems = problems;
    }
    
    public string GetHomeworkList()
    {
        return $"{GetSummary()}\n{_textBookSection} {_problems}";
    }



}