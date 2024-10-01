using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fraction program");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);


       // Setter and Getter 

       int defaultFraction = fraction1.GetTop()/fraction1.GetBottom();
       int wholeNumber = fraction2.GetTop()/fraction2.GetBottom();
       int fraction = fraction3.GetTop()/fraction3.GetBottom();

       Console.WriteLine($"{fraction1.GetTop()}/{fraction1.GetBottom()}");
       Console.WriteLine(defaultFraction);
       Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()}");
       Console.WriteLine(wholeNumber);
       Console.WriteLine($"{fraction3.GetTop()}/{fraction3.GetBottom()}");
       Console.WriteLine(fraction);

       
       Console.WriteLine(""); // Setter and Getter end...

       // method with the correct design
        
       Console.WriteLine(fraction1.GetFractionString());
       Console.WriteLine(fraction1.GetDecimalValue());

       Console.WriteLine(fraction2.GetFractionString());
       Console.WriteLine(fraction2.GetDecimalValue());

       Console.WriteLine(fraction3.GetFractionString());
       Console.WriteLine(fraction3.GetDecimalValue());

       Console.WriteLine(fraction4.GetFractionString());
       Console.WriteLine(fraction4.GetDecimalValue());
    }
}