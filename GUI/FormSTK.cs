using PRO131_Duan1_FA23.Core.Context;
using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormSTK : Form
    {
        private int numpage = 1;
        private int numrecord = 5;
        private void gettableSTK()
        {
            using (var entity = new QLThuVienDBContext())
            {
                var s = entity.sachs.Where(x => x.TinhTrang == false).Skip((numpage - 1) * numrecord).Take(numrecord).ToList();
                dataGridViewSTK.DataSource = s;
            }
        }
        public FormSTK()
        {
            InitializeComponent();
            numpage = 1;
            numrecord = 5;
            gettableSTK();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var entity = new QLThuVienDBContext())
            {
                dataGridViewSTK.DataSource = entity.sachs.Where(x => x.TenSach.Contains(txtTenSach.Text.Trim())).ToList();
            }
            if (dataGridViewSTK.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin liên quan");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int total = 0;
            using (var entity = new QLThuVienDBContext())
            {
                total = entity.sachs.Where(x => x.TinhTrang == false).Count();
            }
            if (total != 5)
            {
                if (numpage - 1 < total / numrecord)
                {
                    numpage++;
                    gettableSTK();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (numpage - 1 > 0)
            {
                numpage--;
                gettableSTK();
            }
        }
    }
}
