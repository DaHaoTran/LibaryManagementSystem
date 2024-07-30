namespace PRO131_Duan1_FA23.GUI
{
    partial class FormSTK
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
            dataGridViewSTK = new DataGridView();
            txtTenSach = new TextBox();
            btnTimKiem = new Button();
            btnBack = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSTK).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSTK
            // 
            dataGridViewSTK.Anchor = AnchorStyles.None;
            dataGridViewSTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSTK.Location = new Point(1, 71);
            dataGridViewSTK.Name = "dataGridViewSTK";
            dataGridViewSTK.ReadOnly = true;
            dataGridViewSTK.RowHeadersWidth = 51;
            dataGridViewSTK.RowTemplate.Height = 29;
            dataGridViewSTK.Size = new Size(1000, 288);
            dataGridViewSTK.TabIndex = 0;
            // 
            // txtTenSach
            // 
            txtTenSach.Anchor = AnchorStyles.None;
            txtTenSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenSach.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSach.Location = new Point(271, 21);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.PlaceholderText = "Nhập tên sách";
            txtTenSach.Size = new Size(292, 39);
            txtTenSach.TabIndex = 1;
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
            btnTimKiem.Location = new Point(602, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(164, 53);
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
            btnBack.Location = new Point(271, 378);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 60);
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
            btnNext.Location = new Point(628, 378);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(138, 60);
            btnNext.TabIndex = 4;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // FormSTK
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1002, 450);
            ControlBox = false;
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTenSach);
            Controls.Add(dataGridViewSTK);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormSTK";
            Text = "FormSTK";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSTK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSTK;
        private TextBox txtTenSach;
        private Button btnTimKiem;
        private Button btnBack;
        private Button btnNext;
    }
}