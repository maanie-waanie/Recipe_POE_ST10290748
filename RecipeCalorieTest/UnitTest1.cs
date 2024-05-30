using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipe_POE;

namespace RecipeCalorieTest
{
    [TestClass]
    public class RecipeTest
    {
        [TestMethod]
        public void CalorieTest()
        {
            // Arrange: Create a new recipe and add ingredients to it
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredient(new Ingredient("Tea", 1, "teabag", 770, "Drink"));
            recipe.AddIngredient(new Ingredient("Milk", 500f, "cup", 800, "Dairy"));

            // Act: Calculate the total calories of the recipe
            int totalCalories = recipe.CalculateTotalCalories();

            // Assert: Verify that the total calories are as expected
            Assert.AreEqual(1570, totalCalories);
        }
    }
}
