namespace Assignment1_CRUD_Screen
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStandardPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProducts = new System.Windows.Forms.Button();
            this.lblSearchDesc = new System.Windows.Forms.Label();
            this.txtSearchDesc = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAvg = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAvgDisplay = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductDescription,
            this.ProductStandardPrice,
            this.ProductFinish});
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 545);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProductDescription
            // 
            this.ProductDescription.DataPropertyName = "ProductDescription";
            this.ProductDescription.HeaderText = "ProductDescription";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Width = 120;
            // 
            // ProductStandardPrice
            // 
            this.ProductStandardPrice.DataPropertyName = "ProductStandardPrice";
            this.ProductStandardPrice.HeaderText = "ProductStandardPrice";
            this.ProductStandardPrice.Name = "ProductStandardPrice";
            this.ProductStandardPrice.Width = 150;
            // 
            // ProductFinish
            // 
            this.ProductFinish.DataPropertyName = "ProductFinish";
            this.ProductFinish.HeaderText = "ProductFinish";
            this.ProductFinish.Name = "ProductFinish";
            this.ProductFinish.Width = 120;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(12, 12);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(95, 31);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Show Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // lblSearchDesc
            // 
            this.lblSearchDesc.AutoSize = true;
            this.lblSearchDesc.Location = new System.Drawing.Point(12, 73);
            this.lblSearchDesc.Name = "lblSearchDesc";
            this.lblSearchDesc.Size = new System.Drawing.Size(148, 13);
            this.lblSearchDesc.TabIndex = 2;
            this.lblSearchDesc.Text = "Search Product Descriptions: ";
            // 
            // txtSearchDesc
            // 
            this.txtSearchDesc.Location = new System.Drawing.Point(166, 70);
            this.txtSearchDesc.Name = "txtSearchDesc";
            this.txtSearchDesc.Size = new System.Drawing.Size(100, 20);
            this.txtSearchDesc.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(353, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(12, 105);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAvg.Size = new System.Drawing.Size(134, 13);
            this.lblAvg.TabIndex = 5;
            this.lblAvg.Text = "Average Price of Products:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAvgDisplay
            // 
            this.lblAvgDisplay.AutoSize = true;
            this.lblAvgDisplay.Location = new System.Drawing.Point(166, 105);
            this.lblAvgDisplay.Name = "lblAvgDisplay";
            this.lblAvgDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblAvgDisplay.TabIndex = 7;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(288, 100);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(116, 23);
            this.btnAverage.TabIndex = 8;
            this.btnAverage.Text = "Show Average Price";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(197, 29);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 694);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.lblAvgDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSearchDesc);
            this.Controls.Add(this.lblSearchDesc);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label lblSearchDesc;
        private System.Windows.Forms.TextBox txtSearchDesc;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductStandardPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductFinish;
        private System.Windows.Forms.Label lblAvgDisplay;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblTest;
    }
}

