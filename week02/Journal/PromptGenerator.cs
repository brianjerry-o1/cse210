using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Attribute containing predefined hardcoded prompt items
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new you learned or realized today?",
        "Describe a moment of peace or quiet you experienced over the last 24 hours."
    };

    // Behavior: Selects and returns a single random string from the pool
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}