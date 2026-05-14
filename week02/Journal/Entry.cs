using System;

public class Entry
{
    // Attributes
    public string _date { get; set; } = "";
    public string _promptText { get; set; } = "";
    public string _entryText { get; set; } = "";

    // Behavior: Responsibility of displaying a single entry cleanly
    public void Display()
    {
        Console.WriteLine($"Date: {_date} — Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine(new string('-', 50)); // Visual divider
    }
}