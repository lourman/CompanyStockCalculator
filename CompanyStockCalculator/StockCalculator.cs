using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStockCalculator
{
    internal class StockCalculator
    {
        // Lists of all types of items being stocked.
        List<Food> foodList;
        //List<Drink> drinksList;

        #region Properties
        /// <summary>
        /// Porperty to return the list of food objects irrespective if they are currently stocked.
        /// </summary>
        public List<Food> Foods
        {
            get
            {
                return foodList;
            }
        }

        /// <summary>
        /// Porperty to return the list of food objects currently being stocked.
        /// </summary>
        public List<Food> StockedFoods
        {
            get
            {
                List<Food> result = new List<Food>();

                foreach (Food f in foodList)
                {
                    if (f.StockLevel > 0)
                        result.Add(f);
                }
                return result;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constrctor initialises all item lists.
        /// Loads the items from the database.
        /// When in DEBUG the connection would be with a test database function.
        /// </summary>
        public StockCalculator()
        {
            foodList = new List<Food>();
            //drinksList = new List<Drink>();

#if DEBUG
            TestDB();
#endif

        }
        #endregion

        #region Food Object Methods
        /// <summary>
        /// Adds a Food object to the foodList
        /// </summary>
        /// <param name="f">The food object to add</param>
        public void AddFoodToList(Food f)
        {
            foodList.Add(f);
        }

        
        /// <summary>
        /// Returns a list of low stock items according to a limit
        /// </summary>
        /// <param name="MinLevel">The limit by which the list should be constructed</param>
        /// <returns>The list of low stock items</returns>
        public List<Food> LowStock(int MinLevel)
        {
            List<Food> result = new List<Food>();

            // TODO: Put your code in here - 
            // You need to return a list of all items with fewer than MinLevel items

            //end of your code

            return result;
        }
        #endregion

#if DEBUG
        /// <summary>
        /// Method to create test items for testing the UI of the application.
        /// </summary>
        public void TestDB()
        {
            //drinks
            //Drink d = new Drink("Coola", 0.55m, true, 330);
            //d.Restock(10);
            //drinksList.Add(d);

            //d = new Drink("Funta", 0.50m, true, 330);
            //d.Restock(8);
            //drinksList.Add(d);

            //d = new Drink("Warter", 0.40m, false, 500);

            //drinksList.Add(d);

            //d = new Drink("Miylk", 0.70m, false, 568);
            //d.Restock(3);
            //drinksList.Add(d);


            //ingredients for foods
            Ingredient flour = new Ingredient("Flour"); ;
            flour.AddAllergen("Gluten");
            Ingredient sugar = new Ingredient("Sugar");
            Ingredient cocoa = new Ingredient("Cocoa");
            Ingredient nuts = new Ingredient("Hazelnuts");
            nuts.AddAllergen("Nuts");
            Ingredient yeast = new Ingredient("Yeast");
            Ingredient water = new Ingredient("Water");
            Ingredient cheese = new Ingredient("Cheese");
            cheese.AddAllergen("Dairy");
            Ingredient ham = new Ingredient("Ham");
            Ingredient butter = new Ingredient("Butter");
            butter.AddAllergen("Dairy");
            Ingredient milk = new Ingredient("Milk");
            milk.AddAllergen("Dairy");
            Ingredient egg = new Ingredient("Egg");
            egg.AddAllergen("Egg");

            //Foods
            Food f;
            f = new Food("Brownie", 1.1m, 250);
            f.AddIngredient(flour, 60); f.AddIngredient(sugar, 30); f.AddIngredient(cocoa, 20);
            f.AddIngredient(nuts, 10);
            f.Restock(10);
            AddFoodToList(f);

            f = new Food("Ham Sandwich", 1.8m, 250);
            f.AddIngredient(flour, 40); f.AddIngredient(yeast, 2); f.AddIngredient(sugar, 3);
            f.AddIngredient(butter, 4); f.AddIngredient(ham, 40);
            f.Restock(3);
            AddFoodToList(f);

            f = new Food("Cheese Sandwich", 1.7m, 375);
            f.AddIngredient(flour, 40); f.AddIngredient(yeast, 2); f.AddIngredient(sugar, 3);
            f.AddIngredient(butter, 4); f.AddIngredient(cheese, 40);
            f.Restock(5);
            AddFoodToList(f);

            f = new Food("Cake Slice", 1.1m, 400);
            f.AddIngredient(flour, 30); f.AddIngredient(sugar, 8);
            f.AddIngredient(butter, 15); f.AddIngredient(milk, 10); f.AddIngredient(egg, 10);
            f.Restock(6);
            AddFoodToList(f);

            f = new Food("Ham Salad", 1.7m, 245);
            f.AddIngredient(ham, 40); f.AddIngredient(new Ingredient("Salad Leaves"), 120);
            AddFoodToList(f);
        }
#endif
    }
}
