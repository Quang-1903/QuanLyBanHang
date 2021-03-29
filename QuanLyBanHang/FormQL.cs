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
    
    public partial class FormQL : Form
    {
        ClassOutput op = new ClassOutput();
        String MAKH = null,HOTEN=null,DCHI=null,MASP=null,DAY=null;
        int SDT = 0,SOHD=0,SL=0;
        double GIA=0,sum=0;
        String connectionSTR = @"Data Source=DESKTOP-Q59EIRP\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        public FormQL()
        {
            InitializeComponent();
            LoadNV();
            LoadMAQL();
            LoadKH();
            LoadMANV();
        }
        public class ThongTinAdmin
        {
            static public String TK_admin ;
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
            connection.Close();
            comboBoxMANV.DataSource = data;
            comboBoxMANV.DisplayMember = "MANV";
        }
        void LoadTop1Up()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select top 1 with ties KHACHHANG.MAKH,HOTEN,SODT,DCHI,sum(TRIGIACT) as DoanhThu from KHACHHANG,CTHD,HOADON"
            + " where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD group by KHACHHANG.MAKH,HOTEN,SODT,DCHI order by sum(TRIGIACT) desc";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void LoadDown1Up()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select top 1 with ties KHACHHANG.MAKH,HOTEN,SODT,DCHI,sum(TRIGIACT) as DoanhThu from KHACHHANG,CTHD,HOADON"
            + " where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD group by KHACHHANG.MAKH,HOTEN,SODT,DCHI order by sum(TRIGIACT) ";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void LoadListUp()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select KHACHHANG.MAKH,HOTEN,SODT,DCHI,sum(TRIGIACT) as DoanhThu from KHACHHANG,CTHD,HOADON"
            + " where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD group by KHACHHANG.MAKH,HOTEN,SODT,DCHI order by sum(TRIGIACT) ";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void LoadListDown()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select KHACHHANG.MAKH,HOTEN,SODT,DCHI,sum(TRIGIACT) as DoanhThu from KHACHHANG,CTHD,HOADON"
            + " where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD group by KHACHHANG.MAKH,HOTEN,SODT,DCHI order by sum(TRIGIACT) desc";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void LoadNear()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select top 1 with ties KHACHHANG.MAKH,HOTEN,SODT,DCHI,NG_NHAP_HD as NgayMua, SUM(TRIGIACT)" +
            " as DoanhThu from KHACHHANG,CTHD,HOADON where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD and" +
            " HOADON.NG_NHAP_HD < CURRENT_TIMESTAMP  group by KHACHHANG.MAKH,HOTEN,SODT,DCHI,NG_NHAP_HD order by NG_NHAP_HD desc  ";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void LoadFar()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select top 1 with ties KHACHHANG.MAKH,HOTEN,SODT,DCHI,NG_NHAP_HD as NgayMua, SUM(TRIGIACT)" +
            " as DoanhThu from KHACHHANG,CTHD,HOADON where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD and" +
            " HOADON.NG_NHAP_HD < CURRENT_TIMESTAMP  group by KHACHHANG.MAKH,HOTEN,SODT,DCHI,NG_NHAP_HD order by NG_NHAP_HD  ";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void LoadTopInYear()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select top 1 with ties KHACHHANG.MAKH,HOTEN,SODT,DCHI,NG_NHAP_HD as NgayMua, SUM(TRIGIACT) as DoanhThu " +
                           "from KHACHHANG, CTHD, HOADON where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD and " +
                           "year(NG_NHAP_HD) = Year(GETDATE())  group by KHACHHANG.MAKH,HOTEN,SODT,DCHI,NG_NHAP_HD order by SUM(TRIGIACT) desc  ";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void LoadDownInYear()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select top 1 with ties KHACHHANG.MAKH,HOTEN,SODT,DCHI,NG_NHAP_HD as NgayMua, SUM(TRIGIACT) as DoanhThu " +
                           "from KHACHHANG, CTHD, HOADON where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD and " +
                           "year(NG_NHAP_HD) = Year(GETDATE())  group by KHACHHANG.MAKH,HOTEN,SODT,DCHI,NG_NHAP_HD order by SUM(TRIGIACT)  ";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void ListSP()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select TENSP,sum(SL) as SoLuongDaBan from CTHD,SANPHAM,HOADON where CTHD.MASP=SANPHAM.MASP and CTHD.SOHD=HOADON.SOHD " +
                           "group by TENSP";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void ListSPtop()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select top 1 with ties TENSP,sum(SL) as SoLuongDaBan from CTHD,SANPHAM,HOADON where CTHD.MASP=SANPHAM.MASP and CTHD.SOHD=HOADON.SOHD "+
                            "group by TENSP order by sum(SL) desc ";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void ListSPdown()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select top 1 with ties TENSP,sum(SL) as SoLuongDaBan from CTHD,SANPHAM,HOADON where CTHD.MASP=SANPHAM.MASP and CTHD.SOHD=HOADON.SOHD " +
                            "group by TENSP order by sum(SL)  ";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void ListKHTop()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select top 1 with ties KHACHHANG.MAKH,HOTEN,DCHI,SODT,sum(SL) as SoLuongSanPhamDaMua,sum(SL*GIA) as TongGiaTri " +
                " from KHACHHANG,CTHD,SANPHAM,HOADON where CTHD.MASP=SANPHAM.MASP and CTHD.SOHD=HOADON.SOHD and KHACHHANG.MAKH=HOADON.MAKH " +
                " group by KHACHHANG.MAKH,HOTEN,DCHI,SODT order by sum(SL) desc";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewDT.DataSource = data;
        }
        void LoadNV()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select * from NHANVIEN";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewNV.DataSource = data;
        }
        void LoadKH()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select KHACHHANG.MAKH,HOTEN,DCHI,SODT,NGMUA,HOADON.SOHD,MASP,SL,TRIGIACT from KHACHHANG,HOADON,CTHD where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridViewKH.DataSource = data;
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
        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxMANV.DropDownStyle =  ComboBoxStyle.DropDown;
            textBoxHT_NV.Text = "";
            textBoxSDT_NV.Text = "";
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxMANV.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên ", "Thông Báo");
                return;
            }
            if (textBoxHT_NV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên ", "Thông Báo");
                return;
            }
            if (textBoxSDT_NV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SĐT nhân viên ", "Thông Báo");
                return;
            }
            SqlConnection connection = new SqlConnection(connectionSTR);
              connection.Open();
              String querycheck="select * from NHANVIEN where MANV= N'"+comboBoxMANV.Text+"'";
              SqlCommand commandcheck = new SqlCommand(querycheck, connection);
              DataTable data = new DataTable();
              SqlDataAdapter adapter = new SqlDataAdapter(commandcheck);
              adapter.Fill(data);
            if (data.Rows.Count >= 1)
            {
                MessageBox.Show("Đã có mã nhân viên " + comboBoxMANV.Text + " đã có ", "Thông Báo");
                return;
            }
            else
            {


                String query = "insert into NHANVIEN (MANV,HOTEN,SODT,NG_VAO_LAM,MAQL) values (@MANV,@HOTEN,@SODT,@NG_VAO_LAM,@MAQL) ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@MANV", comboBoxMANV.Text);
                command.Parameters.Add("@HOTEN", textBoxHT_NV.Text);
                command.Parameters.Add("@SODT", textBoxSDT_NV.Text);
                command.Parameters.Add("@NG_VAO_LAM", dateTimePickerNgayVao.Value.ToString());
                command.Parameters.Add("@MAQL", comboBoxMAQL.Text);
                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Thêm thành công mã nhân viên " + comboBoxMANV.Text, "Thông Báo");
                }
                connection.Close();
            }
        }

        private void buttonResetNV_Click(object sender, EventArgs e)
        {
            LoadNV();
            LoadMANV();
        }

        private void buttonDelNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa mã nhân viên " + dataGridViewNV.Rows[dataGridViewNV.CurrentRow.Index].Cells[0].Value.ToString() + " ?","Thông Báo",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                String query = "delete from NHANVIEN where  MANV=N'" + dataGridViewNV.Rows[dataGridViewNV.CurrentRow.Index].Cells[0].Value.ToString() + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int i=command.ExecuteNonQuery();
                connection.Close();
                if(i==1)
                {
                    MessageBox.Show("Xóa thành công mã nhân viên " + dataGridViewNV.Rows[dataGridViewNV.CurrentRow.Index].Cells[0].Value.ToString(),"Thông Báo");
                }    
            }
        }

        private void buttonEditNV_Click(object sender, EventArgs e)
        {
            if(textBoxHT_KH.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông Báo");
                return;
            }    
            if(textBoxSDT_KH.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập SĐT", "Thông Báo");
                return;
            }    
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "update NHANVIEN set HOTEN= N'" + textBoxHT_NV.Text + "',SODT= N'" + textBoxSDT_NV.Text + "',NG_VAO_LAM ='" + dateTimePickerNgayVao.Value.ToString() + "',MAQL= N'" + comboBoxMAQL.Text + "' where MANV = N'" + comboBoxMANV.Text+"'";
            SqlCommand command = new SqlCommand(query, connection);
            int i= command.ExecuteNonQuery();
            connection.Close();
            if(i==1)
            {
                MessageBox.Show("Sửa thành công mã nhân viên " + comboBoxMANV.Text, "Thông Báo");
            }
        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxMANV.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMANV.Text = dataGridViewNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxHT_NV.Text = dataGridViewNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxSDT_NV.Text = dataGridViewNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxMAQL.Text = dataGridViewNV.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void textBoxHT_NV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn chỉ được nhập chữ cái", "Thông Báo");
                e.Handled = true;
                return;
            }    
        }

        private void textBoxSDT_NV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn chỉ được nhập số ", "Thông Báo");
                e.Handled = true;
                return;
            }
        }

        private void textBoxHT_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn chỉ được nhập chữ cái", "Thông Báo");
                e.Handled = true;
                return;
            }    
        }

        private void textBoxSDT_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn chỉ được nhập số", "Thông Báo");
                e.Handled = true;
                return;
            }
        }

        private void textBoxSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn chỉ được nhập số", "Thông Báo");
                e.Handled = true;
                return;
            }
        }

        private void buttonReset_KH_Click(object sender, EventArgs e)
        {
            textBoxMAKH.Text = "";
            textBoxHT_KH.Text = "";
            textBoxDChi_KH.Text = "";
            textBoxSDT_KH.Text = "";
            textBoxSOHD.Text = "";
            textBoxMASP.Text = "";
            numericUpDownSL.Value = 0;
            textBoxTG.Text = "";
        }

        private void dataGridViewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMAKH.Text = dataGridViewKH.Rows[e.RowIndex].Cells[0].Value.ToString() ;
            MAKH = dataGridViewKH.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxHT_KH.Text = dataGridViewKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            HOTEN = dataGridViewKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDChi_KH.Text = dataGridViewKH.Rows[e.RowIndex].Cells[2].Value.ToString();
            DCHI = dataGridViewKH.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSDT_KH.Text = dataGridViewKH.Rows[e.RowIndex].Cells[3].Value.ToString();
            SDT = int.Parse(dataGridViewKH.Rows[e.RowIndex].Cells[3].Value.ToString());
            dateTimePickerNMua.Text = dataGridViewKH.Rows[e.RowIndex].Cells[4].Value.ToString();
            DAY = dataGridViewKH.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxSOHD.Text = dataGridViewKH.Rows[e.RowIndex].Cells[5].Value.ToString();
            SOHD = int.Parse(dataGridViewKH.Rows[e.RowIndex].Cells[5].Value.ToString());
            textBoxMASP.Text = dataGridViewKH.Rows[e.RowIndex].Cells[6].Value.ToString();
            MASP = dataGridViewKH.Rows[e.RowIndex].Cells[6].Value.ToString();
            numericUpDownSL.Text = dataGridViewKH.Rows[e.RowIndex].Cells[7].Value.ToString();
            SL = int.Parse(dataGridViewKH.Rows[e.RowIndex].Cells[7].Value.ToString());
            textBoxTG.Text = dataGridViewKH.Rows[e.RowIndex].Cells[8].Value.ToString();
            
        }

        private void buttonEdit_KH_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (textBoxMAKH.Text == "")
            {
                status = false;
            }
            if (textBoxSOHD.Text == "")
            {
                status = false;
            }
            if (!status)
            {
                MessageBox.Show("chưa đủ thông tin mời bạn chọn khách hàng", "Thông Báo");
            }
            else
            {
                if (textBoxHT_KH.Text == "")
                {
                    MessageBox.Show("Chưa nhập Họ tên khách hàng", "Thông Báo");
                    return;
                }
                if (textBoxDChi_KH.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ khách hàng", "Thông Báo");
                    return;
                }
                if (textBoxSDT_KH.Text == "")
                {
                    MessageBox.Show("Chưa nhập SĐT khách hàng", "Thông Báo");
                    return;
                }
                if (textBoxMASP.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã sản phẩm", "Thông Báo");
                    return;
                }
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();
                String querycheck = "select KHACHHANG.MAKH,HOTEN,DCHI,SODT,NGMUA,HOADON.SOHD,MASP,SL,TRIGIACT from KHACHHANG,HOADON,CTHD where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD and HOADON.SOHD=N'"+textBoxSOHD.Text+
                     "' and MASP=N'"+textBoxMASP.Text+"' and SL=N'"+numericUpDownSL.Value.ToString()+ "' and KHACHHANG.MAKH=N'"+textBoxMAKH.Text+"' and HOTEN=N'"+textBoxHT_KH.Text+"' and DCHI=N'"+textBoxDChi_KH.Text+"' and SODT=N'"+
                      textBoxSDT_KH.Text+"' and NGMUA=N'"+dateTimePickerNMua.Value.ToString()+"'";
                SqlCommand commandcheck = new SqlCommand(querycheck, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(commandcheck);
                adapter.Fill(data);
                if (data.Rows.Count >= 1)
                {
                    MessageBox.Show("Mã sản phẩm " + textBoxMASP.Text + " của hóa đơn " + textBoxSOHD.Text + " đã có");
                    return;
                }
                else
                {
                    String queryKH = "update KHACHHANG set HOTEN= N'" + textBoxHT_KH.Text + "', DCHI= N'" + textBoxDChi_KH.Text + "',SODT= N'" + textBoxSDT_KH.Text + "',NGMUA =N'" + dateTimePickerNgayVao.Value.ToString() + "' from KHACHHANG,HOADON,CTHD where " +
                    " KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD and KHACHHANG.MAKH = N'" + MAKH + "' and HOADON.SOHD = N'" + SOHD + "' and MASP = N'" + MASP + "' and HOTEN=N'" + HOTEN + "' and DCHI=N'" + DCHI + "' and SODT=N'" + SDT + "' and NGMUA=N'" + DAY + "' and SL=N'" + SL + "' ";
                    String queryCTHD = "update CTHD set MASP= N'" + textBoxMASP.Text + "', SL= N'" + numericUpDownSL.Text + "', TRIGIACT= N'" + textBoxTG.Text + "' from KHACHHANG,HOADON,CTHD where " +
                    " KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD and KHACHHANG.MAKH = N'" + MAKH + "' and HOADON.SOHD = N'" + SOHD + "' and MASP = N'" + MASP + "' and HOTEN=N'" + HOTEN + "' and DCHI=N'" + DCHI + "' and SODT=N'" + SDT + "' and NGMUA=N'" + DAY + "' and SL=N'" + SL + "' ";
                    String queryUpdate = "UPDATE HOADON SET TRIGIA = (select sum(TRIGIACT) from CTHD where SOHD=N'" + textBoxSOHD.Text + "') where SOHD=N'" + textBoxSOHD.Text + "'";
                    SqlCommand commandKH = new SqlCommand(queryKH, connection);
                    commandKH.ExecuteNonQuery();
                    SqlCommand commandCTHD = new SqlCommand(queryCTHD, connection);
                    commandCTHD.ExecuteNonQuery();
                    SqlCommand commandUPdate = new SqlCommand(queryUpdate, connection);
                    commandUPdate.ExecuteNonQuery();
                    connection.Close();
                }
                
            }
            
        }

        private void textBoxMASP_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = " select * from SANPHAM ";
            SqlCommand command = new SqlCommand(query, connection);
            using (DbDataReader dataReader = command.ExecuteReader())
            {
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (textBoxMASP.Text == dataReader["MASP"].ToString())
                        {
                            GIA = double.Parse(dataReader["GIA"].ToString());
                        }
                    }
                }
            }
            connection.Close();
        }

        private void buttonSreachAll_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select * from KHACHHANG where  HOTEN= N'" + textBoxSearchMAKH.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            if (data.Rows.Count >= 1)
                dataGridViewKH.DataSource = data;
            else
            {
                MessageBox.Show("Không tồn tại mã khách hàng " + textBoxSearchMAKH.Text, "Thông Báo");
            }
            connection.Close();
        }

        private void buttonDel_KH_Click(object sender, EventArgs e)
        {

        }

        private void buttonOutPut_Click(object sender, EventArgs e)
        {
            String duongdan = Application.StartupPath + "\\Excel\\";
            op.OutputExcel(dataGridViewDT, duongdan, comboBoxSelect.Text);
            MessageBox.Show("Xuất thành công file Excel", "Thông báo");
        }

        private void buttonReSet_KH_Click_1(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void buttonSreachMAKH_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select KHACHHANG.MAKH,HOTEN,DCHI,SODT,NGMUA,HOADON.SOHD,MASP,SL,TRIGIACT from KHACHHANG,HOADON,CTHD where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD and KHACHHANG.MAKH= N'"+textBoxSearchMAKH.Text+"'";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            if(data.Rows.Count>=1)
            dataGridViewKH.DataSource = data;
            else
            {
                MessageBox.Show("Không tồn tại mã khách hàng " + textBoxSearchMAKH.Text,"Thông Báo");
            }
            connection.Close();
        }

        private void buttonSreachSOHD_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select KHACHHANG.MAKH,HOTEN,DCHI,SODT,NGMUA,HOADON.SOHD,MASP,SL,TRIGIACT from KHACHHANG,HOADON,CTHD where KHACHHANG.MAKH = HOADON.MAKH and HOADON.SOHD = CTHD.SOHD and HOADON.SOHD= N'" + textBoxSreachSOHD.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            if (data.Rows.Count >= 1)
                dataGridViewKH.DataSource = data;
            else
            {
                MessageBox.Show("Không tồn tại số hóa đơn " + textBoxSreachSOHD.Text, "Thông Báo");
            }
            connection.Close();
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            if(textBoxTK_Admin.Text=="")
            {
                MessageBox.Show("Bạn ko được để trống tài khoản Admin", "Thông Báo");
                return;
            }
            if (textBoxMK_Admin.Text == "")
            {
                MessageBox.Show("Bạn ko được để trống mật khẩu Admin", "Thông Báo");
                return;
            }
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            String query = "select * from QUANLY where MAQL=N'QL01'";
            SqlCommand command = new SqlCommand(query, connection);
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (textBoxMK_Admin.Text == reader["MK"].ToString())
                        {
                            ThongTinAdmin.TK_admin = reader["HOTEN"].ToString();
                            FormQLAdmin ad = new FormQLAdmin();
                            this.Hide();
                            ad.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai Mật Khẩu ", "Thông Báo");
                        }
                    }
                }
            }
            connection.Close();
        }

        private void FormQL_Load(object sender, EventArgs e)
        {
            labelAdminNV.Text = "Xin chào quản lí: " + FormLogin.ThongTinNV.TK_NV;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(comboBoxSelect.SelectedIndex==0)
            {
                LoadTop1Up();
            }  
            if(comboBoxSelect.SelectedIndex==1)
            {
                LoadDown1Up();
            }
            if (comboBoxSelect.SelectedIndex == 2)
            {
                LoadListUp();
            }
            if (comboBoxSelect.SelectedIndex == 3)
            {
                LoadListDown();
            }
            if (comboBoxSelect.SelectedIndex == 4)
            {
                LoadNear();
            }
            if (comboBoxSelect.SelectedIndex == 5)
            {
                LoadFar();
            }
            if (comboBoxSelect.SelectedIndex == 6)
            {
                LoadTopInYear();
            }
            if (comboBoxSelect.SelectedIndex == 7)
            {
                LoadDownInYear();
            }
            if (comboBoxSelect.SelectedIndex == 8)
            {
                ListSP();
            }
            if (comboBoxSelect.SelectedIndex == 9)
            {
                ListSPtop();
            }
            if (comboBoxSelect.SelectedIndex == 10)
            {
                ListSPdown();
            }
            if (comboBoxSelect.SelectedIndex == 11)
            {
                ListKHTop();
            }
        }

        private void numericUpDownSL_ValueChanged(object sender, EventArgs e)
        {
            
            sum = GIA * int.Parse(numericUpDownSL.Value.ToString());
            textBoxTG.Text = sum.ToString();
        }
    }
    
}
