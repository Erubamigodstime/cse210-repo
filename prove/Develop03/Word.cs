using System;

public class Word
{
   
    private bool _hidden;
    private string _word;

    public Word(string word){
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public void GetRenderedText()
    {
        if(!_hidden && _word != null  )
        {
            Console.Write(_word);
        }
        else
        {
            foreach (char letter in _word)
            {
                Console.Write("_");
            }
        }
        //IF word is not hidden
        //  display the word (Console.Write(_word))
        //ELSE
        //  FOREACH char letter in _word
        //      display "_"

    }

   
}

