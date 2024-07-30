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
    public partial class FormMuonSach : Form
    {
        private IMuonSachSvc svc;
        private void GetTableSach()
        {
            dataGridViewTTS.DataSource = svc.GetSach();
        }
        private void GetTableKH()
        {
            dGvTTKhachHang.DataSource = svc.GetKhachHang();
        }
        public FormMuonSach(IMuonSachSvc _svc)
        {
            InitializeComponent();
            svc = _svc;
            GetTableSach();
            GetTableKH();
            btnTien.Enabled = false;
            btnLui.Enabled = false;
            reset();
        }

        private void FormMuonSach_Load(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain.instance.Show();
        }

        private void dataGridViewTTS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnTien.Enabled = true;
            dataGridViewSMM.ClearSelection();
        }
        private string masach;
        private void btnTien_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaKH))
            {
                int soSachChoPhepMuon = 3 - count;
                if (dataGridViewSMM.Rows.Count - 1 < soSachChoPhepMuon)
                {
                    if (svc.TimThongTinKH(MaKH))
                    {
                        DataGridViewRow r = dataGridViewTTS.SelectedRows[0];
                        object[] values = new object[r.Cells.Count];
                        for (int i = 0; i < r.Cells.Count; i++)
                        {
                            // Lấy giá trị của ô
                            values[i] = r.Cells[i].Value;
                        }
                        dataGridViewSMM.Rows.Add(values);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Khách hàng {MaKH} đã mượn tối đa");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin của người mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void dataGridViewSMM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            int index = dataGridViewSMM.CurrentCell.RowIndex;
            dataGridViewSMM.Rows.RemoveAt(index);
        }

        private void dataGridViewSMM_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnTien.Enabled = false;
            btnLui.Enabled = true;
            dataGridViewTTS.ClearSelection();
        }

        private void reset()
        {
            txtTenKH.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dateMuon.Value = DateTime.Now;
            dateTra.Value = DateTime.Now;
            MaKH = string.Empty;
            count = 0;
        }
        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (dataGridViewSMM.Rows.Count > 1)
            {
                if(DateTime.Parse(dateMuon.Value.ToString()) <= DateTime.Parse(dateTra.Value.ToString()))
                {
                    for (int i = 0; i < dataGridViewSMM.Rows.Count - 1; i++)
                    {
                        var masach = dataGridViewSMM.Rows[i].Cells[0].Value.ToString();
                        if (!string.IsNullOrEmpty(MaKH) && !string.IsNullOrEmpty(masach))
                        {
                            svc.MuonSach(MaKH, masach, FormMain.instance.maNv, DateTime.Parse(dateTra.Value.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("Thất bại do không tìm thấy thông tin khách hàng");
                        }
                    }
                    MessageBox.Show("Xử lý toàn bộ phiếu mượn thành công");
                    GetTableKH();
                }
                else
                {
                    MessageBox.Show("Ngày trả không được nhỏ hơn ngày mượn");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sách mượn nào");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dGvTTKhachHang.DataSource = svc.FindKhachHang(txtTKKH.Text.Trim());
            if (dGvTTKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng liên quan");
            }
        }

        private void btnTKSach_Click(object sender, EventArgs e)
        {
            dataGridViewTTS.DataSource = svc.FindSach(txtTKSach.Text.Trim());
            if (dataGridViewTTS.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin sách liên quan");
            }
        }
        private string MaKH;
        private int count;
        private void dGvTTKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            reset();
            dataGridViewSMM.ClearSelection();
            dataGridViewTTS.ClearSelection();
            dataGridViewSMM.Rows.Clear();
            dateTra.Enabled = true;
            int index = dGvTTKhachHang.CurrentCell.RowIndex;
            MaKH = dGvTTKhachHang.Rows[index].Cells[0].Value.ToString();
            txtTenKH.Text = dGvTTKhachHang.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dGvTTKhachHang.Rows[index].Cells[2].Value.ToString();
            txtEmail.Text = dGvTTKhachHang.Rows[index].Cells[3].Value.ToString();
            if(DateTime.Parse(dGvTTKhachHang.Rows[index].Cells[5].Value.ToString()).Year >= 2023) 
            {
                dateTra.Value = DateTime.Parse(dGvTTKhachHang.Rows[index].Cells[5].Value.ToString());
            }
            if(DateTime.Parse(dGvTTKhachHang.Rows[index].Cells[4].Value.ToString()).Year >= 2023)
            {
                dateMuon.Value = DateTime.Parse(dGvTTKhachHang.Rows[index].Cells[4].Value.ToString());
            }
            count = svc.CountSachMuon(MaKH);
            if (count == 0)
            {
                MessageBox.Show($"Khách hàng {MaKH} chưa mượn quyển sách nào");
            }
            else
            {
                MessageBox.Show($"Khách hàng {MaKH} đã mượn {count} quyển sách");
            }
        }

        private void dGvTTKhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                string tinhtrg = e.Value.ToString();
                if (tinhtrg.Contains("Đang mượn"))
                {
                    DateTime ngaymuon = DateTime.Parse(dGvTTKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString());
                    DateTime ngaytra = DateTime.Parse(dGvTTKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString());
                    TimeSpan hantra = ngaytra - ngaymuon;
                    double songay = hantra.Days;
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
    }
}
