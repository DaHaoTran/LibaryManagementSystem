namespace PRO131_Duan1_FA23.GUI
{
    partial class FormQuenMK
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOTP = new TextBox();
            txtNewPass = new TextBox();
            txtConfirmPass = new TextBox();
            btnDoiMK = new Button();
            btnThoat = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 129);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 17);
            label1.Name = "label1";
            label1.Size = new Size(630, 96);
            label1.TabIndex = 0;
            label1.Text = "Quên Mật Khẩu";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(218, 191);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
            label2.TabIndex = 1;
            label2.Text = "Mã xác nhận";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(206, 271);
            label3.Name = "label3";
            label3.Size = new Size(156, 27);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(98, 348);
            label4.Name = "label4";
            label4.Size = new Size(264, 27);
            label4.TabIndex = 3;
            label4.Text = "Nhập lại mật khẩu mới";
            // 
            // txtOTP
            // 
            txtOTP.Anchor = AnchorStyles.None;
            txtOTP.BorderStyle = BorderStyle.FixedSingle;
            txtOTP.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOTP.Location = new Point(405, 193);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(155, 30);
            txtOTP.TabIndex = 4;
            // 
            // txtNewPass
            // 
            txtNewPass.Anchor = AnchorStyles.None;
            txtNewPass.BorderStyle = BorderStyle.FixedSingle;
            txtNewPass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPass.Location = new Point(405, 273);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(411, 30);
            txtNewPass.TabIndex = 5;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Anchor = AnchorStyles.None;
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPass.Location = new Point(405, 346);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(411, 30);
            txtConfirmPass.TabIndex = 6;
            // 
            // btnDoiMK
            // 
            btnDoiMK.Anchor = AnchorStyles.None;
            btnDoiMK.BackColor = Color.LimeGreen;
            btnDoiMK.FlatStyle = FlatStyle.Popup;
            btnDoiMK.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoiMK.ForeColor = Color.Black;
            btnDoiMK.Image = Properties.Resources.icons8_password_reset_50;
            btnDoiMK.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoiMK.Location = new Point(312, 416);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(219, 62);
            btnDoiMK.TabIndex = 7;
            btnDoiMK.Text = "Đổi mật khẩu";
            btnDoiMK.TextAlign = ContentAlignment.MiddleRight;
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnDoiMK_Click;
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
            btnThoat.Location = new Point(670, 416);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(144, 62);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnDoiMK);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtConfirmPass);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtNewPass);
            panel2.Controls.Add(txtOTP);
            panel2.Location = new Point(2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 530);
            panel2.TabIndex = 9;
            // 
            // FormQuenMK
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1019, 533);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormQuenMK";
            Text = "FormQuenMK";
            Load += FormQuenMK_Load;
            KeyPress += FormQuenMK_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOTP;
        private TextBox txtNewPass;
        private TextBox txtConfirmPass;
        private Button btnDoiMK;
        private Button btnThoat;
        private Panel panel2;
    }
}