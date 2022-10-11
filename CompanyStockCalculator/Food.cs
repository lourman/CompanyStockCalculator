using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStockCalculator
{
    internal class Food : StockItem
    {
        private Dictionary<Ingredient, int> ingredientsQty;
        private int calories;

        /// <summary>
        /// Construct a food object by supplying the name its price and the calloried it contains
        /// </summary>
        /// <param name="Name">Name of the food item</param>
        /// <param name="Price">The price of the food item</param>
        /// <param name="kcals">The callories in kilo callories of the food  item</param>
        public Food(string Name, decimal Price, int kcals) : base(Name, Price)
        {
            ingredientsQty = new Dictionary<Ingredient, int>();
            calories = kcals;
        }

        /// <summary>
        /// Calculates the price per callories
        /// </summary>
        /// <returns>The price per callory</returns>
        public decimal PricePerCal()
        {
            decimal result;

            result = Price / calories;

            return result;
        }

        /// <summary>
        /// Adds and ingredient to the food item
        /// </summary>
        /// <param name="Ingredient">The ingredient to add</param>
        /// <param name="QtyGrams">The quantity in grams of the ingredient</param>
        public void AddIngredient(Ingredient Ingredient, int QtyGrams)
        {
            ingredientsQty.Add(Ingredient, QtyGrams);
        }

        /// <summary>
        /// Finds if an ingredient is present
        /// </summary>
        /// <param name="Ingredient">The ingredient to find</param>
        /// <returns>True if ingredient was found, else it returns false</returns>
        public bool Contains(Ingredient Ingredient)
        {
            bool result;
            result = ingredientsQty.ContainsKey(Ingredient);
            return result;
        }

        /// <summary>
        /// Returns all allergens of the food item.
        /// It should cicle and find all allergens for each ingredient.
        /// </summary>
        /// <returns>A list of all allergens found</returns>
        public HashSet<String> AllergySet()
        {
            HashSet<String> result = new HashSet<string>();

            foreach (Ingredient ing in ingredientsQty.Keys)
            {
                List<String> ingAllergens = ing.Allergens;
                foreach (String allergen in ingAllergens)
                {
                    result.Add(allergen);
                }
            }
            return result;
        }

        // Insert Task 3 solution here
    }
}
