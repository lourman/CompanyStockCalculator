using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStockCalculator
{
    internal class StockItem
    {
        // Name of the stock item
        string name;
        // Price of the stock item
        decimal price;

        // The stock level of the item
        uint stockLevel;

        /// <summary>
        /// Build a stock item if there is a name and a price. 
        /// The stock level is initialised to zero
        /// </summary>
        /// <param name="Name">The name of the product</param>
        /// <param name="Price">The price of the product</param>
        public StockItem(string Name, decimal Price)
        {
            this.name = Name;
            this.price = Price;
            this.stockLevel = 0;
        }

        /// <summary>
        /// Property to return the name of the product
        /// </summary>
        public string Name 
        { 
            get 
            { 
                return this.name; 
            } 
        }

        /// <summary>
        /// Property to return the price of the product
        /// </summary>
        public decimal Price 
        { 
            get 
            { 
                return this.price; 
            } 
        }

        /// <summary>
        /// Property to return the stock level of the product
        /// </summary>
        public uint StockLevel
        {
            get { return stockLevel; }
        }
        
        /// <summary>
        /// Increases the stock of the item by the correspoding ammount.
        /// </summary>
        /// <param name="Qty">The ammount by which to increase the stock.</param>
        public void Restock(ushort Qty)
        {
            stockLevel += Qty;
        }

        /// <summary>
        /// Sells a quantity of the item from the stock. It should reduce the stock level accordingly
        /// making sure that it does not go below zero.
        /// </summary>
        /// <param name="Qty">The quantity to sell</param>
        /// <returns>The stock level after the sale</returns>
        public ushort Sell(ushort Qty)
        {
            ushort result = 0;

            if (Qty <= stockLevel)
            {
                result = Qty;
            }
            else
            {
                result = (ushort)stockLevel;
            }

            stockLevel -= result;

            return result;
        }               
    }
}
