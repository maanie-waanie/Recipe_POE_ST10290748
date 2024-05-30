PROG Recipe_POE Part 1 

This project is designed to help users, like Sanele, manage and interact with recipes. Upon running the program, users are prompted to enter details for a new recipe, including its name, ingredients with quantities and measurements, and the preparation steps. Once a recipe is entered, users can choose from several options. They can display the recipe in a printed colour(green), scale the recipe by a specified factor to adjust the ingredient quantities, reset the quantities to their original values, enter a new recipe, or exit the program. This project aims to provide a simple and intuitive way for users, like Sanele, to manage and work with their recipes, allowing for easy adjustments and organization.


How I Improved for Part 2

I took the feedback given to me by Mr.Kim after Part 1, and analyzed it so that I know exactly what I must do so that it meets the rubric. Firstly, I fixed the error I made for the scaling option. Secondly, it would scale the values by whatever the user chose (0.5, 2 or 3) and it wouldn't display the recipe after that and it wouldn't reset the changed values back to their original values. So I fixed that. Then I needed to make the comments more meaningful and create seperators between each method to make it look more put together and tidy, like Dr Rudolph wants it. Lastly, I needed to implement error handling.

Ingredient Class-

The Ingredient class represents a single ingredient in a recipe. It includes properties like:
Name: The name of the ingredient.
Quantity: The quantity of the ingredient.
Measurement: The unit of measurement for the quantity.
Calories: The number of calories in the ingredient.
FoodGroup: The food group to which the ingredient belongs.
Constructor: Initializes a new ingredient with specified details.

Recipe Class-

The Recipe class represents a recipe with ingredients and steps.It includes properties like:
Name: The name of the recipe.
Ingredients: A list of ingredients in the recipe.
Steps: A list of steps to prepare the recipe. 
This includes methods such as: 
Constructor: Initializes a new recipe by prompting for recipe details.
DisplayRecipe: Displays the recipe details.
ScaleRecipe: Scales the recipe quantities by a given factor.
ResetQuantities: Resets the quantities to their original values
AddIngredient: Adds an ingredient to the recipe.
AddStep: Adds a step to the recipe.
CalculateTotalCalories: Calculates the total calories of all ingredients in the recipe.

CookBook Class-

The CookBook class manages a collection of recipes. It includes properties like:
Recipes: A list of recipes.
This includes methods such as:
AddRecipe: Adds a new recipe to the cook book and sorts the recipes alphabetically by name.
DisplayAllRecipes: Displays the names of all recipes in the cook book.
GetRecipeByName: Retrieves a recipe by its name.

Program Class-

The Program class contains the main entry point for the application. That includes the Main Method creates a new Recipe object and allows the user to interact with it through a menu. Displays a menu of options to the user. Allows the user to display all recipes, display a specific recipe, enter a new recipe, scale a recipe, reset quantities of a recipe, or exit the application. Prompts the user for input and performs actions based on the user's choice

How to Use Recipe_POE:

A- Run the program.

B- Follow the prompts to enter a recipe, a name, ingredients, quantities, measurements, calories and food groups.

C- Choose from the following options:

1- If you want to it to display all the recipes in alphabetical order

2- If you want to it to display a recipe with the amount of calories

3- If you want to enter a new recipe

4- If you want to it to scale the recipe to a factor of one the options (0.5, 2, 3)

5- If you want to it to reset the quantities to the original

6- If you want to exit the program

Link to the GitHub respository: https://github.com/maanie-waanie/Recipe_POE_ST10290748.git
