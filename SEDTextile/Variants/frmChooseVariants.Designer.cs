namespace SEDTextile.Variants
{
    partial class frmChooseVariants
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
            this.btnChooseVariants = new System.Windows.Forms.Button();
            this.btnAddVariants = new System.Windows.Forms.Button();
            this.ctrMyDataGridView1 = new GPACalculator.ctrMyDataGridView();
            this.SuspendLayout();
            // 
            // btnChooseVariants
            // 
            this.btnChooseVariants.Location = new System.Drawing.Point(597, 35);
            this.btnChooseVariants.Name = "btnChooseVariants";
            this.btnChooseVariants.Size = new System.Drawing.Size(119, 40);
            this.btnChooseVariants.TabIndex = 1;
            this.btnChooseVariants.Text = "Choose";
            this.btnChooseVariants.UseVisualStyleBackColor = true;
            this.btnChooseVariants.Click += new System.EventHandler(this.btnChooseVariants_Click);
            // 
            // btnAddVariants
            // 
            this.btnAddVariants.Location = new System.Drawing.Point(722, 35);
            this.btnAddVariants.Name = "btnAddVariants";
            this.btnAddVariants.Size = new System.Drawing.Size(75, 40);
            this.btnAddVariants.TabIndex = 2;
            this.btnAddVariants.Text = "Add";
            this.btnAddVariants.UseVisualStyleBackColor = true;
            this.btnAddVariants.Click += new System.EventHandler(this.btnAddVariants_Click);
            // 
            // ctrMyDataGridView1
            // 
            this.ctrMyDataGridView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrMyDataGridView1.BackColor = System.Drawing.Color.White;
            this.ctrMyDataGridView1.DataSource = null;
            this.ctrMyDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMyDataGridView1.Location = new System.Drawing.Point(13, 14);
            this.ctrMyDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrMyDataGridView1.MultiSelect = false;
            this.ctrMyDataGridView1.Name = "ctrMyDataGridView1";
            this.ctrMyDataGridView1.Size = new System.Drawing.Size(822, 405);
            this.ctrMyDataGridView1.TabIndex = 0;
            this.ctrMyDataGridView1.Load += new System.EventHandler(this.ctrMyDataGridView1_Load);
            // 
            // frmChooseVariants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 418);
            this.Controls.Add(this.btnAddVariants);
            this.Controls.Add(this.btnChooseVariants);
            this.Controls.Add(this.ctrMyDataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChooseVariants";
            this.Text = "frmChooseVariants";
            this.Load += new System.EventHandler(this.frmChooseVariants_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GPACalculator.ctrMyDataGridView ctrMyDataGridView1;
        private System.Windows.Forms.Button btnChooseVariants;
        private System.Windows.Forms.Button btnAddVariants;
    }
}