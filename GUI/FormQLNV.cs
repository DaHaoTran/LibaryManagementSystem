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
using XAct;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormQLNV : Form
    {
        private IQLNhanVienSvc svc;
        private int numpage = 1;
        private int numrecord = 5;
        private void Start()
        {
            txtTenNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSoDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            picBoxImg.Image = null;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;

            numpage = 1;
            numrecord = 5;
        }
        private bool CheckTenNVInput(string tennv)
        {
            bool re = true;
            Regex r = new Regex(@"[!,@,#,$,%,^,&,*,(,),<,>,?,/,|,\.`,~]");
            if (r.IsMatch(tennv) == false)
            {
                Regex r2 = new Regex(@"[0-9]");
                if (r2.IsMatch(tennv) == false)
                {
                    re = false;
                } else
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
        private void GetTableNhanVien()
        {
            dtGvNhanVien.DataSource = svc.GetNhanVien(numpage, numrecord);
        }
        public FormQLNV(IQLNhanVienSvc _svc)
        {
            InitializeComponent();
            svc = _svc;
            Start();
            GetTableNhanVien();
        }
        private byte[] ImgToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void btnUpImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picBoxImg.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain.instance.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string role = string.Empty;
            NhanVien nv = new NhanVien();
            nv.MaNV = svc.TaoNewMaNV();
            nv.TenNV = txtTenNV.Text.Trim();
            nv.Email = txtEmail.Text.Trim();
            nv.SoDT = txtSoDT.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            if (rbNV.Checked)
            {
                nv.VaiTro = false;
                role = "staff";
            }
            else if (rbQTr.Checked)
            {
                nv.VaiTro = true;
                role = "admin";
            }
            nv.MatKhau = svc.encryption(role + nv.MaNV);
            nv.TinhTrang = false;
            if (picBoxImg.Image != null)
            {
                nv.Hinh = ImgToByteArray(picBoxImg.Image);
            }
            if (txtEmail.Text.Trim().Contains("@gmail.com") && txtEmail.Text.Trim().Length > 13)
            {
                if(txtTenNV.Text.Trim().Length > 1)
                {
                    if (CheckTenNVInput(txtTenNV.Text.Trim()) == false)
                    {
                        if (svc.CheckNotExistEmail(txtEmail.Text.Trim()))
                        {
                            if (txtSoDT.Text.Trim().Length == 10)
                            {
                                if(txtSoDT.Text.Trim().IsNumeric())
                                {
                                    if (svc.ThemNhanVien(nv))
                                    {
                                        MessageBox.Show("Thêm nhân viên mới thành công");
                                        Start();
                                        GetTableNhanVien();
                                        MessageBox.Show("Mật khẩu của " + nv.MaNV + " là : " + role + nv.MaNV);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm nhân viên mới thất bại");
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
                            MessageBox.Show("Email đã tồn tại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên nhân viên không được chứa ký tự hoặc số");
                    }
                }
                else
                {
                    MessageBox.Show("Tên nhân viên phải chứa ít nhất 2 ký tự trở lên");
                }
            }
            else
            {
                MessageBox.Show("Email chưa đúng định dạng");
            }
        }
        private Image ByteArrayToImage(byte[] bytes)
        {
            MemoryStream m = new MemoryStream(bytes);
            return Image.FromStream(m);
        }

        private void dtGvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int index = dtGvNhanVien.CurrentCell.RowIndex;
            txtMaNV.Text = dtGvNhanVien.Rows[index].Cells[0].Value.ToString();
            txtTenNV.Text = dtGvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtSoDT.Text = dtGvNhanVien.Rows[index].Cells[2].Value.ToString();
            txtEmail.Text = dtGvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dtGvNhanVien.Rows[index].Cells[4].Value.ToString();
            bool tinhtrg = bool.Parse(dtGvNhanVien.Rows[index].Cells[7].Value.ToString());
            bool vaitro = bool.Parse(dtGvNhanVien.Rows[index].Cells[5].Value.ToString());
            if (tinhtrg == true)
            {
                rbHD.Checked = true;
            }
            else { rbNgungHD.Checked = true; }
            if (vaitro == true)
            {
                rbQTr.Checked = true;
            }
            else
            {
                rbNV.Checked = true;
            }
            byte[] img = (byte[])dtGvNhanVien.Rows[index].Cells[8].Value;
            if (img != null)
            {
                picBoxImg.Image = ByteArrayToImage(img);
            }
            else
            {
                picBoxImg.Image = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text.Trim();
            nv.Email = txtEmail.Text.Trim();
            nv.SoDT = txtSoDT.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            if (rbNV.Checked)
            {
                nv.VaiTro = false;
            }
            else if (rbQTr.Checked)
            {
                nv.VaiTro = true;
            }
            if (rbHD.Checked)
            {
                nv.TinhTrang = true;
            }
            else if (rbNgungHD.Checked)
            {
                nv.TinhTrang = false;
            }
            if (picBoxImg.Image != null)
            {
                nv.Hinh = ImgToByteArray(picBoxImg.Image);
            }
            if (MessageBox.Show("Bạn đã kiểm tra các thông tin ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (rbNgungHD.Checked)
                {
                    if (txtEmail.Text.Trim().Contains("@gmail.com") && txtEmail.Text.Trim().Length > 13)
                    {
                        if(txtTenNV.Text.Trim().Length > 1)
                        {
                            if (svc.CheckNotExistEmail(txtEmail.Text.Trim()))
                            {
                                if (CheckTenNVInput(txtTenNV.Text.Trim()) == false)
                                {
                                    if (txtSoDT.Text.Trim().Length == 10)
                                    {
                                        if(txtSoDT.Text.Trim().IsNumeric())
                                        {
                                            if (svc.SuaNhanVien(nv))
                                            {
                                                MessageBox.Show("Sửa thông tin nhân viên thành công");
                                                Start();
                                                GetTableNhanVien();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Sửa thông tin nhân viên thất bại");
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
                                    MessageBox.Show("Tên nhân viên không được chứa ký tự hoặc số");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email đã tồn tại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên nhân viên phải chứa ít nhất 2 ký tự trở lên");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email chưa đúng định dạng");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản này đang hoạt động, không được phép sửa đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (rbNgungHD.Checked)
                {
                    if (svc.XoaNhanVien(txtMaNV.Text.Trim()))
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                        Start();
                        GetTableNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên này sẽ làm ảnh hưởng đến các dữ liệu khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản này đang hoạt động, không được phép xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Start();
            GetTableNhanVien();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtGvNhanVien.DataSource = svc.FindNhanVien(txtTimKiem.Text.Trim());
            if (dtGvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin liên quan");
            }
        }

        private void rbHD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtGvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                bool tinhtrang = bool.Parse(e.Value.ToString());
                if (tinhtrang == true)
                {
                    dtGvNhanVien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
            }
        }

        private void FormQLNV_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtGvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int total = 0;
            using (var entity = new QLThuVienDBContext())
            {
                total = entity.nhanViens.Count();
            }
            if(total != 5)
            {
                if (numpage - 1 < total / numrecord)
                {
                    numpage++;
                    GetTableNhanVien();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(numpage - 1  > 0)
            {
                numpage--;
                GetTableNhanVien();
            }
        }
    }
}
