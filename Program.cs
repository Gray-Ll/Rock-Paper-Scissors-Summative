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

            bool done = false;

            Console.Title = "Rock Paper Scissors!";

            while (!done)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Let's play betting Rock Paper Scissors!");
                Console.WriteLine();
                Console.WriteLine("You currently have $" + cash);
                Console.WriteLine();
                Console.Write("Make a bet based on your amount: ");

                while (!Int32.TryParse(Console.ReadLine(), out bet) || bet > cash)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. You need to bet in between your money.");
                    Console.WriteLine("ENTER");
                    Console.ReadLine();
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You currently have $" + cash);
                    Console.WriteLine();
                    Console.Write("Make a bet based on your amount: ");
                }

                Console.WriteLine("Choose your move: Rock, Paper, or Scissors");

                choice = Console.ReadLine().ToLower();

                while (choice != "rock" && choice != "paper" && choice != "scissors")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please type Rock, Paper, or Scissors.");
                    Console.WriteLine("ENTER");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Choose your move: Rock, Paper, or Scissors");

                    choice = Console.ReadLine().ToLower();
                }

                aiRand = random.Next(1, 4);

                if (aiRand == 1)
                    aiChoice = "rock";
                else if (aiRand == 2)
                    aiChoice = "paper";
                else
                    aiChoice = "scissors";

                Console.WriteLine("Computer chooses: " + aiChoice);

                if (choice == aiChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You tied! No winnings or losings.");

                    if (choice == "rock" && aiChoice == "rock")
                    {
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)");
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)");
                    }
                    else if (choice == "paper" && aiChoice == "paper")
                    {
                        Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)");
                        Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)");
                    }
                    else if (choice == "scissors" && aiChoice == "scissors")
                    {
                        Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                        Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                    }
                }
                else if
                    ((choice == "rock" && aiChoice == "scissors") ||
                    (choice == "scissors" && aiChoice == "paper") ||
                    (choice == "paper" && aiChoice == "rock"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won!");
                    cash += bet;

                    if (choice == "rock" && aiChoice == "scissors")
                    {
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)");
                        Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                    }
                    else if (choice == "scissors" && aiChoice == "paper")
                    {
                        Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                        Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)\r\n");
                    }
                    else if (choice == "paper" && aiChoice == "rock")
                    {
                        Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)\r\n");
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lost.");
                    cash -= bet;

                    if (choice == "rock" && aiChoice == "paper")
                    {
                        Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)");
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)");
                    }
                    else if (choice == "paper" && aiChoice == "scissors")
                    {
                        Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                        Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)");
                    }
                    else if (choice == "scissors" && aiChoice == "rock")
                    {
                        Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)");
                        Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                    }
                }

                if (cash <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're out of money! Game over.");
                    done = true;
                }
                else
                {

                    Console.WriteLine("Want to play again? Y/N");

                    string again = Console.ReadLine().ToLower();

                    if (again == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Thanks for playing!");
                        done = true;
                    }
                    else if (again == "y")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        while (again != "n" && again != "y")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Pick Y or N this time..");
                            Console.WriteLine("ENTER");
                            Console.ReadLine();
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Want to play again? Y/N");

                            again = Console.ReadLine().ToLower();

                            if (again == "n")
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Thanks for playing!");
                                done = true;
                            }
                            else if (again == "y")
                            {
                                Console.Clear();
                            }
                        }
                    }
                }
            }
        }
    }
}