namespace SEDTextile
{
    partial class frmStorageInfoForTextile
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
            this.gbTextileInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.gbTextileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrMyDataGridView1
            // 
            this.ctrMyDataGridView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrMyDataGridView1.BackColor = System.Drawing.Color.White;
            this.ctrMyDataGridView1.DataSource = null;
            this.ctrMyDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMyDataGridView1.Location = new System.Drawing.Point(29, 169);
            this.ctrMyDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrMyDataGridView1.Name = "ctrMyDataGridView1";
            this.ctrMyDataGridView1.Size = new System.Drawing.Size(822, 405);
            this.ctrMyDataGridView1.TabIndex = 0;
            // 
            // gbTextileInfo
            // 
            this.gbTextileInfo.Controls.Add(this.lblQuantity);
            this.gbTextileInfo.Controls.Add(this.lblAlias);
            this.gbTextileInfo.Controls.Add(this.lblCode);
            this.gbTextileInfo.Controls.Add(this.label3);
            this.gbTextileInfo.Controls.Add(this.label2);
            this.gbTextileInfo.Controls.Add(this.label1);
            this.gbTextileInfo.Location = new System.Drawing.Point(29, 62);
            this.gbTextileInfo.Name = "gbTextileInfo";
            this.gbTextileInfo.Size = new System.Drawing.Size(822, 99);
            this.gbTextileInfo.TabIndex = 1;
            this.gbTextileInfo.TabStop = false;
            this.gbTextileInfo.Text = "Textile Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(119, 43);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(34, 25);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "??";
            this.lblCode.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(386, 43);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(34, 25);
            this.lblAlias.TabIndex = 6;
            this.lblAlias.Text = "??";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(656, 43);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(34, 25);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "??";
            // 
            // frmStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 588);
            this.Controls.Add(this.gbTextileInfo);
            this.Controls.Add(this.ctrMyDataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmStorage";
            this.Load += new System.EventHandler(this.frmStorage_Load);
            this.gbTextileInfo.ResumeLayout(false);
            this.gbTextileInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GPACalculator.ctrMyDataGridView ctrMyDataGridView1;
        private System.Windows.Forms.GroupBox gbTextileInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAlias;
    }
}