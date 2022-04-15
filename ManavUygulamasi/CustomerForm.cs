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
    public partial class CustomerForm : Form
    {
        CustomerRepo customerRepo;
        Country_City_Town_District_Repo ctd;
        public CustomerForm()
        {
            InitializeComponent();

            customerRepo = new CustomerRepo();
            ctd = new Country_City_Town_District_Repo();

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillForm();  
        }

        private void FillForm()
        {
            if (this.Tag != null)
            {
                var customer = customerRepo.GetVm_Customer(Convert.ToInt32(this.Tag));
                if (customer!=null)
                {
                    txtFirstName.Text = customer.FirstName;
                    txtLastName.Text = customer.LastName;
                    txtPhone.Text = customer.Phone;
                    FillCity(customer);
                }               
            }
            else
            {
                FillCity();
            }
        }
        private void FillCity(Vm_Customer customer=null)
        {
            int customerId = Convert.ToInt32(this.Tag);
            if (customerId > 0)
            {
                cmbCity.DataSource = ctd.GetCities();
                cmbCity.DisplayMember = "CityName";
                cmbCity.ValueMember = "CityId";
                cmbCity.SelectedValue = customer.CityId;
            }
            else
            {
                cmbCity.DataSource = ctd.GetCities();
                cmbCity.DisplayMember = "CityName";
                cmbCity.ValueMember = "CityId";
            }
        }


        private void FillTown()
        {
            if (cmbCity.SelectedValue != null)
            {
                cmbTown.DataSource = ctd.GetTowns((cmbCity.SelectedItem as City));
                cmbTown.DisplayMember = "TownName";
                cmbTown.ValueMember = "TownId";
            }
        }

        private void FillDistrict()
        {
            if (cmbTown.SelectedValue != null)
            {
                cmbDistrict.DataSource = ctd.GetDistricts((cmbTown.SelectedItem as Town));
                cmbDistrict.DisplayMember = "DistrictName";
                cmbDistrict.ValueMember = "DistrictId";
            }
        }
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTown();
        }

        private void cmbTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDistrict();
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "")
            {
                CustomerSaveUpdate();
                this.Close();
            }
            else
                MessageBox.Show("Ad ve Soyad kısmı boş geçilemez...");
            
        }

        private void CustomerSaveUpdate()
        {
            Customer customer = new Customer();
            if (this.Tag != null)
                customer.CustomerId = Convert.ToInt32(this.Tag);
            else
                customer.CustomerId = 0;
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.CityId = Convert.ToInt32(cmbCity.SelectedValue);
            customer.TownId = Convert.ToInt32(cmbTown.SelectedValue);
            customer.DistrictId = Convert.ToInt32(cmbDistrict.SelectedValue);
            customer.Phone = txtPhone.Text;

            customerRepo.Add_Update(customer);
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                CustomerSaveUpdate();
                this.Close();
            }
            else
                MessageBox.Show("Lütfen öncesinde bir müşteri seçimi yapınız.");
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydın Silinmesini İstiyormusunuz?","Bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Customer customer = new Customer();
                if (this.Tag != null)
                {
                    customer.CustomerId = Convert.ToInt32(this.Tag);
                    customerRepo.Delete(customer);
                    this.Close();
                }
                else
                    MessageBox.Show("Lütfen öncesinde müşteri seçiniz.");
            }
        }

        
    }
}
