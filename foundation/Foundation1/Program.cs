using System;

class Program
{
    static void Main(string[] args)
    {
        Track track = new Track();

        Video video1 = new Video ("Learning C# 1", "J.Smith", 7200);
        Video video2 = new Video ("Learning C# 2", "J.Smith", 9350);
        Video video3 = new Video ("Learning C# 3", "J.Smith", 14400);
        Video video4 = new Video ("Learning C# 4", "J.Smith", 18650);
        Video video5 = new Video ("Learning C# 5", "J.Smith", 23456);


        track.AddVideo(video1);
        track.AddVideo(video2);
        track.AddVideo(video3);
        track.AddVideo(video4);
        track.AddVideo(video5);

        track.AddCommentToVideo(0, "userTom&Jerry", "Wow, great video!");
        track.AddCommentToVideo(1, "ErenYaeger149", "Oh, gosh! Its cool, but so confusing!");
        track.AddCommentToVideo(2, "Ben10", "My dad works with it, my mommy says that its for crazy people");
        track.AddCommentToVideo(3, "CarltonClapton", "Great! I finally understanded how to use Abstraction and Encapsulation! Thanks a lot man!");
        track.AddCommentToVideo(4, "JoaneSkinner", "Wait, so this is how we use instancies?!");

        track.DisplayVideosAndComments();

    }
}