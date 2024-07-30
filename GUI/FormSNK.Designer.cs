namespace PRO131_Duan1_FA23.GUI
{
    partial class FormSNK
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
            dataGridViewSNK = new DataGridView();
            btnTimKiem = new Button();
            txtTenSach = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSNK).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSNK
            // 
            dataGridViewSNK.Anchor = AnchorStyles.None;
            dataGridViewSNK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSNK.Location = new Point(2, 70);
            dataGridViewSNK.Name = "dataGridViewSNK";
            dataGridViewSNK.ReadOnly = true;
            dataGridViewSNK.RowHeadersWidth = 51;
            dataGridViewSNK.RowTemplate.Height = 29;
            dataGridViewSNK.Size = new Size(1000, 284);
            dataGridViewSNK.TabIndex = 0;
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
            btnTimKiem.Location = new Point(610, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(163, 52);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTenSach
            // 
            txtTenSach.Anchor = AnchorStyles.None;
            txtTenSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenSach.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSach.Location = new Point(283, 20);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.PlaceholderText = "Nhập tên sách";
            txtTenSach.Size = new Size(281, 39);
            txtTenSach.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.LimeGreen;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.Black;
            btnBack.Image = Properties.Resources.back2;
            btnBack.Location = new Point(283, 374);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(152, 64);
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
            btnNext.Location = new Point(621, 374);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(152, 64);
            btnNext.TabIndex = 4;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // FormSNK
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 450);
            ControlBox = false;
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txtTenSach);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewSNK);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormSNK";
            Text = "FormSNK";
            Load += FormSNK_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSNK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSNK;
        private Button btnTimKiem;
        private TextBox txtTenSach;
        private Button btnBack;
        private Button btnNext;
    }
}