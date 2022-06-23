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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB();
            ShowDGV();
        }
        private void SetCBB()
        {
            comboBoxHP.Items.Clear();
            comboBoxHP.Items.AddRange(BLLQLSV.Instance.GetCBBHP().Distinct().ToArray());
            comboBoxSort.Items.Clear();
            comboBoxSort.Items.Add("TenSV");
            comboBoxSort.Items.Add("DiemCK");
            comboBoxSort.Items.Add("DiemGK");
        }
        private void ShowDGV(string MaHP = "0", string txt = "")
        {
            List<SV> list = BLLQLSV.Instance.Search(MaHP, txt);
            dataGridView1.DataSource = BLLQLSV.Instance.ShowSVView(list);
        }

        private void comboBoxHP_SelectedIndexChanged(object sender, EventArgs e)
        {            
                string MaHP = ((CBBItemHP)comboBoxHP.SelectedItem).Value;
                ShowDGV(MaHP, "");          
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            string MaHP = "0";
            if (comboBoxHP.SelectedIndex >= 0) MaHP = ((CBBItemHP)comboBoxHP.SelectedItem).Value;
            ShowDGV(MaHP, textBox1.Text);
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<string> listMaSV = new List<string>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    listMaSV.Add(row.Cells["MaSV"].Value.ToString());
                }
                BLLQLSV.Instance.DeleteSV(listMaSV);
                ShowDGV();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn sản phẩm để xóa");
            }
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            List<string> ListMaSV = new List<string>();
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    ListMaSV.Add(row.Cells["MaSV"].Value.ToString());
                }
            }
            List<SV> data = BLLQLSV.Instance.Sort(BLLQLSV.Instance.GetSVListNow(ListMaSV), comboBoxSort.SelectedItem.ToString());
            dataGridView1.DataSource = BLLQLSV.Instance.ShowSVView(data);
        }

    }
}
