using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _productService.GetProductWithCategory();
            dataGridView1.DataSource = values;
            var categoryValues = _categoryService.GetAll();
            cbxCategory.DataSource = categoryValues;
            cbxCategory.ValueMember = "CategoryId";
            cbxCategory.DisplayMember = "CategoryName";
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            var values = _productService.GetProductWithCategory();
            dataGridView1.DataSource = values; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxProductId.Text);
            var deletedValues=_productService.GetById(id);
            _productService.Delete(deletedValues);
            MessageBox.Show("Ürün Silindi");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cbxCategory.SelectedValue.ToString());
            product.ProductPrice = decimal.Parse(tbxPrice.Text);
            product.ProductName = tbxProductName.Text;
            product.ProductDescription = tbxDescription.Text;
            product.ProductStock = int.Parse(tbxStock.Text);
            _productService.Add(product);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxProductId.Text);
            var value = _productService.GetById(id);
            value.ProductDescription = tbxDescription.Text;
            value.ProductPrice = decimal.Parse(tbxPrice.Text);
            value.ProductName = tbxProductName.Text;
            value.ProductStock = int.Parse(tbxStock.Text);
            value.CategoryId = int.Parse(cbxCategory.SelectedValue.ToString());
            _productService.Update(value);
            MessageBox.Show("Güncelleme başarılı");

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            tbxProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxStock.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxDescription.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxProductId.Text = id.ToString();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxProductId.Text);
        }
    }
}
