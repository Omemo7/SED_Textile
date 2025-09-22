namespace SEDTextile.Orders.SellingOrders
{
    partial class frmChooseItemsToSell
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
            this.ctrChooseItemsWithQuantities1 = new SEDTextile.ctrChooseItemsWithQuantities();
            this.SuspendLayout();
            // 
            // ctrChooseItemsWithQuantities1
            // 
            this.ctrChooseItemsWithQuantities1.AutoSize = true;
            this.ctrChooseItemsWithQuantities1.BackColor = System.Drawing.Color.White;
            this.ctrChooseItemsWithQuantities1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrChooseItemsWithQuantities1.Location = new System.Drawing.Point(13, 38);
            this.ctrChooseItemsWithQuantities1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrChooseItemsWithQuantities1.Name = "ctrChooseItemsWithQuantities1";
            this.ctrChooseItemsWithQuantities1.Size = new System.Drawing.Size(1030, 736);
            this.ctrChooseItemsWithQuantities1.TabIndex = 0;
            // 
            // frmChooseItemsToSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 787);
            this.Controls.Add(this.ctrChooseItemsWithQuantities1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChooseItemsToSell";
            this.Text = "frmChooseItemsToSell";
            this.Load += new System.EventHandler(this.frmChooseItemsToSell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrChooseItemsWithQuantities ctrChooseItemsWithQuantities1;
    }
}