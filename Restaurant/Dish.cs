﻿using System;

public enum Course
{
    DESSERT, MAIN , STARTER 
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

        public string Name
        {
            get => m_name;
            set => m_name = value;
        }

        public Course Course
        {
            get => m_course;
            set => m_course = value;
        }

        public int Calories
        {
            get => m_calories;
            set => m_calories = value;
        }

        public int Price
        {
            get => m_price;
            set => m_price = value;
        }

        public bool Vegan
        {
            get => m_vegan;
            set => m_vegan = value;
        }
    }
}