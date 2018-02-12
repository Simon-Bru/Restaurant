namespace Restaurant
{
    public struct meal
    {
        private int energy;
        private int bill;

        public int Energy
        {
            get => energy;
            set => energy = value;
        }

        public int Bill
        {
            get => bill;
            set => bill = value;
        }
    }
}