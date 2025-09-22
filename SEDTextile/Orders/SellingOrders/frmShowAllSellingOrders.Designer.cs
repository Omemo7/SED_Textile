namespace SEDTextile.Orders.SellingOrders
{
    partial class frmShowAllSellingOrders
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
            this.ctrMyDataGridView1 = new GPACalculator.ctrMyDataGridView();
            this.SuspendLayout();
            // 
            // ctrMyDataGridView1
            // 
            this.ctrMyDataGridView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrMyDataGridView1.BackColor = System.Drawing.Color.White;
            this.ctrMyDataGridView1.DataSource = null;
            this.ctrMyDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMyDataGridView1.Location = new System.Drawing.Point(13, 80);
            this.ctrMyDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrMyDataGridView1.MultiSelect = false;
            this.ctrMyDataGridView1.Name = "ctrMyDataGridView1";
            this.ctrMyDataGridView1.Size = new System.Drawing.Size(1257, 544);
            this.ctrMyDataGridView1.TabIndex = 0;
            this.ctrMyDataGridView1.withCheckBoxColumn = false;
            this.ctrMyDataGridView1.Load += new System.EventHandler(this.ctrMyDataGridView1_Load);
            // 
            // frmShowAllSellingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 638);
            this.Controls.Add(this.ctrMyDataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmShowAllSellingOrders";
            this.Text = "frmShowAllSellingOrders";
            this.Load += new System.EventHandler(this.frmShowAllSellingOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GPACalculator.ctrMyDataGridView ctrMyDataGridView1;
    }
}