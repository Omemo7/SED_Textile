namespace SEDTextile
{
    partial class ctrChooseItemsWithQuantities
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSelectedItemID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.ctrMyDataGridViewChosenItems = new SEDTextile.ctrMyDataGridView();
            this.ctrMyDataGridViewItems = new SEDTextile.ctrMyDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(569, 643);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(154, 48);
            this.btnRemoveItem.TabIndex = 24;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total Price:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(681, 457);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(23, 25);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.Text = "0";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(569, 572);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(154, 48);
            this.btnResetAll.TabIndex = 19;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(569, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 48);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSelectedItemID
            // 
            this.lblSelectedItemID.AutoSize = true;
            this.lblSelectedItemID.Location = new System.Drawing.Point(893, 85);
            this.lblSelectedItemID.Name = "lblSelectedItemID";
            this.lblSelectedItemID.Size = new System.Drawing.Size(34, 25);
            this.lblSelectedItemID.TabIndex = 17;
            this.lblSelectedItemID.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selected Item ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.DecimalPlaces = 2;
            this.nudQuantity.Location = new System.Drawing.Point(823, 126);
            this.nudQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(97, 30);
            this.nudQuantity.TabIndex = 14;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged_1);
            // 
            // ctrMyDataGridViewChosenItems
            // 
            this.ctrMyDataGridViewChosenItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrMyDataGridViewChosenItems.BackColor = System.Drawing.Color.White;
            this.ctrMyDataGridViewChosenItems.DataSource = null;
            this.ctrMyDataGridViewChosenItems.Enabled = false;
            this.ctrMyDataGridViewChosenItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMyDataGridViewChosenItems.Location = new System.Drawing.Point(4, 433);
            this.ctrMyDataGridViewChosenItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrMyDataGridViewChosenItems.MultiSelect = false;
            this.ctrMyDataGridViewChosenItems.Name = "ctrMyDataGridViewChosenItems";
            this.ctrMyDataGridViewChosenItems.Size = new System.Drawing.Size(526, 298);
            this.ctrMyDataGridViewChosenItems.TabIndex = 25;
            this.ctrMyDataGridViewChosenItems.withCheckBoxColumn = false;
            this.ctrMyDataGridViewChosenItems.Load += new System.EventHandler(this.ctrMyDataGridViewChosenItems_Load);
            // 
            // ctrMyDataGridViewItems
            // 
            this.ctrMyDataGridViewItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrMyDataGridViewItems.BackColor = System.Drawing.Color.White;
            this.ctrMyDataGridViewItems.DataSource = null;
            this.ctrMyDataGridViewItems.Enabled = false;
            this.ctrMyDataGridViewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMyDataGridViewItems.Location = new System.Drawing.Point(0, 5);
            this.ctrMyDataGridViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrMyDataGridViewItems.MultiSelect = false;
            this.ctrMyDataGridViewItems.Name = "ctrMyDataGridViewItems";
            this.ctrMyDataGridViewItems.Size = new System.Drawing.Size(719, 405);
            this.ctrMyDataGridViewItems.TabIndex = 13;
            this.ctrMyDataGridViewItems.withCheckBoxColumn = false;
            this.ctrMyDataGridViewItems.Load += new System.EventHandler(this.ctrMyDataGridViewItems_Load);
            // 
            // ctrChooseItemsWithQuantities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrMyDataGridViewChosenItems);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSelectedItemID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.ctrMyDataGridViewItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrChooseItemsWithQuantities";
            this.Size = new System.Drawing.Size(947, 749);
            this.Load += new System.EventHandler(this.ctrChooseItemsWithQuantities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSelectedItemID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private SEDTextile.ctrMyDataGridView ctrMyDataGridViewItems;
        private SEDTextile.ctrMyDataGridView ctrMyDataGridViewChosenItems;
    }
}
