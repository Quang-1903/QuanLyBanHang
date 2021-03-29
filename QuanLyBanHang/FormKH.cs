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
    public partial class FormKH : Form
    {
        int SOHD = 0;
        String connectionSTR = @"Data Source=DESKTOP-Q59EIRP\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        Double Sum = 0;
        public FormKH()
        {
            InitializeComponent();
            LoadMANV();
            LoadMAQL();
            LoadMASP();
            LoadMAKH();
            GetSOHD();
        }
        void LoadMANV()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select * from NHANVIEN";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            comboBoxMANV.DataSource = data;
            comboBoxMANV.DisplayMember = "MANV";
            connection.Close();
        }
        void LoadMAQL()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select * from QUANLY";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            comboBoxMAQL.DataSource = data;
            comboBoxMAQL.DisplayMember = "MAQL";
            connection.Close();
        }
        void LoadMASP()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select * from SANPHAM";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            comboBoxMASP.DataSource = data;
            comboBoxMASP.DisplayMember = "MASP";
            connection.Close();
        }
        private void buttonAddSP_Click(object sender, EventArgs e)
        {
            Boolean status = true;
            if(comboBoxMAKH.Text=="")
            {
                status = false;
            } 
            if(comboBoxMANV.Text=="")
            {
                status = false;
            }
            if(comboBoxMAQL.Text=="")
            {
                status = false;
            }
            if(comboBoxMASP.Text=="")
            {
                status = false;
            }    
            if (textBoxDChiKH.Text == "")
            {
                status = false;
            }
            if (textBoxSDT_KH.Text == "")
            {
                status = false;
            }
            if (textBoxHoTen_KH.Text == "")
            {
                status = false;
            }
            if (textBoxSoLuongSP.Text == "")
            {
                status = false;
            }
            if (!status)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông Báo");
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                String querySP = "SELECT * FROM SANPHAM ";
                String queryNV = "SELECT * FROM NHANVIEN ";
                connection.Open();
                SqlCommand commandSP = new SqlCommand(querySP, connection);
                SqlCommand commandNV = new SqlCommand(queryNV, connection);
                double money = 0, ThanhTien;
                String TenSP = null;
                int resultMSP = 0, resultMNV = 0;
                using (DbDataReader readerSP = commandSP.ExecuteReader())
                {
                    if (readerSP.HasRows)
                    {
                        while (readerSP.Read())
                        {
                            if (comboBoxMASP.Text == readerSP["MASP"].ToString())
                            {
                                money = Double.Parse(readerSP["GIA"].ToString());
                                TenSP = readerSP["TENSP"].ToString();
                                status = true;
                                resultMSP = 1;
                            }
                        }
                    }
                }
                using (DbDataReader readerNV = commandNV.ExecuteReader())
                {
                    if (readerNV.HasRows)
                    {
                        while (readerNV.Read())
                        {
                            if (comboBoxMANV.Text == readerNV["MANV"].ToString())
                            {
                                status = true;
                                resultMNV = 1;
                            }
                        }
                    }
                }
                for (int i = 0; i < listViewSP.Items.Count; i++)
                {
                    if (listViewSP.Items[i].SubItems[0].Text == comboBoxMASP.Text)
                    {
                        MessageBox.Show("Mã sản phẩm " + comboBoxMASP.Text + "đã có ", "Thông báo");
                        return;
                    }
                }
                if (resultMSP == 0)
                {
                    MessageBox.Show("Mã sản phẩm không tồn tại", "Thông báo");
                    return;
                }
                if (resultMNV == 0)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo");
                    return;
                }
                if (status == true)
                {
                    ThanhTien = money * Double.Parse(textBoxSoLuongSP.Text);
                    Sum += ThanhTien;
                    listViewSP.Items.Add(comboBoxMASP.Text);
                    listViewSP.Items[listViewSP.Items.Count - 1].SubItems.Add(TenSP);
                    listViewSP.Items[listViewSP.Items.Count - 1].SubItems.Add(money.ToString());
                    listViewSP.Items[listViewSP.Items.Count - 1].SubItems.Add(textBoxSoLuongSP.Text);
                    listViewSP.Items[listViewSP.Items.Count - 1].SubItems.Add(ThanhTien.ToString());
                    buttonEditSP.Enabled = true;
                    buttonDelSP.Enabled = true;
                    buttonInputSP.Enabled = true;
                    textBoxSum.Text = Sum.ToString();
                }

                connection.Close();
            }

        }

        private void buttonEditSP_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            Boolean status = true;
            String query = "SELECT * FROM SANPHAM ";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            double money = 0, ThanhTien;
            String TenSP = null;
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (comboBoxMASP.Text == reader["MASP"].ToString())
                        {
                            money = Double.Parse(reader["GIA"].ToString());
                            TenSP = reader["TENSP"].ToString();
                            status = false;
                        }
                    }
                }
            }
            if (!status)
            {
                Sum = int.Parse(textBoxSum.Text) - int.Parse(listViewSP.SelectedItems[0].SubItems[3].Text) * int.Parse(listViewSP.SelectedItems[0].SubItems[2].Text);
                ThanhTien = money * Double.Parse(textBoxSoLuongSP.Text);
                Sum += ThanhTien;
                listViewSP.SelectedItems[0].SubItems[0].Text = comboBoxMASP.Text;
                listViewSP.SelectedItems[0].SubItems[1].Text = TenSP;
                listViewSP.SelectedItems[0].SubItems[2].Text = money.ToString();
                listViewSP.SelectedItems[0].SubItems[3].Text = textBoxSoLuongSP.Text;
                listViewSP.SelectedItems[0].SubItems[4].Text = ThanhTien.ToString();
                textBoxSum.Text = Sum.ToString();
            }
            else
            {

                MessageBox.Show("Mã sản phẩm không tồn tại", "Thông báo");
            }
            connection.Close();
        }

        private void listViewSP_Click(object sender, EventArgs e)
        {

            String MSP = listViewSP.SelectedItems[0].SubItems[0].Text;
            String SL = listViewSP.SelectedItems[0].SubItems[3].Text;
            comboBoxMASP.Text = MSP;
            textBoxSoLuongSP.Text = SL;
        }

        private void buttonDelSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm mã " + comboBoxMASP.Text + " này ko", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Sum = int.Parse(textBoxSum.Text) - int.Parse(listViewSP.SelectedItems[0].SubItems[4].Text);
                listViewSP.Items.RemoveAt(listViewSP.SelectedIndices[0]);
                textBoxSum.Text = Sum.ToString();
            }
        }

        private void buttonClearSP_Click(object sender, EventArgs e)
        {
            textBoxDChiKH.Text = "";
            textBoxHoTen_KH.Text = "";
            textBoxSDT_KH.Text = "";
            textBoxSoLuongSP.Text = "";
            textBoxSum.Text = "";
            listViewSP.Items.Clear();
        }
        
        [Obsolete]
        private void buttonInputSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn không", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                String querycheck = "select * from KHACHHANG where MAKH=N'" + comboBoxMAKH.Text + "'";
                String queryKH = "INSERT INTO KHACHHANG (MAKH,HOTEN,DCHI,SODT,NGMUA) VALUES (@MAKH,@HOTEN,@DCHI,@SODT,@NGMUA)";
                connection.Open();
                //check
                SqlCommand commandCheck = new SqlCommand(querycheck, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(commandCheck);
                adapter.Fill(data);
                if (data.Rows.Count >= 1)
                {
                    String queryHD = "INSERT INTO HOADON (SOHD,NG_NHAP_HD,MAKH,MANV,MAQL,TRIGIA) VALUES (@SOHD,@NG_NHAP_HD,@MAKH,@MANV,@MAQL,@TRIGIA)";
                    SqlCommand commandHD = new SqlCommand(queryHD, connection);
                    LoadSOHD();
                    commandHD.Parameters.Clear();
                    commandHD.Parameters.Add("@SOHD", SOHD );
                    commandHD.Parameters.Add("@NG_NHAP_HD", DateTime.Now.ToString());
                    commandHD.Parameters.Add("@MAKH", comboBoxMAKH.Text);
                    commandHD.Parameters.Add("@MANV", comboBoxMANV.Text);
                    commandHD.Parameters.Add("@MAQL", comboBoxMAQL.Text);
                    commandHD.Parameters.Add("@TRIGIA", Sum);
                    commandHD.ExecuteNonQuery();
                    //insert CTHD

                    String queryCTHD = "INSERT INTO CTHD (SOHD,MASP,SL,TRIGIACT) VALUES (@SOHD,@MASP,@SL,@TRIGIACT)";
                    SqlCommand commandCTHD = new SqlCommand(queryCTHD, connection);

                    for (int i = 0; i < listViewSP.Items.Count; i++)
                    {

                        commandCTHD.Parameters.Clear();
                        commandCTHD.Parameters.Add("@SOHD", SOHD);
                        commandCTHD.Parameters.Add("@MASP", listViewSP.Items[i].SubItems[0].Text);
                        commandCTHD.Parameters.Add("@SL", listViewSP.Items[i].SubItems[3].Text);
                        commandCTHD.Parameters.Add("@TRIGIACT", listViewSP.Items[i].SubItems[4].Text);
                        commandCTHD.ExecuteNonQuery();
                    }
                    MessageBox.Show(SOHD.ToString());
                }
                else
                {
                    //insert KHACHHANG
                    SqlCommand commandKH = new SqlCommand(queryKH, connection);
                    LoadSOHD();
                    commandKH.Parameters.Clear();
                    commandKH.Parameters.Add("@MAKH", comboBoxMAKH.Text);
                    commandKH.Parameters.Add("@HOTEN", textBoxHoTen_KH.Text);
                    commandKH.Parameters.Add("@DCHI", textBoxDChiKH.Text);
                    commandKH.Parameters.Add("@SODT", textBoxSDT_KH.Text);
                    commandKH.Parameters.Add("@NGMUA", DateTime.Now.ToString());
                    int t = commandKH.ExecuteNonQuery();
                    //insert HOADON
                    if (t == 1)
                    {
                        String queryHD = "INSERT INTO HOADON (SOHD,NG_NHAP_HD,MAKH,MANV,MAQL,TRIGIA) VALUES (@SOHD,@NG_NHAP_HD,@MAKH,@MANV,@MAQL,@TRIGIA)";
                        SqlCommand commandHD = new SqlCommand(queryHD, connection);
                        LoadSOHD();
                        commandHD.Parameters.Clear();
                        commandHD.Parameters.Add("@SOHD", SOHD);
                        commandHD.Parameters.Add("@NG_NHAP_HD", DateTime.Now.ToString());
                        commandHD.Parameters.Add("@MAKH", comboBoxMAKH.Text);
                        commandHD.Parameters.Add("@MANV", comboBoxMANV.Text);
                        commandHD.Parameters.Add("@MAQL", comboBoxMAQL.Text);
                        commandHD.Parameters.Add("@TRIGIA", Sum);
                        commandHD.ExecuteNonQuery();
                        //insert CTHD

                        String queryCTHD = "INSERT INTO CTHD (SOHD,MASP,SL,TRIGIACT) VALUES (@SOHD,@MASP,@SL,@TRIGIACT)";
                        SqlCommand commandCTHD = new SqlCommand(queryCTHD, connection);

                        for (int i = 0; i < listViewSP.Items.Count; i++)
                        {

                            commandCTHD.Parameters.Clear();
                            commandCTHD.Parameters.Add("@SOHD", SOHD);
                            commandCTHD.Parameters.Add("@MASP", listViewSP.Items[i].SubItems[0].Text);
                            commandCTHD.Parameters.Add("@SL", listViewSP.Items[i].SubItems[3].Text);
                            commandCTHD.Parameters.Add("@TRIGIACT", listViewSP.Items[i].SubItems[4].Text);
                            commandCTHD.ExecuteNonQuery();
                        }
                    }
                }
                connection.Close();
                LoadMANV();
                LoadMAQL();
                LoadMASP();
            }
        }

        private void textBoxSoLuongSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số nguyên", "Thông Báo");
            }

        }

        private void textBoxSDT_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số nguyên", "Thông Báo");
            }
        }

        private void textBoxHoTen_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập chữ cái", "Thông Báo");
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSP sp = new FormSP();
            this.Hide();
            sp.Show();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin admin = new FormLogin();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }
        void LoadMAKH()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select * from KHACHHANG";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            comboBoxMAKH.DataSource = data;
            comboBoxMAKH.DisplayMember = "MAKH";
            connection.Close();
        }
        void GetSOHD()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            String query = "select max(SOHD) as SOHD from CTHD";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int getHD=0;
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        getHD = int.Parse(reader["SOHD"].ToString());

                    }
                }
            }
            connection.Close();
            SOHD = getHD;
        }
        void LoadSOHD()
        {
            SOHD++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void comboBoxMAKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            String query = "select * from KHACHHANG where MAKH =N'"+comboBoxMAKH.Text+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            String HOTEN = null,DCHI=null,SODT=null;
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        HOTEN = reader["HOTEN"].ToString();
                        DCHI = reader["DCHI"].ToString();
                        SODT = reader["SODT"].ToString();
                    }
                }
            }
            connection.Close();
            textBoxHoTen_KH.Text = HOTEN;
            textBoxDChiKH.Text = DCHI;
            textBoxSDT_KH.Text = SODT;
        }

        private void labelMaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}