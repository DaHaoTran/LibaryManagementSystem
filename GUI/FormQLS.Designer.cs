namespace PRO131_Duan1_FA23.GUI
{
    partial class FormQLS
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtSL = new NumericUpDown();
            cbTenNXB = new ComboBox();
            rbMoi = new RadioButton();
            rbCu = new RadioButton();
            cbtxtTrT = new ComboBox();
            cbtxtLS = new ComboBox();
            txtTenTG = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dtGvSach = new DataGridView();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnSkip = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            panel2 = new Panel();
            btnBack = new Button();
            btnNext = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGvSach).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 20);
            label1.Name = "label1";
            label1.Size = new Size(652, 72);
            label1.TabIndex = 0;
            label1.Text = "Quản lý thông tin sách";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(562, 40);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 5;
            label6.Text = "Tên tác giả:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 216);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 4;
            label5.Text = "Loại sách:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 156);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 3;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 95);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 2;
            label3.Text = "Tên sách:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 40);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 1;
            label2.Text = "Mã sách:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(txtSL);
            groupBox2.Controls.Add(cbTenNXB);
            groupBox2.Controls.Add(rbMoi);
            groupBox2.Controls.Add(rbCu);
            groupBox2.Controls.Add(cbtxtTrT);
            groupBox2.Controls.Add(cbtxtLS);
            groupBox2.Controls.Add(txtTenTG);
            groupBox2.Controls.Add(txtTenSach);
            groupBox2.Controls.Add(txtMaSach);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(33, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1086, 271);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập đầy đủ thông tin";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(168, 154);
            txtSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtSL.Name = "txtSL";
            txtSL.ReadOnly = true;
            txtSL.Size = new Size(130, 27);
            txtSL.TabIndex = 19;
            txtSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbTenNXB
            // 
            cbTenNXB.Anchor = AnchorStyles.None;
            cbTenNXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenNXB.FormattingEnabled = true;
            cbTenNXB.Items.AddRange(new object[] { "none", "Đang được mượn" });
            cbTenNXB.Location = new Point(689, 93);
            cbTenNXB.Name = "cbTenNXB";
            cbTenNXB.Size = new Size(331, 30);
            cbTenNXB.TabIndex = 18;
            // 
            // rbMoi
            // 
            rbMoi.Anchor = AnchorStyles.None;
            rbMoi.AutoSize = true;
            rbMoi.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbMoi.Location = new Point(911, 154);
            rbMoi.Name = "rbMoi";
            rbMoi.Size = new Size(61, 26);
            rbMoi.TabIndex = 17;
            rbMoi.TabStop = true;
            rbMoi.Text = "Mới";
            rbMoi.UseVisualStyleBackColor = true;
            // 
            // rbCu
            // 
            rbCu.Anchor = AnchorStyles.None;
            rbCu.AutoSize = true;
            rbCu.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbCu.Location = new Point(741, 154);
            rbCu.Name = "rbCu";
            rbCu.Size = new Size(51, 26);
            rbCu.TabIndex = 16;
            rbCu.TabStop = true;
            rbCu.Text = "Cũ";
            rbCu.UseVisualStyleBackColor = true;
            // 
            // cbtxtTrT
            // 
            cbtxtTrT.Anchor = AnchorStyles.None;
            cbtxtTrT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtxtTrT.FormattingEnabled = true;
            cbtxtTrT.Items.AddRange(new object[] { "none", "Đang được mượn" });
            cbtxtTrT.Location = new Point(689, 215);
            cbtxtTrT.Name = "cbtxtTrT";
            cbtxtTrT.Size = new Size(331, 30);
            cbtxtTrT.TabIndex = 15;
            // 
            // cbtxtLS
            // 
            cbtxtLS.Anchor = AnchorStyles.None;
            cbtxtLS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtxtLS.FormattingEnabled = true;
            cbtxtLS.Items.AddRange(new object[] { "Sách Chính trị – pháp luật", "Sách Khoa học công nghệ – Kinh tế;", "Sách Văn học nghệ thuật", "Sách Văn hóa xã hội – Lịch sử", "Sách Giáo trình", "Sách Truyện, tiểu thuyết", "Sách Tâm lý, tâm linh, tôn giáo", "Sách Sách thiếu nhi" });
            cbtxtLS.Location = new Point(168, 215);
            cbtxtLS.Name = "cbtxtLS";
            cbtxtLS.Size = new Size(331, 30);
            cbtxtLS.TabIndex = 14;
            // 
            // txtTenTG
            // 
            txtTenTG.Anchor = AnchorStyles.None;
            txtTenTG.BorderStyle = BorderStyle.FixedSingle;
            txtTenTG.Location = new Point(689, 39);
            txtTenTG.Name = "txtTenTG";
            txtTenTG.Size = new Size(331, 27);
            txtTenTG.TabIndex = 12;
            // 
            // txtTenSach
            // 
            txtTenSach.Anchor = AnchorStyles.None;
            txtTenSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenSach.Location = new Point(168, 94);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(331, 27);
            txtTenSach.TabIndex = 10;
            // 
            // txtMaSach
            // 
            txtMaSach.Anchor = AnchorStyles.None;
            txtMaSach.BorderStyle = BorderStyle.FixedSingle;
            txtMaSach.Enabled = false;
            txtMaSach.Location = new Point(168, 39);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(331, 27);
            txtMaSach.TabIndex = 9;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(562, 95);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 6;
            label7.Text = "Tên NXB:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(562, 156);
            label8.Name = "label8";
            label8.Size = new Size(120, 22);
            label8.TabIndex = 7;
            label8.Text = "Tình trạng:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(562, 216);
            label9.Name = "label9";
            label9.Size = new Size(120, 22);
            label9.TabIndex = 8;
            label9.Text = "Trạng thái:";
            // 
            // dtGvSach
            // 
            dtGvSach.Anchor = AnchorStyles.None;
            dtGvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGvSach.Location = new Point(3, 84);
            dtGvSach.Name = "dtGvSach";
            dtGvSach.ReadOnly = true;
            dtGvSach.RowHeadersWidth = 51;
            dtGvSach.RowTemplate.Height = 29;
            dtGvSach.Size = new Size(1080, 227);
            dtGvSach.TabIndex = 0;
            dtGvSach.CellMouseClick += dtGvSach_CellMouseClick;
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
            btnThem.Location = new Point(64, 830);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 58);
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
            btnLuu.Location = new Point(240, 830);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(138, 58);
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
            btnSua.Location = new Point(417, 830);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(138, 58);
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
            btnXoa.Location = new Point(594, 830);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 58);
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
            btnSkip.Location = new Point(773, 830);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(138, 58);
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
            btnThoat.Location = new Point(943, 830);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 58);
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
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(33, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 115);
            panel1.TabIndex = 9;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(283, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên sách ";
            txtTimKiem.Size = new Size(357, 39);
            txtTimKiem.TabIndex = 18;
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
            btnTimKiem.Location = new Point(652, 16);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(162, 52);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(dtGvSach);
            panel2.Location = new Point(33, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(1086, 409);
            panel2.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.LimeGreen;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Image = Properties.Resources.back2;
            btnBack.Location = new Point(252, 327);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 70);
            btnBack.TabIndex = 11;
            btnBack.TextAlign = ContentAlignment.MiddleRight;
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
            btnNext.Location = new Point(689, 327);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(138, 70);
            btnNext.TabIndex = 12;
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // FormQLS
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1149, 915);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnSkip);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormQLS";
            Text = "FormQLS";
            Load += FormQLS_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGvSach).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnThem;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnSkip;
        private Button btnThoat;
        private DataGridView dtGvSach;
        private TextBox txtTenTG;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private RadioButton rbMoi;
        private RadioButton rbCu;
        private ComboBox cbtxtTrT;
        private ComboBox cbtxtLS;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Panel panel1;
        private Panel panel2;
        private Button btnBack;
        private Button btnNext;
        private ComboBox cbTenNXB;
        private NumericUpDown txtSL;
    }
}