using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = PromptList();
    }

    static List<string> PromptList()
    {
        List<string> prompts = new List<string>();
        prompts.Add("What are three things you are grateful for today?");
        prompts.Add("What are some life goals you have?");
        prompts.Add("How can you be better tomorrow than you were today?");
        prompts.Add("What was the best thing about your day?");
        prompts.Add("Tell the story of how you met your favorite person.");
        prompts.Add("What is something you are stressed about right now, and is there a way to decrease that stress?");
        prompts.Add("If you could meet any fictional character, who would it be and why?");
        return prompts;

    }    
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }
}