using System;
namespace NeighbourWarsGame
{
    class NeighbourWarsGame
    {
        public static void Main(string[] args)
        {

            try
            {
                //input and checking data for Pesho
                Console.Write("Enter Pesho’s damage (0-100): ");
                int peshoDamage = int.Parse(Console.ReadLine());
                while (peshoDamage < 0 || peshoDamage > 100)
                {
                    Console.Write("Wrong number for Pesho's demage! It must be between 1 and 100: ");
                    peshoDamage = int.Parse(Console.ReadLine());
                }

                //input and checking data for Gosho
                Console.Write("Enter Gosho’s damage (0-100): ");
                int goshoDamage = int.Parse(Console.ReadLine());
                while (goshoDamage < 0 || goshoDamage > 100)
                {
                    Console.Write("Wrong number for Gosho's demage! It must be between 1 and 100: ");
                    goshoDamage = int.Parse(Console.ReadLine());
                }

                int peshoHealthPoints = 100;
                int goshoHealthPoints = 100;
                int turn = 1;

                while (true)
                {

                    if (turn % 2 == 0)
                    {                    //Gosho attacks
                        peshoHealthPoints -= goshoDamage;
                        if (peshoHealthPoints <= 0)
                        {
                            break;
                        }
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealthPoints} health.");

                    }
                    else
                    {                                //Pesho attacks
                        goshoHealthPoints -= peshoDamage;
                        if (goshoHealthPoints <= 0)
                        {
                            break;
                        }
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealthPoints} health.");
                    }

                    turn++;

                    if ((turn - 1) % 3 == 0)
                    {
                        peshoHealthPoints += 10;
                        goshoHealthPoints += 10;
                    }

                    if (peshoHealthPoints <= 0 || goshoHealthPoints <= 0)
                    {
                        break;
                    }

                }

                if (goshoHealthPoints > peshoHealthPoints)
                {
                    Console.WriteLine($"Gosho won in {turn}th round.");
                }
                else
                {
                    Console.WriteLine($"Pesho won in {turn}th round.");
                }

            }
            catch
            {
                Console.WriteLine("Invalid input! Start from the beginning!");
            }
        }
    }
}