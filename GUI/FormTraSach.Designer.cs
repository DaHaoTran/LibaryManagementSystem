namespace PRO131_Duan1_FA23.GUI
{
    partial class FormTraSach
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
            label2 = new Label();
            label3 = new Label();
            groupBox4 = new GroupBox();
            txtEmail = new TextBox();
            label7 = new Label();
            txtSDT = new TextBox();
            label6 = new Label();
            dateTra = new DateTimePicker();
            txtTenKH = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnThoat = new Button();
            btnTra = new Button();
            btnLui = new Button();
            btnTien = new Button();
            dataGridViewSMT = new DataGridView();
            dataGridViewSDM = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dGvTTKhachHang = new DataGridView();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            panel5 = new Panel();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSMT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSDM).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGvTTKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 27);
            label1.Name = "label1";
            label1.Size = new Size(441, 56);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Của Bạn";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 30);
            label2.Name = "label2";
            label2.Size = new Size(331, 56);
            label2.TabIndex = 1;
            label2.Text = "Sách muốn trả";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(184, 28);
            label3.Name = "label3";
            label3.Size = new Size(322, 56);
            label3.TabIndex = 2;
            label3.Text = "Sách đã mượn";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.BackColor = Color.GhostWhite;
            groupBox4.Controls.Add(txtEmail);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtSDT);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(dateTra);
            groupBox4.Controls.Add(txtTenKH);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(12, 91);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(599, 325);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(213, 178);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 30);
            txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 178);
            label7.Name = "label7";
            label7.Size = new Size(91, 30);
            label7.TabIndex = 11;
            label7.Text = "Email:";
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.None;
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Enabled = false;
            txtSDT.Location = new Point(213, 120);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(327, 30);
            txtSDT.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 120);
            label6.Name = "label6";
            label6.Size = new Size(65, 30);
            label6.TabIndex = 9;
            label6.Text = "SDT:";
            // 
            // dateTra
            // 
            dateTra.Anchor = AnchorStyles.None;
            dateTra.Enabled = false;
            dateTra.Format = DateTimePickerFormat.Short;
            dateTra.Location = new Point(213, 243);
            dateTra.Name = "dateTra";
            dateTra.Size = new Size(158, 30);
            dateTra.TabIndex = 8;
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.None;
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Enabled = false;
            txtTenKH.Location = new Point(213, 62);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(327, 30);
            txtTenKH.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 243);
            label5.Name = "label5";
            label5.Size = new Size(130, 30);
            label5.TabIndex = 4;
            label5.Text = "Ngày trả:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 62);
            label4.Name = "label4";
            label4.Size = new Size(169, 30);
            label4.TabIndex = 3;
            label4.Text = "Tên của bạn:";
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
            btnThoat.Location = new Point(178, 99);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(152, 65);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTra
            // 
            btnTra.Anchor = AnchorStyles.None;
            btnTra.BackColor = Color.LimeGreen;
            btnTra.FlatStyle = FlatStyle.Popup;
            btnTra.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTra.ForeColor = Color.Black;
            btnTra.Location = new Point(178, 18);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(152, 65);
            btnTra.TabIndex = 2;
            btnTra.Text = "Trả";
            btnTra.UseVisualStyleBackColor = false;
            btnTra.Click += btnTra_Click;
            // 
            // btnLui
            // 
            btnLui.Anchor = AnchorStyles.None;
            btnLui.BackColor = Color.LimeGreen;
            btnLui.FlatStyle = FlatStyle.Popup;
            btnLui.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLui.ForeColor = Color.Black;
            btnLui.Image = Properties.Resources.icons8_double_left_50;
            btnLui.Location = new Point(12, 99);
            btnLui.Name = "btnLui";
            btnLui.Size = new Size(152, 65);
            btnLui.TabIndex = 1;
            btnLui.UseVisualStyleBackColor = false;
            btnLui.Click += btnLui_Click;
            // 
            // btnTien
            // 
            btnTien.Anchor = AnchorStyles.None;
            btnTien.BackColor = Color.LimeGreen;
            btnTien.FlatStyle = FlatStyle.Popup;
            btnTien.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTien.ForeColor = Color.Black;
            btnTien.Image = Properties.Resources.icons8_double_right_50;
            btnTien.Location = new Point(12, 18);
            btnTien.Name = "btnTien";
            btnTien.Size = new Size(152, 65);
            btnTien.TabIndex = 0;
            btnTien.UseVisualStyleBackColor = false;
            btnTien.Click += btnTien_Click;
            // 
            // dataGridViewSMT
            // 
            dataGridViewSMT.Anchor = AnchorStyles.None;
            dataGridViewSMT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSMT.Location = new Point(843, 532);
            dataGridViewSMT.Name = "dataGridViewSMT";
            dataGridViewSMT.ReadOnly = true;
            dataGridViewSMT.RowHeadersWidth = 51;
            dataGridViewSMT.RowTemplate.Height = 29;
            dataGridViewSMT.Size = new Size(435, 417);
            dataGridViewSMT.TabIndex = 7;
            // 
            // dataGridViewSDM
            // 
            dataGridViewSDM.Anchor = AnchorStyles.None;
            dataGridViewSDM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSDM.Location = new Point(610, 114);
            dataGridViewSDM.Name = "dataGridViewSDM";
            dataGridViewSDM.ReadOnly = true;
            dataGridViewSDM.RowHeadersWidth = 51;
            dataGridViewSDM.RowTemplate.Height = 29;
            dataGridViewSDM.Size = new Size(668, 302);
            dataGridViewSDM.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 105);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.LimeGreen;
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(610, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 105);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.LimeGreen;
            panel3.Controls.Add(label2);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(838, 416);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 119);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.GhostWhite;
            panel4.Controls.Add(btnTien);
            panel4.Controls.Add(btnThoat);
            panel4.Controls.Add(btnLui);
            panel4.Controls.Add(btnTra);
            panel4.Location = new Point(502, 416);
            panel4.Name = "panel4";
            panel4.Size = new Size(340, 182);
            panel4.TabIndex = 12;
            // 
            // dGvTTKhachHang
            // 
            dGvTTKhachHang.Anchor = AnchorStyles.None;
            dGvTTKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGvTTKhachHang.Location = new Point(12, 599);
            dGvTTKhachHang.Name = "dGvTTKhachHang";
            dGvTTKhachHang.ReadOnly = true;
            dGvTTKhachHang.RowHeadersWidth = 51;
            dGvTTKhachHang.RowTemplate.Height = 29;
            dGvTTKhachHang.Size = new Size(830, 350);
            dGvTTKhachHang.TabIndex = 13;
            dGvTTKhachHang.CellFormatting += dGvTTKhachHang_CellFormatting;
            dGvTTKhachHang.CellMouseClick += dGvTTKhachHang_CellMouseClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(73, 460);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập thông tin của khách hàng";
            txtTimKiem.Size = new Size(370, 39);
            txtTimKiem.TabIndex = 13;
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
            btnTimKiem.Location = new Point(185, 518);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(168, 54);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(610, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 405);
            panel5.TabIndex = 14;
            // 
            // FormTraSach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1290, 961);
            ControlBox = false;
            Controls.Add(panel5);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(dGvTTKhachHang);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewSDM);
            Controls.Add(dataGridViewSMT);
            Controls.Add(groupBox4);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormTraSach";
            Text = "FormTraSach";
            Load += FormTraSach_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSMT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSDM).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dGvTTKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTra;
        private TextBox txtTenKH;
        private Button btnTra;
        private Button btnLui;
        private Button btnTien;
        private Button btnThoat;
        private DataGridView dataGridViewSMT;
        private DataGridView dataGridViewSDM;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtSDT;
        private Label label6;
        private DataGridView dGvTTKhachHang;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Panel panel5;
    }
}