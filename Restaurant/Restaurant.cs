using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Restaurant
{
    public class Restaurant : IRestaurant
    {
        private delegate List<Dish> FillMenu();

        private List<Dish> Menu { get; set; }

        public void Open()
        {
            XmlSerializer xd = new XmlSerializer(typeof(List<Dish>));

            using (StreamReader rd = new StreamReader("myMenu.xml"))
            {
                this.Menu = xd.Deserialize(rd) as List<Dish>; //deserialize
            }
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