using System;
using System.Collections.Generic;

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
            // TODO
            return base.ToString();
        }
    }
}