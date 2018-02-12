using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Restaurant
{
    public class Restaurant : IRestaurant
    {
        private List<Dish> menu;

        public List<Dish> Menu
        {
            get => menu;
            set => menu = value;
        }

        public void Open()
        {
            XmlSerializer xd = new XmlSerializer(typeof(List<Dish>));

            using (StreamReader rd = new StreamReader("myMenu.xml"))
            {
                this.Menu = xd.Deserialize(rd) as List<Dish>; //deserialize
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (Dish plats in menu)
            {
                s = s + plats.ToString();
            }
            return s;
        }
    }
}