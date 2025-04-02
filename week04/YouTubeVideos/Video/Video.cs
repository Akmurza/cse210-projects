using System.Transactions;

namespace Proj;

public class Video
    {
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments;

public Video(string title, string author, int duration,   List<Comment> comments) {
    _title = title;
    _author = author;
    _duration = duration;
    _comments = comments;
}
    public int GetNumberOfComments() => _comments.Count;
    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetDuration() => _duration;
    public List<Comment> GetComments() => _comments;
    }
