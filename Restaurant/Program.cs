using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Restaurant
{
    public delegate List<Dish> fillMenu();
    public delegate bool selectDish(Dish dish);
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Restaurant fastfood = new Restaurant(() =>
            {
                XmlSerializer xd = new XmlSerializer(typeof(List<Dish>));

                using (StreamReader rd = new StreamReader("fastfoodMenu.xml"))
                {
                    return xd.Deserialize(rd) as List<Dish>;
                }
            });
            fastfood.Open();
            
            Restaurant italian = new Restaurant(() =>
            {
                XmlSerializer xd = new XmlSerializer(typeof(List<Dish>));

                using (StreamReader rd = new StreamReader("italianMenu.xml"))
                {
                    return xd.Deserialize(rd) as List<Dish>;
                }
            });
            italian.Open();
            
            
            Customer Michel = new Customer();
            Michel.Name = "Michel";
            Michel.preferences = dish => dish.vegan == false && dish.price < 10;
            
            Customer Roger = new Customer();
            Roger.Name = "Roger";
            Roger.preferences = dish => dish.vegan;
             
            Console.Write(italian.ToString());
        }
    }
}