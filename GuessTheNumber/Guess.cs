using System;
//hi this is Agamy from Remote.
namespace GuessTheNumber
{
    class Guess
    {
        static void Main()
        {
            Random random = new Random();
            //int num = random.Next(1, 100);
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int num;
            int guesses;
            String resp;

            while (playAgain)
            {
                num = random.Next(min, max+1);
                guess = 0;
                guesses=0;
                while(guess != num)
                {
                    Console.WriteLine("Guess The Number between " + min + " - " + max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess > num )
                    {
                        max = guess;
                        Console.WriteLine(guess + " ,is too High");
                    }else if (guess < num)
                    {
                        min = guess;
                        Console.WriteLine(guess + " ,is too Low");
                    }
                    guesses++;
                }
                Console.WriteLine("Win");
                Console.WriteLine("The Number Was: " + num);
                Console.WriteLine("Do You Want to Play Again? (Y/N) ");
                resp = Convert.ToString(Console.ReadLine());
                if(resp.ToUpper() == "Y")
                {
                    Console.WriteLine(" -----------------------");
                    Console.WriteLine("|    Lets Play Again    |");
                    Console.WriteLine(" -----------------------");
                    playAgain = true;
                    min = 1;
                    max = 100;
                }else if(resp.ToUpper() == "N")
                {
                    playAgain = false;
                }
             
            }
            Console.ReadKey();
        }
    }
}
