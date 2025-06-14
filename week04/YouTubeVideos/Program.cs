using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook milenasas", "Chef Jose", 420);
        video1.addComments(new Comment("Alice", "Looks delicious!"));
        video1.addComments(new Comment("Bob", "I tried it and loved it."));

        Video video2 = new Video("Crossfit for beginner", "The man", 560);
        video2.addComments(new Comment("Dave", "Very helpful, thanks!"));
        video2.addComments(new Comment("Eve", "What can I do if I want to be an expert?"));
        video2.addComments(new Comment("Frank", "I did my first pull up!"));

        Video video3 = new Video("Travel Vlog: Montevideo - Uruguay", "Alan", 780);
        video3.addComments(new Comment("Grace", "Amazing views!"));
        video3.addComments(new Comment("Heidi", "I want to go to Montevideo now."));
        video3.addComments(new Comment("Ivan", "Nice editing style!"));

        Video video4 = new Video("Top 10 Coding Tips", "DevMaster", 300);
        video4.addComments(new Comment("Judith", "Great explanation."));
        video4.addComments(new Comment("Valentino", "Love the clear explanations."));
        video4.addComments(new Comment("Sandra", "I want to learn Python"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}