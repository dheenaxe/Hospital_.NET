using Hospital.Web.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital.Web
{
    public partial class TumunuListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new MyContext())
            {
                gw15DAKİKAKALDİ.DataSource = context.Toplamlar.OrderByDescending(x => x.id).ToList();
                gw15DAKİKAKALDİ.DataBind();
            }
        }
    }
}