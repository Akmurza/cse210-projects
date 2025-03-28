namespace MyProj;

public class Reference
{
         private string _book;
         private int _chapter;
    
        private int _startVerse;
    
          private int _endVerse;

    //konstructor for one verse ref
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
    _chapter = chapter;
    _startVerse = verse;
    _endVerse = verse;
    }





    //constructor for a verse range ref 
    public Reference(string book,int chapter,int startVerse,  int endVerse)
    {
    _book =book;
    _chapter =chapter;
    _startVerse =startVerse;
    _endVerse =endVerse;
    }

    public override string ToString()
    {
      
      
             if (_startVerse == _endVerse)
             return $"{_book}.{_chapter}: {_startVerse}";
             else
             return $"{_book}.{_chapter}:{_startVerse}-{_endVerse}";
    }
}