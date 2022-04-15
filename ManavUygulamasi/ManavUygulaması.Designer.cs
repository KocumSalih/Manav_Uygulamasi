
namespace ManavUygulamasi
{
    partial class ManavUygulaması
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCustomers = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.tbProducts = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbCategories = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdCategories = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCategoryNew = new System.Windows.Forms.Button();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpCustomers.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.panel4.SuspendLayout();
            this.tbProducts.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.tbCategories.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCustomers);
            this.tabControl1.Controls.Add(this.tbProducts);
            this.tabControl1.Controls.Add(this.tbCategories);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(265, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 452);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tpCustomers
            // 
            this.tpCustomers.Controls.Add(this.panel5);
            this.tpCustomers.Controls.Add(this.panel4);
            this.tpCustomers.Location = new System.Drawing.Point(4, 44);
            this.tpCustomers.Name = "tpCustomers";
            this.tpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomers.Size = new System.Drawing.Size(794, 404);
            this.tpCustomers.TabIndex = 0;
            this.tpCustomers.Text = "Müsterilerim";
            this.tpCustomers.UseVisualStyleBackColor = true;
            this.tpCustomers.Enter += new System.EventHandler(this.tpCustomers_Enter);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grdCustomers);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(70, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(721, 398);
            this.panel5.TabIndex = 2;
            // 
            // grdCustomers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            this.grdCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCustomers.GridColor = System.Drawing.Color.DarkRed;
            this.grdCustomers.Location = new System.Drawing.Point(0, 0);
            this.grdCustomers.MultiSelect = false;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomers.Size = new System.Drawing.Size(721, 398);
            this.grdCustomers.TabIndex = 1;
            this.grdCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMusteriEkle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(67, 398);
            this.panel4.TabIndex = 0;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMusteriEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMusteriEkle.Location = new System.Drawing.Point(0, 0);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(67, 398);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // tbProducts
            // 
            this.tbProducts.BackColor = System.Drawing.Color.Transparent;
            this.tbProducts.Controls.Add(this.panel6);
            this.tbProducts.Controls.Add(this.btnAddProduct);
            this.tbProducts.ForeColor = System.Drawing.Color.Maroon;
            this.tbProducts.Location = new System.Drawing.Point(4, 44);
            this.tbProducts.Name = "tbProducts";
            this.tbProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tbProducts.Size = new System.Drawing.Size(794, 404);
            this.tbProducts.TabIndex = 1;
            this.tbProducts.Text = "Urunlerim";
            this.tbProducts.Enter += new System.EventHandler(this.tbProducts_Enter);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grdProducts);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(70, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(721, 398);
            this.panel6.TabIndex = 2;
            // 
            // grdProducts
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            this.grdProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdProducts.Location = new System.Drawing.Point(0, 0);
            this.grdProducts.MultiSelect = false;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducts.Size = new System.Drawing.Size(721, 398);
            this.grdProducts.TabIndex = 1;
            this.grdProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellDoubleClick);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(67, 398);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Urun Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbCategories
            // 
            this.tbCategories.BackColor = System.Drawing.Color.Transparent;
            this.tbCategories.Controls.Add(this.panel2);
            this.tbCategories.Controls.Add(this.panel1);
            this.tbCategories.Location = new System.Drawing.Point(4, 44);
            this.tbCategories.Name = "tbCategories";
            this.tbCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tbCategories.Size = new System.Drawing.Size(794, 404);
            this.tbCategories.TabIndex = 2;
            this.tbCategories.Text = "Kategorilerim";
            this.tbCategories.Enter += new System.EventHandler(this.tbCategories_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdCategories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(254, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 398);
            this.panel2.TabIndex = 1;
            // 
            // grdCategories
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen;
            this.grdCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCategories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCategories.Location = new System.Drawing.Point(0, 0);
            this.grdCategories.MultiSelect = false;
            this.grdCategories.Name = "grdCategories";
            this.grdCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCategories.Size = new System.Drawing.Size(537, 398);
            this.grdCategories.TabIndex = 0;
            this.grdCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.btnCategorySave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCategoryNew);
            this.panel1.Controls.Add(this.txtCategoryDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 398);
            this.panel1.TabIndex = 0;
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Location = new System.Drawing.Point(89, 121);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySave.TabIndex = 4;
            this.btnCategorySave.Text = "Kaydet";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCategoryNew
            // 
            this.btnCategoryNew.Location = new System.Drawing.Point(9, 121);
            this.btnCategoryNew.Name = "btnCategoryNew";
            this.btnCategoryNew.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryNew.TabIndex = 3;
            this.btnCategoryNew.Text = "Yeni";
            this.btnCategoryNew.UseVisualStyleBackColor = true;
            this.btnCategoryNew.Click += new System.EventHandler(this.btnCategoryNew_Click);
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(96, 43);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(149, 61);
            this.txtCategoryDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kat. Tanımı";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(96, 12);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(149, 25);
            this.txtCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // ManavUygulaması
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(802, 452);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManavUygulaması";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manav Uygulaması";
            this.tabControl1.ResumeLayout(false);
            this.tpCustomers.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tbProducts.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.tbCategories.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCustomers;
        private System.Windows.Forms.TabPage tbProducts;
        private System.Windows.Forms.TabPage tbCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdCategories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCategoryNew;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

