using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hospital.Web.Entity;
using Hospital.Web.Context;
using System.Data.SqlClient;
using System.Data;

namespace Hospital.Web
{
    public partial class Tumunu_Ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var context = new MyContext())
                {
                    foreach (var item in context.Hastalar)
                    {
                        string x = item.ad;
                        string y = item.soyad;
                        string z = Convert.ToString(item.dogumtarihi);
                        ddHAdi.Items.Add(x);
                        ddHSoy.Items.Add(y);
                        ddDogum.Items.Add(z);
                    }
                    foreach (var item in context.Branslar)
                    {
                        string x = item.brans;
                        ddBrans.Items.Add(x);
                    }
                    foreach (var item in context.Randevular)
                    {
                        int x = item.baslangic;
                        int y = item.bitis;
                        ddRandevuBaslangic.Items.Add(x.ToString());
                        ddRandevuBitis.Items.Add(y.ToString());
                    }

                }
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = ddHAdi.Text;
            string soyad = ddHSoy.Text;
            string adsoyad = ad + " " + soyad;
            string baslangic = ddRandevuBaslangic.Text;
            string bitis = ddRandevuBitis.Text;
            string randevusaati = baslangic + "-" + bitis;
            using (var context = new MyContext())
            {
                var Toplam = new Toplam()
                {
                    adsoyad = adsoyad,
                    brans = ddBrans.Text,
                    dogumtarihi = Convert.ToDateTime(ddDogum),
                    randevusaati = randevusaati
                };
                context.Toplamlar.Add(Toplam);
                context.SaveChanges();
            }
        }
    }
}