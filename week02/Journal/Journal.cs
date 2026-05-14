using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; // Used to satisfy the "Exceeding Requirements" criteria

public class Journal
{
    // Attribute: Core data collection
    public List<Entry> _entries = new List<Entry>();

    // Behavior: Add an explicit instance to the record
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Behavior: Delegate formatting duties back to the individual Entry objects
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nYour journal is currently empty.");
            return;
        }

        Console.WriteLine("\n=== JOURNAL ENTRIES ===");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Behavior: Saves the entire structure using robust JSON format
    public void SaveToFile(string file)
    {
        try
        {
            // Configure JSON for human readability inside the output file
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(_entries, options);

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(jsonString);
            }
            Console.WriteLine($"Journal successfully saved to '{file}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }

    // Behavior: Loads JSON entries and completely overwrites the runtime list
    public void LoadFromFile(string file)
    {
        try
        {
            if (!File.Exists(file))
            {
                Console.WriteLine($"Error: The file '{file}' does not exist.");
                return;
            }

            string jsonString = File.ReadAllText(file);
            List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(jsonString);

            if (loadedEntries != null)
            {
                _entries = loadedEntries;
                Console.WriteLine($"Journal loaded successfully! Retrieved {_entries.Count} entries.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
        }
    }
}
