using ManavUygulamasi.Entities;
using ManavUygulamasi.Repository;
using ManavUygulamasi.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManavUygulamasi
{
    public partial class ManavUygulaması : Form
    {
        ProductRepo productRepo;
        CategoryRepo categoryRepo;
        Category selectedCategory = null;
        CustomerRepo customerRepo;

        int topCategoryId = 1;
        public ManavUygulaması()
        {
            InitializeComponent();

            categoryRepo = new CategoryRepo();
            productRepo = new ProductRepo();
            customerRepo = new CustomerRepo();
        }

        private void tbCategories_Enter(object sender, EventArgs e)
        {
            FillCategories();
        }

        private void FillCategories()
        {
            var categories = categoryRepo.Get();
            grdCategories.DataSource = categories;
        }
        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            Category category = new Category();

            if (this.selectedCategory == null)
            {
                category.CategoryId = 0;
                if (txtCategoryName.Text != "" && txtCategoryDescription.Text != "")
                {
                    category.CategoryName = txtCategoryName.Text;
                    category.Description = txtCategoryDescription.Text;
                }
                else
                    MessageBox.Show("Kategori adı ve tanımı boş geçilemez.");
            }
            else
            {
                category.CategoryId = selectedCategory.CategoryId;
                category.CategoryName = txtCategoryName.Text;
                category.Description = txtCategoryDescription.Text;
                selectedCategory = null;
            }
            categoryRepo.Add_Update(category);
            FillCategories();
            CategoryFormClear();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var category = (grdCategories.DataSource as List<Category>)[e.RowIndex];
            selectedCategory = category;
            txtCategoryName.Text = category.CategoryName;
            txtCategoryDescription.Text = category.Description;
        }

        private void CategoryFormClear()
        {
            txtCategoryDescription.Clear();
            txtCategoryName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                if (MessageBox.Show("Kaydın Silinmesini İstiyormusunuz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    categoryRepo.Delete(selectedCategory);
                    FillCategories();
                    ClearCategoryTab();
                }
            }
            else
            {
                MessageBox.Show("Lütfen öncesinde kategori seçimi yapınız");
            }
        }

        private void tbProducts_Enter(object sender, EventArgs e)
        {
            FillProducs();
        }

        private void FillProducs()
        {
            List<Product> products = productRepo.Get();
            grdProducts.DataSource = products;
            grdProducts.Columns[2].Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductForm urunFormu = new ProductForm();
            urunFormu.ShowDialog();
            FillProducs();
        }

        private void grdProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var product = (grdProducts.DataSource as List<Product>)[e.RowIndex];

            ProductForm pf = new ProductForm();
            pf.Tag = product.ProductId;
            pf.ShowDialog();
            FillProducs();
        }

        private void tpCustomers_Enter(object sender, EventArgs e)
        {
            FillCustomers();
        }

        private void FillCustomers()
        {

            grdCustomers.DataSource = customerRepo.GetVm_Customers();
            grdCustomers.Columns["CityId"].Visible = false;
            grdCustomers.Columns["TownId"].Visible = false;
            grdCustomers.Columns["DistrictId"].Visible = false;
        }

        private void grdCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var customer = (grdCustomers.DataSource as List<Vm_Customer>)[e.RowIndex];
            CustomerForm cf = new CustomerForm();
            cf.Tag = customer.CustomerId;
            cf.ShowDialog();
            FillCustomers();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
            FillCustomers();
        }

        private void btnCategoryNew_Click(object sender, EventArgs e)
        {
            ClearCategoryTab();
        }

        private void ClearCategoryTab()
        {
            txtCategoryDescription.Clear();
            txtCategoryName.Clear();
            selectedCategory = null;
        }
    }
}
