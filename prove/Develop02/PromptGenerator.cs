using System;
using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        Random randomQuestions = new Random();
        string randomPrompt = _prompts[randomQuestions.Next(_prompts.Count)];
        
        
        return randomPrompt;
    }



}