using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodChain
{
    internal class Menus
    {
        public static void MainMenu()
        {
            bool isInMain = true;

            while (isInMain)
            {
                Console.WriteLine("*----------------------------*");
                Console.WriteLine("|       MCDONALDS MENU       |");
                Console.WriteLine("|                            |");
                Console.WriteLine("| [1] Cheeseburger meals     |");
                Console.WriteLine("| [2] Rice meals             |");
                Console.WriteLine("| [3] Sides                  |");
                Console.WriteLine("| [4] Drinks                 |");
                Console.WriteLine("| [5] Desserts               |");
                Console.WriteLine("| [6] Order Summary          |");
                Console.WriteLine("| [7] Check-out              |");
                Console.WriteLine("*----------------------------*");

                string user_input = Console.ReadLine();

                switch (user_input)
                {
                    case "1":
                        Cheeseburgers.CheeseBurgerMenu();
                        break;
                    case "2":
                        RiceMeals.RiceMealsMenu();
                        break;
                    case "3":
                        Sides.SidesMenu();
                        break;
                    case "4":
                        Drinks.DrinksMenu();
                        break;
                    case "5":
                        Desserts.DessertsMenu();
                        break;
                    case "6":
                        
                        break;
                    case "7":
                        Console.WriteLine("Logging out...");
                        isInMain = false;
                        break;
                    case "032224":
                        Console.WriteLine("Secret Menu!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        public static void CheckoutMenu()
        {
            Console.WriteLine("*----------------------------*");
            Console.WriteLine("| Order:     Quan:    Price: |");
            Console.WriteLine("|----------------------------|");
            Console.WriteLine("|                            |");
            Console.WriteLine("*----------------------------*");
        }
    }
}
