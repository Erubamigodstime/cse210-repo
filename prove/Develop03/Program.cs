using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference("John", "3", "16");
        Scripture scripture = new Scripture(reference, "For God so love the world that whosoever believeth in him shall no perish but have everlsting life.");
        Random rand = new Random();

        foreach (Word word in scripture.getScriptureTextList())
            {
                word.GetRenderedText();
                Console.Write(" ");
            }

            Console.Write("\n\nType 'Quit' to end the program or press enter to continue: ");
            string userInput = Console.ReadLine();
            if (userInput == "Quit")
                System.Environment.Exit(0);


        while (true)
        {
            Console.Clear();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        
            List<Word> visibleWords = scripture.GetVisibleWords();
            for(int x = 0; x < 3; x++)
            {
                int index = rand.Next(visibleWords.Count());
                visibleWords[index].Hide();
            }
            foreach (Word word in scripture.getScriptureTextList())
            {
                word.GetRenderedText();
                Console.Write(" ");
            }

            Console.Write("\n\nType 'Quit' to end the program or press enter to continue: ");
            userInput = Console.ReadLine();
            if (userInput == "Quit")
                break;
        }

        // WHILE TRUE loop
        // call the IsCompletelyHidden(). If true:
        //   break
        // display each word in the scripture using a for loop
        // FOREACH (Word word in scripture.GetScriptureText())
        //      Console.Write(word)
        // use a random generator to hide a random index of the scripturetext list. Do this three times.
        // Prompt user to enter quit to exit program OR press enter to continue
        // input = console.readline()
        // IF input == "quit"
        //      exit program
    }
}

// // Choose a random non-hidden word to hide
//             