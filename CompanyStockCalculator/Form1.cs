using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyStockCalculator
{
    public partial class Form1 : Form
    {
        // Object that records all stock
        StockCalculator stockCalculator;

        /// <summary>
        /// Form constructor that initialises the object for all stock.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            stockCalculator = new StockCalculator();
        }

        #region UI_Methods
        /// <summary>
        /// Finds the selected item from the stock list
        /// </summary>
        /// <returns>The object of the selected item</returns>
        private Food SelectedItem()
        {
            Food result;

            result = stockCalculator.Foods[listBoxCurrentStock.SelectedIndex];
            return result;
        }

        /// <summary>
        /// Fills the stock list control with all stock
        /// </summary>
        private void ShowStock()
        {
            listBoxCurrentStock.Items.Clear();

            foreach (Food f in stockCalculator.Foods)
            {
                listBoxCurrentStock.Items.Add(f.Name + "\t(" + f.StockLevel + ")");
                decimal ppc = f.PricePerCal();
            }
        }

        /// <summary>
        /// Shows in the information textbox the allergens for a selected food object
        /// </summary>
        public void ShowAllergens()
        {
            Food f;
            f = SelectedItem();

            HashSet<String> allergens;
            allergens = f.AllergySet();

            richTextBoxSelectedItemInfo.Clear();

            foreach (String s in allergens)
            {
                richTextBoxSelectedItemInfo.AppendText(s + "\n");
            }
        }
        #endregion

        #region Control_Events
        /// <summary>
        /// Make sure that all stock is displayed in the stock list control, when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowStock();
        }
        
        /// <summary>
        /// The button should sell an item and reduce the stock level of the item
        /// the user has selected in the stock list control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellItem_Click(object sender, EventArgs e)
        {
            Food f;

            f = SelectedItem();
            f.Sell(1);
            ShowStock();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowLowStock_Click(object sender, EventArgs e)
        {
            //Task 1
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRestockItem_Click(object sender, EventArgs e)
        {
            //Task 5
        }

        /// <summary>
        /// When an item in the stock list is selected makes sure that the correct information 
        /// is shown in the information textbox. For Food that is the allergens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCurrentStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllergens();
        }
        #endregion
    }
}
