namespace SEDTextile.Orders.BuyingOrders
{
    partial class frmPlaceBuyingOrder
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
            this.dtpEstimatedArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.btnChoose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.nudPaidPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFactory = new SEDTextile.ctrMyComboBox();
            this.ctrMyDataGridView1 = new GPACalculator.ctrMyDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaidPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factory:";
            // 
            // dtpEstimatedArrivalDate
            // 
            this.dtpEstimatedArrivalDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEstimatedArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEstimatedArrivalDate.Location = new System.Drawing.Point(276, 178);
            this.dtpEstimatedArrivalDate.Name = "dtpEstimatedArrivalDate";
            this.dtpEstimatedArrivalDate.Size = new System.Drawing.Size(148, 30);
            this.dtpEstimatedArrivalDate.TabIndex = 2;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(485, 101);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 45);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estimated Arrival Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Price:";
            // 
            // nudTotalPrice
            // 
            this.nudTotalPrice.DecimalPlaces = 2;
            this.nudTotalPrice.Enabled = false;
            this.nudTotalPrice.Location = new System.Drawing.Point(246, 274);
            this.nudTotalPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudTotalPrice.Name = "nudTotalPrice";
            this.nudTotalPrice.Size = new System.Drawing.Size(90, 30);
            this.nudTotalPrice.TabIndex = 10;
            this.nudTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTotalPrice.ValueChanged += new System.EventHandler(this.nudTotalPrice_ValueChanged);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.Location = new System.Drawing.Point(683, 101);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(211, 45);
            this.btnResetOrder.TabIndex = 11;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = true;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(139, 439);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(211, 45);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // nudPaidPrice
            // 
            this.nudPaidPrice.DecimalPlaces = 2;
            this.nudPaidPrice.Location = new System.Drawing.Point(246, 323);
            this.nudPaidPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudPaidPrice.Name = "nudPaidPrice";
            this.nudPaidPrice.Size = new System.Drawing.Size(90, 30);
            this.nudPaidPrice.TabIndex = 14;
            this.nudPaidPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Paid Price:";
            // 
            // cbFactory
            // 
            this.cbFactory.BackColor = System.Drawing.Color.White;
            this.cbFactory.DataSource = null;
            this.cbFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFactory.Location = new System.Drawing.Point(139, 121);
            this.cbFactory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFactory.Name = "cbFactory";
            this.cbFactory.Size = new System.Drawing.Size(157, 35);
            this.cbFactory.TabIndex = 5;
            // 
            // ctrMyDataGridView1
            // 
            this.ctrMyDataGridView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrMyDataGridView1.BackColor = System.Drawing.Color.White;
            this.ctrMyDataGridView1.DataSource = null;
            this.ctrMyDataGridView1.Enabled = false;
            this.ctrMyDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMyDataGridView1.Location = new System.Drawing.Point(468, 183);
            this.ctrMyDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrMyDataGridView1.MultiSelect = false;
            this.ctrMyDataGridView1.Name = "ctrMyDataGridView1";
            this.ctrMyDataGridView1.Size = new System.Drawing.Size(584, 332);
            this.ctrMyDataGridView1.TabIndex = 4;
            this.ctrMyDataGridView1.withCheckBoxColumn = false;
            // 
            // frmPlaceBuyingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 602);
            this.Controls.Add(this.nudPaidPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.nudTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cbFactory);
            this.Controls.Add(this.ctrMyDataGridView1);
            this.Controls.Add(this.dtpEstimatedArrivalDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPlaceBuyingOrder";
            this.Text = "frmPlaceBuyingOrder";
            this.Load += new System.EventHandler(this.frmPlaceBuyingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaidPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEstimatedArrivalDate;
        private GPACalculator.ctrMyDataGridView ctrMyDataGridView1;
        private ctrMyComboBox cbFactory;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTotalPrice;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.NumericUpDown nudPaidPrice;
        private System.Windows.Forms.Label label4;
    }
}