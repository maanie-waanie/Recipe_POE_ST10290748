﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Aman Adams
/// ST10290748
/// PROG6221
/// PROG POE PART 1
/// Code included in this POE has been created with using this website as help: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays 
/// </summary>

namespace Recipe_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Creating a new recipe object
            Recipe recipe = new Recipe();

            //A While loop is used to display the menu of options
            while (true)     
            {
                Console.WriteLine("\n\nWhat would you like to do?");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Display the recipe");
                Console.WriteLine("2. Scale the recipe");
                Console.WriteLine("3. Reset the quantities");
                Console.WriteLine("4. Enter a new recipe");
                Console.WriteLine("5. Exit the program");
                Console.WriteLine("--------------------------");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipe.DisplayRecipe();
                        break;
                    case 2:
                        Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
                        float factor = float.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                        Console.WriteLine("Recipe scaled!");
                        break;
                    case 3:
                        recipe.ResetQuantities();
                        Console.WriteLine("Quantities have reset to original values!");
                        break;
                    case 4:
                        recipe = new Recipe();
                        Console.WriteLine("New recipe entered!");
                        break;
                    case 5:
                        Console.WriteLine("Thank You and Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid choice.");
                        break;

                }
               
            }
        }
    }
}
                          