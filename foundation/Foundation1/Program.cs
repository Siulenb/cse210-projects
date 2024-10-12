using System;

class Program
{
    static void Main(string[] args)
    {
        // string title = "";
        
        // Create a list to store videos
        List<Video> videos = new List<Video>();
        
        // Some videos
        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        Video video2 = new Video("Cooking Pasta", "Jane Smith", 900);
        Video video3 = new Video("Travel Vlog", "Travel with Tom", 1200);

        video1.AddComments(new Comment("Alice", "I learned a lot thanks"));
        video1.AddComments(new Comment("Thomas", "Great video"));
        video1.AddComments(new Comment("Carlos", "Keep doing please"));

        video2.AddComments(new Comment("Maria", "What do you do when you overcook the pasta?"));
        video2.AddComments(new Comment("Gary", "So delicous recipe"));
        video2.AddComments(new Comment("Hank", "it is easy to make"));

        video3.AddComments(new Comment("Isabella", "So funny the video"));
        video3.AddComments(new Comment("Tommy", "what a beautiful place"));
        video3.AddComments(new Comment("Jerry", "what tips do you have for visiting in November?"));

        // Add video to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.Display();
        }
    }
      
}