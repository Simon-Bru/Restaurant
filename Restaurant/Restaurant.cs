using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class Restaurant : IRestaurant
    {
        private List<Dish> m_menu;

        public List<Dish> Menu
        {
            get => m_menu;
            set => m_menu = value;
        }

        public void Open()
        {
            // TODO
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            String s = "";
            foreach (Dish plats in m_menu)
            {
                s = s + plats.ToString();
            }
            return s;
        }
    }
}