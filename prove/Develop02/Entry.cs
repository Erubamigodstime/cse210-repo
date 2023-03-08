using System;
using System.IO;

 public class Entry
{
    public List<string> author = new List<string>()
        {
            "erubami godstime",
            "erubami freedom",
            "elizabeth emekpa",
            "erubami victory",
            "amy"
        
        };
    // public string _auts;
    // public string _authorName;
    public string _time;
    PromptGen prompts = new PromptGen();
    DateTime  currentDate = DateTime.Now;
    public string _Date;
    public string _Prompt;
    public string _Response;
  
    public void Write()
    {
        
        
        _time = currentDate.ToShortTimeString();
        _Date = currentDate.ToShortDateString();
        _Prompt = prompts.getPrompt();
        // Console.WriteLine("Enter Author name");
        // _authorName = Console.ReadLine();
        // _auts = _authorName.ToLower();
        Console.WriteLine(_Prompt);
        _Response = Console.ReadLine();
    }
    public void displayEntry()
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Time: {_time}\n Date: {_Date}\n Prompt: {_Prompt}\n Response: {_Response}");
        Console.WriteLine(" ");
    }

}