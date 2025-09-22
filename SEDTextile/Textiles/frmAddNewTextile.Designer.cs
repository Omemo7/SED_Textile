namespace SEDTextile.Textiles
{
    partial class frmAddNewTextile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.nudSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.nudBuyingPrice = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtChosenVariantsIDs = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.mycbFabric = new SEDTextile.ctrMyComboBox();
            this.mycbFactory = new SEDTextile.ctrMyComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyingPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Textile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Buying Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Variants:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "??";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Factory:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fabric:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Selling Price:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(180, 126);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(145, 30);
            this.txtCode.TabIndex = 10;
            // 
            // nudSellingPrice
            // 
            this.nudSellingPrice.DecimalPlaces = 2;
            this.nudSellingPrice.Location = new System.Drawing.Point(250, 266);
            this.nudSellingPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSellingPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSellingPrice.Name = "nudSellingPrice";
            this.nudSellingPrice.Size = new System.Drawing.Size(59, 30);
            this.nudSellingPrice.TabIndex = 12;
            this.nudSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSellingPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(540, 59);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(145, 30);
            this.txtAlias.TabIndex = 13;
            // 
            // nudBuyingPrice
            // 
            this.nudBuyingPrice.DecimalPlaces = 2;
            this.nudBuyingPrice.Location = new System.Drawing.Point(616, 258);
            this.nudBuyingPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBuyingPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBuyingPrice.Name = "nudBuyingPrice";
            this.nudBuyingPrice.Size = new System.Drawing.Size(59, 30);
            this.nudBuyingPrice.TabIndex = 17;
            this.nudBuyingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBuyingPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtChosenVariantsIDs);
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.mycbFabric);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mycbFactory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudBuyingPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAlias);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nudSellingPrice);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(58, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 349);
            this.panel1.TabIndex = 22;
            // 
            // txtChosenVariantsIDs
            // 
            this.txtChosenVariantsIDs.Location = new System.Drawing.Point(191, 202);
            this.txtChosenVariantsIDs.Name = "txtChosenVariantsIDs";
            this.txtChosenVariantsIDs.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtChosenVariantsIDs.Size = new System.Drawing.Size(151, 30);
            this.txtChosenVariantsIDs.TabIndex = 26;
            this.txtChosenVariantsIDs.Text = "No variants chosen";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(204, 174);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(121, 33);
            this.btnChoose.TabIndex = 24;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // mycbFabric
            // 
            this.mycbFabric.BackColor = System.Drawing.Color.White;
            this.mycbFabric.DataSource = null;
            this.mycbFabric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mycbFabric.Location = new System.Drawing.Point(545, 194);
            this.mycbFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mycbFabric.Name = "mycbFabric";
            this.mycbFabric.Size = new System.Drawing.Size(129, 33);
            this.mycbFabric.TabIndex = 21;
            // 
            // mycbFactory
            // 
            this.mycbFactory.BackColor = System.Drawing.Color.White;
            this.mycbFactory.DataSource = null;
            this.mycbFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mycbFactory.Location = new System.Drawing.Point(546, 126);
            this.mycbFactory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mycbFactory.Name = "mycbFactory";
            this.mycbFactory.Size = new System.Drawing.Size(129, 33);
            this.mycbFactory.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(400, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 50);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddNewTextile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 559);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddNewTextile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddNewTextile";
            this.Load += new System.EventHandler(this.frmAddNewTextile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyingPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.NumericUpDown nudSellingPrice;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.NumericUpDown nudBuyingPrice;
        private ctrMyComboBox mycbFactory;
        private ctrMyComboBox mycbFabric;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtChosenVariantsIDs;
    }
}