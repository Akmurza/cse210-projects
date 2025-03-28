using System.Diagnostics.Contracts;

namespace MyProj;


public class Word
{


         private string _text;
         private bool _isHidden;

         public Word(string text)
           {
              _text = text;
             _isHidden = false;
            }

          public void Hide()
        {
            _isHidden = true;
        }

        public bool IsHidden()
        {
             return _isHidden;
        }

    public string GetRenderedText()
    {
        if (_isHidden)
        {
               // it is return _ = number of letters in the word
            return new string('_', _text.Length);
        }
        else
         return _text;
        
    }

    public override string ToString()
    {
        return GetRenderedText();
    }
}