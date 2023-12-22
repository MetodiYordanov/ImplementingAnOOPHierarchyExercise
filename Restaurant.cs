using System;
using System.Collections.Generic;

namespace ExerciseOopHierarchy
{
    public class Restaurant
    {
        private List<Customer> _customers = new();
        private List<MenuItem> _menu = new();

        public void AddCustomer(Customer customer)
        {
            this._customers.Add(customer);
        }

        public MenuItem GetMenuItem(int index)
        {
            if (index < 0 || index > this._menu.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            return this._menu[index];
        }

        public void AddMenuItem(MenuItem item)
        {
            this._menu.Add(item);
        }

        public void PlaceOrder(Customer customer, Order order)
        {
            customer.AddOrder(order);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");
            foreach (MenuItem currentItem in this._menu)
            {
                Console.WriteLine(currentItem.ToString());
            }
        }

        public void DisplayOrderHistory(Customer customer)
        {
            Console.WriteLine($"{customer.Name}'s Order History:");

            foreach (Order order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Total: ${order.GetTotal():F2}");

                foreach (MenuItem item in order.Items)
                {
                    Console.WriteLine($"  {item}");
                }
            }
        }
    }
}
