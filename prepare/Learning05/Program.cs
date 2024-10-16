using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Homework!\n");

        Assignment assignment1 = new Assignment("Carlos", "La Vida es Bella");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Luis Navarro", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());


        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());











    }
}