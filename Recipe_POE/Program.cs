using System;

/// <summary>
/// Aman Adams
/// ST10290748
/// PROG6221
/// PROG POE PART 2
/// Code included in this POE has been created with using this website as help: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays 
/// </summary>

namespace Recipe_POE
{
    class Program
    {
        static void Main(string[] args)
        {
            CookBook recipeBook = new CookBook(); //Initialize a new cookbook
            Recipe currentRecipe = null;

            while (true)
            {
                //Display the menu
                Console.WriteLine("\n\nWhat would you like to do?");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Display all recipes");
                Console.WriteLine("2. Display a recipe");
                Console.WriteLine("3. Enter a new recipe");
                Console.WriteLine("4. Scale a recipe");
                Console.WriteLine("5. Reset quantities of a recipe");
                Console.WriteLine("6. Exit the program");
                Console.WriteLine("--------------------------");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Display all recipes in the cookbook
                        recipeBook.DisplayAllRecipes();
                        break;
                    case 2:
                        //Display a specific recipe by name
                        Console.Write("Enter the name of the recipe to display: ");
                        string recipeName = Console.ReadLine();
                        currentRecipe = recipeBook.GetRecipeByName(recipeName);
                        if (currentRecipe != null)
                        {
                            currentRecipe.OnCaloriesExceeded += message => Console.WriteLine(message);
                            currentRecipe.displayRecipe();
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        break;
                    case 3:
                        //Enter a new recipe
                        Console.Write("Enter the recipe name: ");
                        string name = Console.ReadLine();
                        currentRecipe = new Recipe(name);

                        Console.Write("Enter the number of ingredients: ");
                        int ingredientNo = int.Parse(Console.ReadLine());
                        for (int i = 0; i < ingredientNo; i++)
                        {
                            Console.Write($"Enter the name of ingredient {i + 1}: ");
                            string ingredientName = Console.ReadLine();

                            Console.Write($"Enter the quantity of {ingredientName}: ");
                            float quantity = float.Parse(Console.ReadLine());

                            Console.Write($"Enter the unit of measurement for {ingredientName}: ");
                            string measurement = Console.ReadLine();

                            Console.Write($"Enter the number of calories for {ingredientName}: ");
                            int calories = int.Parse(Console.ReadLine());

                            Console.Write($"Enter the food group for {ingredientName}: ");
                            string foodGroup = Console.ReadLine();

                            Ingredient ingredient = new Ingredient(ingredientName, quantity, measurement, calories, foodGroup);
                            currentRecipe.AddIngredient(ingredient);
                        }

                        Console.Write("Enter the number of steps: ");
                        int stepsNo = int.Parse(Console.ReadLine());
                        for (int i = 0; i < stepsNo; i++)
                        {
                            Console.Write($"Enter step {i + 1}: ");
                            string step = Console.ReadLine();
                            currentRecipe.AddStep(step);
                        }

                        recipeBook.AddRecipe(currentRecipe);
                        Console.WriteLine("New recipe entered!");
                        break;
                    case 4:
                        //Scale a recipe by a given factor
                        Console.Write("Enter the name of the recipe to scale: ");
                        string scaleRecipeName = Console.ReadLine();
                        currentRecipe = recipeBook.GetRecipeByName(scaleRecipeName);
                        if (currentRecipe != null)
                        {
                            Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
                            float factor = float.Parse(Console.ReadLine());
                            currentRecipe.scaleRecipe(factor);
                            Console.WriteLine("Recipe scaled! Press 2 to display the new values.");
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        break;
                    case 5:
                        //Reset the quantities of a scaled recipe
                        Console.Write("Enter the name of the recipe to reset quantities: ");
                        string resetRecipeName = Console.ReadLine();
                        currentRecipe = recipeBook.GetRecipeByName(resetRecipeName);
                        if (currentRecipe != null)
                        {
                            Console.Write("Enter the scaling factor used: ");
                            float resetFactor = float.Parse(Console.ReadLine());
                            currentRecipe.resetQuantities(resetFactor);
                            Console.WriteLine("Quantities have been reset! Press 2 to display the new values.");
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        break;
                    case 6:
                        //Exit the program
                        Console.WriteLine("Thank You and Goodbye!");
                        return;
                    default:
                        //Handle invalid menu choices
                        Console.WriteLine("Invalid choice. Please enter a valid choice.");
                        break;
                }
            }
        }
    }
}
//--------------------------------------------------END OF FILE---------------------------------------------------------------------------------//