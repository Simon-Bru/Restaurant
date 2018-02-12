using System;

public enum Course
{
    DESSERT, MAIN , STARTER 
}

namespace Restaurant
{
    public class Dish
    {
        public String name;
        public Course course;
        public int calories;
        public int price;
        public Boolean vegan;

        public Dish() {}
        
        public string Name
        {
            get => name;
            set => name = value;
        }

        public Course Course
        {
            get => course;
            set => course = value;
        }

        public int Calories
        {
            get => calories;
            set => calories = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public bool Vegan
        {
            get => vegan;
            set => vegan = value;
        }
    }
}