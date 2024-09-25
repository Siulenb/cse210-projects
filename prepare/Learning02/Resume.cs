
using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _name;
    public List<Jobs> _jobs = new List<Jobs>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        foreach (Jobs job in _jobs)
        {
            job.Display();
        }
    }

}