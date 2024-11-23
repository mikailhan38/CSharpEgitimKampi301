using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfProject
{
    public partial class FrmStatics : Form
    {
        public FrmStatics()
        {
            InitializeComponent();
        }
        EfProjectDBEntities db = new EfProjectDBEntities();
        private void FrmStatics_Load(object sender, EventArgs e)
        {


            lblLocationTotal.Text = db.Locations.Count().ToString();
            lblSumCapacity.Text = db.Locations.Sum(x => x.Capacity).ToString();
            lblRebherSum.Text = db.Guides.Count().ToString();
            lblCapacityAvg.Text = db.Locations.Average(x => x.Capacity).Value.ToString("F0");
            lblAvgTourPrice.Text = db.Locations.Average(x => x.Price).Value.ToString("F2") + " ₺";
            int lastCountryId = db.Locations.Max(x => x.LocationId);
            lblLastCountry.Text = db.Locations.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            lblKapadokya.Text = db.Locations.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkeyAvgCapacity.Text = db.Locations.Where(x => x.Country == "Türkiye").Average(x => x.Capacity).ToString();
            var romeGuideId = db.Locations.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomaRehber.Text = db.Guides.Where(x => x.GuideId == romeGuideId).Select(y => y.Name + " " + y.Surname).FirstOrDefault().ToString();
            var maxCapacity=db.Locations.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text=db.Locations.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();
            var maxPrice =db.Locations.Max(y => y.Price);
            lblMaxPriceTour.Text = db.Locations.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();
            var guideIdMikailLale = db.Guides.Where(x=>x.Name=="Mikail"&&x.Surname=="Lale").Select(y => y.GuideId).FirstOrDefault();
            lblMikailTour.Text=db.Locations.Where(x=>x.GuideId==guideIdMikailLale).Count().ToString();
        }
    }
}
