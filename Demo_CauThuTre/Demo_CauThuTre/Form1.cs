using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_CauThuTre
{
    public partial class Form1 : Form
    {
        private static string stringKetNoi = @"Data Source=DESKTOP-EBFVT45\SQLSERVER;Initial Catalog=DEMO_CAUTHUTRE;Integrated Security=True";
        SqlConnection Connect = new SqlConnection(stringKetNoi);

        private void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaThe.Enabled = true;
            txtTenCauThu.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbbGioiTinh.Enabled = true;
            txtQueQuan.Enabled = true;
            cbbViTri.Enabled = true;
            txtSoAo.Enabled = true;
            txtChieuCao.Enabled = true;
            txtCanNang.Enabled = true;
            txtMaThe.Text = "";
            txtTenCauThu.Text = "";
            dtpNgaySinh.Text = "";
            cbbGioiTinh.Text = "";
            txtQueQuan.Text = "";
            cbbViTri.Text = "";
            txtSoAo.Text = "";
            txtChieuCao.Text = "";
            txtCanNang.Text = "";
        }
        private void Insert()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaThe.Enabled = true;
            txtTenCauThu.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbbGioiTinh.Enabled = true;
            txtQueQuan.Enabled = true;
            cbbViTri.Enabled = true;
            txtSoAo.Enabled = true;
            txtChieuCao.Enabled = true;
            txtCanNang.Enabled = true;
            txtMaThe.Text = "";
            txtTenCauThu.Text = "";
            dtpNgaySinh.Text = "";
            cbbGioiTinh.Text = "";
            txtQueQuan.Text = "";
            cbbViTri.Text = "";
            txtSoAo.Text = "";
            txtChieuCao.Text = "";
            txtCanNang.Text = "";
        }
        private void Edit()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaThe.Enabled = false;
            txtTenCauThu.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbbGioiTinh.Enabled = false;
            txtQueQuan.Enabled = false;
            cbbViTri.Enabled = false;
            txtSoAo.Enabled = false;
            txtChieuCao.Enabled = false;
            txtCanNang.Enabled = false;
        }
        private void connectCauThuTre()
        {
            try
            {
                Connect.Open();
                string query = "SELECT * FROM CAUTHUTRE";
                SqlCommand sqlCommand = new SqlCommand(query, Connect);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvCauThuTre.DataSource = dataTable;
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectCauThuTre();
            chkTimKiem_CheckedChanged(sender, e);
            loadDataTimKiem();
            dgvCauThuTre.Columns["MATHE"].HeaderText = "Mã thẻ";
            dgvCauThuTre.Columns["TENCAUTHU"].HeaderText = "Tên cầu thủ";
            dgvCauThuTre.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dgvCauThuTre.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgvCauThuTre.Columns["QUEQUAN"].HeaderText = "Quê quán";
            dgvCauThuTre.Columns["VITRI"].HeaderText = "Vị trí";
            dgvCauThuTre.Columns["SOAO"].HeaderText = "Số áo";
            dgvCauThuTre.Columns["CHIEUCAO"].HeaderText = "Chiều cao";
            dgvCauThuTre.Columns["CANNANG"].HeaderText = "Cân nặng";
            Edit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaThe.Text == "" || txtTenCauThu.Text == "" || dtpNgaySinh.Value.ToString() == "" || cbbGioiTinh.Text == "" || txtQueQuan.Text == "" || cbbViTri.Text == "" || txtSoAo.Text == "" || txtChieuCao.Text == "" || txtCanNang.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "INSERT INTO CAUTHUTRE (MATHE, TENCAUTHU, NGAYSINH, GIOITINH, QUEQUAN, VITRI, SOAO, CHIEUCAO, CANNANG) VALUES (@MATHE, @TENCAUTHU, @NGAYSINH, @GIOITINH, @QUEQUAN, @VITRI, @SOAO, @CHIEUCAO, @CANNANG)";
                    SqlCommand sqlCommand = new SqlCommand(query, Connect);
                    sqlCommand.Parameters.AddWithValue("@MATHE", txtMaThe.Text);
                    sqlCommand.Parameters.AddWithValue("@TENCAUTHU", txtTenCauThu.Text);
                    DateTime NGAYSINH = dtpNgaySinh.Value;
                    string strNgaySinh = NGAYSINH.ToString("yyyy/MM/dd");
                    sqlCommand.Parameters.AddWithValue("@NGAYSINH", strNgaySinh);
                    if(cbbGioiTinh.Text != "")
                    {
                        sqlCommand.Parameters.AddWithValue("@GIOITINH", cbbGioiTinh.Text);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@GIOITINH", cbbGioiTinh.SelectedItem.ToString());
                    }
                    sqlCommand.Parameters.AddWithValue("@QUEQUAN", txtQueQuan.Text);
                    if (cbbViTri.Text != "")
                    {
                        sqlCommand.Parameters.AddWithValue("@VITRI", cbbViTri.Text);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@VITRI", cbbViTri.SelectedItem.ToString());
                    }
                    sqlCommand.Parameters.AddWithValue("@SOAO", txtSoAo.Text);
                    sqlCommand.Parameters.AddWithValue("@CHIEUCAO", txtChieuCao.Text);
                    sqlCommand.Parameters.AddWithValue("CANNANG", txtCanNang.Text);
                  
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Lưu dữ liệu thành công!");
                    loadDataTimKiem();
                    Reset();
                    Connect.Close();
                    connectCauThuTre();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Trùng id, hãy nhập lại!");
                    Connect.Close();
                }
                Insert();
            }
        }

        private void dgvCauThuTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex - 1 >= 0 || e.ColumnIndex - 1 >= 0)
            {
                DataGridViewRow row = dgvCauThuTre.CurrentRow;
                txtMaThe.Text = row.Cells["MATHE"].Value.ToString();
                txtTenCauThu.Text = row.Cells["TENCAUTHU"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NGAYSINH"].Value);
                cbbGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString();
                txtQueQuan.Text = row.Cells["QUEQUAN"].Value.ToString();
                cbbViTri.Text = row.Cells["VITRI"].Value.ToString();
                txtSoAo.Text = row.Cells["SOAO"].Value.ToString();
                txtChieuCao.Text = row.Cells["CHIEUCAO"].Value.ToString();
                txtCanNang.Text = row.Cells["CANNANG"].Value.ToString();
            }
            txtMaThe.Enabled = false;
            txtTenCauThu.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbbGioiTinh.Enabled = true;
            txtQueQuan.Enabled = true;
            cbbViTri.Enabled = true;
            txtSoAo.Enabled = true;
            txtChieuCao.Enabled = true;
            txtCanNang.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaThe.Text == "" || txtTenCauThu.Text == "" || dtpNgaySinh.Value.ToString() == "" || cbbGioiTinh.Text == "" || txtQueQuan.Text == "" || cbbViTri.Text == "" || txtSoAo.Text == "" || txtChieuCao.Text == "" || txtCanNang.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "UPDATE CAUTHUTRE SET MATHE = @MATHE, TENCAUTHU = @TENCAUTHU, NGAYSINH = @NGAYSINH, GIOITINH = @GIOITINH, QUEQUAN = @QUEQUAN, VITRI = @VITRI, SOAO = @SOAO, CHIEUCAO = @CHIEUCAO, CANNANG = @CANNANG WHERE MATHE = @MATHE";
                    SqlCommand sqlCommand = new SqlCommand(query, Connect);
                    sqlCommand.Parameters.AddWithValue("@MATHE", txtMaThe.Text);
                    sqlCommand.Parameters.AddWithValue("@TENCAUTHU", txtTenCauThu.Text);
                    DateTime NGAYSINH = dtpNgaySinh.Value;
                    string strNgaySinh = NGAYSINH.ToString("yyyy/MM/dd");
                    sqlCommand.Parameters.AddWithValue("@NGAYSINH", strNgaySinh);
                    if (cbbGioiTinh.Text != "")
                    {
                        sqlCommand.Parameters.AddWithValue("@GIOITINH", cbbGioiTinh.Text);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@GIOITINH", cbbGioiTinh.SelectedItem.ToString());
                    }
                    sqlCommand.Parameters.AddWithValue("@QUEQUAN", txtQueQuan.Text);
                    if (cbbViTri.Text != "")
                    {
                        sqlCommand.Parameters.AddWithValue("@VITRI", cbbViTri.Text);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@VITRI", cbbViTri.SelectedItem.ToString());
                    }
                    sqlCommand.Parameters.AddWithValue("@SOAO", txtSoAo.Text);
                    sqlCommand.Parameters.AddWithValue("@CHIEUCAO", txtChieuCao.Text);
                    sqlCommand.Parameters.AddWithValue("CANNANG", txtCanNang.Text);

                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Sửa dữ liệu thành công!");
                    loadDataTimKiem();
                    Reset();
                    Connect.Close();
                    connectCauThuTre();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Connect.Open();
                    string query = "DELETE FROM CAUTHUTRE WHERE MATHE = @MATHE";
                    SqlCommand sqlCommand = new SqlCommand(query, Connect);
                    sqlCommand.Parameters.AddWithValue("@MATHE", txtMaThe.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    loadDataTimKiem();
                    Reset();
                    Connect.Close();
                    connectCauThuTre();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void chkTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiem.Checked == true)
            {
                cbbTimKiem.Visible = true;
                btnTimKiem.Visible = true;
            }
            else
            {
                cbbTimKiem.Visible = false;
                btnTimKiem.Visible = false;
            }
            connectCauThuTre();
        }

        private void loadDataTimKiem()
        {
            string query = "SELECT TENCAUTHU FROM CAUTHUTRE";
            using (SqlConnection Connect = new SqlConnection(stringKetNoi))
            {
                Connect.Open();
                SqlCommand sqlCommand = new SqlCommand(query, Connect);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                cbbTimKiem.Items.Clear();
                while (reader.Read())
                {
                    cbbTimKiem.Items.Add(reader.GetString(0));
                }
                reader.Close();
                sqlCommand.Dispose();
                Connect.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Connect.Open();
            string query = "SELECT * FROM CAUTHUTRE WHERE TENCAUTHU LIKE '%' + @TENCAUTHU + '%' ";
            SqlCommand sqlCommand = new SqlCommand(query, Connect);
            string TimKiemHVT;
            if (cbbTimKiem.Text == null)
            {
                TimKiemHVT = cbbTimKiem.SelectedItem.ToString();
            }
            else
            {
                TimKiemHVT = cbbTimKiem.Text;
            }
            sqlCommand.Parameters.AddWithValue("@TENCAUTHU", TimKiemHVT);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvCauThuTre.DataSource = dataTable;
            Connect.Close();
            cbbTimKiem.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
