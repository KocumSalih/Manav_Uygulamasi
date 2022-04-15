using ManavUygulamasi.Entities;
using ManavUygulamasi.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManavUygulamasi
{
    public partial class ProductForm : Form
    {
        ProductRepo productRepo;
        CategoryRepo categoryRepo;
        public ProductForm()
        {
            InitializeComponent();

            productRepo = new ProductRepo();
            categoryRepo = new CategoryRepo();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillCategory();
            FiilForm();
        }

        private void FiilForm()
        {
            if (this.Tag != null)
            {
                var product = productRepo.GetByID(Convert.ToInt32(this.Tag));
                if (product != null)
                {
                    txtProductName.Text = product.ProductName;
                    cmbProductCategory.SelectedValue = product.CategoryId;
                    //txtQuantityPerUnit.Text = product.QuantityPerUnit;
                    chkDiscontinued.Checked = product.Discontinued;
                    nudUnitPrice.Value = product.UnitPrice;
                    nudUnitsInStok.Value = product.UnitsInStock;
                    nudUnitsOnOrder.Value = product.UnitsOnOrder;
                }
            }
        }

        private void FillCategory()
        {
            var categories = categoryRepo.Get();
            cmbProductCategory.DataSource = categories;
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {

            Product product = null;
            if (this.Tag != null && !String.IsNullOrEmpty(txtProductName.Text) && cmbProductCategory.SelectedIndex>-1)
            {
                product = new Product()
                {
                    ProductId = Convert.ToInt32(this.Tag),
                    ProductName = txtProductName.Text,
                    CategoryId = Convert.ToInt32(cmbProductCategory.SelectedValue),
                    //QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitPrice = nudUnitPrice.Value,
                    UnitsInStock = Convert.ToInt16(nudUnitsInStok.Value),
                    UnitsOnOrder = Convert.ToInt16(nudUnitsOnOrder.Value),
                    Discontinued = chkDiscontinued.Checked
                };
                productRepo.Add_Update(product);
                this.Close();
                ClearControls();
            }
            else if (this.Tag == null && !String.IsNullOrEmpty(txtProductName.Text) && cmbProductCategory.SelectedIndex > -1)
            {
                product = new Product()
                {
                    ProductId = 0,
                    ProductName = txtProductName.Text,
                    CategoryId = Convert.ToInt32(cmbProductCategory.SelectedValue),
                    UnitPrice = nudUnitPrice.Value,
                    UnitsInStock = Convert.ToInt16(nudUnitsInStok.Value),
                    UnitsOnOrder = Convert.ToInt16(nudUnitsOnOrder.Value),
                    Discontinued = chkDiscontinued.Checked
                };
                productRepo.Add_Update(product);
                this.Close();
            }
            else
                MessageBox.Show("Ürün adı ve kategori alanı boş geçilemez. Kategori listesi boş ise lütfen öncelikli olarak kategori tanımlayınız.");
            
            
        }
        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtProductName.Clear();
            //txtQuantityPerUnit.Clear();
            if (cmbProductCategory.Items.Count!=0)
                cmbProductCategory.SelectedIndex = 0;
            nudUnitPrice.Value = 0;
            nudUnitsInStok.Value = 0;
            nudUnitsOnOrder.Value = 0;
            this.Tag = null;
        }

        private void tbnProductDelete_Click(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                if (MessageBox.Show("Kaydın Silinmesini İstiyormusunuz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productRepo.Delete(productRepo.GetByID(Convert.ToInt32(this.Tag)));
                    this.Close();
                }
            }
            else
                MessageBox.Show("Lütfen Ürün listesinden ürün seçiniz.");
        }
    }
}
