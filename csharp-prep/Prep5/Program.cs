using System;

class Program
{
    static void Main(string[] args)
    {
        static void displayWelcome()
        {
            Console.WriteLine("Welcome to the program!");

        }
        
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
         static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favourite Number: ");
            int number =  int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber( int number)        
        {
            int square = (int)Math.Sqrt(number);
            return square ;

        }

        static void DisplayResult(string name, int squaredNumb)
        {
            Console.WriteLine($"{name}, The square of your favourite number is {squaredNumb}");


        }
        displayWelcome();
        string name = PromptUserName();
        int numb = PromptUserNumber();
        int sqr = SquareNumber(numb);
        DisplayResult(name, sqr);
    }
}