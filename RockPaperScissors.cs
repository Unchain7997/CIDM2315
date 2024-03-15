namespace ExtraCredit;

using System;

class HumanPlayer {
    private int points;
    public HumanPlayer(int initial) {
        points = initial;
    }
    public int GetPoints() {
        return points;
    }
    public void WinRound() {
        points +=5;
    }
    public void LoseRound() {
        points -=5;
    }
    public string HumanDecision() {
        Console.WriteLine("Please, input your choice: rock, paper, or scissors): ");
        string decision = Console.ReadLine().ToLower();
        while (decision != "rock" && decision != "paper" && decision != "scissors") {
            Console.WriteLine("Invalid input. Please enter Rock, Paper, or Scissors: ");
            decision = Console.ReadLine().ToLower();
        }
        return decision;
    }
}

class ComputerPlayer {
    public string ComputerDecision() {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0, 3);

        if (rnd_num == 0)
            return "rock";
        else if (rnd_num == 1)
            return "paper";
        else
            return "scissors";
    }
}

class RockPaperScissors
{
    static void Main(string[] args) {
        Console.WriteLine("****Rock - Paper - Scissors, Start!!****");
        HumanPlayer humanPlayer = new HumanPlayer(5);
        ComputerPlayer computerPlayer = new ComputerPlayer();

        while (humanPlayer.GetPoints() > 0)
        {
            Console.WriteLine($"You have {humanPlayer.GetPoints()} points");

            string humanDecision = humanPlayer.HumanDecision();
            Console.WriteLine("--> Your Decision: " + humanDecision);

            string computerDecision = computerPlayer.ComputerDecision();
            Console.WriteLine("--> Computer Decision: " + computerDecision);

            if (humanDecision == computerDecision) {
                Console.WriteLine("It's a tie! You do not win or lose points.");
            }
            else if ((humanDecision == "rock" && computerDecision == "scissors") ||
                     (humanDecision == "paper" && computerDecision == "rock") ||
                     (humanDecision == "scissors" && computerDecision == "paper")) {
                humanPlayer.WinRound();
                Console.WriteLine("You Win! You won 5 more points.");
            }
            else {
                humanPlayer.LoseRound();
                Console.WriteLine("You Lose! You lost 5 points.");
            }

            if (humanPlayer.GetPoints() <= 0) {
                    Console.WriteLine("Sorry, you don't have enough points. Thank you for playing!");
                    break;
                }

        Console.WriteLine("--> Play again? Input Y to continue, or N to exit");
            string playAgain = Console.ReadLine().ToLower();
            while (playAgain != "y" && playAgain != "n") {
                Console.WriteLine("Invalid input. Please enter Y or N");
                playAgain = Console.ReadLine().ToLower();
            }

            if (playAgain == "n") {
                Console.WriteLine("Thank you for playing! Goodbye!");
                return;
            }
        }

    }
}
