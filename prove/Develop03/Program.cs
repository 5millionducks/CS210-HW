using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();

        scripture.DisplayScripture();
        string userInput = Console.ReadLine();
        while(!scripture.isAllHidden() && userInput.ToLower() != "quit") {
            scripture.HideRandomWords();
            scripture.DisplayScripture();
            userInput = Console.ReadLine();
        }

        
    }
}