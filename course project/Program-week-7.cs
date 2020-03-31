using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = "muzzo".ToCharArray();
            char letter;
            char[] guessed = new char[26];
            int score = 0;
            int index = 0;
            bool found = false;
            
            Console.WriteLine("Welcome to the hangman game!");

            
            for (int guessCount = 0; guessCount <10 ; guessCount++)
            {
                for(int symbol=0;symbol<word.Length;symbol++)
                {
                    for(int correctlyGuessed=0;correctlyGuessed<index;correctlyGuessed++)
                    {
                        if (word[symbol] == guessed[correctlyGuessed])
                            found = true;
                    }
                    if (found == true)
                    {
                        Console.Write(word[symbol]);
                        found = false;
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
                Console.Write("Enter a letter please: ");

                letter = char.Parse(Console.ReadLine());
                if (word.Contains(letter))
                {
                    Console.WriteLine("You guessed correctly!");
                    guessed[index] = letter;
                    index++;
                }
                else
                {
                    Console.WriteLine("You guessed incorrectly.");
                    score++;
                }

            }
            Console.WriteLine();
                Console.WriteLine("your score is: " + score);
                Console.ReadLine();
            
        }
    }
}
