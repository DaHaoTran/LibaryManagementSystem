namespace PRO131_Duan1_FA23.GUI
{
    partial class FormThongKe
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
            menuStrip1 = new MenuStrip();
            danhSáchMượnToolStripMenuItem = new ToolStripMenuItem();
            sáchNhậpKhoToolStripMenuItem = new ToolStripMenuItem();
            sáchTồnKhoToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            panelBody = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LimeGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhSáchMượnToolStripMenuItem, sáchNhậpKhoToolStripMenuItem, sáchTồnKhoToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchMượnToolStripMenuItem
            // 
            danhSáchMượnToolStripMenuItem.BackColor = Color.LimeGreen;
            danhSáchMượnToolStripMenuItem.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            danhSáchMượnToolStripMenuItem.Name = "danhSáchMượnToolStripMenuItem";
            danhSáchMượnToolStripMenuItem.Size = new Size(222, 34);
            danhSáchMượnToolStripMenuItem.Text = "Danh sách mượn ";
            danhSáchMượnToolStripMenuItem.Click += danhSáchMượnToolStripMenuItem_Click;
            // 
            // sáchNhậpKhoToolStripMenuItem
            // 
            sáchNhậpKhoToolStripMenuItem.BackColor = Color.LimeGreen;
            sáchNhậpKhoToolStripMenuItem.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sáchNhậpKhoToolStripMenuItem.Name = "sáchNhậpKhoToolStripMenuItem";
            sáchNhậpKhoToolStripMenuItem.Size = new Size(196, 34);
            sáchNhậpKhoToolStripMenuItem.Text = "Sách nhập kho";
            sáchNhậpKhoToolStripMenuItem.Click += sáchNhậpKhoToolStripMenuItem_Click;
            // 
            // sáchTồnKhoToolStripMenuItem
            // 
            sáchTồnKhoToolStripMenuItem.BackColor = Color.LimeGreen;
            sáchTồnKhoToolStripMenuItem.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sáchTồnKhoToolStripMenuItem.Name = "sáchTồnKhoToolStripMenuItem";
            sáchTồnKhoToolStripMenuItem.Size = new Size(183, 34);
            sáchTồnKhoToolStripMenuItem.Text = "Sách tồn kho";
            sáchTồnKhoToolStripMenuItem.Click += sáchTồnKhoToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.BackColor = Color.LimeGreen;
            thoátToolStripMenuItem.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(92, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // panelBody
            // 
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 38);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1100, 457);
            panelBody.TabIndex = 1;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 495);
            ControlBox = false;
            Controls.Add(panelBody);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormThongKe";
            Text = "FormThongKe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhSáchMượnToolStripMenuItem;
        private ToolStripMenuItem sáchNhậpKhoToolStripMenuItem;
        private ToolStripMenuItem sáchTồnKhoToolStripMenuItem;
        private Panel panelBody;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}