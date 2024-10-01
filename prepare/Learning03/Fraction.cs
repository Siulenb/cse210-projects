

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    
    public int SetTop(int top)
    {
        _top = top;
        return top;
    }
    public int GetBottom()
    {
       return _bottom;
    }

    public int GetBottom(int bottom)
    {
        _bottom = bottom;
        return bottom;
    }

    public string GetFractionString()
    {
        string textFraction = $"{_top}/{_bottom}";
        return textFraction;
    }

    public double GetDecimalValue()
    {
        double fractionResult = (double)_top/(double)_bottom;
        return fractionResult;
    }




}