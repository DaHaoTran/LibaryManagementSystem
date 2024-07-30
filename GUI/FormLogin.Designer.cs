namespace PRO131_Duan1_FA23.GUI
{
    partial class FormLogin
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
            label3 = new Label();
            txtLogin = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            lbQuenMK = new Label();
            panelBody = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 28);
            label1.Name = "label1";
            label1.Size = new Size(838, 72);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập hệ thống thư viện";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(367, 128);
            label3.Name = "label3";
            label3.Size = new Size(374, 91);
            label3.TabIndex = 2;
            label3.Text = "Welcome";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.BackColor = Color.GhostWhite;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(385, 268);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Email";
            txtLogin.Size = new Size(387, 35);
            txtLogin.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.None;
            txtPass.BackColor = Color.GhostWhite;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(385, 376);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Mật khẩu ";
            txtPass.Size = new Size(387, 35);
            txtPass.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(64, 0, 64);
            btnLogin.Image = Properties.Resources.icons8_login_50;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(307, 477);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(218, 62);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.BackColor = Color.LimeGreen;
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Cascadia Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.FromArgb(64, 0, 64);
            btnThoat.Image = Properties.Resources.icons8_close_60;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(581, 477);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(191, 62);
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 125);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(307, 309);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 1);
            panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.icons8_account_90;
            pictureBox1.Location = new Point(307, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.icons8_password_100__1_;
            pictureBox2.Location = new Point(307, 354);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(307, 417);
            panel3.Name = "panel3";
            panel3.Size = new Size(465, 1);
            panel3.TabIndex = 11;
            // 
            // lbQuenMK
            // 
            lbQuenMK.Anchor = AnchorStyles.None;
            lbQuenMK.AutoSize = true;
            lbQuenMK.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuenMK.ForeColor = Color.Blue;
            lbQuenMK.Location = new Point(564, 430);
            lbQuenMK.Name = "lbQuenMK";
            lbQuenMK.Size = new Size(208, 30);
            lbQuenMK.TabIndex = 13;
            lbQuenMK.Text = "Quên mật khẩu ?";
            lbQuenMK.Click += lbQuenMK_Click;
            // 
            // panelBody
            // 
            panelBody.Anchor = AnchorStyles.None;
            panelBody.BackColor = Color.GhostWhite;
            panelBody.Controls.Add(panel1);
            panelBody.Controls.Add(lbQuenMK);
            panelBody.Controls.Add(label3);
            panelBody.Controls.Add(panel3);
            panelBody.Controls.Add(txtLogin);
            panelBody.Controls.Add(pictureBox2);
            panelBody.Controls.Add(txtPass);
            panelBody.Controls.Add(pictureBox1);
            panelBody.Controls.Add(btnLogin);
            panelBody.Controls.Add(panel2);
            panelBody.Controls.Add(btnThoat);
            panelBody.Location = new Point(84, 1);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1022, 628);
            panelBody.TabIndex = 14;
            panelBody.Paint += panelBody_Paint;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1186, 630);
            ControlBox = false;
            Controls.Add(panelBody);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            KeyPress += FormLogin_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label3;
        private TextBox txtLogin;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnThoat;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label lbQuenMK;
        private Panel panelBody;
    }
}