using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Aman Adams
/// ST10290748
/// PROG6221
/// PROG POE PART 2
/// Code included in this POE has been created with using this website as help: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays 
/// </summary>

namespace Recipe_POE
{
    class CookBook
    { 
        public List<Recipe> Recipes { get; set; }

        //--------------------------------------------------------------------------------------------------------------------------------------//
        //Constructor to initialize the cookbook with an empty list of recipes
        public CookBook()
        {
            Recipes = new List<Recipe>();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------//
        //Add a recipe to the cookbook and sort recipes alphabetically by name
        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
            Recipes = Recipes.OrderBy(r => r.Name).ToList();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------//
        //Display all recipe names in the cookbook
        public void DisplayAllRecipes()
        {
            Console.WriteLine("Recipes:");
            for (int i = 0; i < Recipes.Count; i++)
            {
                Console.WriteLine(Recipes[i].Name);
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------//
        //Retrieve a recipe by its name, returning null if not found
        public Recipe GetRecipeByName(string name)
        {
            for (int i = 0; i < Recipes.Count; i++)
            {
                if (Recipes[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return Recipes[i];
                }
            }
            return null;
        }
    }
}
//--------------------------------------------------END OF FILE---------------------------------------------------------------------------------//