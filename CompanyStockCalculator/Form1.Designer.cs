namespace CompanyStockCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCurrentStock = new System.Windows.Forms.GroupBox();
            this.listBoxCurrentStock = new System.Windows.Forms.ListBox();
            this.groupBoxItemInfo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelMenuBar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSellItem = new System.Windows.Forms.Button();
            this.buttonRestockItem = new System.Windows.Forms.Button();
            this.buttonShowLowStock = new System.Windows.Forms.Button();
            this.numericUpDownLowStockLimit = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxSelectedItemInfo = new System.Windows.Forms.RichTextBox();
            this.groupBoxQueryStock = new System.Windows.Forms.GroupBox();
            this.listBoxQueryStock = new System.Windows.Forms.ListBox();
            this.groupBoxCurrentStock.SuspendLayout();
            this.groupBoxItemInfo.SuspendLayout();
            this.flowLayoutPanelMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowStockLimit)).BeginInit();
            this.groupBoxQueryStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCurrentStock
            // 
            this.groupBoxCurrentStock.Controls.Add(this.listBoxCurrentStock);
            this.groupBoxCurrentStock.Location = new System.Drawing.Point(101, 12);
            this.groupBoxCurrentStock.Name = "groupBoxCurrentStock";
            this.groupBoxCurrentStock.Size = new System.Drawing.Size(256, 287);
            this.groupBoxCurrentStock.TabIndex = 0;
            this.groupBoxCurrentStock.TabStop = false;
            this.groupBoxCurrentStock.Text = "Current Stock";
            // 
            // listBoxCurrentStock
            // 
            this.listBoxCurrentStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCurrentStock.FormattingEnabled = true;
            this.listBoxCurrentStock.Location = new System.Drawing.Point(3, 16);
            this.listBoxCurrentStock.Name = "listBoxCurrentStock";
            this.listBoxCurrentStock.Size = new System.Drawing.Size(250, 268);
            this.listBoxCurrentStock.Sorted = true;
            this.listBoxCurrentStock.TabIndex = 0;
            this.listBoxCurrentStock.SelectedIndexChanged += new System.EventHandler(this.listBoxCurrentStock_SelectedIndexChanged);
            // 
            // groupBoxItemInfo
            // 
            this.groupBoxItemInfo.Controls.Add(this.richTextBoxSelectedItemInfo);
            this.groupBoxItemInfo.Location = new System.Drawing.Point(104, 305);
            this.groupBoxItemInfo.Name = "groupBoxItemInfo";
            this.groupBoxItemInfo.Size = new System.Drawing.Size(250, 133);
            this.groupBoxItemInfo.TabIndex = 1;
            this.groupBoxItemInfo.TabStop = false;
            this.groupBoxItemInfo.Text = "Selected Item Information";
            // 
            // flowLayoutPanelMenuBar
            // 
            this.flowLayoutPanelMenuBar.Controls.Add(this.buttonSellItem);
            this.flowLayoutPanelMenuBar.Controls.Add(this.buttonRestockItem);
            this.flowLayoutPanelMenuBar.Controls.Add(this.buttonShowLowStock);
            this.flowLayoutPanelMenuBar.Controls.Add(this.numericUpDownLowStockLimit);
            this.flowLayoutPanelMenuBar.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelMenuBar.Name = "flowLayoutPanelMenuBar";
            this.flowLayoutPanelMenuBar.Size = new System.Drawing.Size(83, 426);
            this.flowLayoutPanelMenuBar.TabIndex = 2;
            // 
            // buttonSellItem
            // 
            this.buttonSellItem.Location = new System.Drawing.Point(3, 3);
            this.buttonSellItem.Name = "buttonSellItem";
            this.buttonSellItem.Size = new System.Drawing.Size(75, 23);
            this.buttonSellItem.TabIndex = 0;
            this.buttonSellItem.Text = "Sell";
            this.buttonSellItem.UseVisualStyleBackColor = true;
            this.buttonSellItem.Click += new System.EventHandler(this.buttonSellItem_Click);
            // 
            // buttonRestockItem
            // 
            this.buttonRestockItem.Location = new System.Drawing.Point(3, 32);
            this.buttonRestockItem.Name = "buttonRestockItem";
            this.buttonRestockItem.Size = new System.Drawing.Size(75, 23);
            this.buttonRestockItem.TabIndex = 1;
            this.buttonRestockItem.Text = "Restock";
            this.buttonRestockItem.UseVisualStyleBackColor = true;
            this.buttonRestockItem.Click += new System.EventHandler(this.buttonRestockItem_Click);
            // 
            // buttonShowLowStock
            // 
            this.buttonShowLowStock.Location = new System.Drawing.Point(3, 61);
            this.buttonShowLowStock.Name = "buttonShowLowStock";
            this.buttonShowLowStock.Size = new System.Drawing.Size(75, 49);
            this.buttonShowLowStock.TabIndex = 2;
            this.buttonShowLowStock.Text = "Show Low stock";
            this.buttonShowLowStock.UseVisualStyleBackColor = true;
            this.buttonShowLowStock.Click += new System.EventHandler(this.buttonShowLowStock_Click);
            // 
            // numericUpDownLowStockLimit
            // 
            this.numericUpDownLowStockLimit.Location = new System.Drawing.Point(3, 116);
            this.numericUpDownLowStockLimit.Name = "numericUpDownLowStockLimit";
            this.numericUpDownLowStockLimit.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownLowStockLimit.TabIndex = 3;
            this.numericUpDownLowStockLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // richTextBoxSelectedItemInfo
            // 
            this.richTextBoxSelectedItemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSelectedItemInfo.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxSelectedItemInfo.Name = "richTextBoxSelectedItemInfo";
            this.richTextBoxSelectedItemInfo.ReadOnly = true;
            this.richTextBoxSelectedItemInfo.Size = new System.Drawing.Size(244, 114);
            this.richTextBoxSelectedItemInfo.TabIndex = 0;
            this.richTextBoxSelectedItemInfo.Text = "";
            // 
            // groupBoxQueryStock
            // 
            this.groupBoxQueryStock.Controls.Add(this.listBoxQueryStock);
            this.groupBoxQueryStock.Location = new System.Drawing.Point(363, 12);
            this.groupBoxQueryStock.Name = "groupBoxQueryStock";
            this.groupBoxQueryStock.Size = new System.Drawing.Size(253, 284);
            this.groupBoxQueryStock.TabIndex = 3;
            this.groupBoxQueryStock.TabStop = false;
            this.groupBoxQueryStock.Text = "groupBoxQueryStock";
            // 
            // listBoxQueryStock
            // 
            this.listBoxQueryStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQueryStock.FormattingEnabled = true;
            this.listBoxQueryStock.Location = new System.Drawing.Point(3, 16);
            this.listBoxQueryStock.Name = "listBoxQueryStock";
            this.listBoxQueryStock.Size = new System.Drawing.Size(247, 265);
            this.listBoxQueryStock.Sorted = true;
            this.listBoxQueryStock.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxQueryStock);
            this.Controls.Add(this.flowLayoutPanelMenuBar);
            this.Controls.Add(this.groupBoxItemInfo);
            this.Controls.Add(this.groupBoxCurrentStock);
            this.Name = "Form1";
            this.Text = "Company Stock Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCurrentStock.ResumeLayout(false);
            this.groupBoxItemInfo.ResumeLayout(false);
            this.flowLayoutPanelMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowStockLimit)).EndInit();
            this.groupBoxQueryStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCurrentStock;
        private System.Windows.Forms.ListBox listBoxCurrentStock;
        private System.Windows.Forms.GroupBox groupBoxItemInfo;
        private System.Windows.Forms.RichTextBox richTextBoxSelectedItemInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuBar;
        private System.Windows.Forms.Button buttonSellItem;
        private System.Windows.Forms.Button buttonRestockItem;
        private System.Windows.Forms.Button buttonShowLowStock;
        private System.Windows.Forms.NumericUpDown numericUpDownLowStockLimit;
        private System.Windows.Forms.GroupBox groupBoxQueryStock;
        private System.Windows.Forms.ListBox listBoxQueryStock;
    }
}

