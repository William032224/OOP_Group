using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodChain
{
    class OrderSummary
    {
        public class Order
        {
            public string Item { get; set; }
            public int Quantity { get; set; }


            public Order(string item, int quantity)
            {
                Item = item;
                Quantity = quantity;
            }
        }

        // Class managing order operations
        public class OrderManager
        {
            public List<Order> orders; // List to store orders

            public OrderManager()
            {
                orders = new List<Order>();
            }

            // Method to add an order
            public void AddOrder(string itemName, int itemPrice)
            {
                Console.WriteLine($"\n{itemName}: ${itemPrice}");
                Console.WriteLine("Would you like to add to your order?");
                Console.WriteLine("Yes or No [1][2]");

                string user_input2 = Console.ReadLine();
                switch (user_input2)
                {
                    case "1":
                        Console.Write("Quantity: ");
                        string quantityInput = Console.ReadLine();
                        if (int.TryParse(quantityInput, out int quantity))
                        {
                            orders.Add(new Order(itemName, quantity)); // Add order to list
                            Console.WriteLine($"Added {quantity} x {itemName} to order!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid quantity. Please enter a number.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Returning to Cheeseburger Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            // Method to display all current orders
            public void DisplayOrders()
            {
                if (orders.Count == 0)
                {
                    Console.WriteLine("No orders have been placed yet.");
                }
                else
                {
                    Console.WriteLine("\nCurrent Orders:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine($"{order.Quantity} x {order.Item}");
                    }
                }
            }
        }
    }
}
