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
    public partial class FormSP : Form
    {
        String connectionSTR = @"Data Source=DESKTOP-Q59EIRP\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        public FormSP()
        {
            InitializeComponent();
            LoadSP();
        }
        void LoadSP()
        {
           
            SqlConnection connection = new SqlConnection(connectionSTR);

            String querySP = "SELECT * FROM SANPHAM ";
            connection.Open();
            SqlCommand command = new SqlCommand(querySP, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewSP.DataSource = data;
            
        }

        private void buttonSreachSP_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select * from SANPHAM where MASP= N'"+ textBoxSreachSP.Text + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            if(command.ExecuteScalar() ==null)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại", "Thông Báo");
                return;
            }    
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewSP.DataSource = data;
        }

        private void buttonResetSP_Click(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void buttonResetTextSP_Click(object sender, EventArgs e)
        {
            textBoxMaSP.ReadOnly = false;
            buttonAddSP.Enabled = true;
            textBoxMaSP.Text = "";
            textBoxNameSP.Text = "";
            textBoxDV_SP.Text = "";
            textBoxCountrySP.Text = "";
            textBoxCostSP.Text = "";
        }

        private void buttonAddSP_Click(object sender, EventArgs e)
        {
            bool status = true;
            if(textBoxMaSP.Text == "")
            {
                status = false;
            }
            else
                if (textBoxCostSP.Text == "")
            {
                status = false;
            }
            else
                if (textBoxCountrySP.Text == "")
            {
                status = false;
            }
            else
                if (textBoxDV_SP.Text == "")
            {
                status = false;
            }
            else
                if (textBoxNameSP.Text == "")
            {
                status = false;
            }
            if (status)
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                String queryCheck = "select * from SANPHAM where MASP= N'" + textBoxMaSP.Text + "' ";
                SqlCommand commandCheck = new SqlCommand(queryCheck, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(commandCheck);
                adapter.Fill(data);
                if (data.Rows.Count >= 1)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông Báo");
                    return;
                }
                String query = "insert into SANPHAM (MASP,TENSP,DON_VI_TINH,NUOCSX,GIA) values (@MASP,@TENSP,@DON_VI_TINH,@NUOCSX,@GIA)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@MASP", textBoxMaSP.Text);
                command.Parameters.Add("@TENSP", textBoxNameSP.Text);
                command.Parameters.Add("@DON_VI_TINH", textBoxDV_SP.Text);
                command.Parameters.Add("@NUOCSX", textBoxCountrySP.Text);
                command.Parameters.Add("@GIA", textBoxCostSP.Text);

                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Thêm thành công mã SP " + textBoxMaSP.Text, "Thông Báo");
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Không được để trống ", "Thông Báo");
                return;
            }    
        }

        private void buttonDelSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa mã SP " + dataGridViewSP.Rows[dataGridViewSP.CurrentRow.Index].Cells[0].Value.ToString() + " hay ko?","Thông Báo",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                String query = " delete from SANPHAM where MASP= N'" + dataGridViewSP.Rows[dataGridViewSP.CurrentRow.Index].Cells[0].Value.ToString() + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int i = command.ExecuteNonQuery();
                connection.Close();
                if (i == 1)
                {
                    MessageBox.Show("Đã xóa thành công mã sản phẩm " + dataGridViewSP.Rows[dataGridViewSP.CurrentRow.Index].Cells[0].Value.ToString(), "Thông Báo");
                }
                 
            }
        }

        private void buttonEditSP_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (textBoxMaSP.Text == "")
            {
                status = false;
            }
            if (textBoxCostSP.Text == "")
            {
                status = false;
            }
            if (textBoxCountrySP.Text == "")
            {
                status = false;
            }
            if (textBoxDV_SP.Text == "")
            {
                status = false;
            }
            if (textBoxNameSP.Text == "")
            {
                status = false;
            }
            if (!status)
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông Báo");
                return;
            }
            else
            {
                textBoxMaSP.ReadOnly = false;
                buttonAddSP.Enabled = true;
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                String query = "update SANPHAM set TENSP= N'" + textBoxNameSP.Text + "',DON_VI_TINH= N'" + textBoxDV_SP.Text + "',NUOCSX =N'" + textBoxCountrySP.Text + "',GIA= N'" + textBoxCostSP.Text + "' where MASP = N'" + textBoxMaSP.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Sửa thành công mã SP " + textBoxMaSP.Text, "Thông Báo");
                }
                connection.Close();
            }
        }

        private void textBoxNameSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled=true;
                MessageBox.Show("Bạn chỉ được nhập chữ cái", "Thông Báo");
            }    
        }

        private void textBoxDV_SP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập chữ cái", "Thông Báo");
            }
        }

        private void textBoxCountrySP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập chữ cái", "Thông Báo");
            }
        }

        private void textBoxCostSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số nguyên", "Thông Báo");
            }    
        }

        private void dataGridViewSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaSP.ReadOnly = true;
            buttonAddSP.Enabled = false;
            textBoxMaSP.Text = dataGridViewSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNameSP.Text= dataGridViewSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDV_SP.Text= dataGridViewSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxCountrySP.Text= dataGridViewSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxCostSP.Text= dataGridViewSP.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void FormSP_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSreachSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
