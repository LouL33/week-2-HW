﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3
{
    class Program
    {
        static int PromtAndOutput()
        {
            Console.WriteLine("pick a number from 1 to 100");
            var userGuess = Console.ReadLine();
            int.TryParse(userGuess, out int bestGuess);
            return bestGuess;

        }

        static void TheOthersAfter(bool jackTheNumber,int bestGuess,int randomNumber, int countOfGuesses)
        {

            while (bestGuess != randomNumber && countOfGuesses <= 4)
            {

                if (bestGuess < randomNumber)
                {
                    countOfGuesses++;
                    Console.WriteLine("try agian yo its to low {bestGuess}");
                    jackTheNumber = int.TryParse(Console.ReadLine(), out bestGuess);

                }

                else if (bestGuess > randomNumber)
                {
                    countOfGuesses++;
                    Console.WriteLine("try again yo its to high {bestGuess}");
                    jackTheNumber = int.TryParse(Console.ReadLine(), out bestGuess);
                }

            }
        }

        static void Main(string[] args)
        {
            var randomNumber = new Random().Next(1, 101);
            Console.WriteLine(randomNumber);

            bool jackTheNumber = false;
            var countOfGuesses = 0;
            var bestGuess = 0;

            PromtAndOutput();
            TheOthersAfter(jackTheNumber, randomNumber, countOfGuesses);

            // while (bestGuess != randomNumber && countOfGuesses <= 4)


            //   if (bestGuess < randomNumber)
            {
                //     countOfGuesses++,
                //       Console.WriteLine("try agian yo its to high {bestGuess}");
                // jackTheNumber = int.TryParse(Console.ReadLine(), out bestGuess);

            }

            //else if (bestGuess > randomNumber)
            {
                //  countOfGuesses++;
                //Console.WriteLine("try again yo its to high {bestGuess}");
                // jackTheNumber = int.TryParse(Console.ReadLine(), out bestGuess);
            }

        }
    }

    
}




   


