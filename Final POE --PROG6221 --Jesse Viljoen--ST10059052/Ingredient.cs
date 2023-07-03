namespace RecipeApp
{
    internal class Ingredient
    {
        private string name;
        private int calories;
        private string foodGroup;
        private int quantity;
        private string unit;

        public Ingredient(string name, int calories, string foodGroup, int quantity, string unit)
        {
            this.name = name;
            this.calories = calories;
            this.foodGroup = foodGroup;
            this.quantity = quantity;
            this.unit = unit;
        }

        public object Name { get; internal set; }
        public object FoodGroup { get; internal set; }
    }
}