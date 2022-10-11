using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStockCalculator
{
    internal class Ingredient
    {
        /// <summary>
        /// Name attribute of the ingredient
        /// </summary>
        string name;

        /// <summary>
        /// A list attribute of the possible allergens related to the ingredient
        /// </summary>
        List<string> allergens;

        /// <summary>
        /// Property to return all allergens of the ingredient
        /// </summary>
        public List<string> Allergens
        {
            get 
            { 
                return allergens; 
            }
        }
        
        /// <summary>
        /// Constructs an ingredient with a name. Initialises an empty allergen list.
        /// </summary>
        /// <param name="Name">The name of the ingredient</param>
        public Ingredient(string Name)
        {
            this.name = Name;
            this.allergens = new List<string>();
        }

        /// <summary>
        /// Adds an allegen to the ingredient
        /// </summary>
        /// <param name="Allergen"></param>
        public void AddAllergen(string Allergen)
        {
           this.allergens.Add(Allergen);
        }

        /// <summary>
        /// Checks if an allergen is present on the ingredient.
        /// </summary>
        /// <param name="Allergen">The allergen to find</param>
        /// <returns>True if found, false is not found</returns>
        public bool AllergenPresent(string Allergen)
        {
            bool result;

            result = this.allergens.Contains(Allergen);

            return result;
        }       
    }
}
