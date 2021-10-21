using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Web.Entity
{
    public class Randevu
    {
        public int id { get; set; }
        public int mesaibaslangic = 8;
        public int mesaibitis = 18;
        public int baslangic { get; set; }
        public int bitis { get; set; }
    }
}