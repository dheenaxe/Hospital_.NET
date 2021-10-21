using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Web.Entity
{
    public class Toplam
    {
        public int id { get; set; }
        public string adsoyad { get; set; }
        public DateTime dogumtarihi { get; set; }
        public string brans { get; set; }
        public string randevusaati { get; set; }
    }
}