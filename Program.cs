using System;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNumber, enemyRandomNumber;
            int playerPoints = 0, enemyPoints = 0, round = 0; 
            ConsoleKeyInfo key; 
            Random random = new Random();

            for( int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll");
                key = Console.ReadKey();
                //Console.WriteLine(key.Key.ToString());

                playerRandomNumber = random.Next(1, 10);
                enemyRandomNumber = random.Next(1, 10);

                round++;
                Console.WriteLine("...........");


                if ( playerRandomNumber > enemyRandomNumber )
                {
                    playerPoints++;
                    Console.WriteLine("Player Random Number: " + playerRandomNumber);
                    Console.WriteLine("Enemy Random Number: " + enemyRandomNumber);
                    Console.WriteLine("Player wins round " + round);

                }
                else if(playerRandomNumber < enemyRandomNumber)
                {
                    enemyPoints++;
                    Console.WriteLine("Player Random Number: " + playerRandomNumber);
                    Console.WriteLine("Enemy Random Number: " + enemyRandomNumber);
                    Console.WriteLine("Enemy wins round " + round);

                }
                else
                {
                    Console.WriteLine("Player Random Number: " + playerRandomNumber);
                    Console.WriteLine("Enemy Random Number: " + enemyRandomNumber);
                    Console.WriteLine("Its a tie!");
                }
                Console.WriteLine("..........."); 
            }

            if( playerPoints > enemyPoints)
            {
                Console.WriteLine("Player Wins the game"); 
            }
            else if( playerPoints < enemyPoints)
            {
                Console.WriteLine("Enemy Wins the game");
            }
            else
            {
                Console.WriteLine("Its a draw!"); 
            }
        }
    }
}
