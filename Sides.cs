using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodChain
{
    internal class Sides
    {
        public static void SidesMenu()
        {
            bool isInSidesM = true;

            while (isInSidesM)
            {
                Console.WriteLine("*----------------------------*");
                Console.WriteLine("|           SIDES            |");
                Console.WriteLine("|                            |");
                Console.WriteLine("| [1] Spaghetti              |");
                Console.WriteLine("| [2] Chicken Nuggets        |");
                Console.WriteLine("| [3] Rice                   |");
                Console.WriteLine("| [4] Fries                  |");
                Console.WriteLine("| [5] Hash Browns            |");
                Console.WriteLine("| [6] Back                   |");
                Console.WriteLine("*----------------------------*");

                string user_input = Console.ReadLine();

                switch (user_input)
                {
                    case "1":
                        Console.WriteLine("\nSpaghetti: $5");
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
                                Console.WriteLine("Returning to Sides Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nChicken Nuggets: $7");
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
                                Console.WriteLine("Returning to Sides Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nExtra Rice: $1");
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
                                Console.WriteLine("Returning to Sides Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("\nFries: $4");
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
                                Console.WriteLine("Returning to Sides Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("\nHash Browns: $4");
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
                                Console.WriteLine("Returning to Sides Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Going back to the main menu...");
                        isInSidesM = false;  // Set to false to exit the loop
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
