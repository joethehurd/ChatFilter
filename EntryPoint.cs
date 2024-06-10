using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatFilter
{
    class EntryPoint
    {
        static void Main()
        {
            Console.Write($"Enter a word, sentence, or phrase: ");
            string input = Console.ReadLine();
            Console.WriteLine($"You entered: {CheckForBadWords(input)}");           
        }

        static string CheckForBadWords(string input)
        {
            string[] badWords = { "cat", "dog", "mouse" }; // replace with desired vocabulary
            string censoredWord = input;

            foreach (string badWord in badWords)
            {
                if (input.Contains(badWord))
                {
                    censoredWord = censoredWord.Replace(badWord, Censor(badWord));
                }
            }

            return censoredWord;
        }

        static string Censor(string badWord)
        {
            string asterisks = String.Empty;

            for (int i = 0; i < badWord.Length; i++)
            {
                asterisks += "*";
            }

            return asterisks;
        }
    }
}
