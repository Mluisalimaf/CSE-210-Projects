using System;
using System.Reflection.Metadata;

public class Track
{
    private List<Video> _videos;

    public Track()
    {
        _videos = new List<Video>();
    } 

    public void AddVideo (Video video)
    {
        _videos.Add(video);
    }

    public void AddCommentToVideo(int videoIndex, string user, string userComment)
    {
        if (videoIndex >= 0 && videoIndex <_videos.Count)
        {
            _videos[videoIndex].AddComment(user, userComment);
        }
        else
        {
            throw new ArgumentOutOfRangeException("Video is out of range");
        }
    }

    public void DisplayVideosAndComments()
    {
        foreach (var video in _videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Durantion: {video.Seconds} seconds.");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Commented by {comment.User}: {comment.UserComment}");
            }
            Console.WriteLine();
        }

    }
        
    
}
