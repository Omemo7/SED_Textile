namespace SEDTextile
{
    partial class frmNavigation
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
            this.textilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellingOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyingOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAllSellingOrders = new System.Windows.Forms.Button();
            this.btnPlaceSellingOrder = new System.Windows.Forms.Button();
            this.btnPlaceBuyingOrder = new System.Windows.Forms.Button();
            this.btnShowBuyingOrders = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textilesToolStripMenuItem
            // 
            this.textilesToolStripMenuItem.Name = "textilesToolStripMenuItem";
            this.textilesToolStripMenuItem.Size = new System.Drawing.Size(125, 30);
            this.textilesToolStripMenuItem.Text = "Textiles";
            this.textilesToolStripMenuItem.Click += new System.EventHandler(this.textilesToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.textilesToolStripMenuItem,
            this.factoriesToolStripMenuItem,
            this.storesToolStripMenuItem,
            this.storageToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.factoriesToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip1.Size = new System.Drawing.Size(862, 50);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellingOrdersToolStripMenuItem,
            this.buyingOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(111, 30);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // sellingOrdersToolStripMenuItem
            // 
            this.sellingOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.allOrdersToolStripMenuItem});
            this.sellingOrdersToolStripMenuItem.Name = "sellingOrdersToolStripMenuItem";
            this.sellingOrdersToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.sellingOrdersToolStripMenuItem.Text = "Selling Orders";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.placeOrderToolStripMenuItem_Click);
            // 
            // allOrdersToolStripMenuItem
            // 
            this.allOrdersToolStripMenuItem.Name = "allOrdersToolStripMenuItem";
            this.allOrdersToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.allOrdersToolStripMenuItem.Text = "All Orders";
            this.allOrdersToolStripMenuItem.Click += new System.EventHandler(this.allOrdersToolStripMenuItem_Click);
            // 
            // buyingOrdersToolStripMenuItem
            // 
            this.buyingOrdersToolStripMenuItem.Name = "buyingOrdersToolStripMenuItem";
            this.buyingOrdersToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.buyingOrdersToolStripMenuItem.Text = "Buying Orders";
            this.buyingOrdersToolStripMenuItem.Click += new System.EventHandler(this.buyingOrdersToolStripMenuItem_Click);
            // 
            // factoriesToolStripMenuItem
            // 
            this.factoriesToolStripMenuItem.Name = "factoriesToolStripMenuItem";
            this.factoriesToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.factoriesToolStripMenuItem.Text = "Factories";
            this.factoriesToolStripMenuItem.Click += new System.EventHandler(this.factoriesToolStripMenuItem_Click);
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(105, 30);
            this.storesToolStripMenuItem.Text = "Stores";
            this.storesToolStripMenuItem.Click += new System.EventHandler(this.storesToolStripMenuItem_Click);
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.storageToolStripMenuItem.Text = "Storage";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowBuyingOrders);
            this.panel1.Controls.Add(this.btnPlaceBuyingOrder);
            this.panel1.Controls.Add(this.btnShowAllSellingOrders);
            this.panel1.Controls.Add(this.btnPlaceSellingOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 421);
            this.panel1.TabIndex = 2;
            // 
            // btnShowAllSellingOrders
            // 
            this.btnShowAllSellingOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllSellingOrders.Location = new System.Drawing.Point(321, 218);
            this.btnShowAllSellingOrders.Name = "btnShowAllSellingOrders";
            this.btnShowAllSellingOrders.Size = new System.Drawing.Size(225, 57);
            this.btnShowAllSellingOrders.TabIndex = 1;
            this.btnShowAllSellingOrders.Text = "Show Selling Orders";
            this.btnShowAllSellingOrders.UseVisualStyleBackColor = true;
            this.btnShowAllSellingOrders.Click += new System.EventHandler(this.btnShowAllSellingOrders_Click);
            // 
            // btnPlaceSellingOrder
            // 
            this.btnPlaceSellingOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceSellingOrder.Location = new System.Drawing.Point(321, 127);
            this.btnPlaceSellingOrder.Name = "btnPlaceSellingOrder";
            this.btnPlaceSellingOrder.Size = new System.Drawing.Size(225, 59);
            this.btnPlaceSellingOrder.TabIndex = 0;
            this.btnPlaceSellingOrder.Text = "Place Selling Order";
            this.btnPlaceSellingOrder.UseVisualStyleBackColor = true;
            this.btnPlaceSellingOrder.Click += new System.EventHandler(this.btnPlaceSellingOrder_Click);
            // 
            // btnPlaceBuyingOrder
            // 
            this.btnPlaceBuyingOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceBuyingOrder.Location = new System.Drawing.Point(70, 127);
            this.btnPlaceBuyingOrder.Name = "btnPlaceBuyingOrder";
            this.btnPlaceBuyingOrder.Size = new System.Drawing.Size(225, 59);
            this.btnPlaceBuyingOrder.TabIndex = 2;
            this.btnPlaceBuyingOrder.Text = "Place Buying Order";
            this.btnPlaceBuyingOrder.UseVisualStyleBackColor = true;
            this.btnPlaceBuyingOrder.Click += new System.EventHandler(this.btnPlaceBuyingOrder_Click);
            // 
            // btnShowBuyingOrders
            // 
            this.btnShowBuyingOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBuyingOrders.Location = new System.Drawing.Point(70, 218);
            this.btnShowBuyingOrders.Name = "btnShowBuyingOrders";
            this.btnShowBuyingOrders.Size = new System.Drawing.Size(225, 57);
            this.btnShowBuyingOrders.TabIndex = 3;
            this.btnShowBuyingOrders.Text = "Show Buying Orders";
            this.btnShowBuyingOrders.UseVisualStyleBackColor = true;
            this.btnShowBuyingOrders.Click += new System.EventHandler(this.btnShowBuyingOrders_Click);
            // 
            // frmNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNavigation";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNavigation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem textilesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem factoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellingOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyingOrdersToolStripMenuItem;
        private System.Windows.Forms.Button btnShowAllSellingOrders;
        private System.Windows.Forms.Button btnPlaceSellingOrder;
        private System.Windows.Forms.Button btnPlaceBuyingOrder;
        private System.Windows.Forms.Button btnShowBuyingOrders;
    }
}

