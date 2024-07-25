using System;

public class Video(string title, string author, int length)
{
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;
    public int Length { get; set; } = length;
    private readonly List<Comment> comments = [];

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }

    public override string ToString()
    {
        string videoComments = string.Join("\n", comments);
        return $"Title: {Title}\nAuthor: {Author}\nlength: {Length} seconds\nComment Count: {NumberOfComments()}\nComments:\n{videoComments}\n";
    }
}