using System;

public class Scripture
{
    private Reference rf;
    private List<Word>  _scriptureText = new List<Word>();
    


    public Scripture(Reference reference, string scripture)
    {
        rf = reference;
        string[] words = scripture.Split(" ");
        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _scriptureText.Add(wordObj);
        }   
    }

    public bool IsCompletelyHidden()
    {
        foreach ( Word  word in _scriptureText)
        {
            if (!word.IsHidden())
            {
                return false;
            }
            
        }
       
        return true;
        

        // return IsCompletelyHidden();
        //FOREACH word in sctripturetext
        //  IF word == false
        //        return false
        //  ELSE
        //      return true

    }

    public List<Word> getScriptureTextList()
    {
        List<Word> script   = _scriptureText;
        
        return _scriptureText;
    }

    // getter for 

    public List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _scriptureText)
        {
            if (!word.IsHidden())
                visibleWords.Add(word);
        }

        return visibleWords;
    }

   
}
