using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200084_DoNguyenQuocDat.DTO
{
    public class SV_View
    {
        public string MaSV { get; set; }

        public string TenSV { get; set; }
        public string TenHP { get; set; }
        public string LopSH { get; set; }
        public double DiemBT { get; set; }
        public double DiemGK { get; set; }
        public double DiemCK { get; set; }
        public double TongKet { get; set; }
        public DateTime? NgayThi { get; set; }
    }
}
