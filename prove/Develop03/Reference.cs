using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;
   
   public Reference(string book, string chapter, string startVerse)
   {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null;

   }
   public Reference(string book, string chapter, string startVerse, string endVerse)
   {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
   }

   // create getter methods for each attribute

   public void getBook()
   {
        string book = _book;
   }
   public void getChapter()
   {
        string chapt  = _chapter;
   }
   public void getStartVerse()
   {
        string verse = _startVerse;
   }
   public void getEndVerse()
   {
        string endvs  = _endVerse;
   }
   
}

// Scripture - Keeps track of the reference and the text of the scripture.
// Can hide words and get the rendered display of the text.
// Reference - Keeps track of the book, chapter, and verse information.
// Word - Keeps track of a single word and whether it is shown or hidden.