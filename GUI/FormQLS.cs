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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormQLS : Form
    {
        private IQLSachSvc svc;
        private int numpage = 1;
        private int numrecord = 5;
        private void GetTableSach()
        {
            dtGvSach.DataSource = svc.GetSach(numpage, numrecord);
        }
        private void GetNhaXBs()
        {
            cbTenNXB.DataSource = svc.GetListTenNXB();
        }
        private void Start()
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtTenSach.Enabled = false;
            txtSL.Enabled = false;
            cbtxtLS.Enabled = false;
            txtTenTG.Enabled = false;
            cbTenNXB.Enabled = false;
            rbMoi.Enabled = false;
            rbCu.Enabled = false;
            cbtxtTrT.Enabled = false;

            txtTenSach.Text = string.Empty;
            txtSL.Text = string.Empty;
            cbtxtLS.Text = string.Empty;
            txtTenTG.Text = string.Empty;
            cbTenNXB.Text = string.Empty;
            rbCu.Checked = false;
            rbMoi.Checked = false;
            cbtxtTrT.Text = string.Empty;
            txtMaSach.Text = string.Empty;

            numpage = 1;
            numrecord = 5;
        }
        private bool CheckTenTGInput(string tentg)
        {
            bool re = true;
            Regex r = new Regex(@"[!,@,#,$,%,^,&,*,(,),<,>,?,/,|,\.`,~]");
            if (r.IsMatch(tentg) == false)
            {
                Regex r2 = new Regex(@"[0-9]");
                if (r2.IsMatch(tentg) == false)
                {
                    re = false;
                }
                else
                {
                    re = true;
                }
            }
            else
            {
                re = true;
            }
            return re;
        }
        public FormQLS(IQLSachSvc _svc)
        {
            InitializeComponent();
            svc = _svc;
            Start();
            GetTableSach();
            GetNhaXBs();
        }

        private void FormQLS_Load(object sender, EventArgs e)
        {

        }
        private void OpenTextBox()
        {
            txtTenSach.Enabled = true;
            txtSL.Enabled = true;
            cbtxtLS.Enabled = true;
            txtTenTG.Enabled = true;
            cbTenNXB.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            OpenTextBox();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.MaSach = svc.TaoMaSachMoi();
            s.TenSach = txtTenSach.Text.Trim();
            s.TacGia = txtTenTG.Text.Trim();
            s.LoaiSach = cbtxtLS.Text.Trim();
            s.TinhTrang = true;
            s.TrangThai = "none";
            s.SoLuong = int.Parse(txtSL.Value.ToString());
            s.MaNV = FormMain.instance.maNv;
            s.MaXB = cbTenNXB.Text.Trim();
            if(!string.IsNullOrEmpty(txtTenSach.Text.Trim()) && !string.IsNullOrEmpty(txtTenTG.Text.Trim()) && !string.IsNullOrEmpty(cbtxtLS.Text.Trim()) && !string.IsNullOrEmpty(txtSL.Value.ToString()) && !string.IsNullOrEmpty(cbTenNXB.Text.Trim()))
            {
                if(CheckTenTGInput(txtTenTG.Text.Trim()) == false)
                {
                    if (svc.ThemSach(s))
                    {
                        MessageBox.Show("Thêm sách mới thành công");
                        Start();
                        GetTableSach();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách mới thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Tên tác giả không được chứa ký tự hoặc số");
                }
               
            }
            else
            {
                MessageBox.Show("Một số thông tin vẫn còn bỏ trống, Hãy nhập đầy đủ");
            }
        }

        private void dtGvSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            rbCu.Enabled = true;
            rbMoi.Enabled = true;
            cbtxtTrT.Enabled = true;
            OpenTextBox();
            int index = dtGvSach.CurrentCell.RowIndex;
            txtMaSach.Text = dtGvSach.Rows[index].Cells[0].Value.ToString();
            txtTenSach.Text = dtGvSach.Rows[index].Cells[1].Value.ToString();
            txtTenTG.Text = dtGvSach.Rows[index].Cells[2].Value.ToString();
            cbtxtLS.Text = dtGvSach.Rows[index].Cells[3].Value.ToString();
            bool tinhtrg = bool.Parse(dtGvSach.Rows[index].Cells[4].Value.ToString());
            if (tinhtrg == true)
            {
                rbMoi.Checked = true;
            }
            else if (tinhtrg == false)
            {
                rbCu.Checked = true;
            }
            cbtxtTrT.Text = dtGvSach.Rows[index].Cells[5].Value.ToString();
            txtSL.Value = decimal.Parse(dtGvSach.Rows[index].Cells[6].Value.ToString());
            cbTenNXB.Text = svc.getTenXB(dtGvSach.Rows[index].Cells[8].Value.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.MaSach = txtMaSach.Text.Trim();
            s.TenSach = txtTenSach.Text.Trim();
            s.TacGia = txtTenTG.Text.Trim();
            s.LoaiSach = cbtxtLS.Text.Trim();
            if (rbMoi.Checked == true)
            {
                s.TinhTrang = true;
            }
            else if (rbCu.Checked == true)
            {
                s.TinhTrang = false;
            }
            s.TrangThai = cbtxtTrT.Text.Trim();
            s.SoLuong = int.Parse(txtSL.Value.ToString());
            s.MaNV = FormMain.instance.maNv;
            s.MaXB = cbTenNXB.Text.Trim();
            if (!string.IsNullOrEmpty(txtTenSach.Text.Trim()) && !string.IsNullOrEmpty(txtTenTG.Text.Trim()) && !string.IsNullOrEmpty(cbtxtLS.Text.Trim()) && !string.IsNullOrEmpty(txtSL.Value.ToString()) && !string.IsNullOrEmpty(cbTenNXB.Text.Trim()))
            {
                if(CheckTenTGInput(txtTenTG.Text.Trim()) == false)
                {
                    if (svc.SuaSach(s))
                    {
                        MessageBox.Show("Sửa thông tin sách thành công");
                        Start();
                        GetTableSach();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin sách thất bại");
                    }
                } 
                else
                {
                    MessageBox.Show("Tên tác giả không được chứa ký tự hoặc số");
                }
              
            } else
            {
                MessageBox.Show("Một số thông tin vẫn còn bỏ trống, Hãy bổ sung đầy đủ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dtGvSach.CurrentCell.RowIndex;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(dtGvSach.Rows[index].Cells[5].Value.ToString().Contains("Đang") || dtGvSach.Rows[index].Cells[5].Value.ToString().Contains("Đang được mượn"))
                {
                    MessageBox.Show($"Sách {dtGvSach.Rows[index].Cells[0].Value.ToString()} đang được mượn, không được phép xóa");
                }
                else
                {
                    if (svc.XoaSach(txtMaSach.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thông tin sách thành công");
                        Start();
                        GetTableSach();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách này sẽ làm ảnh hưởng đến các dữ liệu khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Start();
            GetTableSach();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain.instance.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtGvSach.DataSource = svc.FindSach(txtTimKiem.Text.Trim());
            if (dtGvSach.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin liên quan");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int total = 0;
            using (var entity = new QLThuVienDBContext())
            {
                total = entity.sachs.Count();
            }
            if (total != 5)
            {
                if (numpage - 1 < total / numrecord)
                {
                    numpage++;
                    GetTableSach();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (numpage - 1 > 0)
            {
                numpage--;
                GetTableSach();
            }
        }
    }
}
