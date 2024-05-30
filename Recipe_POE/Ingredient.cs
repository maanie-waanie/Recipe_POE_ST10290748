using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Aman Adams
/// ST10290748
/// PROG6221
/// PROG POE PART 2
/// Code included in this POE has been created with using this website as help: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays 
/// </summary>

namespace Recipe_POE
{ 
    class Ingredient
    {
        public string Name { get; set; }
        public float Quantities { get; set; }   
        public string Measurements { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }

        //--------------------------------------------------------------------------------------------------------------------------------------//
        //Constructor to initialize an ingredient with its properties
        public Ingredient(string name, float quantity, string measurement, int calories, string foodGroup)
        {
            this.Name = name;
            this.Quantities = quantity;
            this.Measurements = measurement;
            this.Calories = calories;
            this.FoodGroup = foodGroup;
        }
    }
}
//--------------------------------------------------END OF FILE---------------------------------------------------------------------------------//

