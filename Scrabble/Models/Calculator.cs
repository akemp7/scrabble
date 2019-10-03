using System.Collections.Generic;
using System;

namespace ScrabbleCalculator.Models
{
    public class Scrabble
    {
        public string UserWord { get; set; }
        public int Score { get; set; }

        public Scrabble (string userWord)
        {
            UserWord = userWord;
            Score = 0;
        }
         
        public void Calculator()
        {
            char[] wordArray = UserWord.ToCharArray();
            for(int i = 0; i< wordArray.Length; i++)
            {
                if(char.ToLower(wordArray[i]) == 'q'|| char.ToLower(wordArray[i]) == 'z')
                {
                    Score += 10;
                }
                else if(char.ToLower(wordArray[i]) == 'j'|| char.ToLower(wordArray[i]) == 'x')
                {
                    Score += 8;
                }
                else if(char.ToLower(wordArray[i]) == 'k')
                {
                    Score += 5;
                }
                else if(char.ToLower(wordArray[i]) == 'f'|| char.ToLower(wordArray[i]) == 'h' || char.ToLower(wordArray[i]) == 'v' || char.ToLower(wordArray[i]) == 'w' || char.ToLower(wordArray[i]) == 'y')
                {
                    Score += 4;
                }
                else if(char.ToLower(wordArray[i]) == 'b'|| char.ToLower(wordArray[i]) == 'c' || char.ToLower(wordArray[i]) == 'm' || char.ToLower(wordArray[i]) == 'p')
                {
                    Score += 3;
                }
                else if(char.ToLower(wordArray[i]) == 'd' || char.ToLower(wordArray[i]) == 'g')
                {
                    Score += 2;
                }
                else
                {
                    Score += 1;
                }
            }
        }
    }
}