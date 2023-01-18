using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        while(play == "yes")
        {       
            int number = 300;       
            int attempt = 0;
            int guess = 0;
            Random randomGenerator = new Random();
            number = randomGenerator.Next(1, 10);        
            while (guess != number)
            {               
                Console.Write("What is the magic Number?: ");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if ( guess == number)
                {
                    Console.WriteLine("Hurray You guessed it right");
                }
                attempt ++;              
                
            }            
            Console.WriteLine($" It took you {attempt}, attempts to guess it right");
            Console.Write("Do you want to keep playing?: ");
            play = Console.ReadLine();
        
    }


    


    }
}