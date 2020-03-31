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
            char letter1 = 'm', letter2 = 'u', letter3 = 'z', letter4 = 'z', letter5 = 'o', letter;
            char[] guessed = new char[26];
            int score = 0;
            int index = 0;
            
            Console.WriteLine("Welcome to the hangman game!");

            Console.WriteLine("Enter a letter please: ");
            for (int guessCount = 0; guessCount <10 ; guessCount++)
            {
                Console.WriteLine("*****");
                letter = char.Parse(Console.ReadLine());
                if (letter == letter1 || letter == letter2 || letter == letter3 || letter == letter4 || letter == letter5)
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
                Console.WriteLine("your score is: " + score);
                Console.ReadLine();
            
        }
    }
}
