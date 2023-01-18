using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("what is your first Name?");
      string first = Console.ReadLine();
      Console.Write("what is your Last Name?");
      string Last = Console.ReadLine();
      Console.WriteLine($" My Name is {first}, {Last} {first} ");
    }
}