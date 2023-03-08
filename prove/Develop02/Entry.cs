using System;
using System.IO;

 public class Entry
{
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
        Console.WriteLine(_Prompt);
        _Response = Console.ReadLine();
    }
    public void displayEntry()
    {
        Console.WriteLine($" Time: {_time}\n Date: {_Date}\n Prompt: {_Prompt}\n Response: {_Response}");
    }

}