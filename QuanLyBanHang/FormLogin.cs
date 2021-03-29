using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public class ThongTinNV
        {
            static public String TK_NV;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Bạn có muốn thoát không", "Thông Báo",MessageBoxButtons.YesNo);
            if(result== DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String connectionSTR = @"Data Source=DESKTOP-Q59EIRP\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select * from QUANLY where TK=N'" + textBoxTK.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            if(data.Rows.Count==0)
            {
                MessageBox.Show("Tài Khoản khoản không tồn tại", "Thông Báo");
            }
            else
            {
                
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (textBoxMK.Text == reader["MK"].ToString())
                            {
                                FormQL ql = new FormQL();
                                ThongTinNV.TK_NV = reader["HOTEN"].ToString();
                                this.Hide();
                                ql.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Sai Mật Khẩu ", "Thông Báo");
                            }
                        }
                    }
                }
            }
            connection.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
