using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EfProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EfProjectDBEntities efProjectDBEntities = new EfProjectDBEntities();
        public void LoadList()
        {
            var values = efProjectDBEntities.Guides.ToList();
            dataGridView1.DataSource = values;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

            LoadList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guides guides = new Guides();
            guides.Name = tbxName.Text;
            guides.Surname = tbsSurname.Text;
            efProjectDBEntities.Guides.Add(guides);
            efProjectDBEntities.SaveChanges();
            MessageBox.Show("Rehber kaydı başarı ile gerçekleşti");
            LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxIdEdit.Text);
            var removeValue = efProjectDBEntities.Guides.Find(id);
            efProjectDBEntities.Guides.Remove(removeValue); ;
            efProjectDBEntities.SaveChanges();
            MessageBox.Show("Rehber kaydı başarı ile silindi");
            LoadList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxIdEdit.Text);
            var value = efProjectDBEntities.Guides.Find(id);
            value.Name = tbxName.Text;
            value.Surname = tbsSurname.Text;
            efProjectDBEntities.SaveChanges();
            MessageBox.Show("Rehber kaydı başarı ile gerçekleşti", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadList();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxIdEdit.Text);
            var values = efProjectDBEntities.Guides.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbxIdEdit.Text = row.Cells["GuideId"].Value.ToString();
                tbxName.Text = row.Cells[1].Value.ToString();
                tbsSurname.Text = row.Cells[2].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
