using SEDTextile;

namespace SEDTextile
{
    partial class frmFactories
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
            this.ctrMyDataGridView1 = new SEDTextile.ctrMyDataGridView();
            this.SuspendLayout();
            // 
            // ctrMyDataGridView1
            // 
            this.ctrMyDataGridView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrMyDataGridView1.BackColor = System.Drawing.Color.White;
            this.ctrMyDataGridView1.DataSource = null;
            this.ctrMyDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMyDataGridView1.Location = new System.Drawing.Point(17, 136);
            this.ctrMyDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrMyDataGridView1.Name = "ctrMyDataGridView1";
            this.ctrMyDataGridView1.Size = new System.Drawing.Size(822, 405);
            this.ctrMyDataGridView1.TabIndex = 0;
            // 
            // frmFactories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 555);
            this.Controls.Add(this.ctrMyDataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFactories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFactories";
            this.Load += new System.EventHandler(this.frmFactories_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrMyDataGridView ctrMyDataGridView1;
    }
}