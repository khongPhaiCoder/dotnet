using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _102200288_LeDucTho.DTO;
using System.Data.Entity;

namespace _102200084_DoNguyenQuocDat
{
    public class CreateDB : DropCreateDatabaseAlways<DALQLSV>
    {
        protected override void Seed(DALQLSV context)
        {
            context.HPs.AddRange(new HP[]
            {
                new HP{ MaHP="HP1",TenHP = "Toan" },
                new HP{ MaHP="HP2",TenHP = "Van" },
                new HP{ MaHP="HP3",TenHP = "Anh" },
            });
            context.SVs.AddRange(new SV[]
            {
                new SV{ MaSV = "SV001",TenSV="Nguyen A",LopSH="Lop1A",GT =true,DiemBT =4,DiemGK=10,DiemCK=2,NgayThi = new DateTime(2022, 03, 04),MaHP="HP1"},
                new SV{ MaSV = "SV002",TenSV="Le B",LopSH="Lop1B",GT =true,DiemBT =7,DiemGK=8.7,DiemCK=5,NgayThi = new DateTime(2022, 06, 04),MaHP="HP3"},
                new SV{ MaSV = "SV003",TenSV="Tran C",LopSH="Lop1C",GT =false,DiemBT =10,DiemGK=5,DiemCK=2,NgayThi = new DateTime(2022, 04, 02),MaHP="HP2"},
                new SV{ MaSV = "SV004",TenSV="Doan D",LopSH="Lop1B",GT =true,DiemBT =6,DiemGK=8.9,DiemCK=10,NgayThi = new DateTime(2022, 05, 05),MaHP="HP2"},
                new SV{ MaSV = "SV005",TenSV="Dang E",LopSH="Lop1A",GT =false,DiemBT =10,DiemGK=10,DiemCK=8,NgayThi = new DateTime(2022, 06, 06),MaHP="HP1"},
                new SV{ MaSV = "SV006",TenSV="Bui F",LopSH="Lop1C",GT =true,DiemBT =4,DiemGK=10,DiemCK=2,NgayThi = new DateTime(2022, 03, 04),MaHP="HP3"},

            });
        }
    }
}
