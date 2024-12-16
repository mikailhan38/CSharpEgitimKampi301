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
    public partial class FrmCategory : Form
    {
         private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var getAll = _categoryService.GetAll();
            dataGridView1.DataSource = getAll;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=tbxCategoryName.Text;
            if (rbtnActive.Checked)
            {
                category.CategoryStatus = true;
            }
            if (rbtnPassive.Checked)
            {
                category.CategoryStatus = false;
            }
            _categoryService.Add(category);
            MessageBox.Show("Başarılı Bir Şekilde Kayıt edildi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id =int.Parse(tbxCategoryId.Text);
            var deletedValues=_categoryService.GetById(id);
            _categoryService.Delete(deletedValues);
            MessageBox.Show("Seçili Kategori Silindi");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxCategoryId.Text);
           var values= _categoryService.GetById(id);
            dataGridView1 .DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // Category category=new Category();
            int updatedId= int.Parse(tbxCategoryId.Text);
            var updatedValue=_categoryService.GetById(updatedId);
            updatedValue.CategoryName = tbxCategoryName.Text;
            if (rbtnActive.Checked)
            {
                updatedValue.CategoryStatus = true;
            }
            if (rbtnPassive.Checked)
            {
                updatedValue.CategoryStatus = false;
            }
            _categoryService.Update(updatedValue);

        }
    }
}
