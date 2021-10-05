using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenThuThuy.Models
{
    public partial class LTQLDbContetx : DbContext
    {
        public LTQLDbContetx()
            : base("name=LTQLDbContetx")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<NguyenThuThuy.Models.LopHoc> LopHocs { get; set; }

        public System.Data.Entity.DbSet<NguyenThuThuy.Models.SinhVien> SinhViens { get; set; }
    }
}
