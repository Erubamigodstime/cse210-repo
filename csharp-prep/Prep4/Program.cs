using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Console.Write("Enter a List of number. type 0 when finished");        
        int number = -1;
        while (number!= 0)
        {            
            Console.Write("Enter number: ");
            string numbers = Console.ReadLine();
            number = int.Parse(numbers);
            numberList.Add(number);            
        }
        int sum = 0;
        // sum = numberList.Sum();
        // Console.WriteLine(sum);

        foreach (int Num in numberList)
        {   
            Console.WriteLine(Num);    
            sum += Num ;     
            
        }
        int average = sum / 2;
        int maxVal = numberList.Max();
        int minVal  = numberList.Min();      
        Console.WriteLine($" The sum is: {sum}");
        Console.WriteLine($" The Average is: {average}");        
        Console.WriteLine($" The Min Value   is: {minVal}");
        Console.WriteLine($" The Max Value   is: {maxVal}");
        

    }
}