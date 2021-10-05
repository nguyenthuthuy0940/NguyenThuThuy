using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThuThuy.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public int Id { get; set; }
        public int MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public int MaLop { get; set; }
    }
}