using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    private string _title; 
    private string _author;
    private int _seconds;
    public List<Comment> Comments { get; set;}


    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
        Comments = new List<Comment>();
    }

    public string Title
    {
        get { return _title;}
        set
        {
            if(!string.IsNullOrWhiteSpace(value))
            {
                _title = value;
            }
            else
            {
                throw new ArgumentException("Title cannot be null or whitespace.");
            }
        }
    }

    public string Author
    {
        get { return _author;}
        set
        {
            if(!string.IsNullOrWhiteSpace(value))
            {
                _author = value;
            }
        }
    }

    public int Seconds
    {
        get {return _seconds;}
        set
        {
            if (value >= 0)
            {
                _seconds = value;
            }
        }
    }

    public void AddComment(string user, string userComment)
    {
        Comments.Add(new Comment(user, userComment)); // Adiciona um novo comentário à lista
    }

}