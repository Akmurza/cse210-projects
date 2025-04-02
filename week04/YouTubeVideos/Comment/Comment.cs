namespace Proj;

 public class Comment
    {
 private string _commentAuthor;
 private string _commentText;

public Comment(string author, string text)
 {
   _commentAuthor = author;
  _commentText = text;
 }

    public string GetCommentAuthor() => _commentAuthor;
    public string GetCommentText() => _commentText;
    }