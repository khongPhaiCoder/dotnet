using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _102200288_LeDucTho.DTO;
using _102200288_LeDucTho.BLL;

namespace _102200084_DoNguyenQuocDat.View
{
    public partial class Form2 : Form
    {
        string MaSV;
        public delegate void MyDel(string MaHP, string txt);
        public MyDel d;
        public Form2(string MaSV)
        {
            this.MaSV = MaSV;
            InitializeComponent();
        }
        
    }
}
