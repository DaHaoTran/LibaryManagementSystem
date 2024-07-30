using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class FormDSM : Form
    {
        private int numpage = 1;
        private int numrecord = 5;
        private int total = 0;
        private void gettableDSM()
        {
            using (var entity = new QLThuVienDBContext())
            {
                var kh = entity.khachHangs.Join(entity.KhachHangSach, x => x.MaKhachHang, x => x.MaKhachHang, (kh, xl) => new
                {
                    MaKH = kh.MaKhachHang,
                    MaSach = xl.MaSach
                }).ToList();

                var groupby = kh.GroupBy(x => x.MaKH, x => x.MaSach, (key, value) => new { MaKH = key, SoLuongMuon = value.Count() }).ToList();

                var list = groupby.Join(entity.khachHangs, x => x.MaKH, x => x.MaKhachHang, (gb, k) => new
                {
                    MaKH = k.MaKhachHang,
                    TenKH = k.TenKhachHang,
                    Email = k.Email,
                    SoLuongMuon = gb.SoLuongMuon,
                    TrangThai = k.TrangThai,
                    NgayMuon = k.NgayMuon,
                    NgayTra = k.NgayTra
                }).OrderByDescending(x => x.NgayTra).ToList();

                total = list.Count();

                dataGridViewDSM.DataSource = list.Skip((numpage - 1) * numrecord).Take(numrecord).ToList();
            }
        }
        public FormDSM()
        {
            InitializeComponent();
            numpage = 1;
            numrecord = 5;
            gettableDSM();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var entity = new QLThuVienDBContext())
            {
                dataGridViewDSM.DataSource = entity.khachHangs.Where(x => x.TenKhachHang.Contains(txtTenKH.Text.Trim())).ToList();
            }
            if (dataGridViewDSM.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin liên quan");
            }
        }

        private void dataGridViewDSM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (total != 5)
            {
                if (numpage - 1 < total / numrecord)
                {
                    numpage++;
                    gettableDSM();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (numpage - 1 > 0)
            {
                numpage--;
                gettableDSM();
            }
        }

        private void FormDSM_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewDSM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 6 && e.Value != null)
            {
                DateTime ngaymuon = DateTime.Parse(dataGridViewDSM.Rows[e.RowIndex].Cells[5].Value.ToString());
                DateTime ngaytra = DateTime.Parse(dataGridViewDSM.Rows[e.RowIndex].Cells[6].Value.ToString());
                TimeSpan songay = ngaytra - ngaymuon;
                int hantra = songay.Days;
                if (hantra == 2 || hantra == 1)
                {
                    dataGridViewDSM.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (hantra < 1)
                {
                    dataGridViewDSM.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
