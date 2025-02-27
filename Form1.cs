using QLKD_Project.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKD_Project
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenMainForm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(); // Tạo đối tượng MainForm
            mainForm.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn Form1 nếu không cần nữa
        }
    }
}
