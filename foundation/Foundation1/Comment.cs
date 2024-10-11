using System;

public class Comment
{
    private string _user;
    private string _userComment;

    public Comment (string user, string userComment)
    {
        _user = user;
        _userComment = userComment;
    }

    public string User => _user;
    public string UserComment => _userComment;
}