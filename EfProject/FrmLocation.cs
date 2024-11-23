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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EfProjectDBEntities db = new EfProjectDBEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Locations.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Locations location = new Locations();
            location.Capacity=byte.Parse(numCapacity.Value.ToString());
            location.City=tbxCity.Text;
            location.Country=tbxCountry.Text;
            location.Price=decimal.Parse(tbxPrice.Text.ToString());
            location.DayNight = tbxDay.Text;
            location.GuideId=int.Parse(cbxRehber.SelectedValue.ToString());
            db.Locations.Add(location);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guides.Select(x => new
            {
                FullName = x.Name + " " + x.Surname,
                x.GuideId
            }).ToList();
            cbxRehber.DisplayMember = "FullName";
            cbxRehber.ValueMember = "GuideId";
            cbxRehber.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxIdEdit.Text.ToString());
            var value = db.Locations.Find(id);
            db.Locations.Remove(value);
            db.SaveChanges();
            MessageBox.Show("Silme Başarılı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbxIdEdit.Text = row.Cells["LocationId"].Value.ToString();
                tbxCity.Text = row.Cells[1].Value.ToString();
                tbxCountry.Text = row.Cells[2].Value.ToString();
                numCapacity.Text = row.Cells[3].Value.ToString();
                tbxPrice.Text = row.Cells[4].Value.ToString();
                tbxDay.Text = row.Cells[5].Value.ToString();
                cbxRehber.DisplayMember = row.Cells[6].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxIdEdit.Text.ToString());
            var value = db.Locations.Find(id);
            value.Capacity = byte.Parse(numCapacity.Value.ToString());
            value.City = tbxCity.Text;
            value.Country = tbxCountry.Text;
            value.Price = decimal.Parse(tbxPrice.Text.ToString());
            value.DayNight = tbxDay.Text;
            value.GuideId = int.Parse(cbxRehber.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
        }
    }
}
