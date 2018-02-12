namespace Restaurant
{
    delegate bool selectDish(Dish dish);

    public class Customer
    {
        private string name;

        
        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}