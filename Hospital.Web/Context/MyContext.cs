using Hospital.Web.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hospital.Web.Context
{
    public class MyContext:DbContext
    {
        public MyContext()
            :base("HospitalContext")
        {

        }
        public DbSet<Brans> Branslar { get; set; }
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<Toplam> Toplamlar { get; set; }
    }
}