/*https://www.dotnetperls.com/random
 * Author:Sam Allen
 * 04/24/19
 * Program is  a random number generator
 * Edited by: Troy Mateo
 * I extended the program to include making a game of it.
 */

using System;

class Program
{
    static void Main()
    {
        // ... Create new Random object.
        Random random = new Random();
        // ... Get 3 random numbers.
        //     These are always 5, 6, 7, 8 or 9.
        Console.WriteLine("RANDOM: " + random.Next(5, 10));
        Console.WriteLine("RANDOM: " + random.Next(5, 10));
        Console.WriteLine("RANDOM: " + random.Next(5, 10));

        // I added everything after this point
        Console.WriteLine("Pleases enter a number between 1 and 10");
       
        bool answer = true;

        // A do while loop created to make sure the guessing game is executed at least once
        do
        {
            int numberGuess = int.Parse(Console.ReadLine());
            int randomNumber = random.Next(1, 11);
            
            //If you win you exit the game
            if (numberGuess == randomNumber)
            {
                Console.WriteLine("Great Job! Number was indeed " + numberGuess);
                break;
            }
            //If you lose you have the option to try again
            else
            {
                Console.WriteLine("Sorry! That's not it. Do you wanna try again? y/n");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "n")
                {
                    answer = false;
                }
                else
                {
                    answer = true;
                }
            }
        }
        while (answer);
        
    }
}

// Output random numbers 3 times
//Then asks you to guess a number if it is correct you win
//If wrong you have the option to try guessing a different number
