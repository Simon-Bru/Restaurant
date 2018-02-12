using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

public enum Course
{
    DESSERT, 
    MAIN , 
    STARTER 
}

namespace Restaurant
{
    public class Dish
    {
        private String m_name;
        private Course m_course;
        private int m_calories;
        private int m_price;
        private Boolean m_vegan;

        public Dish() {}
        
        public string name
        {
            get => m_name;
            set => m_name = value;
        }

        public Course course
        {
            get => m_course;
            set => m_course = value;
        }

        public int calories
        {
            get => m_calories;
            set => m_calories = value;
        }

        public int price
        {
            get => m_price;
            set => m_price = value;
        }

        public bool vegan
        {
            get => m_vegan;
            set => m_vegan = value;
        }

        public override string ToString()
        {
            return "Name :\t"+this.name+"\nCourse:\t"+this.course+"\nPrice:\t"+this.price+"\nVegan:\t"+this.vegan+"\nCalories:"+this.calories+"\n";
        } 
    }
}