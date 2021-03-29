using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            this.ControlBox = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 5;
            if (rectangleShape2.Width >= 506)
            {
                timer1.Stop();
                FormKH kh = new FormKH();
                this.Hide();
                kh.ShowDialog();
                this.Close();
                
            }
        }
    }
}
