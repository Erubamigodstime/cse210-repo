using System;

public class Resume
{
    public string _personName ;
    public List<Job>_job = new List<Job>(); 
     public Resume()
    {

    }

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name:{_personName}");
        Console.WriteLine("Jobs:");
        // for (int i = 0; i < _list.Count; i++)
        // {
            
        //     Console.WriteLine(_list[i]);
        // }

        foreach ( Job word in _job)
        {            
            word.display();
        }

    }
    
}