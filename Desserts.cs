using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodChain
{
    internal class Desserts
    {
        public static void DessertsMenu()
        {
            bool isInDessertsM = true;

            while (isInDessertsM)
            {
                Console.WriteLine("*----------------------------*");
                Console.WriteLine("|         DESSERTS           |");
                Console.WriteLine("|                            |");
                Console.WriteLine("| [1] Vanilla Sundae         |");
                Console.WriteLine("| [2] Hot Fudge Sundae       |");
                Console.WriteLine("| [3] Caramel Sundae         |");
                Console.WriteLine("| [4] Oreo McFlurry          |");
                Console.WriteLine("| [5] Apple Pie              |");
                Console.WriteLine("| [6] Back                   |");
                Console.WriteLine("*----------------------------*");

                string user_input = Console.ReadLine();

                switch (user_input)
                {
                    case "1":
                        Console.WriteLine("\nVanilla Sundae: $0.5");
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
                                Console.WriteLine("Returning to Desserts Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nHot Fudge Sundae: $0.6");
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
                                Console.WriteLine("Returning to Desserts Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nCaramel Sundae: $0.6");
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
                                Console.WriteLine("Returning to Desserts Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("\nOreo McFlurry: $0.7");
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
                                Console.WriteLine("Returning to Desserts Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("\nApple Pie: $0.6");
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
                                Console.WriteLine("Returning to Desserts Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Going back to the main menu...");
                        isInDessertsM = false;  // Set to false to exit the loop
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
