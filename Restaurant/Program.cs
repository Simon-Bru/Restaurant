using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Restaurant
{
    public delegate List<Dish> fillMenu();
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Restaurant restaurant = new Restaurant(delegate
            {
                XmlSerializer xd = new XmlSerializer(typeof(List<Dish>));

                using (StreamReader rd = new StreamReader("myMenu.xml"))
                {
                    return xd.Deserialize(rd) as List<Dish>;
                }
            });
            
            restaurant.Open();
             
            Console.Write(restaurant.ToString());
        }
    }
}