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
        public Dish() {}
        
        public string name { get; set; }

        public Course course { get; set; }

        public int calories { get; set; }

        public int price { get; set; }

        public bool vegan { get; set; }

        public override string ToString()
        {
            return "Name :\t"+this.name+"\nCourse:\t"+this.course+"\nPrice:\t"+this.price+"\nVegan:\t"+this.vegan+"\nCalories:"+this.calories+"\n";
        } 
    }
}