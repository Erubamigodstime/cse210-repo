using System;


public class Program
{
    static void Main(string[] args)
    {
        int userInput;
        Journal journal = new Journal();        
        do
        {
        
        
        Console.WriteLine("--------Welcome to your Journal-----------");
        Console.WriteLine("What would you want to do at this time");             
        // 
        string[] _menuItems = { "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};
        foreach(string items in _menuItems)
        {
            Console.WriteLine(items);
        }
        Console.WriteLine("Enter a number from 1-5 according to the menu above >>");

        userInput = int.Parse(Console.ReadLine());
        // PromptGen prompt = new PromptGen();            
        // Console.WriteLine(prompt.getPrompt());

        if (userInput == 1)
        {
            journal.Write();
            
        }
        else if (userInput == 2)
        {
            journal.Display();
        }
        else if (userInput == 3)
        {
            journal.Load();
        }
        else if (userInput == 4)
        {
            journal.Save();
        }
            
        } while (userInput != 5);
        
        
    }
}


