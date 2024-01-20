using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber;
        int guess;
        int attempts = 0;
        string playAgain;


        do
        {
            Console.WriteLine ("Do you want to choose the magic number (yes/no)? ");
            string chooseMagicNumber = Console.ReadLine().ToLower();

            if (chooseMagicNumber == "yes")
            {
                Console.Write("Enter the magic number (1-100): ");
                magicNumber = int.Parse(Console.ReadLine());
            }
            else
            {
                magicNumber = random.Next(1, 101);
            }

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }    

                attempts++;
            }  while (guess != magicNumber);

           
            Console.WriteLine($"You guessed the number in {attempts} attempts.");

            
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
            
}
    
