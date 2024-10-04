using System;
using System.Collections.Generic;
using static FastFoodChain.OrderSummary;

// Order class to store item and quantity

public class Cheeseburgers
{
    public static void CheeseBurgerMenu()
    {
        bool isInChizB = true;
        OrderManager orderManager = new OrderManager(); // Instantiate OrderManager

        while (isInChizB)
        {
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("|       CHEESEBURGERS        |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| [1] Original               |");
            Console.WriteLine("| [2] Double                 |");
            Console.WriteLine("| [3] Triple                 |");
            Console.WriteLine("| [4] Quarter Pounder        |");
            Console.WriteLine("| [5] Big Mac                |");
            Console.WriteLine("| [6] Back                   |");
            Console.WriteLine("| [7] View Orders            |"); // Option to view current orders
            Console.WriteLine("*----------------------------*");

            string user_input = Console.ReadLine();

            switch (user_input)
            {
                case "1":
                    orderManager.AddOrder("Original Cheeseburger", 5);
                    break;
                case "2":
                    orderManager.AddOrder("Double Cheeseburger", 9);
                    break;
                case "3":
                    orderManager.AddOrder("Triple Cheeseburger", 14);
                    break;
                case "4":
                    orderManager.AddOrder("Quarter Pounder Meal", 19);
                    break;
                case "5":
                    orderManager.AddOrder("Big Mac Meal", 23);
                    break;
                case "6":
                    Console.WriteLine("Going back to the main menu...");
                    isInChizB = false;  // Set to false to exit the loop
                    break;
                case "7":
                    orderManager.DisplayOrders(); // Display current orders
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

    // Method to add an order
    
