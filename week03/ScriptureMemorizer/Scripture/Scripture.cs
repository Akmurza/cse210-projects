using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyProj;


     public class Scripture
{
          private Reference _reference;
         private List<Word> _words;

         public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

            //break down the text to words and make it as Word objects
            string[] wordArray = text.Split(' ');
            foreach (string wordText in wordArray)
            {
            Word word = new Word(wordText);
            _words.Add(word);
             }
    }





    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;
        // Continue hiding words till hidden is requested number
            //until all words will be hidden
        while (wordsHidden < numberToHide && !AllWordsHidden())
        {
            int randomIndex = random.Next(0, _words.Count);
            // hide the word if it isnt hidden
            if (!_words[randomIndex].IsHidden())
            {
            _words[randomIndex].Hide();
            wordsHidden++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            return false;
            
        }
            return true;
    }
    

                public string GetDisplayText()
    {
               string displayText = _reference.ToString() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetRenderedText() + " ";}
        return displayText.Trim();
    }
}