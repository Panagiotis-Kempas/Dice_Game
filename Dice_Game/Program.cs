using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerScore = 0;
            int computerScore = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to role tha Dice.");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a "+ playerRandomNum);
                
                
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);


                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Computer rolled a " + enemyRandomNum);
                if(playerRandomNum > enemyRandomNum)
                {
                    playerScore++;
                    Console.WriteLine("Player win this round");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    computerScore++;
                    Console.WriteLine("Computer win this round");
                }
                else
                {
                    Console.WriteLine("DRAW!!!");
                }

                Console.WriteLine("THE SCORES NOW IS:\nPLAYER :{0}\tCOMPUTER :{1}",playerScore,computerScore);
                Console.WriteLine();

                

            }
            if(playerScore > computerScore)
            {
                Console.WriteLine("You win!");
            }
            else if(playerScore < computerScore)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It s a draw!");
            }

            Console.ReadKey();
            
        }
    }
}
