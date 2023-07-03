using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Media3D;

namespace RecipeApp
{
    public partial class MainWindow : Window
    {
        private Recipe recipe;
        private List<Ingredient> ingredients;
        private string unit;
        private TextBox nameTextBox; 
        private TextBox caloriesTextBox; 
        private TextBox foodGroupTextBox; 
        private TextBox quantityTextBox; 
        private TextBox unitTextBox; 
        private ListBox ingredientsListBox; 
        private TextBlock recipeDetailsTextBlock; 
        private List<Recipe> filteredRecipes;
        private List<Ingredient> filteredIngredients;
        private ComboBox foodGroupFilterComboBox; 
        public TextBox MaxCaloriesFilterTextBox { get; private set; } 
        public object IngredientFilterTextBox { get; private set; }

        private Window window;

        public MainWindow()
        {
            this.window = this;
            this.InitializeComponent();

            recipe = new Recipe();
            ingredients = new List<Ingredient>();
            filteredRecipes = new List<Recipe>();
            filteredIngredients = new List<Ingredient>();
        }

      //This block of code put the declarartions of strings and the integers used within the code into an method so that I used it throught the code as an working private method//
        private string GetNameTextBox()
        {
            TextBox nameTextBox = new TextBox();
            return nameTextBox.Text;
        }

        private int GetCaloriesTextBox()
        {
            TextBox caloriesTextBox = new TextBox();
            return int.Parse(caloriesTextBox.Text);
        }

        private string GetFoodGroupTextBox()
        {
            TextBox foodGroupTextBox = new TextBox();
            return foodGroupTextBox.Text;
        }

        private string GetUnitTextBox()
        {
            TextBox unitTextBox = new TextBox();
            return unitTextBox.Text;
        }

        private int GetQuantityTextBox()
        {
            TextBox quantityTextBox = new TextBox();
            return int.Parse(quantityTextBox.Text);
        }

        private void EnterRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Get recipe details from text fields
            string name = GetNameTextBox();
            int calories = GetCaloriesTextBox();
            string foodGroup = GetFoodGroupTextBox();
            int quantity = GetQuantityTextBox();
            string unit = GetUnitTextBox();

            // Create new ingredient
            Ingredient ingredient = new Ingredient(name, calories, foodGroup, quantity, unit);

            // Add ingredient to recipe
            recipe.AddIngredient(ingredient);

            // Add recipe to the filtered recipes list for filtering purposes
            filteredRecipes.Add(recipe);

            // Add ingredient to the filtered ingredients list for filtering purposes
            filteredIngredients = filteredIngredients.Where(ingredient => !(ingredient.Name.Contains(ingredientFilter) || ingredient.FoodGroup.Equals(foodGroupFilter))).ToList();

            // Update the UI to display the filtered recipes
            UpdateFilteredRecipesUI();
            UpdateFilteredIngredientsUI();
        }

        private static Ingredient GetIngredient(string name, int calories, string foodGroup, int quantity, string unit)
        {
            return new Ingredient(name, calories, foodGroup, quantity, unit);
        }
        private void FilterRecipesButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the filter criteria from text fields or selection
            TextBox IngredientFilterTextBox = new TextBox();
            string ingredientFilter = IngredientFilterTextBox.Text;
            string foodGroupFilter = foodGroupFilterComboBox.SelectedItem.ToString(); 
            int maxCaloriesFilter = int.Parse(MaxCaloriesFilterTextBox.Text); 

            // Apply the filters to the list of recipes
            if (ingredientFilter != "")
            {
                filteredRecipes = recipe.FilterRecipes(ingredientFilter, foodGroupFilter, maxCaloriesFilter);
            }
            else
            {
                filteredRecipes = new List<Recipe>();
            }

            // Apply the filters to the list of ingredients
            filteredIngredients = filteredIngredients.Where(ingredient => !ingredient.Name.Contains(ingredientFilter)
            && !ingredient.FoodGroup.Equals(foodGroupFilter)).ToList();

            // Update the UI to display the filtered recipes
            UpdateFilteredRecipesUI();
            UpdateFilteredIngredientsUI();
        }

        private void UpdateFilteredRecipesUI() => throw new NotImplementedException();
        private void UpdateFilteredIngredientsUI() => throw new NotImplementedException();
    }
}