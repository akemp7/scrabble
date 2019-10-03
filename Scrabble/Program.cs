using System;
using ScrabbleCalculator.Models;
using System.Text.RegularExpressions;
namespace ScrabbleCalculator
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Scrabble!");
            Console.Write("Please enter a word:");
            string userInput = Console.ReadLine();

            Regex regex = new Regex (@"[^a-zA-Z]");
            Match match = regex.Match(userInput);
            if(match.Success)
            {
                Console.WriteLine("Please input a word.");
                Main();
            }
            else
            {
                Scrabble newScrabble = new Scrabble(userInput);
                newScrabble.Calculator();
                int result = newScrabble.Score;
                Console.WriteLine("Your word " + newScrabble.UserWord + " is worth " + newScrabble.Score + " points.");
            }
            
        }

    }
}