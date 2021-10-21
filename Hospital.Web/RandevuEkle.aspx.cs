using Hospital.Web.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hospital.Web.Entity;

namespace Hospital.Web
{
    public partial class RandevuEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtbitis.Text) > 18 || int.Parse(txtbaslangic.Text) < 8)
            {
                Response.Write("<script language='javascript'>alert('Mesai Saatleri Dışında Bir Seçim')</script>");
            }
            else
            {
                using (var context = new MyContext())
                {
                    var Randevu = new Randevu()
                    {
                        baslangic = int.Parse(txtbaslangic.Text),
                        bitis = int.Parse(txtbitis.Text)
                    };
                    context.Randevular.Add(Randevu);
                    context.SaveChanges();
                }
            }
        }
    }
}