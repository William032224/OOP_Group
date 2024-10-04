using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodChain
{
    internal class Drinks
    {
        public static void DrinksMenu()
        {
            bool isInDrinksM = true;

            while (isInDrinksM)
            {
                Console.WriteLine("*----------------------------*");
                Console.WriteLine("|           DRINKS           |");
                Console.WriteLine("|                            |");
                Console.WriteLine("| [1] Coke                   |");
                Console.WriteLine("| [2] Coke Zero              |");
                Console.WriteLine("| [3] Sprite                 |");
                Console.WriteLine("| [4] Royal                  |");
                Console.WriteLine("| [5] Bottled Water          |");
                Console.WriteLine("| [6] Back                   |");
                Console.WriteLine("*----------------------------*");

                string user_input = Console.ReadLine();

                switch (user_input)
                {
                    case "1":
                        Console.WriteLine("\nCoke: $0.5");
                        Console.WriteLine("Would you like to add to your order?");
                        Console.WriteLine("Yes or No [1][2]");

                        string user_input2 = Console.ReadLine();
                        switch (user_input2)
                        {
                            case "1":
                                Console.Write("Quantity: ");
                                string quantityInput = Console.ReadLine();  // Read entire line
                                if (int.TryParse(quantityInput, out int quantity))  // Parse to int
                                {
                                    Console.WriteLine($"Added {quantity} to order!");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid quantity. Please enter a number.");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Returning to Drinks Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nCoke Zero: $0.5");
                        Console.WriteLine("Would you like to add to your order?");
                        Console.WriteLine("Yes or No [1][2]");

                        string user_input3 = Console.ReadLine();
                        switch (user_input3)
                        {
                            case "1":
                                Console.Write("Quantity: ");
                                string quantityInput = Console.ReadLine();  // Read entire line
                                if (int.TryParse(quantityInput, out int quantity))  // Parse to int
                                {
                                    Console.WriteLine($"Added {quantity} to order!");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid quantity. Please enter a number.");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Returning to Drinks Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nSprite: $0.5");
                        Console.WriteLine("Would you like to add to your order?");
                        Console.WriteLine("Yes or No [1][2]");

                        string user_input4 = Console.ReadLine();
                        switch (user_input4)
                        {
                            case "1":
                                Console.Write("Quantity: ");
                                string quantityInput = Console.ReadLine();  // Read entire line
                                if (int.TryParse(quantityInput, out int quantity))  // Parse to int
                                {
                                    Console.WriteLine($"Added {quantity} to order!");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid quantity. Please enter a number.");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Returning to Drinks Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("\nRoyal: $0.5");
                        Console.WriteLine("Would you like to add to your order?");
                        Console.WriteLine("Yes or No [1][2]");

                        string user_input5 = Console.ReadLine();
                        switch (user_input5)
                        {
                            case "1":
                                Console.Write("Quantity: ");
                                string quantityInput = Console.ReadLine();  // Read entire line
                                if (int.TryParse(quantityInput, out int quantity))  // Parse to int
                                {
                                    Console.WriteLine($"Added {quantity} to order!");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid quantity. Please enter a number.");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Returning to Drinks Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("\nBottled Water: $0.5");
                        Console.WriteLine("Would you like to add to your order?");
                        Console.WriteLine("Yes or No [1][2]");

                        string user_input6 = Console.ReadLine();
                        switch (user_input6)
                        {
                            case "1":
                                Console.Write("Quantity: ");
                                string quantityInput = Console.ReadLine();  // Read entire line
                                if (int.TryParse(quantityInput, out int quantity))  // Parse to int
                                {
                                    Console.WriteLine($"Added {quantity} to order!");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid quantity. Please enter a number.");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Returning to Drinks Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Going back to the main menu...");
                        isInDrinksM = false;  // Set to false to exit the loop
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
