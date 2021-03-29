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
    public partial class FormQLAdmin : Form
    {
        int a = 0;
        String connectionSTR = @"Data Source=DESKTOP-Q59EIRP\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        String MAQL = null;
        public FormQLAdmin()
        {
            InitializeComponent();
            LoadAdminQL();
            LoadMAQL();
        }
        void LoadMAQL()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "SELECT TOP 1 MAQL FROM QUANLY WHERE QUANLY.NG_TAO < CURRENT_TIMESTAMP ORDER BY QUANLY.NG_TAO DESC";
            SqlCommand command = new SqlCommand(query, connection);
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MAQL = reader["MAQL"].ToString();

                    }
                }
            }
            connection.Close();
            String str1 = null, str2 = null;
            int QL;
            str1 = MAQL.Substring(0, 2);
            str2 = MAQL.Substring(2, 2);
            QL = int.Parse(str2);
            QL++;
            MAQL = str1 + "0" + QL.ToString();
        }
        private void FormQLAdmin_Load(object sender, EventArgs e)
        {
            label.Text = "Xin chào Admin " +FormQL.ThongTinAdmin.TK_admin;
            
        }
        void LoadAdminQL()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            String query = "select * from QUANLY";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewAdminQL.DataSource = data;
            connection.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDChiQL.Text = "";
            textBoxHoTenQL.Text = "";
            textBoxMK.Text = "";
            textBoxSDT_QL.Text = "";
            textBoxTK.Text = "";
        }

        private void buttonReset_QL_Click(object sender, EventArgs e)
        {
            LoadAdminQL();
        }

        private void buttonAdd_QL_Click(object sender, EventArgs e)
        {
            bool status = true;
            if(textBoxHoTenQL.Text=="")
            {
                status = false;
            }
            if (textBoxDChiQL.Text == "")
            {
                status = false;
            }
            if (textBoxMK.Text == "")
            {
                status = false;
            }
            if (textBoxSDT_QL.Text == "")
            {
                status = false;
            }
            if (textBoxTK.Text == "")
            {
                status = false;
            }
            if (!status)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông Báo");
                return;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                String query = "insert into QUANLY(MAQL,HOTEN,DCHI,SODT,TK,MK,NG_TAO) values(@MAQL,@HOTEN,@DCHI,@SODT,@TK,@MK,@NG_TAO) ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@MAQL", MAQL);
                command.Parameters.Add("@HOTEN", textBoxHoTenQL.Text);
                command.Parameters.Add("@DCHI", textBoxDChiQL.Text);
                command.Parameters.Add("@SODT", textBoxSDT_QL.Text);
                command.Parameters.Add("@TK", textBoxTK.Text);
                command.Parameters.Add("@MK", textBoxMK.Text);
                command.Parameters.Add("@NG_TAO", DateTime.Now.ToString());
                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Thêm thành công ", "Thông báo");
                    timer1.Start();
                    buttonAdd_QL.Enabled = false;
                    a = 60;
                    buttonAdd_QL.Text = "Thêm(" + a.ToString() + ")";
                }
            }
        }

        private void buttonDel_QL_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdminQL.Rows[dataGridViewAdminQL.CurrentRow.Index].Cells[0].Value.ToString() == "QL01")
            {
                MessageBox.Show("Bạn không thể xóa mã QL01", "Thông Báo");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa mã quản lí là " + dataGridViewAdminQL.Rows[dataGridViewAdminQL.CurrentRow.Index].Cells[0].Value.ToString() + " không ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == result)
                {
                    SqlConnection connection = new SqlConnection(connectionSTR);
                    connection.Open();
                    String query = "delete from QUANLY where MAQL=N'" + dataGridViewAdminQL.Rows[dataGridViewAdminQL.CurrentRow.Index].Cells[0].Value.ToString() + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    int i = command.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Xóa thành công mã quản lí " + dataGridViewAdminQL.Rows[dataGridViewAdminQL.CurrentRow.Index].Cells[0].Value.ToString(), "Thông Báo");
                    }
                    LoadMAQL();
                }
            }
        }

        private void dataGridViewAdminQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxHoTenQL.Text = dataGridViewAdminQL.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDChiQL.Text = dataGridViewAdminQL.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSDT_QL.Text= dataGridViewAdminQL.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxTK.Text= dataGridViewAdminQL.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxMK.Text= dataGridViewAdminQL.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void buttonEdit_QL_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (textBoxHoTenQL.Text == "")
            {
                status = false;
            }
            if (textBoxDChiQL.Text == "")
            {
                status = false;
            }
            if (textBoxMK.Text == "")
            {
                status = false;
            }
            if (textBoxSDT_QL.Text == "")
            {
                status = false;
            }
            if (textBoxTK.Text == "")
            {
                status = false;
            }
            if (!status)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông Báo");
                return;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                String query = "update QUANLY set HOTEN=N'" + textBoxHoTenQL.Text + "', DCHI=N'" + textBoxDChiQL.Text + "', SODT=N'" + textBoxSDT_QL.Text + "', TK=N'" + textBoxTK.Text + "', MK=N'" + textBoxMK.Text + "', NG_TAO=N'" + DateTime.Now.ToString() + "' where MAQL=N'" + dataGridViewAdminQL.Rows[dataGridViewAdminQL.CurrentRow.Index].Cells[0].Value.ToString() + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("sửa thành công mã quản lí " + dataGridViewAdminQL.Rows[dataGridViewAdminQL.CurrentRow.Index].Cells[0].Value.ToString(), "Thông Báo");
                }
                connection.Close();
            }
        }

        private void textBoxHoTenQL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập chữ cái", "Thông Báo");
                
            }     
        }

        private void textBoxDChiQL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập chữ cái", "Thông Báo");

            }
        }

        private void textBoxSDT_QL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập chữ số", "Thông Báo");

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String timecool = buttonAdd_QL.Text;
            String t1 = timecool.Substring(5);
            string[] arrListStr = t1.Split(')');
            int i=int.Parse(arrListStr[0]);
            i--;
            buttonAdd_QL.Text = "Thêm(" + i.ToString() + ")";
            if (i==0)
            {
                buttonAdd_QL.Text = "Thêm";
                buttonAdd_QL.Enabled = true;
                timer1.Stop();
                
            }    
        }


    }

}
