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
    public partial class BransEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var context = new MyContext())
            {
                var Brans = new Brans()
                {
                    brans = txtBrans.Text
                };
                context.Branslar.Add(Brans);
                context.SaveChanges();
            }
        }
    }
}