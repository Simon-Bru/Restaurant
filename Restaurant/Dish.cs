using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

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

        public override string ToString()
        {
            return "Name :\t"+this.m_name+"\nCourse:\t"+this.m_course+"\nPrice:\t"+this.m_price+"\nVegan:\t"+this.m_vegan+"\nCalories:"+this.m_calories;
        } 
    }
}