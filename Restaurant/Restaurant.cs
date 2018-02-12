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

        public void Welcome()
        {
            throw new NotImplementedException();
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