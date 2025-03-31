using System.Diagnostics.Contracts;
using System.Globalization;
namespace MyProj;


public class Word
{
private string _text;//our text to recieve
private bool _isHidden; //hidden flag
public Word(string text)//class constructor
{
    _text = text;
    _isHidden = false;
}
public void Hide(bool revealOneLetter)
{
    _isHidden = true;
    if( revealOneLetter && _text.Length>0)
    {
       Random random = new Random();
       RevealedLetterIndex= random.Next(0,_text.Length);
    }
    else
    {
       RevealedLetterIndex= -1;
        
    }
}
public bool IsHidden()
{
    return _isHidden;
}

public int RevealedLetterIndex{get; set;}=-1;
public string GetRenderedText(bool revealOneLetter)//getter
{
    if (_isHidden)
    {
        if(revealOneLetter && RevealedLetterIndex !=-1)
        {
        char[] newArray = new char [_text.Length];
        for(int i=0; i<newArray.Length;i++)
        {
            newArray[i]='_';
        }

        newArray[RevealedLetterIndex]=_text[RevealedLetterIndex];
        // it is return _ = number of letters in the word
        return new string(newArray);//makes string of __ which equal length of word
        }
        else{
            return new string('_',_text.Length);

        }
    }
    else
        return _text;
    }
public override string ToString()
{
    return GetRenderedText(false);
}
}