using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Web.Entity
{
    public class Hasta
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dogumtarihi { get; set; }
    }
}