using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1.title="Harry Potter Lore";
        v1.author="Haggrid_99";
        v1.length=25;

        Video v2 = new Video();
        v2.title="Destiny Lore";
        v2.author="xur";
        v2.length=12;

        Video v3 = new Video();
        v3.title="C# Essentials";
        v3.author="hello_world";
        v3.length=18;

        v1.comments.Add(new Comment { userName = "giraffe_turtle", userComment = "Cool video!" });
        v1.comments.Add(new Comment { userName = "coolguy72", userComment = "Great video, I love the intro" });
        v1.comments.Add(new Comment { userName = "acioacio", userComment = "This is very incorrect" });

        v2.comments.Add(new Comment { userName = "DestinyFan4ever", userComment = "I love this video!" });
        v2.comments.Add(new Comment { userName = "GameMasterZ", userComment = "How did you unlock that?" });
        v2.comments.Add(new Comment { userName = "MinimalGames", userComment = "Cant wait for season 12" });

        v3.comments.Add(new Comment { userName = "Yeahbuddy", userComment = "How can I learn instantly in 1 minute!?" });
        v3.comments.Add(new Comment { userName = "User1896513541", userComment = "I don't get it!" });
        v3.comments.Add(new Comment { userName = "Josh Doe", userComment = "Very helpful!" }); 
    
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.title}");
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Length: {video.length} seconds");
            Console.WriteLine($"Number of Comments: {video.CommentCount()}");

            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"Comment by {comment.userName}: {comment.userComment}");
            }
        }
    }
}