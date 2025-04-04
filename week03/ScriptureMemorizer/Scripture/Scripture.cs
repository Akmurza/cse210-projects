using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace MyProj;
public class Scripture
{
 private Reference _reference;
 private List<Word> _words; 
 public Scripture(Reference reference, string text)  //init constructor which recieve variable text which breaks it down to array of words and instance of class reference
{
    _reference = reference;
    _words = new List<Word>();
    //break down the text to words and make it as Word array
    string[] wordArray = text.Split(' ');
    foreach (string wordText in wordArray)
    {
        Word word = new Word(wordText);//instance of word class___!!!
        _words.Add(word);}
    }
    //hide function
    public void HideRandomWords(int numberToHide, bool revealOneLetter)//add one leter pole
    {
        Random random = new Random();
        int wordsHidden = 0;
        //Continue hiding words till hidden is't requested number or
        //until all words will be hidden
        while (wordsHidden < numberToHide && !AllWordsHidden())
        {
            int randomIndex = random.Next(0, _words.Count);
            // hide the word if it isnt hidden
            if (!_words[randomIndex].IsHidden())
            {
            _words[randomIndex].Hide(revealOneLetter);
            wordsHidden++;//just increments it and sycling again
            }
        }
    }

    public bool AllWordsHidden()//just checker of hideness
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            return false;
        }
        return true;
    }

    public string GetDisplayText(bool revealOneLetter)//get method which reply to private _reference. making text with hidden words
    {
        string displayText = _reference.ToString() + " ";
        foreach (Word word in _words)
        {
        displayText += word.GetRenderedText(revealOneLetter) + " ";}
        return displayText.Trim();//cleared 
    }
}