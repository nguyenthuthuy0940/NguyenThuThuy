using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThuThuy.Models
{
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        public int Id { get; set; }
        public int MaLop { get; set; }
        public string TenLop { get; set; }
    }
}
