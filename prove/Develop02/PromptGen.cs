using System;
using System.IO;

public class PromptGen
{
    
    public Random _randomGenerator = new Random();
    List<string> _prompts = new List<string>()
    {"Who was the most interesting person i interacted with today",
      "What was the best part of your day",
      "How did you see the hand of the lord in your life today",
       "What was the strongest emotions i felt today",
       "If i had one thing i could do over and over again today what could it be",
       "Write your innermost thought",
       "How are you feeling at the momment"

                        
    };
    // public static bool isRepeat(int promptNumb,  string[] _prompts)
    // {
    //     foreach (int item in _prompts)
    //     {
    //         if (item == promptNumb)
    //         {
    //             return  true;
                
    //         }
            
    //     }
    //     return false;

    // }

    public string getPrompt()
    {
        int promptNumb = _randomGenerator.Next(_prompts.Count());        
        return _prompts[promptNumb];
    }
    // public string getPrompt()
    // {
    //     for (int i = 0; i < _prompts.Length; i++)
    //     {
    //         promptNumb = _randomGenerator.Next(_prompts.Count()); 
    //         while (isRepeat(promptNumb, _prompts))
    //         {
    //             promptNumb = _randomGenerator.Next(_prompts.Count()); 
    //         }
    //         _prompts[i] = promptNumb;

            
    //     }
           
    //     // return _prompts[promptNumb];

    // }
    
   
}  
  