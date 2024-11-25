using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı            
            lblLocationCount.Text = db.Location.Count().ToString();
            #endregion

            #region Toplam Kapasite
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            #endregion

            #region Rehber Sayısı
            lblGuideCount.Text = db.Guide.Count().ToString();
            #endregion

            #region Ortalama Tur Kapasitesi
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            #endregion

            #region Ortalama Tur Fiyatı
            lblAvgPrice.Text = $"{db.Location.Average(x => x.Price):F2} ₺";
            #endregion

            #region Eklenen Son Ülke
            int lastCountryId = db.Location.Max(x=>x.LocationId);
            lblAddedLastCountry.Text =db.Location.Where(x=>x.LocationId==lastCountryId).Select(y=>
            y.Country).FirstOrDefault();
            #endregion

            #region Kapadokya Tur Kapasitesi
            lblCappadociaLocationCap.Text = db.Location.Where(x=>x.City=="Kapadokya").Select(y=> y.Capacity).FirstOrDefault().ToString();
            #endregion

            #region Türkiye Kapasite Ortalaması
            lblTurkiyeCapAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            #endregion

            #region Roma Gezi Rehberi
            var romeGuideId = db.Location.Where(x=>x.City == "Roma Turistik").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname)
                .FirstOrDefault().ToString();
            #endregion

            #region En Yüksek Kapasiteli Tur
            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();
            #endregion

            #region En Pahalı Tur
            var maxPrice = db.Location.Max(x=>x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x=>x.Price == maxPrice).Select(y=>y.City).FirstOrDefault();
            #endregion

            #region Adı Ali Çelik Olan Rehberin Tur Sayısı
            var guideIdByNameAliCelik = db.Guide.Where(x => x.GuideName == "Ali" && x.GuideSurname == "Çelik").Select
                (y => y.GuideId).FirstOrDefault();
            lblAliCelikLocationCount.Text = db.Location.Where(x=>x.GuideId == guideIdByNameAliCelik).Count().ToString();
            #endregion
        }
    }
}
