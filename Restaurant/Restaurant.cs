using System;
using System.Collections.Generic;

namespace Restaurant
{    
    public class Restaurant : IRestaurant
    {
        private fillMenu leChef;

        private List<Dish> Menu { get; set; }

        public Restaurant(fillMenu chef)
        {
            this.leChef = chef;
        }

        public void Open()
        {
            this.Menu = this.leChef();
        }

        public void Welcome(Customer customer)
        {
            Console.WriteLine("Welcome "+ customer.Name +", take a seat");
            meal meal = this.placeOrder(customer);
            Console.WriteLine("Here's your bill: \nCalories: "+meal.Energy+"\nTotal: "+meal.Bill+"$\n\n");
        }

        private meal placeOrder(Customer customer)
        {
            meal customerMeal = new meal();
            this.Menu.ForEach(dish =>
            {
                if (customer.preferences(dish))
                {
                    Console.WriteLine("I'm having "+ dish.name);
                    customerMeal.Bill += dish.price;
                    customerMeal.Energy += dish.calories;
                }
            });
            return customerMeal;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Dish plats in Menu)
            {
                s = s + plats.ToString();
                s = s + "\n";
            }
            return s;
        }
    }
}