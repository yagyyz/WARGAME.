using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            
            while (playAgain)
            { 

                    int playerHp = 40;
                    int enemyHp = 20;
                    int playerAttack = 5;
                    int enemyAttack = 7;
                    int healAmount = 5;
                    int enemyhealAmount = 6;
                    
                    Random random = new Random();


            while( playerHp > 0 && enemyHp > 0 )
            {
                // Player Turn
                Console.WriteLine("-- Player Turn --");
                Console.WriteLine("Player HP: " + playerHp + " Enemy HP: " + enemyHp + "");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player Attack Enemy And Deals " + playerAttack + " Damage!");
                }
                else if (choice == "h")
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player Restore " + healAmount + " Health Points ");
                }

                // Enemy Turn
                if (enemyHp > 0)
                {
                    Console.WriteLine("-- Enemy Turn --");
                    Console.WriteLine("Player HP: " + playerHp + " Enemy HP: " + enemyHp + "");
                    int enemtChoice = random.Next(0,2);

                    if( enemtChoice == 0 ) 
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy Attack Player And Deals " + enemyAttack + " Damage!");
                    }
                    else 
                    {
                        enemyHp += enemyhealAmount;
                        Console.WriteLine("Enemy Restore " + enemyhealAmount + " Health Points ");

                    }
                }


            }
            if( playerHp > 0)
            {
                Console.WriteLine("PLAYER WON!!!");
            }
            else {
                Console.WriteLine("ENEMY WON!!!");

            }

                Console.WriteLine("Do You Want Play Again y/n");
                string loop = Console.ReadLine();
                if (loop == "y") 
                {
                    playAgain = true;
                    Console.Clear();
                }
                else
                {
                    playAgain= false;
                }
            }
       }      
    }
}
