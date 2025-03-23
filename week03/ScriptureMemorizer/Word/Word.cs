namespace MyProj;


class Word{
    public static string NewWord(){
        string _editedText=Scripture.MakeScriptures();
        string[] _wordsArray = _editedText.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in _wordsArray)
        {
            Console.WriteLine(word); 
        }
        Random random =new Random();
        int _randomIndexToChange = random.Next(_wordsArray.Length);
        string _randomWord=_wordsArray[_randomIndexToChange];
        if(_randomWord.Contains("_")){

        }
        char[]changedWord = new char[_randomWord.Length];
        for(int i=0; i< _randomWord.Length;i++)
        {    
            changedWord[i]='_';

        }
        string resultWord=new string(changedWord);
        string newText = _editedText.Replace(_randomWord,resultWord);
        return newText;
    }
}