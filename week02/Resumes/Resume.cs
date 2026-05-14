using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name = "";

    // List to store all jobs
    public List<Job> _jobs = new List<Job>();

    // Displays the complete resume
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job and display it
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}