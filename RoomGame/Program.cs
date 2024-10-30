using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoomGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stuff to be implemented (an Inventory system, swords, a dungeon, shops, etc.)
            // List<string> inventory = new List<string>();

            Console.OutputEncoding = System.Text.Encoding.UTF8; // wanted to use arrows to move around earlier, didnt really work out well
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\r\n█░█░█ █▀▀ █░░ █▀▀ █▀█ █▀▄▀█ █▀▀   ▀█▀ █▀█\r\n▀▄▀▄▀ ██▄ █▄▄ █▄▄ █▄█ █░▀░█ ██▄   ░█░ █▄█");
            Console.WriteLine("\r\n██████╗░░█████╗░░█████╗░███╗░░░███╗░██████╗\r\n██╔══██╗██╔══██╗██╔══██╗████╗░████║██╔════╝\r\n██████╔╝██║░░██║██║░░██║██╔████╔██║╚█████╗░\r\n██╔══██╗██║░░██║██║░░██║██║╚██╔╝██║░╚═══██╗\r\n██║░░██║╚█████╔╝╚█████╔╝██║░╚═╝░██║██████╔╝\r\n╚═╝░░╚═╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚═════╝░");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This is a game in which you have enter number inputs\nin order to explore the different rooms. Good luck!");
            Console.WriteLine();
            Console.WriteLine("Please select an option from the menu below!");
            // Allows us to have the ability to continue the game if it's over or the player dies.
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("1. Start game");
                Console.WriteLine("2. Exit Game");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Input: \t ");
                int optionInput = int.Parse(Console.ReadLine());
                switch (optionInput)
                {
                    case 1:
                        EntryArea();
                        break;
                    case 2:
                        ExitGame();
                        break;
                    default:
                        WrongInput();
                        break;

                }
            }

            // The whole map basically
            static void EntryArea()
            {
                Console.Clear();
                Console.Write("\t \t \t     Armorer");
                Console.Write("\t \t");
                Console.Write("  City Hall");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("Weapons Shop");
                Console.Write("\t \tMarket District");
                Console.Write("\t\tCity Square");
                Console.Write("\t \tCastle");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("\t \t \tStables/mounts");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t \tEntry Area");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.WriteLine("\t Your available move positions:");
                Console.WriteLine("\t 1. City Square");
                Console.WriteLine();
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Choose an option: ");
                int moveDirectionOption = int.Parse(Console.ReadLine());
                Thread loading = new Thread(Loading);
                loading.Start();
                Thread waitTime = new Thread(WaitTime);
                waitTime.Start();
                switch (moveDirectionOption)
                {
                    case 1:
                        Console.Clear();   
                        loading.Join();
                        CitySquare();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Attempting to go back...");
                        waitTime.Join();
                        EntryArea();
                        break;
                }

            }
            static void CitySquare()
            {
                Console.Clear();
                Console.Write("\t \t \t     Armorer");
                Console.Write("\t \t");
                Console.Write("  City Hall");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("Weapons Shop");
                Console.Write("\t \tMarket District");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t\tCity Square");
                Console.ResetColor();
                Console.Write("\t \tCastle");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("\t \t \tStables/mounts");
                Console.Write("\t \tEntry Area");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.WriteLine("\t Your available move positions:");
                Console.WriteLine("\t 1. City Hall");
                Console.WriteLine("\t 2. Castle");
                Console.WriteLine("\t 3. Market District");
                Console.WriteLine("\t 4. Go Back");
                Console.WriteLine();
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Choose an option: ");
                int moveDirectionOption = int.Parse(Console.ReadLine());
                Thread loading = new Thread(Loading);
                loading.Start();
                Thread waitTime = new Thread(WaitTime);
                waitTime.Start();
                switch (moveDirectionOption)
                {
                    case 1:
                        Console.Clear();      
                        loading.Join(3000);
                        CityHall();
                        break;
                    case 2:
                        Console.Clear();
                        loading.Join(3000);
                        Castle();
                        break;
                    case 3:
                        Console.Clear();
                        loading.Join(3000);
                        MarketDistrict();
                        break;
                    case 4:
                        Console.Clear();
                        loading.Join(3000);
                        EntryArea();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Attempting to go back...");
                        waitTime.Join();
                        CitySquare();
                        break;
                }
            }
            static void Castle()
            {
                Console.Clear();
                Console.Write("\t \t \t     Armorer");
                Console.Write("\t \t");
                Console.Write("  City Hall");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("Weapons Shop");
                Console.Write("\t \tMarket District");
                Console.Write("\t\tCity Square");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t \tCastle");
                Console.ResetColor();
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("\t \t \tStables/mounts");
                Console.Write("\t \tEntry Area");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.WriteLine("\t Your available move options:");
                Console.WriteLine("\t 1. Attack the King!");
                Console.WriteLine("\t 2. Attempt to steal an item.");
                Console.WriteLine("\t 3. Go Back");
                Console.WriteLine();
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Choose an option: ");
                int moveDirectionOption = int.Parse(Console.ReadLine());
                Thread loading = new Thread(Loading);
                loading.Start();
                Thread jailTime = new Thread(JailTime);
                jailTime.Start();
                Thread waitTime = new Thread(WaitTime);
                waitTime.Start();
                Random random = new Random();
                int roll = random.Next(1, 20);
                int currentMoney = 0;
                Random coins = new Random();
                int stolenCoins;
                switch (moveDirectionOption)
                {
                    case 1:
                        if(roll >= 1 && roll <= 10)
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("You were killed by the guards! Exiting game...");
                            waitTime.Join(4000);
                            Console.ResetColor();
                            ExitGame();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You've barely escaped the guards and live to see another day!");
                            waitTime.Join(4000);
                            Console.ResetColor();
                            CitySquare();
                            break;
                        } 
                    case 2:
                        if (roll >= 1 && roll <= 10)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You've attemped to steal an item but you were caught! Waiting on jail time...");
                            jailTime.Join(5000);                           
                            CitySquare();
                        }
                        else
                        {
                            Console.Clear();
                            stolenCoins = coins.Next(50, 101);
                            currentMoney += stolenCoins;
                            Console.WriteLine($"You've successfuly stolen {currentMoney} coins! >:) Going back...");
                            waitTime.Join(4000);
                            CitySquare();

                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine();
                        loading.Join(3000);
                        CitySquare();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Attempting to go back...");
                        loading.Join(3000);
                        CitySquare();
                        break;
                }

            }
            static void CityHall()
            {
                Console.Clear();
                Console.Write("\t \t \t     Armorer");
                Console.Write("\t \t");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("  City Hall");
                Console.ResetColor();
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("Weapons Shop");
                Console.Write("\t \tMarket District");
                Console.Write("\t\tCity Square");
                Console.Write("\t \tCastle");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("\t \t \tStables/mounts");
                Console.Write("\t \tEntry Area");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.WriteLine("\t Your available move positions:"); 
                Console.WriteLine("\t 1. Go Back. There's nothing to see here really..");
                Console.WriteLine();
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Choose an option: ");
                
                int moveDirectionOption = int.Parse(Console.ReadLine());
                Thread loading = new Thread(Loading);
                loading.Start();
                Thread waitTime = new Thread(WaitTime);
                waitTime.Start();
                switch (moveDirectionOption)
                {
                    case 1:
                        Console.Clear();
                        loading.Join(3000);
                        CitySquare();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Attempting to go back...");
                        waitTime.Join();
                        CitySquare();
                        break;

                }

                }
            static void MarketDistrict()
            {
                Console.Clear();
                Console.Write("\t \t \t     Armorer");
                Console.Write("\t \t");
                Console.Write("  City Hall");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("Weapons Shop");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t \tMarket District");
                Console.ResetColor();
                Console.Write("\t\tCity Square");
                Console.Write("\t \tCastle");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("\t \t \tStables/mounts");
                Console.Write("\t \tEntry Area");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.WriteLine("\t Your available move positions:");
                Console.WriteLine("\t 1. Armorer");
                Console.WriteLine("\t 2. Weapons Shop");
                Console.WriteLine("\t 3. Stables");
                Console.WriteLine("\t 4. Go Back");
                Console.WriteLine();
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Choose an option: ");
                int moveDirectionOption = int.Parse(Console.ReadLine());
                Thread loading = new Thread(Loading);
                loading.Start();
                Thread waitTime = new Thread(WaitTime);
                waitTime.Start();
                switch (moveDirectionOption)
                {
                    case 1:
                        Console.Clear();
                        loading.Join(3000);
                        Armorer();
                        break;
                    case 2:
                        Console.Clear();
                        loading.Join(3000);
                        WeaponsShop();
                        break;
                    case 3:
                        Console.Clear();
                        loading.Join(3000);
                        Stables();
                        break;
                    case 4:
                        Console.Clear();
                        loading.Join(3000);
                        CitySquare();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Attempting to go back...");
                        waitTime.Join();
                        CitySquare();
                        break;
                }


            }
            static void Armorer()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t \t \t     Armorer");
                Console.ResetColor();
                Console.Write("\t \t");
                Console.Write("  City Hall");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("Weapons Shop");
                Console.Write("\t \tMarket District");
                Console.Write("\t\tCity Square");
                Console.Write("\t \tCastle");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("\t \t \tStables/mounts");
                Console.Write("\t \tEntry Area");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.WriteLine("\t Your available move positions:");
                Console.WriteLine("\t 1. This is an unfinished part of the map. Travel back.");
                Console.WriteLine("\t 2. Go Back");
                Console.WriteLine();
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Choose an option: ");
                int moveDirectionOption = int.Parse(Console.ReadLine());
                Thread loading = new Thread(Loading);
                loading.Start();
                Thread waitTime = new Thread(WaitTime);
                waitTime.Start();
                switch (moveDirectionOption)
                {
                    case 1:
                        Console.Clear();
                        loading.Join(3000);
                        MarketDistrict();
                        break;
                    case 2:
                        Console.Clear();
                        loading.Join(3000);
                        MarketDistrict();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Attempting to go back...");
                        waitTime.Join();
                        MarketDistrict();
                        break;
                }

            }
            static void WeaponsShop()
            {
                Console.Clear();
                Console.Write("\t \t \t     Armorer");
                Console.Write("\t \t");
                Console.Write("  City Hall");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Weapons Shop");
                Console.ResetColor();
                Console.Write("\t \tMarket District");
                Console.Write("\t\tCity Square");
                Console.Write("\t \tCastle");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("\t \t \tStables/mounts");
                Console.Write("\t \tEntry Area");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.WriteLine("\t Your available move positions:");
                Console.WriteLine("\t 1. This is an unfinished part of the map. Travel back.");              
                Console.WriteLine("\t 2. Go Back");
                Console.WriteLine();
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Choose an option: ");
                int moveDirectionOption = int.Parse(Console.ReadLine());
                Thread loading = new Thread(Loading);
                loading.Start();
                Thread waitTime = new Thread(WaitTime);
                waitTime.Start();
                switch (moveDirectionOption)
                {
                    case 1:
                        Console.Clear();
                        loading.Join(3000);
                        MarketDistrict();
                        break;
                    case 2:
                        Console.Clear();
                        loading.Join(3000);
                        MarketDistrict();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Attempting to go back...");
                        waitTime.Join();
                        MarketDistrict();
                        break;
                }
            }
            static void Stables()
            {
                
                Console.Clear();
                Console.Write("\t \t \t     Armorer");
                Console.Write("\t \t");
                Console.Write("  City Hall");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.Write("Weapons Shop");
                Console.Write("\t \tMarket District");
                Console.Write("\t\tCity Square");
                Console.Write("\t \tCastle");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t \t \tStables/mounts");
                Console.ResetColor();
                Console.Write("\t \tEntry Area");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.WriteLine("\t Your available move positions:");
                Console.WriteLine("\t 1. Attempt to steal a horse!");
                Console.WriteLine("\t 2. Feed the horse");
                Console.WriteLine("\t 3. Go Back");
                Console.WriteLine();
                Console.WriteLine("---------===================---------");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Choose an option: ");
                int moveDirectionOption = int.Parse(Console.ReadLine());
                Random random = new Random();
                int roll = random.Next(1, 20);
                Thread loading = new Thread(Loading);
                loading.Start();
                Thread waitTime = new Thread(WaitTime);
                waitTime.Start();
                switch (moveDirectionOption)
                {
                    case 1:
                        if(roll >= 1 && roll <= 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("Congratulations. You just got stomped to death by a.. HORSE? You fool! Exiting game...");
                            waitTime.Join(4000);
                            Console.ResetColor();
                            ExitGame();
                            break;
                            
                        }
                        else {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("A crazy horse is on the loose. You almost escaped getting stomped by it.. phew. Attempting to go back.");
                            waitTime.Join(4000);
                            Console.ResetColor();
                            MarketDistrict();
                            break;
                        }
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        Console.WriteLine("You fed the horse, he's happy now :D Going back..");
                        waitTime.Join(4000);
                        Console.ResetColor();
                        MarketDistrict();
                        break;
                    case 3:
                        Console.Clear();
                        waitTime.Join(4000);
                        MarketDistrict();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Attempting to go back...");
                        waitTime.Join();
                        MarketDistrict();
                        break;
                }

            }
            // A method that exits/restarts the game if the player dies or something goes wrong.
            static void ExitGame()
            {
                Console.Clear();
                Console.WriteLine("You've exited the game!");
                Console.WriteLine("Please select an option");
            }
            // A method to deal with wrong inputs
            static void WrongInput()
            {
                Console.Clear();
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\r\n█░█░█ █▀▀ █░░ █▀▀ █▀█ █▀▄▀█ █▀▀   ▀█▀ █▀█\r\n▀▄▀▄▀ ██▄ █▄▄ █▄▄ █▄█ █░▀░█ ██▄   ░█░ █▄█");
                Console.WriteLine("\r\n██████╗░░█████╗░░█████╗░███╗░░░███╗░██████╗\r\n██╔══██╗██╔══██╗██╔══██╗████╗░████║██╔════╝\r\n██████╔╝██║░░██║██║░░██║██╔████╔██║╚█████╗░\r\n██╔══██╗██║░░██║██║░░██║██║╚██╔╝██║░╚═══██╗\r\n██║░░██║╚█████╔╝╚█████╔╝██║░╚═╝░██║██████╔╝\r\n╚═╝░░╚═╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚═════╝░");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please input a valid number!");
                Console.WriteLine("Your options are:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("1. Start game");
                Console.WriteLine("2. Exit Game");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Input: ");
                int optionInput = int.Parse(Console.ReadLine());


                switch (optionInput)
                {
                    case 1:
                        EntryArea();
                        break;
                    case 2:
                        ExitGame();
                        break;
                    default:
                        Console.ResetColor();
                        WrongInput();
                        break;

                }
            }
            // Wait times for when there's an action happening
            static void Loading()
            {
                Console.WriteLine("Loading...");
                Thread.Sleep(500);
            }
            static void JailTime()
            {
                Console.WriteLine("You were caught by the guards! You are serving jail time for a whole 5 seconds.");
                Thread.Sleep(5000);
            }
            static void WaitTime()
            {              
                Thread.Sleep(4000);
            }
        }
    }
}




