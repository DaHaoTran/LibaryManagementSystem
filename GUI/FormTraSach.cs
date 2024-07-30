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

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormTraSach : Form
    {
        private ITraSachSvc svc;
        private void active()
        {
            btnTien.Enabled = false;
            btnLui.Enabled = false;
            dataGridViewSDM.DataSource = null;
            dataGridViewSMT.DataSource = null;
            txtTenKH.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            dateTra.Value = DateTime.Now;
        }
        private void GetTableKhachHang()
        {
            dGvTTKhachHang.DataSource = svc.GetKhachHang();
        }
        public FormTraSach(ITraSachSvc _svc)
        {
            InitializeComponent();
            svc = _svc;
            active();
            GetTableKhachHang();
        }

        private void FormTraSach_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain.instance.Show();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            dataGridViewSMT.DataSource = svc.GetListSM(MaKH);
            dataGridViewSDM.DataSource = null;
            btnTien.Enabled = false;
            btnLui.Enabled = true;
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            dataGridViewSDM.DataSource = svc.GetListSM(txtTenKH.Text.Trim());
            dataGridViewSMT.DataSource = null;
            btnTien.Enabled = true;
            btnLui.Enabled = false;
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (dataGridViewSMT.Rows.Count > 0)
            {
                if (svc.TraSach(MaKH))
                {
                    MessageBox.Show($"Xử lý đơn trả sách của khách hàng {MaKH} thành công");
                    active();
                    GetTableKhachHang();
                }
                else
                {
                    MessageBox.Show($"Xử lý đơn trả sách của khách hàng {MaKH} thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sách nào được chọn để trả");
            }
        }
        private string MaKH;
        private void dGvTTKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewSDM.DataSource = null;
            dataGridViewSMT.DataSource = null;
            MaKH = string.Empty;
            int index = dGvTTKhachHang.CurrentCell.RowIndex;
            MaKH = dGvTTKhachHang.Rows[index].Cells[0].Value.ToString();
            txtTenKH.Text = dGvTTKhachHang.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dGvTTKhachHang.Rows[index].Cells[2].Value.ToString();
            txtEmail.Text = dGvTTKhachHang.Rows[index].Cells[3].Value.ToString();
            if (DateTime.Parse(dGvTTKhachHang.Rows[index].Cells[5].Value.ToString()).Year >= 2023)
            {
                dateTra.Value = DateTime.Parse(dGvTTKhachHang.Rows[index].Cells[5].Value.ToString());
            }

            dataGridViewSDM.DataSource = svc.GetListSM(MaKH);
            if (dataGridViewSDM.Rows.Count > 0)
            {
                dateTra.Text = svc.GetNgayTra(MaKH).ToString();
                btnTien.Enabled = true;
                btnLui.Enabled = false;
            }
            else
            {
                dateTra.Text = DateTime.Now.ToString();
                MessageBox.Show($"Không có đơn mượn sách của khách hàng: {MaKH}");
            }
        }

        private void dGvTTKhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                string tinhtrg = e.Value.ToString();
                if (tinhtrg == "Đang mượn")
                {
                    DateTime ngaymuon = DateTime.Parse(dGvTTKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString());
                    DateTime ngaytra = DateTime.Parse(dGvTTKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString());
                    TimeSpan hantra = ngaytra - ngaymuon;
                    int songay = hantra.Days;
                    if (songay == 1 || songay == 2)
                    {
                        dGvTTKhachHang.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (songay < 1)
                    {
                        dGvTTKhachHang.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridViewSDM.DataSource = null;
            dataGridViewSMT.DataSource = null;

            MaKH = string.Empty;
            txtTenKH.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;

            dGvTTKhachHang.DataSource = svc.FindKhachHang(txtTimKiem.Text.Trim());
            if(dGvTTKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng liên quan");
            }
        }
    }
}
