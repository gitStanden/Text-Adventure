using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to my text adventure game.\n Please start by entering your character name: ");
            PlayerClass player = new PlayerClass(Convert.ToString(Console.ReadLine()), 30, 50.0);
            Weapons silverSword = new Weapons("Silver Sword", 1, 5);

            object[] inventory = { silverSword };

            Console.WriteLine($"\n \n Jorge: \"Abandon ship! Abandon ship!\" \nA crewmate screams as you stand in horror of what is currently tearing the warship to pieces");
            Console.WriteLine($"Nothing could have prepared you for this, and even worse is you were caught unprepared, yet instinctively you draw your silver sword.");
            Console.WriteLine("\nPress the enter key to continue...");
            Console.ReadLine();

            Enemy krakenTentacle = new Enemy("Kraken Tentacle", 35, 0, 3, 7);

            BattleEncounter(krakenTentacle, player, silverSword); //MAGIC NOT IMPLEMENTED
        }

        static int CritCheck(int damage) //Rolls "dice" between 1 and 100 to check for either critical hit or critical miss
        {
            int criticalHitNum;
            Random criticalHitCheck = new Random();
            criticalHitNum = criticalHitCheck.Next(1, 100);

            if (criticalHitNum >= 95)
            {
                Console.WriteLine("CRITICAL HIT!");
                return damage * 2;
            }
            else if (criticalHitNum <= 5)
            {
                Console.WriteLine("CRITICAL MISS!");
                return damage * 0;
            }
            else
            {
                return damage;
            }
        }

        static int Attack(int minDamage, int maxDamage, int health)
        {
            Console.WriteLine($"Attacking! \n");
            Random randDamage = new Random();
            int damage = randDamage.Next(minDamage, maxDamage);
            CritCheck(damage);
            return health -= damage;
        }

        static void BattleEncounter(Enemy enemy, PlayerClass player, Weapons weapon)
        {
            while (enemy.Health > 0 || player.Health > 0)
            {
                Console.WriteLine($"\nBATTLE! \n");

                bool playerTurn = true;
                if (playerTurn == true)
                {
                    Console.WriteLine($"YOUR TURN \n");
                    Console.WriteLine($"{enemy.Name} \n---------- \n HP: {enemy.Health} \n Magic: {enemy.Magic} \n");
                    Console.WriteLine($"{player.Name} \n----------\n HP: {player.Health} \n Magic: {player.Magic} \n");

                    Console.WriteLine($"Type the letter to select an option: A) Attack, B) Run"); //C) Magic
                    char option = Convert.ToChar(Console.ReadLine());

                    if (option == 'A' || option == 'a')
                    {
                        Attack(weapon.MinDamage, weapon.MaxDamage, enemy.Health);
                        Console.WriteLine($"\nEnemy now has {enemy.Health}.\n");
                    }
                    else if (option == 'B' || option == 'b')
                    {
                        Console.WriteLine($"You attempt to run but {enemy.Name} catches up with you.");
                    }
                    playerTurn = false;
                }
                
                if (playerTurn == false)
                {
                    Console.WriteLine($"ENEMY TURN \n");
                    Console.WriteLine($"{enemy.Name} \n---------- \n HP: {enemy.Health} \n Magic: {enemy.Magic} \n");
                    Console.WriteLine($"{player.Name} \n----------\n HP: {player.Health} \n Magic: {player.Magic} \n");

                    Attack(enemy.MinDamage, enemy.MaxDamage, player.Health);
                    Console.WriteLine($"\nYou now have {player.Health}.\n");

                    playerTurn = true;
                }
                
            }
        }
    }
}
