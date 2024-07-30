namespace PRO131_Duan1_FA23.GUI
{
    partial class FormDoiMK
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
            label4 = new Label();
            label5 = new Label();
            txtTK = new TextBox();
            txtOldPass = new TextBox();
            txtNewPass = new TextBox();
            txtNewPassA = new TextBox();
            btnDoiMK = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
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
            label1.Location = new Point(168, 26);
            label1.Name = "label1";
            label1.Size = new Size(415, 72);
            label1.TabIndex = 1;
            label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(177, 166);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 2;
            label2.Text = "Tài Khoản";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(151, 224);
            label3.Name = "label3";
            label3.Size = new Size(156, 30);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(138, 284);
            label4.Name = "label4";
            label4.Size = new Size(169, 30);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(23, 346);
            label5.Name = "label5";
            label5.Size = new Size(286, 30);
            label5.TabIndex = 5;
            label5.Text = "Nhập lại mật khẩu mới";
            // 
            // txtTK
            // 
            txtTK.Anchor = AnchorStyles.None;
            txtTK.BorderStyle = BorderStyle.FixedSingle;
            txtTK.Enabled = false;
            txtTK.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTK.Location = new Point(313, 157);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(323, 39);
            txtTK.TabIndex = 6;
            // 
            // txtOldPass
            // 
            txtOldPass.Anchor = AnchorStyles.None;
            txtOldPass.BorderStyle = BorderStyle.FixedSingle;
            txtOldPass.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldPass.Location = new Point(313, 215);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(323, 39);
            txtOldPass.TabIndex = 7;
            // 
            // txtNewPass
            // 
            txtNewPass.Anchor = AnchorStyles.None;
            txtNewPass.BorderStyle = BorderStyle.FixedSingle;
            txtNewPass.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPass.Location = new Point(313, 275);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(323, 39);
            txtNewPass.TabIndex = 8;
            // 
            // txtNewPassA
            // 
            txtNewPassA.Anchor = AnchorStyles.None;
            txtNewPassA.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassA.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassA.Location = new Point(313, 337);
            txtNewPassA.Name = "txtNewPassA";
            txtNewPassA.Size = new Size(323, 39);
            txtNewPassA.TabIndex = 9;
            // 
            // btnDoiMK
            // 
            btnDoiMK.Anchor = AnchorStyles.None;
            btnDoiMK.BackColor = Color.LimeGreen;
            btnDoiMK.FlatStyle = FlatStyle.Popup;
            btnDoiMK.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoiMK.ForeColor = Color.Black;
            btnDoiMK.Image = Properties.Resources.icons8_password_reset_50;
            btnDoiMK.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoiMK.Location = new Point(155, 417);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(176, 66);
            btnDoiMK.TabIndex = 10;
            btnDoiMK.Text = "Đổi MK";
            btnDoiMK.TextAlign = ContentAlignment.MiddleRight;
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnDoiMK_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.LimeGreen;
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = Properties.Resources.icons8_close_60;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(411, 417);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(163, 66);
            btnThoat.TabIndex = 11;
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 125);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnDoiMK);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtNewPassA);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtNewPass);
            panel2.Controls.Add(txtTK);
            panel2.Controls.Add(txtOldPass);
            panel2.Location = new Point(3, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(733, 523);
            panel2.TabIndex = 13;
            // 
            // FormDoiMK
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(739, 548);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDoiMK";
            Text = "FormDoiMK";
            Load += FormDoiMK_Load;
            KeyPress += FormDoiMK_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTK;
        private TextBox txtOldPass;
        private TextBox txtNewPass;
        private TextBox txtNewPassA;
        private Button btnDoiMK;
        private Button btnThoat;
        private Panel panel1;
        private Panel panel2;
    }
}