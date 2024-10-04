using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodChain
{
    internal class RiceMeals
    {
        public static void RiceMealsMenu()
        {
            bool isInRiceM = true;

            while (isInRiceM)
            {
                Console.WriteLine("*----------------------------*");
                Console.WriteLine("|         RICE MEALS         |");
                Console.WriteLine("|                            |");
                Console.WriteLine("| [1] Original McChicken     |");
                Console.WriteLine("| [2] 2-Piece Original       |");
                Console.WriteLine("| [3] Spicy McChicken        |");
                Console.WriteLine("| [4] 2-Piece Spicy          |");
                Console.WriteLine("| [5] Ala King               |");
                Console.WriteLine("| [6] Pepper Steak           |");
                Console.WriteLine("| [7] Back                   |");
                Console.WriteLine("*----------------------------*");

                string user_input = Console.ReadLine();

                switch (user_input)
                {
                    case "1":
                        Console.WriteLine("\nOriginal McChicken Meal: $7");
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
                                Console.WriteLine("Returning to Rice Meals Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("\n2-Piece McChicken Meal: $13");
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
                                Console.WriteLine("Returning to Rice Meals Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nSpicy McChicken Meal: $8");
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
                                Console.WriteLine("Returning to Rice Meals Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("\n 2-Piece Spicy McChicken Meal: $15");
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
                                Console.WriteLine("Returning to Rice Meals Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("\n Ala King Meal: $7");
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
                                Console.WriteLine("Returning to Rice Meals Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("\nPepper Steak Meal: $7");
                        Console.WriteLine("Would you like to add to your order?");
                        Console.WriteLine("Yes or No [1][2]");

                        string user_input7 = Console.ReadLine();
                        switch (user_input7)
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
                                Console.WriteLine("Returning to Rice Meals Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "7":
                        Console.WriteLine("Going back to the main menu...");
                        isInRiceM = false;  // Set to false to exit the loop
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
