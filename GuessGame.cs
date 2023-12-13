namespace GuessGame
{
    class Program
    {
        static void Game()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            int guess = 0;
            int tries = 3;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guess != number)
            {
                string rawguess = Console.ReadLine();
                int.TryParse(rawguess, out guess);
                
                if (tries == 0)
                {
                    Console.WriteLine("You run out of tries!");
                    break;
                }
                else if (guess == number)
                {
                    Console.WriteLine("Correct! It's " + number);
                    break;
                }
                else if (guess < 1 || guess > 10)
                {
                    Console.WriteLine("Enter a number between 1 and 10.");
                }
                else if (guess != number)
                {
                    tries -= 1;
                    Console.WriteLine("Incorrect, it's not number " + guess);
                }
                else
                {
                    Console.WriteLine("Error! This should of not happened...");
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                Game();

                Console.WriteLine("Do you want to play again? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response != "y" && response != "yes" && response != "n" && response != "no")
                {
                    Console.WriteLine("Invalid response. Please enter (y/n): ");
                    response = Console.ReadLine().ToLower();
                }
                else if (response == "n" || response == "no")
                {
                    Console.WriteLine("Exiting...");
                    playing = false;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
