namespace Rock_Paper_Scissors_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string choice;
            string aiChoice;
            int aiRand;
            int bet;
            int cash = 50;

            Console.Title = "Rock Paper Scissors!";

            while (cash > 0)
            {
                startLoop:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Let's play betting Rock Paper Scissors!");
                Console.WriteLine();
                Console.WriteLine("You currently have $" + cash);
                Console.WriteLine();
                Console.Write("Make a bet based on your amount:");

                Int32.TryParse(Console.ReadLine(), out bet);

                if (bet <= 0 || bet > cash)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid bet. You must bet an amount between 1 and your total money.");
                    Console.WriteLine("ENTER");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Choose your move: Rock, Paper, or Scissors");
                choice = Console.ReadLine().ToLower();

                if (choice != "rock" && choice != "paper" && choice != "scissors")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please type Rock, Paper, or Scissors.");
                    Console.WriteLine("ENTER");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                aiRand = random.Next(1, 4); //Ai choice picker  Mark

                if (aiRand == 1)
                    aiChoice = "rock";
                else if (aiRand == 2)
                    aiChoice = "paper";
                else
                    aiChoice = "scissors"; //Ai choice picker  Mark

                Console.WriteLine("Computer chooses: " + aiChoice);

                if (choice == aiChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a tie!");
                }
                else if (
                    (choice == "rock" && aiChoice == "scissors") ||
                    (choice == "scissors" && aiChoice == "paper") ||
                    (choice == "paper" && aiChoice == "rock")
                )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won!");
                    cash += bet;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    cash -= bet;
                }

                if (cash <= 0)
                {
                    Console.WriteLine("You're out of money! Game over.");
                    break;
                }

                Console.WriteLine("Do you want to play again? Y/N");

                string again = Console.ReadLine().ToLower();

                if (again == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
                if (again == "y")
                    Console.Clear();
                    goto startLoop;
            }
        }
    }
}