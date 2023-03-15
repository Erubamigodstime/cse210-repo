using System;

class Program
{
    static void Main(string[] args)
    {
       // Set up the sentence to be hidden
        string sentence = "The quick brown fox jumps over the lazy dog";

        // Split the sentence into individual words
        string[] words = sentence.Split(' ');

        // Set up a boolean array to track which words are hidden
        bool[] hidden = Enumerable.Repeat(false, words.Length).ToArray();

        // Set up a random number generator
        Random random = new Random();

        // Display the original sentence
        Console.WriteLine(sentence);

        // Loop until all words are hidden
        while (hidden.Any(h => !h))
        {
            // Wait for a key to be pressed
            Console.ReadKey(true);

            // Choose a random non-hidden word to hide
            int index = random.Next(words.Length);
            while (hidden[index])
            {
                index = random.Next(words.Length);
            }

            // Hide the chosen word
            hidden[index] = true;

            // Display the updated sentence with the hidden word
            Console.Clear();
            Console.WriteLine(string.Join(" ", words.Select((w, i) => hidden[i] ? new string('-', w.Length) : w)));
        }

        // All words are now hidden, so display a message
        Console.WriteLine("All words are hidden!");
        
    }   
}