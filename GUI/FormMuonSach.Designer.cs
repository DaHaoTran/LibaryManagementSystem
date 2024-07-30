namespace PRO131_Duan1_FA23.GUI
{
    partial class FormMuonSach
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnThoat = new Button();
            btnMuon = new Button();
            btnLui = new Button();
            btnTien = new Button();
            groupBox5 = new GroupBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            dateTra = new DateTimePicker();
            dateMuon = new DateTimePicker();
            txtTenKH = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridViewSMM = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            dataGridViewTTS = new DataGridView();
            MaKhachhang = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dGvTTKhachHang = new DataGridView();
            txtTKKH = new TextBox();
            btnTimKiem = new Button();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            txtTKSach = new TextBox();
            btnTKSach = new Button();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSMM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTTS).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGvTTKhachHang).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 17);
            label2.Name = "label2";
            label2.Size = new Size(366, 52);
            label2.TabIndex = 7;
            label2.Text = "Sách muốn mượn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 17);
            label1.Name = "label1";
            label1.Size = new Size(391, 52);
            label1.TabIndex = 6;
            label1.Text = "Thông tin của bạn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(244, 22);
            label3.Name = "label3";
            label3.Size = new Size(316, 52);
            label3.TabIndex = 8;
            label3.Text = "Thông tin sách";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LimeGreen;
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Image = Properties.Resources.icons8_close_60;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(197, 90);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(167, 59);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnMuon
            // 
            btnMuon.BackColor = Color.LimeGreen;
            btnMuon.FlatStyle = FlatStyle.Popup;
            btnMuon.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMuon.ForeColor = Color.White;
            btnMuon.Location = new Point(197, 17);
            btnMuon.Name = "btnMuon";
            btnMuon.Size = new Size(167, 59);
            btnMuon.TabIndex = 2;
            btnMuon.Text = "Mượn";
            btnMuon.UseVisualStyleBackColor = false;
            btnMuon.Click += btnMuon_Click;
            // 
            // btnLui
            // 
            btnLui.BackColor = Color.LimeGreen;
            btnLui.FlatStyle = FlatStyle.Popup;
            btnLui.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLui.ForeColor = Color.White;
            btnLui.Image = Properties.Resources.icons8_double_left_50;
            btnLui.Location = new Point(14, 90);
            btnLui.Name = "btnLui";
            btnLui.Size = new Size(167, 59);
            btnLui.TabIndex = 1;
            btnLui.UseVisualStyleBackColor = false;
            btnLui.Click += btnLui_Click;
            // 
            // btnTien
            // 
            btnTien.BackColor = Color.LimeGreen;
            btnTien.FlatStyle = FlatStyle.Popup;
            btnTien.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTien.ForeColor = Color.White;
            btnTien.Image = Properties.Resources.icons8_double_right_50;
            btnTien.Location = new Point(14, 17);
            btnTien.Name = "btnTien";
            btnTien.Size = new Size(167, 59);
            btnTien.TabIndex = 0;
            btnTien.UseVisualStyleBackColor = false;
            btnTien.Click += btnTien_Click;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.None;
            groupBox5.BackColor = Color.GhostWhite;
            groupBox5.Controls.Add(txtEmail);
            groupBox5.Controls.Add(txtSDT);
            groupBox5.Controls.Add(dateTra);
            groupBox5.Controls.Add(dateMuon);
            groupBox5.Controls.Add(txtTenKH);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(12, 34);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(510, 371);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(188, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 30);
            txtEmail.TabIndex = 24;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Enabled = false;
            txtSDT.Location = new Point(188, 216);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(281, 30);
            txtSDT.TabIndex = 23;
            // 
            // dateTra
            // 
            dateTra.Enabled = false;
            dateTra.Format = DateTimePickerFormat.Short;
            dateTra.Location = new Point(188, 311);
            dateTra.Name = "dateTra";
            dateTra.Size = new Size(187, 30);
            dateTra.TabIndex = 22;
            // 
            // dateMuon
            // 
            dateMuon.Enabled = false;
            dateMuon.Format = DateTimePickerFormat.Short;
            dateMuon.Location = new Point(188, 261);
            dateMuon.Name = "dateMuon";
            dateMuon.Size = new Size(187, 30);
            dateMuon.TabIndex = 21;
            // 
            // txtTenKH
            // 
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Enabled = false;
            txtTenKH.Location = new Point(188, 113);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(281, 30);
            txtTenKH.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 213);
            label8.Name = "label8";
            label8.Size = new Size(72, 27);
            label8.TabIndex = 13;
            label8.Text = "SDT :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 164);
            label7.Name = "label7";
            label7.Size = new Size(96, 27);
            label7.TabIndex = 12;
            label7.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 311);
            label6.Name = "label6";
            label6.Size = new Size(120, 27);
            label6.TabIndex = 11;
            label6.Text = "Ngày trả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 261);
            label5.Name = "label5";
            label5.Size = new Size(132, 27);
            label5.TabIndex = 10;
            label5.Text = "Ngày mượn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 116);
            label4.Name = "label4";
            label4.Size = new Size(132, 27);
            label4.TabIndex = 9;
            label4.Text = "Họ và tên:";
            // 
            // dataGridViewSMM
            // 
            dataGridViewSMM.Anchor = AnchorStyles.None;
            dataGridViewSMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSMM.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridViewSMM.Location = new Point(856, 493);
            dataGridViewSMM.Name = "dataGridViewSMM";
            dataGridViewSMM.ReadOnly = true;
            dataGridViewSMM.RowHeadersWidth = 51;
            dataGridViewSMM.RowTemplate.Height = 29;
            dataGridViewSMM.Size = new Size(422, 456);
            dataGridViewSMM.TabIndex = 4;
            dataGridViewSMM.CellDoubleClick += dataGridViewSMM_CellDoubleClick;
            dataGridViewSMM.CellMouseClick += dataGridViewSMM_CellMouseClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "MaSach ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "TenSach";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "TacGia";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "LoaiSach";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "TinhTrang";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "TrangThai";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "SoLuong";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "MaNV";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "MaXB";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // dataGridViewTTS
            // 
            dataGridViewTTS.Anchor = AnchorStyles.None;
            dataGridViewTTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTTS.Location = new Point(518, 198);
            dataGridViewTTS.Name = "dataGridViewTTS";
            dataGridViewTTS.ReadOnly = true;
            dataGridViewTTS.RowHeadersWidth = 51;
            dataGridViewTTS.Size = new Size(760, 207);
            dataGridViewTTS.TabIndex = 5;
            dataGridViewTTS.CellMouseClick += dataGridViewTTS_CellMouseClick;
            // 
            // MaKhachhang
            // 
            MaKhachhang.DataPropertyName = "string";
            MaKhachhang.HeaderText = "NguoiMuon";
            MaKhachhang.MinimumWidth = 6;
            MaKhachhang.Name = "MaKhachhang";
            MaKhachhang.Width = 125;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Maiandra GD", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 93);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.LimeGreen;
            panel2.Controls.Add(label3);
            panel2.Font = new Font("Maiandra GD", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(518, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 93);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.LimeGreen;
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Maiandra GD", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(856, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 87);
            panel3.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.GhostWhite;
            panel4.Controls.Add(btnTien);
            panel4.Controls.Add(btnThoat);
            panel4.Controls.Add(btnLui);
            panel4.Controls.Add(btnMuon);
            panel4.Location = new Point(478, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(379, 165);
            panel4.TabIndex = 26;
            // 
            // dGvTTKhachHang
            // 
            dGvTTKhachHang.Anchor = AnchorStyles.None;
            dGvTTKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGvTTKhachHang.Location = new Point(12, 572);
            dGvTTKhachHang.Name = "dGvTTKhachHang";
            dGvTTKhachHang.ReadOnly = true;
            dGvTTKhachHang.RowHeadersWidth = 51;
            dGvTTKhachHang.RowTemplate.Height = 29;
            dGvTTKhachHang.Size = new Size(845, 377);
            dGvTTKhachHang.TabIndex = 27;
            dGvTTKhachHang.CellFormatting += dGvTTKhachHang_CellFormatting;
            dGvTTKhachHang.CellMouseClick += dGvTTKhachHang_CellMouseClick;
            // 
            // txtTKKH
            // 
            txtTKKH.Anchor = AnchorStyles.None;
            txtTKKH.BorderStyle = BorderStyle.FixedSingle;
            txtTKKH.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTKKH.Location = new Point(56, 436);
            txtTKKH.Name = "txtTKKH";
            txtTKKH.PlaceholderText = "Nhập thông tin khách hàng";
            txtTKKH.Size = new Size(383, 39);
            txtTKKH.TabIndex = 25;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.LimeGreen;
            btnTimKiem.FlatStyle = FlatStyle.Popup;
            btnTimKiem.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Image = Properties.Resources.icons8_magnifying_glass_50;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(159, 500);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(170, 59);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(12, 402);
            panel7.Name = "panel7";
            panel7.Size = new Size(1266, 6);
            panel7.TabIndex = 29;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 393);
            panel6.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(518, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 393);
            panel5.TabIndex = 28;
            // 
            // txtTKSach
            // 
            txtTKSach.Anchor = AnchorStyles.None;
            txtTKSach.BorderStyle = BorderStyle.FixedSingle;
            txtTKSach.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTKSach.Location = new Point(593, 139);
            txtTKSach.Name = "txtTKSach";
            txtTKSach.PlaceholderText = "Nhập thông tin sách";
            txtTKSach.Size = new Size(383, 34);
            txtTKSach.TabIndex = 30;
            // 
            // btnTKSach
            // 
            btnTKSach.Anchor = AnchorStyles.None;
            btnTKSach.BackColor = Color.LimeGreen;
            btnTKSach.FlatStyle = FlatStyle.Popup;
            btnTKSach.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTKSach.ForeColor = Color.White;
            btnTKSach.Image = Properties.Resources.icons8_magnifying_glass_50;
            btnTKSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTKSach.Location = new Point(1032, 125);
            btnTKSach.Name = "btnTKSach";
            btnTKSach.Size = new Size(194, 59);
            btnTKSach.TabIndex = 31;
            btnTKSach.Text = "Tìm kiếm";
            btnTKSach.TextAlign = ContentAlignment.MiddleRight;
            btnTKSach.UseVisualStyleBackColor = false;
            btnTKSach.Click += btnTKSach_Click;
            // 
            // FormMuonSach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1290, 961);
            ControlBox = false;
            Controls.Add(btnTKSach);
            Controls.Add(txtTKSach);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTKKH);
            Controls.Add(dGvTTKhachHang);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewTTS);
            Controls.Add(dataGridViewSMM);
            Controls.Add(groupBox5);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMuonSach";
            Text = "FormMuonSach";
            Load += FormMuonSach_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSMM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTTS).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGvTTKhachHang).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtTenKH;
        private DateTimePicker dateTra;
        private DateTimePicker dateMuon;
        private Button btnMuon;
        private Button btnLui;
        private Button btnTien;
        private Button btnThoat;
        private DataGridView dataGridViewSMM;
        private DataGridView dataGridViewTTS;
        private DataGridViewTextBoxColumn MaKhachhang;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Panel panel4;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private DataGridView dGvTTKhachHang;
        private TextBox txtTKKH;
        private Button btnTimKiem;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private TextBox txtTKSach;
        private Button btnTKSach;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}