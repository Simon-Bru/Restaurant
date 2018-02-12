using System;

namespace Restaurant
{
    public delegate bool selectDish(Dish dish);
    class Program
    {
        private bool PreferencesMichel(Dish dish)
        {
            if (dish.vegan == false && dish.price < 10)
            {
                return true;
            }
            else return false;
        }
        private bool PreferencesRoger(Dish dish)
        {
            if (dish.vegan == true)
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Open();
            Customer Michel = new Customer();
            Michel.Name = "Michel";
            Michel.preferences = delegate(Dish dish) {
                return dish.vegan == false && dish.price < 10; 
            };
            Customer Roger = new Customer();
            Roger.Name = "Roger";
            Roger.preferences = delegate(Dish dish) {
                return dish.vegan; 
            };
             
            Console.Write(restaurant.ToString());
        }
    }
}