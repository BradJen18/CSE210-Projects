using System;
using System.Security.Cryptography;

public class PromptGen
{
    public List<string> _prompts =
    [
        "How was your day?","What was the high of your day?","What made you smile?","How did you help someone?","How did you make someone smile?","Who'd you talk to today?", "What was today's low?","What was the weirdest thing you saw?","Did you compliment anyone?","Did anyone compliment you?"
    ];
    public string PickPrompt()
    {
        Random random = new Random();
        int number = random.Next(5);
        string _prompt = _prompts[number];
        return _prompt;
    }
}