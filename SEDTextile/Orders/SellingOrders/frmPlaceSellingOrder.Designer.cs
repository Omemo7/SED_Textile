namespace SEDTextile.Orders.SellingOrders
{
    partial class frmPlaceSellingOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEstimatedArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnChooseItems = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrMyDataGridView1 = new SEDTextile.ctrMyDataGridView();
            this.mycbDeliveryMethod = new SEDTextile.ctrMyComboBox();
            this.mycbStores = new SEDTextile.ctrMyComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.nudDiscountPrice = new System.Windows.Forms.NumericUpDown();
            this.nudPaidPrice = new System.Windows.Forms.NumericUpDown();
            this.btnResetOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaidPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estimated Arriaval Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Delivery Method:";
            // 
            // dtpEstimatedArrivalDate
            // 
            this.dtpEstimatedArrivalDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEstimatedArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEstimatedArrivalDate.Location = new System.Drawing.Point(306, 262);
            this.dtpEstimatedArrivalDate.Name = "dtpEstimatedArrivalDate";
            this.dtpEstimatedArrivalDate.Size = new System.Drawing.Size(146, 30);
            this.dtpEstimatedArrivalDate.TabIndex = 10;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(151, 504);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(260, 77);
            this.btnPlaceOrder.TabIndex = 14;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnChooseItems
            // 
            this.btnChooseItems.Location = new System.Drawing.Point(566, 75);
            this.btnChooseItems.Name = "btnChooseItems";
            this.btnChooseItems.Size = new System.Drawing.Size(124, 46);
            this.btnChooseItems.TabIndex = 16;
            this.btnChooseItems.Text = "Choose";
            this.btnChooseItems.UseVisualStyleBackColor = true;
            this.btnChooseItems.Click += new System.EventHandler(this.btnChoose_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Discount Price:";
            // 
            // ctrMyDataGridView1
            // 
            this.ctrMyDataGridView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrMyDataGridView1.BackColor = System.Drawing.Color.White;
            this.ctrMyDataGridView1.DataSource = null;
            this.ctrMyDataGridView1.Enabled = false;
            this.ctrMyDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMyDataGridView1.Location = new System.Drawing.Point(549, 130);
            this.ctrMyDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrMyDataGridView1.MultiSelect = false;
            this.ctrMyDataGridView1.Name = "ctrMyDataGridView1";
            this.ctrMyDataGridView1.Size = new System.Drawing.Size(508, 451);
            this.ctrMyDataGridView1.TabIndex = 18;
            this.ctrMyDataGridView1.withCheckBoxColumn = false;
            // 
            // mycbDeliveryMethod
            // 
            this.mycbDeliveryMethod.BackColor = System.Drawing.Color.White;
            this.mycbDeliveryMethod.DataSource = null;
            this.mycbDeliveryMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mycbDeliveryMethod.Location = new System.Drawing.Point(227, 175);
            this.mycbDeliveryMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mycbDeliveryMethod.Name = "mycbDeliveryMethod";
            this.mycbDeliveryMethod.Size = new System.Drawing.Size(157, 35);
            this.mycbDeliveryMethod.TabIndex = 11;
            // 
            // mycbStores
            // 
            this.mycbStores.BackColor = System.Drawing.Color.White;
            this.mycbStores.DataSource = null;
            this.mycbStores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mycbStores.Location = new System.Drawing.Point(151, 87);
            this.mycbStores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mycbStores.Name = "mycbStores";
            this.mycbStores.Size = new System.Drawing.Size(157, 34);
            this.mycbStores.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Paid Price:";
            // 
            // nudTotalPrice
            // 
            this.nudTotalPrice.DecimalPlaces = 2;
            this.nudTotalPrice.Enabled = false;
            this.nudTotalPrice.Location = new System.Drawing.Point(312, 347);
            this.nudTotalPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTotalPrice.Name = "nudTotalPrice";
            this.nudTotalPrice.Size = new System.Drawing.Size(97, 30);
            this.nudTotalPrice.TabIndex = 23;
            this.nudTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTotalPrice.ValueChanged += new System.EventHandler(this.nudTotalPrice_ValueChanged);
            // 
            // nudDiscountPrice
            // 
            this.nudDiscountPrice.DecimalPlaces = 2;
            this.nudDiscountPrice.Location = new System.Drawing.Point(312, 393);
            this.nudDiscountPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDiscountPrice.Name = "nudDiscountPrice";
            this.nudDiscountPrice.Size = new System.Drawing.Size(97, 30);
            this.nudDiscountPrice.TabIndex = 24;
            this.nudDiscountPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudPaidPrice
            // 
            this.nudPaidPrice.DecimalPlaces = 2;
            this.nudPaidPrice.Location = new System.Drawing.Point(312, 441);
            this.nudPaidPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPaidPrice.Name = "nudPaidPrice";
            this.nudPaidPrice.Size = new System.Drawing.Size(97, 30);
            this.nudPaidPrice.TabIndex = 25;
            this.nudPaidPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.Location = new System.Drawing.Point(824, 76);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(203, 46);
            this.btnResetOrder.TabIndex = 26;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = true;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // frmPlaceSellingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 647);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.nudPaidPrice);
            this.Controls.Add(this.nudDiscountPrice);
            this.Controls.Add(this.nudTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrMyDataGridView1);
            this.Controls.Add(this.btnChooseItems);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.mycbDeliveryMethod);
            this.Controls.Add(this.dtpEstimatedArrivalDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mycbStores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPlaceSellingOrder";
            this.Text = "frmPlaceSellingOrder";
            this.Load += new System.EventHandler(this.frmPlaceSellingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaidPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrMyComboBox mycbStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEstimatedArrivalDate;
        private ctrMyComboBox mycbDeliveryMethod;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnChooseItems;
        private SEDTextile.ctrMyDataGridView ctrMyDataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTotalPrice;
        private System.Windows.Forms.NumericUpDown nudDiscountPrice;
        private System.Windows.Forms.NumericUpDown nudPaidPrice;
        private System.Windows.Forms.Button btnResetOrder;
    }
}