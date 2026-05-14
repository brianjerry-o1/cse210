using System;

class Program
{
    static void Main(string[] args)
    {
        // Object Instantiations
        Journal theJournal = new Journal();
        PromptGenerator theGenerator = new PromptGenerator();
        
        bool keepRunning = true;
        Console.WriteLine("Welcome to your Digital Journal Program!");

        while (keepRunning)
        {
            // Display User Menu Option Interface
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Gather automated date and prompt context
                    string randomPrompt = theGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {randomPrompt}");
                    Console.Write("> ");
                    string userResponse = Console.ReadLine();

                    // Map fields into a clean object instance
                    Entry currentEntry = new Entry();
                    currentEntry._date = DateTime.Now.ToShortDateString();
                    currentEntry._promptText = randomPrompt;
                    currentEntry._entryText = userResponse;

                    // Save the entry instance into the journal controller
                    theJournal.AddEntry(currentEntry);
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("\nEnter the filename to load from (e.g., journal.json): ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("\nEnter the filename to save to (e.g., journal.json): ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;

                case "5":
                    Console.WriteLine("\nThank you for writing today. Goodbye!");
                    keepRunning = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid option selection. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}