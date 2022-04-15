
namespace ManavUygulamasi
{
    partial class ProductForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nudUnitsInStok = new System.Windows.Forms.NumericUpDown();
            this.nudUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.tbnProductDelete = new System.Windows.Forms.Button();
            this.btnClearProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsOnOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stok Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Siparişteki Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Satışta mı?";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(87, 17);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(191, 25);
            this.txtProductName.TabIndex = 7;
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(87, 47);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(191, 25);
            this.cmbProductCategory.TabIndex = 8;
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Location = new System.Drawing.Point(86, 82);
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(131, 25);
            this.nudUnitPrice.TabIndex = 10;
            // 
            // nudUnitsInStok
            // 
            this.nudUnitsInStok.Location = new System.Drawing.Point(409, 13);
            this.nudUnitsInStok.Name = "nudUnitsInStok";
            this.nudUnitsInStok.Size = new System.Drawing.Size(139, 25);
            this.nudUnitsInStok.TabIndex = 11;
            // 
            // nudUnitsOnOrder
            // 
            this.nudUnitsOnOrder.Location = new System.Drawing.Point(409, 46);
            this.nudUnitsOnOrder.Name = "nudUnitsOnOrder";
            this.nudUnitsOnOrder.Size = new System.Drawing.Size(139, 25);
            this.nudUnitsOnOrder.TabIndex = 12;
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(409, 87);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.chkDiscontinued.TabIndex = 13;
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btnProductSave
            // 
            this.btnProductSave.Location = new System.Drawing.Point(210, 126);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(111, 30);
            this.btnProductSave.TabIndex = 14;
            this.btnProductSave.Text = "Kaydet";
            this.btnProductSave.UseVisualStyleBackColor = true;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // tbnProductDelete
            // 
            this.tbnProductDelete.Location = new System.Drawing.Point(327, 126);
            this.tbnProductDelete.Name = "tbnProductDelete";
            this.tbnProductDelete.Size = new System.Drawing.Size(111, 30);
            this.tbnProductDelete.TabIndex = 16;
            this.tbnProductDelete.Text = "Sil";
            this.tbnProductDelete.UseVisualStyleBackColor = true;
            this.tbnProductDelete.Click += new System.EventHandler(this.tbnProductDelete_Click);
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.Location = new System.Drawing.Point(93, 126);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Size = new System.Drawing.Size(111, 30);
            this.btnClearProduct.TabIndex = 17;
            this.btnClearProduct.Text = "Yeni";
            this.btnClearProduct.UseVisualStyleBackColor = true;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(558, 165);
            this.Controls.Add(this.btnClearProduct);
            this.Controls.Add(this.tbnProductDelete);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.chkDiscontinued);
            this.Controls.Add(this.nudUnitsOnOrder);
            this.Controls.Add(this.nudUnitsInStok);
            this.Controls.Add(this.nudUnitPrice);
            this.Controls.Add(this.cmbProductCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsInStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsOnOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.NumericUpDown nudUnitsInStok;
        private System.Windows.Forms.NumericUpDown nudUnitsOnOrder;
        private System.Windows.Forms.CheckBox chkDiscontinued;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button tbnProductDelete;
        private System.Windows.Forms.Button btnClearProduct;
    }
}