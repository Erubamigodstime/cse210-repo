using System;
using System.IO;

class Journal
{
    public List<Entry>_entryList = new List<Entry>();
   
    public void Display()
    {
        foreach(Entry entry in _entryList )
        {
            entry.displayEntry();

        }
        
    }
    public void Write()
    {
        Entry entry = new Entry();
        entry.Write();
        _entryList.Add(entry);

    }
    public void Save()
    {
        Console.WriteLine("Enter the filename: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entryList)
                {
                    
                    outputFile.WriteLine(entry._time);
                    outputFile.WriteLine(entry._Date);
                    outputFile.WriteLine(entry._Prompt);
                    outputFile.WriteLine(entry._Response);
                }  


        }
        Console.WriteLine("");
        Console.WriteLine("Your data has been saved");
        Console.WriteLine(" ");
           
    }
    
    public void Load()
    {
        //  string data;       
        Console.WriteLine("Enter the file name");
        string filename = Console.ReadLine();
        StreamReader sw = new StreamReader(filename);
        Console.WriteLine(" ");
        while (sw.ReadLine() is string s )
        {
            
            Console.WriteLine(s);
           
        }
        Console.WriteLine(" ");
        // // StreamReader reader  = new StreamReader(filename);
        // data = reader.ReadLine();
        // string [] data = File.ReadAllLines(filename);
        // foreach(string line in data)
        // {
        //     string[] parts = line.Split(",");
        //     for (int i = 0; i < parts.Length; i++)
        //     {
        //         Console.WriteLine(i);
                
        //     }                   
        // }
        
        
    }

// string filename = "myFile.txt";
// string[] lines = System.IO.File.ReadAllLines(filename);

// foreach (string line in lines)
// {
//     string[] parts = line.Split(",");

//     string firstName = parts[0];
//     string lastName = parts[1];
// }
//     //METHODS
//     // Display method to display all the entries
//     //      foreach (Entry entry in entryList)
//     //          enrty.Display()

//     // Write method
//     //      create an Entry object
//     //      entry.Write()
//     //      add the entry to the entry list (entryList.Add(entryName))

//     // Save to file

//     // Load from file

   
}