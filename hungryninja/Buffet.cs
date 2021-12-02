namespace hungryninja
{
    public class Buffet
        {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Rice", "Corn", "Meat", "Vegetables", "Tofu", "Sushi", "Cookie")
            };
        }
        
        public Food Serve()
        {
            Random rand = new Random();

        }
    }
}