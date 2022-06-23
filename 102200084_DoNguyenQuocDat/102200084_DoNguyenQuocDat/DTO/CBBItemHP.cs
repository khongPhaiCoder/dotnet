using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _102200288_LeDucTho.DTO;

namespace _102200084_DoNguyenQuocDat.BLL
{
    public class BLLQLSV
    {
        DALQLSV db = new DALQLSV();
        private static BLLQLSV _Instance;
        public static BLLQLSV Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLLQLSV();
                return _Instance;
            }
            private set { }
        }
        public List<CBBItemHP> GetCBBHP()
        {
            List<CBBItemHP> list = new List<CBBItemHP>();
            list.Add(new CBBItemHP { Value = "0", Text = "All" });
            foreach (HP i in db.HPs)
            {
                list.Add(new CBBItemHP { Value = i.MaHP, Text = i.TenHP });
            }
            return list;
        }
        public List<SV> Search(string MaHP, string txt)
        {
            List<SV> list = new List<SV>();
            if (MaHP == "0")
            {
                return db.SVs.Where(p => p.TenSV.Contains(txt)).ToList();
            }
            else
            {
                list = db.SVs.Where(p => p.TenSV.Contains(txt) && p.HP.MaHP.Equals(MaHP)).ToList();

            }
            return list;
        }
        public List<SV_View> ShowSVView(List<SV> list)
        {
            List<SV_View> data = new List<SV_View>();
            foreach (SV i in list)
            {

                data.Add(new SV_View
                {
                    MaSV = i.MaSV,
                    TenSV = i.TenSV,
                    LopSH = i.LopSH,
                    DiemBT = i.DiemBT,
                    DiemGK = i.DiemGK,
                    DiemCK = i.DiemCK,
                    TongKet = i.DiemBT * 0.2 + i.DiemGK * 0.2 + i.DiemCK * 0.6,
                    TenHP = i.HP.TenHP,
                    NgayThi = i.NgayThi,
                });
            }
            return data;
        }
        public List<SV> GetAllSV()
        {
            return db.SVs.ToList();
        }
        public void DeleteSV(List<string> ListMaSV)
        {
            foreach (string i in ListMaSV)
            {
                SV s = db.SVs.Find(i);
                db.SVs.Remove(s);
            }
            db.SaveChanges();
        }
        public List<SV> GetSVListNow(List<string> ListMaSV)
        {
            List<SV> list = new List<SV>();
            foreach (string i in ListMaSV)
            {
                SV s = db.SVs.Find(i);
                list.Add(s);
            }
            return list;
        }
        public List<SV> Sort(List<SV> list, string SortType)
        {
            switch (SortType)
            {
                case "TenSV":
                    {
                        return list.OrderBy(s => s.TenSV).ToList();
                    }
                case "DiemCK":
                    {
                        return list.OrderBy(s => s.DiemCK).ToList();
                    }
                case "DiemGK":
                    {
                        return list.OrderBy(s => s.DiemGK).ToList();
                    }
                default:
                    return list;
            }
        }
        public bool isUpdate(string MaSV)
        {
            if (db.SVs.Find(MaSV) != null) return true;
            return false;
        }
    }
}
