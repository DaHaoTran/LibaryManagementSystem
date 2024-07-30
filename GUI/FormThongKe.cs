using PRO131_Duan1_FA23.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO131_Duan1_FA23.GUI
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }
        private Form currenChild;
        private void OpenChildForm(Form childform)
        {
            if (currenChild != null)
            {
                currenChild.Close();
            }
            currenChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelBody.Controls.Add(currenChild);
            panelBody.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void danhSáchMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDSM());
        }

        private void sáchNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSNK());
        }

        private void sáchTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSTK());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain.instance.Show();
        }
    }
}
