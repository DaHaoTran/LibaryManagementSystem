namespace PRO131_Duan1_FA23.GUI
{
    partial class FormDSM
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
            dataGridViewDSM = new DataGridView();
            txtTenKH = new TextBox();
            btnTimKiem = new Button();
            btnBack = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSM).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDSM
            // 
            dataGridViewDSM.Anchor = AnchorStyles.None;
            dataGridViewDSM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDSM.Location = new Point(0, 98);
            dataGridViewDSM.Name = "dataGridViewDSM";
            dataGridViewDSM.ReadOnly = true;
            dataGridViewDSM.RowHeadersWidth = 51;
            dataGridViewDSM.RowTemplate.Height = 29;
            dataGridViewDSM.Size = new Size(1000, 260);
            dataGridViewDSM.TabIndex = 0;
            dataGridViewDSM.CellContentClick += dataGridViewDSM_CellContentClick;
            dataGridViewDSM.CellFormatting += dataGridViewDSM_CellFormatting;
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.None;
            txtTenKH.BackColor = Color.White;
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKH.Location = new Point(231, 30);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.PlaceholderText = "Nhập tên khách hàng";
            txtTenKH.Size = new Size(327, 39);
            txtTenKH.TabIndex = 1;
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
            btnTimKiem.Location = new Point(612, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(163, 52);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.LimeGreen;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.Black;
            btnBack.Image = Properties.Resources.back2;
            btnBack.Location = new Point(231, 376);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 62);
            btnBack.TabIndex = 3;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.LimeGreen;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.ForeColor = Color.Black;
            btnNext.Image = Properties.Resources.icons8_next_100;
            btnNext.Location = new Point(644, 376);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(131, 62);
            btnNext.TabIndex = 4;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // FormDSM
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 450);
            ControlBox = false;
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTenKH);
            Controls.Add(dataGridViewDSM);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDSM";
            Text = "FormDSM";
            Load += FormDSM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDSM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDSM;
        private TextBox txtTenKH;
        private Button btnTimKiem;
        private Button btnBack;
        private Button btnNext;
    }
}