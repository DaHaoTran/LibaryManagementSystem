namespace PRO131_Duan1_FA23.GUI
{
    partial class FormQLNV
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            gbVaiTro = new GroupBox();
            rbQTr = new RadioButton();
            rbNV = new RadioButton();
            gbTinhTrang = new GroupBox();
            button1 = new Button();
            rbHD = new RadioButton();
            rbNgungHD = new RadioButton();
            txtMaNV = new TextBox();
            label8 = new Label();
            btnSkip = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnUpImg = new Button();
            picBoxImg = new PictureBox();
            txtEmail = new TextBox();
            txtSoDT = new TextBox();
            txtDiaChi = new TextBox();
            txtTenNV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnBack = new Button();
            btnNext = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dtGvNhanVien = new DataGridView();
            panel1 = new Panel();
            groupBox2.SuspendLayout();
            gbVaiTro.SuspendLayout();
            gbTinhTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxImg).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGvNhanVien).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(326, 19);
            label1.Name = "label1";
            label1.Size = new Size(539, 72);
            label1.TabIndex = 0;
            label1.Text = "Quản lý nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(gbVaiTro);
            groupBox2.Controls.Add(gbTinhTrang);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnSkip);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnUpImg);
            groupBox2.Controls.Add(picBoxImg);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtSoDT);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(txtTenNV);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(38, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1148, 505);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quản trị";
            // 
            // gbVaiTro
            // 
            gbVaiTro.Anchor = AnchorStyles.None;
            gbVaiTro.Controls.Add(rbQTr);
            gbVaiTro.Controls.Add(rbNV);
            gbVaiTro.Location = new Point(268, 345);
            gbVaiTro.Name = "gbVaiTro";
            gbVaiTro.Size = new Size(429, 67);
            gbVaiTro.TabIndex = 25;
            gbVaiTro.TabStop = false;
            // 
            // rbQTr
            // 
            rbQTr.Anchor = AnchorStyles.None;
            rbQTr.AutoSize = true;
            rbQTr.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbQTr.Location = new Point(31, 17);
            rbQTr.Name = "rbQTr";
            rbQTr.Size = new Size(138, 34);
            rbQTr.TabIndex = 7;
            rbQTr.TabStop = true;
            rbQTr.Text = "Quản trị";
            rbQTr.UseVisualStyleBackColor = true;
            // 
            // rbNV
            // 
            rbNV.Anchor = AnchorStyles.None;
            rbNV.AutoSize = true;
            rbNV.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbNV.Location = new Point(188, 17);
            rbNV.Name = "rbNV";
            rbNV.Size = new Size(151, 34);
            rbNV.TabIndex = 9;
            rbNV.TabStop = true;
            rbNV.Text = "Nhân viên";
            rbNV.UseVisualStyleBackColor = true;
            // 
            // gbTinhTrang
            // 
            gbTinhTrang.Anchor = AnchorStyles.None;
            gbTinhTrang.Controls.Add(button1);
            gbTinhTrang.Controls.Add(rbHD);
            gbTinhTrang.Controls.Add(rbNgungHD);
            gbTinhTrang.Location = new Point(268, 272);
            gbTinhTrang.Name = "gbTinhTrang";
            gbTinhTrang.Size = new Size(429, 67);
            gbTinhTrang.TabIndex = 24;
            gbTinhTrang.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(47, 84, 128);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_magnifying_glass_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(809, 9);
            button1.Name = "button1";
            button1.Size = new Size(178, 55);
            button1.TabIndex = 23;
            button1.Text = "Tìm Kiếm";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // rbHD
            // 
            rbHD.Anchor = AnchorStyles.None;
            rbHD.AutoSize = true;
            rbHD.Enabled = false;
            rbHD.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbHD.Location = new Point(31, 21);
            rbHD.Name = "rbHD";
            rbHD.Size = new Size(151, 34);
            rbHD.TabIndex = 6;
            rbHD.TabStop = true;
            rbHD.Text = "Hoạt động";
            rbHD.UseVisualStyleBackColor = true;
            // 
            // rbNgungHD
            // 
            rbNgungHD.Anchor = AnchorStyles.None;
            rbNgungHD.AutoSize = true;
            rbNgungHD.Enabled = false;
            rbNgungHD.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbNgungHD.Location = new Point(188, 21);
            rbNgungHD.Name = "rbNgungHD";
            rbNgungHD.Size = new Size(229, 34);
            rbNgungHD.TabIndex = 8;
            rbNgungHD.TabStop = true;
            rbNgungHD.Text = "Ngừng hoạt động";
            rbNgungHD.UseVisualStyleBackColor = true;
            // 
            // txtMaNV
            // 
            txtMaNV.Anchor = AnchorStyles.None;
            txtMaNV.BorderStyle = BorderStyle.FixedSingle;
            txtMaNV.Enabled = false;
            txtMaNV.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNV.Location = new Point(268, 40);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(309, 34);
            txtMaNV.TabIndex = 22;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(44, 44);
            label8.Name = "label8";
            label8.Size = new Size(182, 30);
            label8.TabIndex = 21;
            label8.Text = "Mã nhân viên:";
            // 
            // btnSkip
            // 
            btnSkip.Anchor = AnchorStyles.None;
            btnSkip.BackColor = Color.LimeGreen;
            btnSkip.FlatStyle = FlatStyle.Popup;
            btnSkip.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSkip.ForeColor = Color.Black;
            btnSkip.Image = Properties.Resources.icons8_skip_50;
            btnSkip.ImageAlign = ContentAlignment.MiddleLeft;
            btnSkip.Location = new Point(683, 427);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(158, 56);
            btnSkip.TabIndex = 20;
            btnSkip.Text = "Bỏ qua";
            btnSkip.TextAlign = ContentAlignment.MiddleRight;
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += btnSkip_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.LimeGreen;
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Black;
            btnThem.Image = Properties.Resources.icons8_add_50;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(98, 427);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(141, 56);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.LimeGreen;
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Black;
            btnSua.Image = Properties.Resources.icons8_write_48;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(282, 427);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(141, 56);
            btnSua.TabIndex = 18;
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
            btnXoa.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Image = Properties.Resources.icons8_delete_50;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(478, 427);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(141, 56);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.LimeGreen;
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = Properties.Resources.icons8_close_60;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(899, 427);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(141, 56);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnUpImg
            // 
            btnUpImg.Anchor = AnchorStyles.None;
            btnUpImg.BackColor = Color.LimeGreen;
            btnUpImg.FlatStyle = FlatStyle.Popup;
            btnUpImg.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpImg.ForeColor = Color.Black;
            btnUpImg.Image = Properties.Resources.icons8_image_64;
            btnUpImg.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpImg.Location = new Point(887, 301);
            btnUpImg.Name = "btnUpImg";
            btnUpImg.Size = new Size(178, 62);
            btnUpImg.TabIndex = 15;
            btnUpImg.Text = "Up File";
            btnUpImg.TextAlign = ContentAlignment.MiddleRight;
            btnUpImg.UseVisualStyleBackColor = false;
            btnUpImg.Click += btnUpImg_Click;
            // 
            // picBoxImg
            // 
            picBoxImg.Anchor = AnchorStyles.None;
            picBoxImg.BorderStyle = BorderStyle.FixedSingle;
            picBoxImg.Location = new Point(865, 35);
            picBoxImg.Name = "picBoxImg";
            picBoxImg.Size = new Size(228, 260);
            picBoxImg.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxImg.TabIndex = 14;
            picBoxImg.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(268, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(524, 34);
            txtEmail.TabIndex = 13;
            // 
            // txtSoDT
            // 
            txtSoDT.Anchor = AnchorStyles.None;
            txtSoDT.BorderStyle = BorderStyle.FixedSingle;
            txtSoDT.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDT.Location = new Point(268, 184);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(524, 34);
            txtSoDT.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.None;
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(268, 137);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(524, 34);
            txtDiaChi.TabIndex = 11;
            // 
            // txtTenNV
            // 
            txtTenNV.Anchor = AnchorStyles.None;
            txtTenNV.BorderStyle = BorderStyle.FixedSingle;
            txtTenNV.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNV.Location = new Point(268, 88);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(524, 34);
            txtTenNV.TabIndex = 10;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 364);
            label7.Name = "label7";
            label7.Size = new Size(117, 30);
            label7.TabIndex = 5;
            label7.Text = "Vai trò:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 293);
            label6.Name = "label6";
            label6.Size = new Size(156, 30);
            label6.TabIndex = 4;
            label6.Text = "Tình trạng:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 236);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 3;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 188);
            label4.Name = "label4";
            label4.Size = new Size(195, 30);
            label4.TabIndex = 2;
            label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 141);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(195, 30);
            label2.TabIndex = 0;
            label2.Text = "Tên nhân viên:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(btnBack);
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(dtGvNhanVien);
            groupBox3.Location = new Point(38, 634);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1148, 344);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.LimeGreen;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Image = Properties.Resources.back2;
            btnBack.Location = new Point(244, 268);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(158, 70);
            btnBack.TabIndex = 27;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.LimeGreen;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Black;
            btnNext.Image = Properties.Resources.icons8_next_100;
            btnNext.Location = new Point(733, 268);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(158, 70);
            btnNext.TabIndex = 26;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(244, 27);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên nhân viên";
            txtTimKiem.Size = new Size(440, 39);
            txtTimKiem.TabIndex = 23;
            txtTimKiem.TextChanged += textBox1_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.LimeGreen;
            btnTimKiem.FlatStyle = FlatStyle.Popup;
            btnTimKiem.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Image = Properties.Resources.icons8_magnifying_glass_50;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(690, 17);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(178, 55);
            btnTimKiem.TabIndex = 23;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dtGvNhanVien
            // 
            dtGvNhanVien.Anchor = AnchorStyles.None;
            dtGvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGvNhanVien.Location = new Point(3, 78);
            dtGvNhanVien.Name = "dtGvNhanVien";
            dtGvNhanVien.ReadOnly = true;
            dtGvNhanVien.RowHeadersWidth = 51;
            dtGvNhanVien.RowTemplate.Height = 29;
            dtGvNhanVien.Size = new Size(1145, 184);
            dtGvNhanVien.TabIndex = 0;
            dtGvNhanVien.CellContentClick += dtGvNhanVien_CellContentClick;
            dtGvNhanVien.CellFormatting += dtGvNhanVien_CellFormatting;
            dtGvNhanVien.CellMouseClick += dtGvNhanVien_CellMouseClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(47, 84, 128);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(41, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 116);
            panel1.TabIndex = 3;
            // 
            // FormQLNV
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1237, 984);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQLNV";
            Text = "FormQLNV";
            KeyPress += FormQLNV_KeyPress;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbVaiTro.ResumeLayout(false);
            gbVaiTro.PerformLayout();
            gbTinhTrang.ResumeLayout(false);
            gbTinhTrang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxImg).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGvNhanVien).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rbNV;
        private RadioButton rbNgungHD;
        private RadioButton rbQTr;
        private RadioButton rbHD;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dtGvNhanVien;
        private TextBox txtEmail;
        private TextBox txtSoDT;
        private TextBox txtDiaChi;
        private TextBox txtTenNV;
        private Button btnUpImg;
        private PictureBox picBoxImg;
        private Button btnSkip;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtMaNV;
        private Label label8;
        private Panel panel1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private GroupBox gbVaiTro;
        private GroupBox gbTinhTrang;
        private Button button1;
        private Button btnBack;
        private Button btnNext;
    }
}