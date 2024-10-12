


public class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments;


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        _comments = new List<Comment>();

    }

    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int TotalComments()
    {

        return _comments.Count;
    }

    public void Display()
    {
        
    
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {TotalComments()}");

        // Display each comment for the current video
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine(); // Add an empty line for spacing between videos
        


    }




}