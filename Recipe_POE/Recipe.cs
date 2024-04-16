using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/// <summary>
/// Aman Adams
/// ST10290748
/// PROG6221
/// PROG POE PART 1
/// Code included in this POE has been created with using this website as help: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays 
/// </summary>

namespace Recipe_POE
{
    class Recipe
    {
        public string Name { get; set; }
        public int ingredientNo { get; set; }
        public string[] ingredientNames { get; set; }
        public float[] quantities { get; set; }
        public string[] measurements { get; set; }
        public int stepsNo { get; set; }
        public string[] steps { get; set; }


        //Constructor to initialize a new recipe and naming it
        public Recipe()

        {
            Console.WriteLine("Enter recipe name:");
            Name = Console.ReadLine();

            Console.Write("Enter the number of ingredients: ");
            ingredientNo = int.Parse(Console.ReadLine());

            ingredientNames = new string[ingredientNo];
            quantities = new float[ingredientNo];
            measurements = new string[ingredientNo];

            //For loop that inputs ingredients, their quantities and their unit of measurement
            for (int i = 0; i < ingredientNo; i++)
            {
                Console.Write($"Enter the name of ingredient {i + 1}: ");
                ingredientNames[i] = Console.ReadLine();

                Console.Write($"Enter the quantity of {ingredientNames[i]}: ");
                quantities[i] = float.Parse(Console.ReadLine());

                Console.Write($"Enter the unit of measurement for {ingredientNames[i]}: ");
                measurements[i] = Console.ReadLine();
            }

            Console.Write("Enter the number of steps: ");
            stepsNo = int.Parse(Console.ReadLine());

            steps = new string[stepsNo];

            //For loop that inputs each of the recipe steps
            for (int i = 0; i < stepsNo; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                steps[i] = Console.ReadLine();
            }
        }

        public void DisplayRecipe()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------");
            Console.WriteLine("Recipe Name: {0}", Name);
            Console.WriteLine("\n\nRecipe:");
            Console.WriteLine("-------");

            for (int i = 0; i < ingredientNo; i++)
            {
                Console.WriteLine($"{ingredientNames[i]}: {quantities[i]} {measurements[i]}");
            }

            Console.WriteLine("\nSteps:");
            Console.WriteLine("------");

            for (int i = 0; i < stepsNo; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
            Console.WriteLine("--------------------------");
            Console.ResetColor();
        }

        public void ScaleRecipe(float factor)
        {
            for (int i = 0; i < ingredientNo; i++)
            {
                quantities[i] *= factor;
            }
        }

        public void ResetQuantities()
        {
            for (int i = 0; i < ingredientNo; i++)
            {
                quantities[i] /= 1.0f;
            }
        }
    }

}
