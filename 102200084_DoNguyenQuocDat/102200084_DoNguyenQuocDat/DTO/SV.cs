using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _102200084_DoNguyenQuocDat.DTO
{
    internal class SV
    {
        [Key]
        public string MaSV { get; set; }

        public string TenSV { get; set; }

        public string LopSH { get; set; }

        public bool GT { get; set; }
        public double diemBT { get; set; }
        public double diemGK { get; set; }

        public double diemCK { get; set; }
        public DateTime? NgayThi { get; set; }

        [ForeignKey("MaHP")]
        public virtual HP HP { get; set; }
    }
}
