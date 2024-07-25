using System;

public class Comment(string personName, string commentText)
{
    public string _personName { get; set; } = personName;
    public string _commentText { get; set; } = commentText;

    public override string ToString()
    {
        return $"{_personName}: {_commentText}";
    }
}