using System;
using System.Collections.Generic;

namespace RecipeApp
{
    internal class Recipe
    {
        public object Name { get; internal set; }

        internal void AddIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        internal List<Recipe> FilterRecipes(string ingredientFilter, string foodGroupFilter, int maxCaloriesFilter)
        {
            throw new NotImplementedException();
        }
    }
}