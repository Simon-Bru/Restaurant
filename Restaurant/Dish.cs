using System;

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
    }
}