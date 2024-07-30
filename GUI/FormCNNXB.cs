using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PRO131_Duan1_FA23.Core.Context;
using PRO131_Duan1_FA23.Core.Models;
using PRO131_Duan1_FA23.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XAct;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormCNNXB : Form
    {
        private INhaXBSvc svc;
        private int pagenumber = 1;
        private int numberrecord = 5;
        private void GetTableNhaXB(int page, int record)
        {
            dtGvNXB.DataSource = svc.GetNhaXB(page, record);
        }
        private void Skip()
        {
            txtNXB.Enabled = false;
            txtTenNXB.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDT.Enabled = false;
            txtGC.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtNXB.Text = string.Empty;
            txtTenNXB.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSoDT.Text = string.Empty;
            txtGC.Text = string.Empty;

            pagenumber = 1;
            numberrecord = 5;
        }
        public FormCNNXB(INhaXBSvc _svc)
        {
            InitializeComponent();
            svc = _svc;
            GetTableNhaXB(pagenumber, numberrecord);
            Skip();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaXB xb = new NhaXB();
            xb.MaXB = txtNXB.Text.Trim();
            xb.TenNhaXB = txtTenNXB.Text.Trim();
            xb.DiaChi = txtDiaChi.Text.Trim();
            xb.SoDT = txtSoDT.Text.Trim();
            xb.GhiChu = txtGC.Text.Trim();
            xb.MaNV = FormMain.instance.maNv;
            if(txtSoDT.Text.Length >= 8 && txtSoDT.Text.Length <= 10)
            {
                if(txtSoDT.Text.Trim().IsNumeric())
                {
                    if (svc.CapNhapNhaXB(xb))
                    {
                        MessageBox.Show("Sửa nhà xuất bản thành công");
                        Skip();
                        GetTableNhaXB(pagenumber, numberrecord);
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhà xuất bản thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không được chứa chữ hay ký tự");
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại phải có từ 8 đến 10 số trở lên");
            }
        }
        private void OpenTextBox()
        {
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            txtGC.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenTextBox();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain.instance.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (svc.XoaNhaXB(txtNXB.Text))
                {
                    MessageBox.Show("Xóa nhà xuất bản thành công");
                    Skip();
                    GetTableNhaXB(pagenumber, numberrecord);
                }
                else
                {
                    MessageBox.Show("Xóa sách này sẽ làm ảnh hưởng đến các dữ liệu khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void FormCNNXB_Load(object sender, EventArgs e)
        {

        }

        private void dtGvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Skip();
            GetTableNhaXB(pagenumber, numberrecord);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhaXB xb = new NhaXB();
            xb.MaXB = svc.NewMaXB();
            xb.TenNhaXB = txtTenNXB.Text.Trim();
            xb.DiaChi = txtDiaChi.Text.Trim();
            xb.SoDT = txtSoDT.Text.Trim();
            xb.GhiChu = txtGC.Text.Trim();
            xb.MaNV = FormMain.instance.maNv;
            if(txtSoDT.Text.Length >= 8 && txtSoDT.Text.Length <=10)
            {
                if(txtSoDT.Text.Trim().IsNumeric())
                {
                    if (svc.ThemNhaXB(xb))
                    {
                        MessageBox.Show("Thêm nhà xuất bản mới thành công");
                        Skip();
                        GetTableNhaXB(pagenumber, numberrecord);
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà xuất bản mới thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không được chứa chữ hay ký tự");
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại phải có từ 8 đến 10 số trở lên");
            }
        }

        private void dtGvNXB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OpenTextBox();
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int index = dtGvNXB.CurrentCell.RowIndex;
            txtNXB.Text = dtGvNXB.Rows[index].Cells[0].Value.ToString();
            txtTenNXB.Text = dtGvNXB.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dtGvNXB.Rows[index].Cells[2].Value.ToString();
            txtSoDT.Text = dtGvNXB.Rows[index].Cells[3].Value.ToString();
            txtGC.Text = dtGvNXB.Rows[index].Cells[4].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtGvNXB.DataSource = svc.FindNhaXB(txtTimKiem.Text.Trim());
            if (dtGvNXB.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin liên quan");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int total = 0;
            using (var entity = new QLThuVienDBContext())
            {
                total = entity.nhaXBs.Count();
            }
            if(total != 5)
            {
                if (pagenumber - 1 < total / numberrecord)
                {
                    pagenumber++;
                    GetTableNhaXB(pagenumber, numberrecord);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(pagenumber - 1 > 0)
            {
                pagenumber--;
                GetTableNhaXB(pagenumber, numberrecord);
            }
        }
    }
}
