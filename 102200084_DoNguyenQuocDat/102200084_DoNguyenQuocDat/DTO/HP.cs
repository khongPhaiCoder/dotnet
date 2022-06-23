using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _102200084_DoNguyenQuocDat.DTO
{
    internal class HP
    {
        [Key]
        public string MaHP { get; set; }

        public string TenHP { get; set; }

        public ICollection<SV> SVs { get; set; }
        public HP()
        {
            SVs = new HashSet<SV>();
        }
    }
}
