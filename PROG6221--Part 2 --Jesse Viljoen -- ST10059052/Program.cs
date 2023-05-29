// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;

namespace RecipeApp
{
    class Recipe
    {// This where you are declaring the arrays //
        private string name3;
        private int num5Ingredients;
        private string[] ingredients6;
        private int[] quantities5;
        private int[] origQuantities;
        private string[] units9;
        private int numberSteps;
        private string[] steps2;
        public int Quantity { get; set; }
        private List<Ingredient> ingredients = new List<Ingredient>();
//The arrayList//
        private List<string> steps = new List<string>();
        private string name;
        private object newRecipe;
        private object recipes;

        public string Name { get => name3; set => name3 = value; }
        public List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
        public int TotalCalories { get; set; }
       
        public delegate void RecipeExceedsCaloriesHandler(Recipe recipe);//The 300-calories notification is done using a delegate


        public Recipe(string name3)
        {
            this.Name = name3;

            //This an default constructor
        }

        public Recipe()
        {
        }
        // This block of code contains the calculation of the total calories//
        public int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (Ingredient ingredient in this.ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            if (totalCalories > 300)
            {
                Console.WriteLine("You have reach the limit of calories");
            }
            return totalCalories;
        }
        //This block of code will call to another ingredient to the recipe//
        public void AddIngredient(Ingredient ingredient)
        {
            this.ingredients.Add(ingredient);
        }
        //The method of EnterRecipe will allow the user enter the recipe and display the recipe//
        public void EnterRecipe()
        {
            Console.WriteLine("Enter recipe name:");
            name3 = Console.ReadLine();
            Console.WriteLine("Enter number of ingredients:");
            num5Ingredients = int.Parse(Console.ReadLine());
            ingredients6 = new string[num5Ingredients];
            quantities5 = new int[num5Ingredients];
            origQuantities = new int[num5Ingredients];
            units9 = new string[num5Ingredients];

            for (int j = 0; j < num5Ingredients; j++)
            {
                Console.WriteLine("\nIngredient " + (j + 1) + ":");
                Console.WriteLine("--------------------");
                Console.WriteLine("Enter name of ingredient " + (j + 1) + ":");
                ingredients6[j] = Console.ReadLine();
                Console.WriteLine("Enter quantity of ingredient " + (j + 1) + ":");
                quantities5[j] = int.Parse(Console.ReadLine());
                origQuantities[j] = quantities5[j];
                Console.WriteLine("Enter unit of measurement for ingredient " + (j + 1) + ":");
                units9[j] = Console.ReadLine();
            }

            Console.WriteLine("\n\nEnter the number of steps:");
            Console.WriteLine("------------------------");
            numberSteps = int.Parse(Console.ReadLine());
            steps2 = new string[numberSteps];

            for (int j = 0; j < numberSteps; j++)
            {
                Console.WriteLine("Enter description of the steps " + " " + (j + 1) + ":");
                steps2[j] = Console.ReadLine();
            }
            Console.WriteLine("Your Recipe you typed: \n");
            Console.WriteLine("Recipe you Name: " + name3);
            Console.WriteLine("Ingredients are:");
            for (int j = 0; j < num5Ingredients; j++)
            {
                Console.WriteLine(" " + quantities5[j] + " " + units9[j] + " of " + ingredients6[j]);
            }
            Console.WriteLine("Steps:");
            for (int j = 0; j < numberSteps; j++)
            {
                Console.WriteLine((j + 1) + ". " + steps2[j]);
            }
            Console.WriteLine($"Enter calories of {name}:");
            int calories = Convert.ToInt32(Console.ReadLine());
        
          
            Console.WriteLine($"Enter food group of {name}:");
            string foodGroup = Console.ReadLine();

       CalculateTotalCalories();
            

        }

        // This method allows the ingredient quantities to be scaled//
        public void ScaleRecipe(double factor)
        {
            for (int j = 0; j < num5Ingredients; j++)
            {
                quantities5[j] = (int)Math.Round(quantities5[j] * factor);
            }
        }
        // This method allows reset the ingredient quantities back to the orginal value//
        public void ResetQuantities()
        {
            // Reset quantities to their original values
            this.Quantity = 0;
        }
        // This method will clear the arrays//
        public void ClearRecipe()
        {
            name3 = null;
            num5Ingredients = 0;
            ingredients6 = null;
            quantities5 = null;
            units9 = null;
            numberSteps = 0;
            steps2 = null;
        }


    }
    //Class contains method to invoke the 300 calories set value//
    class Ingredient
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public event Recipe.RecipeExceedsCaloriesHandler RecipeExceedsCalories;

        public Ingredient(string name, int calories, string foodGroup, int quantity, string unit)
        {
            this.Name = name;
            this.Calories = calories;
            this.FoodGroup = foodGroup;
            this.Quantity = quantity;
            this.Unit = unit;
            if (this.Calories > 300)
            {
                RecipeExceedsCalories?.Invoke(null);
            }
           
        }




        class Program
        {
            private static object newRecipe;

            static void Main(string[] args)
            {// This is an construtor that calls the class of recipe and the methods of the recipe class//
                Recipe recipe = new Recipe();
                List<Recipe> recipes = new List<Recipe>();
                bool continueEntering = true;
                while (continueEntering)
                {
                    //This block of code will display want user wants to do//
                    Console.WriteLine("Enter recipe and display recipe type = 1" + "    " + "Enter ingredient quantites be scaling factor (0.5, 2, or 3) type = 2 " + "   " +
                         " " +
                        "Enter recipe and display recipe and If you want the ingredient quantites to be reset type = 3 / " + "    " +
                        " If want clear all the data and start a new recipe type = 4 / " + "    " +
                        "If want to exit the program type = 5 / ");
                    int input4 = Convert.ToInt32(Console.ReadLine());
                    //this block of code will enable the user enter choose by 1 to 5 //
                    int input6 = 1;
                    int input7 = 2;
                    int input8 = 3;
                    int input9 = 4;
                    int input10 = 5;

                    //This block of code contains the if statements that have user choose input methods //
                    if (input4 == input6)
                    {
                        recipe.EnterRecipe();
                        
                        recipes.Sort((x, y) => string.Compare(x.Name, y.Name));//sort name of the recipe in order//

                        Console.WriteLine("Recipes:");
                        foreach (Recipe r in recipes)
                        {
                            Console.WriteLine(r.Name);
                        }//Calls the recipe once the user type name of the recipe out//
                        
                        Console.WriteLine("Enter the name of the recipe to display:");
                        string recipeToDisplay = Console.ReadLine();
                        //Can display the recipe//
                        
                        Recipe selectedRecipe = recipes.Find(r => r.Name.ToLower() == recipeToDisplay.ToLower());
                        if (selectedRecipe != null)
                        {
                            selectedRecipe.EnterRecipe();
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        //Search for the recipe //

                    }


                    if (input4 == input7)
                    {
                        Console.WriteLine("Enter scaling factor (0.5, 2, or 3):");
                        double factor = Console.Read();
                        recipe.ScaleRecipe(factor);
                    }


                    if (input4 == input8)
                    {

                        recipe.ResetQuantities();
                    }


                    if (input4 == input9)
                    {
                        recipe.ClearRecipe();
                    }


                    if (input4 == input10)
                    {
                        Environment.Exit(0);
                    }



                }
            }
        }
    }
}
