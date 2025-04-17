using System;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();

        // Video 1
        Video video1 = new("How to Bake Homemade Bread", "Maria the Baker", 300);
        video1.AddComment(new Comment("John", "Very helpful, thank you!"));
        video1.AddComment(new Comment("Anna", "I tried it and it turned out great!"));
        video1.AddComment(new Comment("Carlos", "You saved my breakfast!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new("Top 5 Travel Spots in Brazil", "Explore the World", 600);
        video2.AddComment(new Comment("Luke", "Been to 2 of these—amazing!"));
        video2.AddComment(new Comment("Marina", "Loved the suggestions."));
        video2.AddComment(new Comment("Paula", "Added to my travel list."));
        videos.Add(video2);

        // Video 3
        Video video3 = new("Learn C# in 10 Minutes", "Code Master", 580);
        video3.AddComment(new Comment("Philip", "Very straight to the point!"));
        video3.AddComment(new Comment("Julia", "Liked the hands-on example."));
        video3.AddComment(new Comment("Roberta", "Please do one for Java too!"));
        videos.Add(video3);

        // Display all video info
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
