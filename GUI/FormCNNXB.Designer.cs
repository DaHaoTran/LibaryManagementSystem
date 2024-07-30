namespace PRO131_Duan1_FA23.GUI
{
    partial class FormCNNXB
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
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            txtGC = new RichTextBox();
            txtSoDT = new TextBox();
            txtTenNXB = new TextBox();
            txtDiaChi = new TextBox();
            txtNXB = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            btnThoat = new Button();
            btnSkip = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            btnNext = new Button();
            btnBack = new Button();
            dtGvNXB = new DataGridView();
            panel1 = new Panel();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGvNXB).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(138, 26);
            label1.Name = "label1";
            label1.Size = new Size(1002, 72);
            label1.TabIndex = 0;
            label1.Text = "Cập Nhật Thông Tin Nhà Xuất Bản";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(txtGC);
            groupBox2.Controls.Add(txtSoDT);
            groupBox2.Controls.Add(txtTenNXB);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(txtNXB);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(651, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(619, 534);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập thông tin đầy đủ";
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
            btnTimKiem.Location = new Point(425, 40);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(162, 54);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(96, 45);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên NXB";
            txtTimKiem.Size = new Size(312, 39);
            txtTimKiem.TabIndex = 11;
            // 
            // txtGC
            // 
            txtGC.Anchor = AnchorStyles.None;
            txtGC.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGC.Location = new Point(199, 405);
            txtGC.Name = "txtGC";
            txtGC.Size = new Size(388, 106);
            txtGC.TabIndex = 10;
            txtGC.Text = "";
            // 
            // txtSoDT
            // 
            txtSoDT.Anchor = AnchorStyles.None;
            txtSoDT.BorderStyle = BorderStyle.FixedSingle;
            txtSoDT.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDT.Location = new Point(199, 335);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(388, 31);
            txtSoDT.TabIndex = 9;
            // 
            // txtTenNXB
            // 
            txtTenNXB.Anchor = AnchorStyles.None;
            txtTenNXB.BorderStyle = BorderStyle.FixedSingle;
            txtTenNXB.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNXB.Location = new Point(199, 195);
            txtTenNXB.Name = "txtTenNXB";
            txtTenNXB.Size = new Size(388, 31);
            txtTenNXB.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.None;
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(199, 265);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(388, 31);
            txtDiaChi.TabIndex = 7;
            // 
            // txtNXB
            // 
            txtNXB.Anchor = AnchorStyles.None;
            txtNXB.BorderStyle = BorderStyle.FixedSingle;
            txtNXB.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNXB.Location = new Point(199, 123);
            txtNXB.Name = "txtNXB";
            txtNXB.Size = new Size(388, 31);
            txtNXB.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(96, 405);
            label6.Name = "label6";
            label6.Size = new Size(90, 22);
            label6.TabIndex = 5;
            label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(116, 337);
            label5.Name = "label5";
            label5.Size = new Size(70, 22);
            label5.TabIndex = 4;
            label5.Text = "Số ĐT:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(96, 265);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 197);
            label3.Name = "label3";
            label3.Size = new Size(180, 22);
            label3.TabIndex = 2;
            label3.Text = "Tên nhà xuất bản:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 125);
            label2.Name = "label2";
            label2.Size = new Size(170, 22);
            label2.TabIndex = 1;
            label2.Text = "Mã nhà xuất bản:";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.Controls.Add(btnThoat);
            groupBox4.Controls.Add(btnSkip);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnLuu);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(15, 712);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1258, 131);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
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
            btnThoat.Location = new Point(1061, 40);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(135, 64);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
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
            btnSkip.Location = new Point(857, 40);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(148, 64);
            btnSkip.TabIndex = 5;
            btnSkip.Text = "Bỏ qua";
            btnSkip.TextAlign = ContentAlignment.MiddleRight;
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += btnSkip_Click;
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
            btnXoa.Location = new Point(665, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(135, 64);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            btnSua.Location = new Point(471, 40);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(135, 64);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
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
            btnLuu.Location = new Point(265, 40);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(135, 64);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
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
            btnThem.Location = new Point(71, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 64);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(btnNext);
            groupBox3.Controls.Add(btnBack);
            groupBox3.Controls.Add(dtGvNXB);
            groupBox3.Location = new Point(12, 143);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(633, 534);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.LimeGreen;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Black;
            btnNext.Image = Properties.Resources.icons8_next_100;
            btnNext.Location = new Point(385, 461);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(127, 67);
            btnNext.TabIndex = 8;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.LimeGreen;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Image = Properties.Resources.back2;
            btnBack.Location = new Point(115, 461);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 67);
            btnBack.TabIndex = 7;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dtGvNXB
            // 
            dtGvNXB.Anchor = AnchorStyles.None;
            dtGvNXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGvNXB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGvNXB.Location = new Point(3, 23);
            dtGvNXB.Name = "dtGvNXB";
            dtGvNXB.ReadOnly = true;
            dtGvNXB.RowHeadersWidth = 51;
            dtGvNXB.RowTemplate.Height = 29;
            dtGvNXB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGvNXB.Size = new Size(627, 432);
            dtGvNXB.TabIndex = 0;
            dtGvNXB.CellClick += dtGvNXB_CellClick;
            dtGvNXB.CellMouseClick += dtGvNXB_CellMouseClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 125);
            panel1.TabIndex = 2;
            // 
            // FormCNNXB
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 873);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCNNXB";
            Text = "FormCNNXB";
            Load += FormCNNXB_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGvNXB).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private DataGridView dtGvNXB;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox txtGC;
        private TextBox txtSoDT;
        private TextBox txtTenNXB;
        private TextBox txtDiaChi;
        private TextBox txtNXB;
        private Button btnThoat;
        private Button btnSkip;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnThem;
        private TextBox txtTimKiem;
        private Panel panel1;
        private Button btnTimKiem;
        private Button btnNext;
        private Button btnBack;
    }
}