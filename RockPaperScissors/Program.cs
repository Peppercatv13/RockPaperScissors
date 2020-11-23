using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            string inputPlayer, inputOpponent;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreOpponent = 0;

                while (scorePlayer < 3 && scoreOpponent < 3)
                {

                    Console.WriteLine("Choose between ROCK, PAPER or SCISSORS");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
                    if (inputPlayer == "ROCK" || inputPlayer == "PAPER" || inputPlayer == "SCISSORS")
                    {
                        Random rnd = new Random();

                        randomInt = rnd.Next(1, 4);

                        switch (randomInt)
                        {
                            case 1:
                                inputOpponent = "ROCK";
                                Console.WriteLine("Opponent chose ROCK");
                                if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("DRAW!\n\n");
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("Player WINS!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("Player LOSES!\n\n");
                                    scoreOpponent++;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Opponent chose PAPER");
                                if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("DRAW!\n\n");
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("Player WINS!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("Player LOSES!\n\n");
                                    scoreOpponent++;
                                }
                                inputOpponent = "PAPER";
                                break;
                            case 3:
                                Console.WriteLine("Opponent chose SCISSORS");
                                if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("DRAW!\n\n");
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("Player WINS!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("Player LOSES!\n\n");
                                    scoreOpponent++;
                                }
                                inputOpponent = "SCISSORS";
                                break;
                            default:
                                Console.WriteLine("Invalid Selection");
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("That is an INVALID selection, try AGAIN.");
                    }

                    Console.WriteLine("SCORE- PLAYER: " + scorePlayer + " OPPONENT: " + scoreOpponent);
                    Console.WriteLine("Would you like to PLAY again?  Y / N ?");
                    string rpsLoop = Console.ReadLine();
                    if (rpsLoop == "y")
                    {
                        playAgain = true;
                    }
                    else if (rpsLoop == "n")
                    {
                        playAgain = false;
                    }
                }
            }
        }
    }
}
