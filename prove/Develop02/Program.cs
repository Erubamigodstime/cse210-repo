using System;


public class Program
{
    static void Main(string[] args)
    {
        
        Entry ent = new Entry();
        List<string> author = ent.author;
        
        int userInput;
        Journal journal = new Journal();
        Console.WriteLine("--------Welcome to your Journal-----------");
        Console.WriteLine("Are you an authorised  Author");
        string AuthurResponse  = Console.ReadLine();
        string art = AuthurResponse.ToLower();
        if (art == "yes")
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            string realName = name.ToLower();

            if (author.Contains(realName))
            {
                do
                {
                
                
                Console.WriteLine($"Welcome {name}"); 
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
            else
            {
                Console.WriteLine($"{name} does not have an account yet");
                Console.WriteLine("You cant make use of this journl at this time");
                Console.WriteLine("Contact 09073905497 (Godstime Erubami) to create an account for you ");
            }
        }
        else if (art == "no")
        {
            Console.WriteLine("You cant make use of this journl at this time");
            Console.WriteLine("Contact 09073905497 (Godstime Erubami) to create an account for you ");
        }
        else
        {
            Console.WriteLine("Unrecongnise input");
        } 





        
        
        
    }
}


