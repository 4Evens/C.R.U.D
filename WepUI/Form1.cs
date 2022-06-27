using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstrack;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace WepUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
        private ICategoryService _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            cbxCAtegoryUpdate.DataSource = _categoryService.GetAll();
            cbxCAtegoryUpdate.DisplayMember = "CategoryName";
            cbxCAtegoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName2.Text,
                    QuantityPerUnit = tbxQantityPer.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)
                });
                MessageBox.Show("Ürün Eklendi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdateProductName.Text,
                    CategoryId = Convert.ToInt32(cbxCAtegoryUpdate.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxUnitStockUpdate.Text),
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    QuantityPerUnit = tbxQantityUpdate.Text
                });
                MessageBox.Show("Ürün Güncellendi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[2].Value.ToString();
            cbxCAtegoryUpdate.SelectedValue = row.Cells[1].Value;
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQantityUpdate.Text = row.Cells[4].Value.ToString();
            tbxUnitStockUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Ürün Silindi.");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
