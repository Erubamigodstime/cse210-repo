using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the fraction program");
        Console.WriteLine(" ");
        Fraction number = new Fraction();
        Fraction number2 = new Fraction(5);
        Fraction number3 = new Fraction(3, 4);    
        Console.WriteLine(number.ToString());
        Console.WriteLine(number.GetDecimalValue());
        Console.WriteLine(number2.ToString());
        Console.WriteLine(number2.GetDecimalValue());
        Console.WriteLine(number3.ToString());
        Console.WriteLine(number3.GetDecimalValue());
        
        // Fraction getters = new Fraction();

        // getters.SetTop(2);
        // Console.WriteLine(getters.GetTop());
        // Console.WriteLine(" ");
        // getters.SetBottom(5);
        // Console.WriteLine(getters.GetBottom());

        
    }

    // Person p = new Person();
    // p.SetFirstName("Peter");

    // 
}