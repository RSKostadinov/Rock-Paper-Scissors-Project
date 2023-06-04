using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            string Rock = "Rock";
            string Paper = "Paper";
            string Scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);

            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = Rock;
                    break;
                case 2:
                    computerMove = Paper;
                    break;
                case 3:
                    computerMove = Scissors;
                    break;
            }
            Console.WriteLine($"The computer chose {computerMove}.");

            if (playerMove == Rock && computerMove == Scissors || playerMove == Paper && computerMove == Rock || playerMove == Scissors && computerMove == Paper)
            {
                Console.WriteLine("You win.");
            }
            else if (playerMove == Rock && computerMove == Paper || playerMove == Paper && computerMove == Scissors || playerMove == Scissors && computerMove == Rock)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }
            Console.ReadLine();
            Console.WriteLine("Thank you for playing my game!");
            Console.WriteLine();
            Console.WriteLine("This code was written by: Radoslav Stankov Kostadinov");
        }
    }
}
