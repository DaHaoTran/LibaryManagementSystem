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
using XAct;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormQLKH : Form
    {
        private IQLKhachHangSvc svc;
        private int numpage = 1;
        private int numrecord = 5;
        private void GetTableKH(int page, int record)
        {
            dtGvKH.DataSource = svc.GetKhachHang(page, record);
        }
        private void Start()
        {
            txtTenKH.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            txtSoDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbBoxTrT.Text = string.Empty;
            txtNgayMuon.Text = string.Empty;
            txtNgayTra.Text = string.Empty;

            txtTenKH.Enabled = false;
            txtMaKH.Enabled = false;
            txtSoDT.Enabled = false;
            txtEmail.Enabled = false;
            cbBoxTrT.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            numpage = 1;
            numrecord = 5;
        }
        private bool CheckTenKHInput(string tenkh)
        {
            bool re = true;
            Regex r = new Regex(@"[!,@,#,$,%,^,&,*,(,),<,>,?,/,|,\.`,~]");
            if (r.IsMatch(tenkh) == false)
            {
                Regex r2 = new Regex(@"[0-9]");
                if (r2.IsMatch(tenkh) == false)
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
        public FormQLKH(IQLKhachHangSvc _svc)
        {
            InitializeComponent();
            svc = _svc;
            Start();
            GetTableKH(numpage, numrecord);

        }

        private void FormQLKH_Load(object sender, EventArgs e)
        {

        }
        private void EnableTextBox()
        {
            txtTenKH.Enabled = true;
            txtSoDT.Enabled = true;
            txtEmail.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableTextBox();
            btnLuu.Enabled = true;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Start();
            GetTableKH(numpage, numrecord);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKhachHang = svc.TaoNewMaKhachHang();
            kh.TenKhachHang = txtTenKH.Text.Trim();
            kh.SoDT = txtSoDT.Text.Trim();
            kh.Email = txtEmail.Text.Trim();
            kh.MatKhau = svc.encryption("user" + kh.MaKhachHang);
            kh.TrangThai = "none";
            kh.MaNV = FormMain.instance.maNv;
            kh.MaSach = null;
            if (txtEmail.Text.Trim().Contains("@gmail.com") && txtEmail.Text.Trim().Length > 13)
            {
                if(txtTenKH.Text.Trim().Length > 1)
                {
                    if (svc.CheckNotExistEmail(txtEmail.Text.Trim()))
                    {
                        if (CheckTenKHInput(txtTenKH.Text.Trim()) == false)
                        {
                            if (txtSoDT.Text.Trim().Length == 10)
                            {
                                if((txtSoDT.Text.Trim()).IsNumeric())
                                {
                                    if (svc.ThemKhachHang(kh))
                                    {
                                        MessageBox.Show("Thêm khách hàng mới thành công");
                                        Start();
                                        GetTableKH(numpage, numrecord);
                                        MessageBox.Show("Mật khẩu khách hàng " + kh.MaKhachHang + " là " + "user" + kh.MaKhachHang);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm khách hàng mới thất bại");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Số điện thoại không được chứa chữ hay ký tự");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại phải có đúng 10 số");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên khách hàng không được chứa ký tự hoặc số");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email bị trùng với email của khách hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Tên khách hàng phải chứa ít nhất 2 ký tự trở lên");
                }
              
            }
            else
            {
                MessageBox.Show("Email khách hàng chưa đúng định dạng");
            }
        }

        private void dtGvKH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dtGvKH.CurrentCell.RowIndex;
            txtTenKH.Text = dtGvKH.Rows[index].Cells[1].Value.ToString();
            txtSoDT.Text = dtGvKH.Rows[index].Cells[2].Value.ToString();
            txtEmail.Text = dtGvKH.Rows[index].Cells[3].Value.ToString();
            cbBoxTrT.Text = dtGvKH.Rows[index].Cells[7].Value.ToString();
            txtNgayMuon.Text = dtGvKH.Rows[index].Cells[4].Value.ToString();
            txtNgayTra.Text = dtGvKH.Rows[index].Cells[5].Value.ToString();
            txtMaKH.Text = dtGvKH.Rows[index].Cells[0].Value.ToString();

            btnThem.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            cbBoxTrT.Enabled = true;
            EnableTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKhachHang = txtMaKH.Text.Trim();
            kh.TenKhachHang = txtTenKH.Text.Trim();
            kh.SoDT = txtSoDT.Text.Trim();
            kh.Email = txtEmail.Text.Trim();
            kh.TrangThai = cbBoxTrT.Text.Trim();
            kh.MaNV = FormMain.instance.maNv;
            if (txtEmail.Text.Trim().Contains("@gmail.com") && txtEmail.Text.Trim().Length > 13)
            {
                if(txtTenKH.Text.Trim().Length > 1)
                {
                    if (svc.CheckNotExistEmail(txtEmail.Text.Trim()))
                    {
                        if (CheckTenKHInput(txtTenKH.Text.Trim()) == false)
                        {
                            if (txtSoDT.Text.Trim().Length == 10)
                            {
                                if(txtSoDT.Text.Trim().IsNumeric())
                                {
                                    if (svc.SuaKhachHang(kh))
                                    {
                                        MessageBox.Show("Sửa thông tin khách hàng thành công");
                                        Start();
                                        GetTableKH(numpage, numrecord);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sửa thông tin khách hàng thất bại");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Số điện thoại không được chứa chữ hay ký tự");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại phải có đúng 10 số");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên khách hàng không được chứa ký tự hoặc số");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email bị trùng với email của khách hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Tên khách hàng phải chứa ít nhất 2 ký tự trở lên");
                }
            }
            else
            {
                MessageBox.Show("Email khách hàng chưa đúng định dạng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dtGvKH.CurrentCell.RowIndex;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(dtGvKH.Rows[index].Cells[7].Value.ToString().Contains("Đang") || dtGvKH.Rows[index].Cells[7].Value.ToString().Contains("Đang mượn"))
                {
                    MessageBox.Show($"Khách hàng {dtGvKH.Rows[index].Cells[0].Value.ToString()} đang mượn sách, không được phép xóa");
                }
                else
                {
                    if (svc.XoaKhachHang(txtMaKH.Text.Trim()))
                    {
                        MessageBox.Show("Xóa thông tin khách hàng thành công");
                        Start();
                        GetTableKH(numpage, numrecord);
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng này sẽ làm ảnh hưởng đến các dữ liệu khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain.instance.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtGvKH.DataSource = svc.FindKhachHang(txtTimKiem.Text.Trim());
            if (dtGvKH.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin liên quan");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (numpage - 1 > 0)
            {
                numpage--;
                GetTableKH(numpage, numrecord);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int total = 0;
            using (var entity = new QLThuVienDBContext())
            {
                total = entity.khachHangs.Count();
            }
            if (total != 5)
            {
                if (numpage - 1 < total / numrecord)
                {
                    numpage++;
                    GetTableKH(numpage, numrecord);
                }
            }
        }

        private void dtGvKH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 7 && e.Value != null)
            {
                string tinhtrg = e.Value.ToString();
                if(tinhtrg == "Đang mượn")
                {
                    DateTime ngaymuon = DateTime.Parse(dtGvKH.Rows[e.RowIndex].Cells[4].Value.ToString());
                    DateTime ngaytra = DateTime.Parse(dtGvKH.Rows[e.RowIndex].Cells[5].Value.ToString());
                    TimeSpan songay = ngaytra - ngaymuon;
                    int hantra = songay.Days;
                    if(hantra == 2 || hantra == 1)
                    {
                        dtGvKH.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if(hantra < 1)
                    {
                        dtGvKH.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
