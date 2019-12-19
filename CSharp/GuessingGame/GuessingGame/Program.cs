using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            const int RANDMIN = 1;
            const int RANDMAX = 100;

            int userGuess = 0;
            string userGuessTest = "";
            string playAgain = "";
            int numGuesses = 0;
            bool keepGoing = true;

            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            

            do
            {
                Write("\nGuess the secret number (1-100): ");
                userGuessTest = ReadLine();

                if (isNumeric(userGuessTest))
                {
                    userGuess = Convert.ToInt32(userGuessTest);

                    if (userGuess > RANDMAX || userGuess < RANDMIN)
                    {
                        WriteLine("\nGuess must be between 1-100. Try again.");

                    }

                    if (userGuess == randomNumber)
                    {
                        numGuesses += 1;
                        Write("\nCongrats! You guessed correctly! \nIt took you " + numGuesses + " guesses to guess the secret number (" + randomNumber + ")");
                        Write("\nDo you want to play again? (Y/N)");
                        playAgain = Convert.ToString(ReadLine());
                        if (playAgain == "Y")
                        {
                            numGuesses = 0;
                            random = new Random();
                            randomNumber = random.Next(1, 101);

                        }
                        else
                        {
                            keepGoing = false;
                        }

                    }
                    else if (userGuess < randomNumber)
                    {
                        Write("\nToo low. Try again.");
                        numGuesses += 1;

                    }
                    else if (userGuess > randomNumber)
                    {
                        Write("\nToo high. Try again");
                        numGuesses += 1;

                    }
                }

                else
                {
                    Write("\nNon-numeric input\n");
                }

                


            } while (keepGoing == true);


            

        }

        static private bool isNumeric(String input)
        {
            int test;
            return int.TryParse(input, out test);
        }


    }
}
