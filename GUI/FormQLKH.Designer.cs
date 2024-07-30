namespace PRO131_Duan1_FA23.GUI
{
    partial class FormQLKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            groupBox2 = new GroupBox();
            txtNgayTra = new TextBox();
            txtNgayMuon = new TextBox();
            cbBoxTrT = new ComboBox();
            label8 = new Label();
            txtEmail = new TextBox();
            txtSoDT = new TextBox();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnBack = new Button();
            btnNext = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dtGvKH = new DataGridView();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnSkip = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGvKH).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Maiandra GD", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(342, 24);
            label7.Name = "label7";
            label7.Size = new Size(577, 72);
            label7.TabIndex = 0;
            label7.Text = "Quản lý khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(txtNgayTra);
            groupBox2.Controls.Add(txtNgayMuon);
            groupBox2.Controls.Add(cbBoxTrT);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtSoDT);
            groupBox2.Controls.Add(txtMaKH);
            groupBox2.Controls.Add(txtTenKH);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(29, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1180, 369);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập đầy đủ thông tin";
            // 
            // txtNgayTra
            // 
            txtNgayTra.Anchor = AnchorStyles.None;
            txtNgayTra.BorderStyle = BorderStyle.FixedSingle;
            txtNgayTra.Enabled = false;
            txtNgayTra.Location = new Point(781, 269);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(251, 28);
            txtNgayTra.TabIndex = 15;
            // 
            // txtNgayMuon
            // 
            txtNgayMuon.Anchor = AnchorStyles.None;
            txtNgayMuon.BorderStyle = BorderStyle.FixedSingle;
            txtNgayMuon.Enabled = false;
            txtNgayMuon.Location = new Point(350, 268);
            txtNgayMuon.Name = "txtNgayMuon";
            txtNgayMuon.Size = new Size(251, 28);
            txtNgayMuon.TabIndex = 14;
            // 
            // cbBoxTrT
            // 
            cbBoxTrT.Anchor = AnchorStyles.None;
            cbBoxTrT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoxTrT.FormattingEnabled = true;
            cbBoxTrT.Items.AddRange(new object[] { "none", "Đang mượn", "Đã trả " });
            cbBoxTrT.Location = new Point(349, 318);
            cbBoxTrT.Name = "cbBoxTrT";
            cbBoxTrT.Size = new Size(252, 32);
            cbBoxTrT.TabIndex = 13;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(607, 268);
            label8.Name = "label8";
            label8.Size = new Size(180, 27);
            label8.TabIndex = 12;
            label8.Text = "Ngày trả sách:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(349, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(682, 28);
            txtEmail.TabIndex = 9;
            // 
            // txtSoDT
            // 
            txtSoDT.Anchor = AnchorStyles.None;
            txtSoDT.BorderStyle = BorderStyle.FixedSingle;
            txtSoDT.Location = new Point(349, 156);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(682, 28);
            txtSoDT.TabIndex = 8;
            // 
            // txtMaKH
            // 
            txtMaKH.Anchor = AnchorStyles.None;
            txtMaKH.BorderStyle = BorderStyle.FixedSingle;
            txtMaKH.Enabled = false;
            txtMaKH.Location = new Point(349, 39);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(252, 28);
            txtMaKH.TabIndex = 7;
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.None;
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Location = new Point(350, 97);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(682, 28);
            txtTenKH.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(152, 319);
            label6.Name = "label6";
            label6.Size = new Size(144, 27);
            label6.TabIndex = 5;
            label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(152, 269);
            label5.Name = "label5";
            label5.Size = new Size(192, 27);
            label5.TabIndex = 4;
            label5.Text = "Ngày mượn sách:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(152, 213);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(152, 157);
            label3.Name = "label3";
            label3.Size = new Size(180, 27);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(152, 40);
            label2.Name = "label2";
            label2.Size = new Size(180, 27);
            label2.TabIndex = 1;
            label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(155, 98);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(btnBack);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(dtGvKH);
            groupBox3.Location = new Point(29, 506);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1180, 403);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.LimeGreen;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Image = Properties.Resources.back2;
            btnBack.Location = new Point(313, 315);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(144, 67);
            btnBack.TabIndex = 10;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.LimeGreen;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Black;
            btnNext.Image = Properties.Resources.icons8_next_100;
            btnNext.Location = new Point(731, 315);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(144, 67);
            btnNext.TabIndex = 11;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(301, 36);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên khách hàng";
            txtTimKiem.Size = new Size(455, 39);
            txtTimKiem.TabIndex = 16;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.LimeGreen;
            btnTimKiem.FlatStyle = FlatStyle.Popup;
            btnTimKiem.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Image = Properties.Resources.icons8_magnifying_glass_50;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(762, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(157, 57);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dtGvKH
            // 
            dtGvKH.Anchor = AnchorStyles.None;
            dtGvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGvKH.Location = new Point(0, 89);
            dtGvKH.Name = "dtGvKH";
            dtGvKH.ReadOnly = true;
            dtGvKH.RowHeadersWidth = 51;
            dtGvKH.RowTemplate.Height = 29;
            dtGvKH.Size = new Size(1174, 210);
            dtGvKH.TabIndex = 0;
            dtGvKH.CellFormatting += dtGvKH_CellFormatting;
            dtGvKH.CellMouseClick += dtGvKH_CellMouseClick;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.LimeGreen;
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Black;
            btnThem.Image = Properties.Resources.icons8_add_50;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(68, 915);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(144, 57);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.BackColor = Color.LimeGreen;
            btnLuu.FlatStyle = FlatStyle.Popup;
            btnLuu.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.Black;
            btnLuu.Image = Properties.Resources.icons8_save_50;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(253, 915);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(144, 57);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.LimeGreen;
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Black;
            btnSua.Image = Properties.Resources.icons8_write_48;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(443, 915);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(144, 57);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.LimeGreen;
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Image = Properties.Resources.icons8_delete_50;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(630, 915);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 57);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSkip
            // 
            btnSkip.Anchor = AnchorStyles.None;
            btnSkip.BackColor = Color.LimeGreen;
            btnSkip.FlatStyle = FlatStyle.Popup;
            btnSkip.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSkip.ForeColor = Color.Black;
            btnSkip.Image = Properties.Resources.icons8_skip_50;
            btnSkip.ImageAlign = ContentAlignment.MiddleLeft;
            btnSkip.Location = new Point(821, 915);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(144, 57);
            btnSkip.TabIndex = 7;
            btnSkip.Text = "Bỏ qua";
            btnSkip.TextAlign = ContentAlignment.MiddleRight;
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += btnSkip_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.LimeGreen;
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = Properties.Resources.icons8_close_60;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(1010, 915);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(144, 57);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label7);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(29, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 125);
            panel1.TabIndex = 9;
            // 
            // FormQLKH
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1242, 995);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnSkip);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormQLKH";
            Text = "FormQLKH";
            Load += FormQLKH_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGvKH).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtSoDT;
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private ComboBox cbBoxTrT;
        private DataGridView dtGvKH;
        private Button btnThem;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnSkip;
        private Button btnThoat;
        private TextBox txtNgayMuon;
        private Button btnTimKiem;
        private Panel panel1;
        private TextBox txtTimKiem;
        private Button btnBack;
        private Button btnNext;
        private TextBox txtNgayTra;
    }
}