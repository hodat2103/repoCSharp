using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_BangLuong
{
    public partial class Form1 : Form
    {
        private static string stringKetNoi = @"Data Source=DESKTOP-EBFVT45\SQLSERVER;Initial Catalog=DEMO_BANGLUONG;Integrated Security=True";
        SqlConnection Connect = new SqlConnection(stringKetNoi);
        private void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaThe.Enabled = true;
            txtHoVaTen.Enabled = true;
            cbbNgheNghiep.Enabled = true;
            cbbViTri.Enabled = true;
            cbbThanhTich.Enabled = true;
            txtTienThuongTT.Enabled = true;
            cbbPhuCap.Enabled = true;
            txtTienPhuCap.Enabled = true;
            txtLuongCB.Enabled = true;
            txtLuongThucLinh.Enabled = true;


            txtMaThe.Text = "";
            txtHoVaTen.Text = "";
            cbbNgheNghiep.Text = "";
            cbbViTri.Text = "";
            cbbThanhTich.Text = "";
            txtTienThuongTT.Text = "";
            cbbPhuCap.Text = "";
            txtTienPhuCap.Text = "";
            txtLuongCB.Text = "";
            txtLuongThucLinh.Text = "";
        }

        private void Insert()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaThe.Enabled = true;
            txtHoVaTen.Enabled = true;
            cbbNgheNghiep.Enabled = true;
            cbbViTri.Enabled = true;
            cbbThanhTich.Enabled = true;
            txtTienThuongTT.Enabled = true;
            cbbPhuCap.Enabled = true;
            txtTienPhuCap.Enabled = true;
            txtLuongCB.Enabled = true;
            txtLuongThucLinh.Enabled = true;


            txtMaThe.Text = "";
            txtHoVaTen.Text = "";
            cbbNgheNghiep.Text = "";
            cbbViTri.Text = "";
            cbbThanhTich.Text = "";
            txtTienThuongTT.Text = "";
            cbbPhuCap.Text = "";
            txtTienPhuCap.Text = "";
            txtLuongCB.Text = "";
            txtLuongThucLinh.Text = "";
        }

        private void Edit()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaThe.Enabled = false;
            txtHoVaTen.Enabled = false;
            cbbNgheNghiep.Enabled = false;
            cbbViTri.Enabled = false;
            cbbThanhTich.Enabled = false;
            txtTienThuongTT.Enabled = false;
            cbbPhuCap.Enabled = false;
            txtTienPhuCap.Enabled = false;
            txtLuongCB.Enabled = false;
            txtLuongThucLinh.Enabled = false;
        }
        private void ResetSearch()
        {
            cbbTimKiem.Text = "";
        }

        private void connectBangLuong()
        {
            Connect.Open();
            string query = "SELECT * FROM BANGLUONG";
            SqlCommand sqlCommand = new SqlCommand(query, Connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvBangLuong.DataSource = dataTable;
            dgvBangLuong.Columns["LUONGCB"].DefaultCellStyle.Format = "#,##0 VNĐ";
            dgvBangLuong.Columns["TIENTHUONGTT"].DefaultCellStyle.Format = "#,##0 VNĐ";
            dgvBangLuong.Columns["TIENPC"].DefaultCellStyle.Format = "#,##0 VNĐ";
            dgvBangLuong.Columns["LUONGTHUCLINH"].DefaultCellStyle.Format = "#,##0 VNĐ";
            Connect.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectBangLuong();
            cbbThanhTich.SelectedIndexChanged += cbbThanhTich_SelectedIndexChanged;
            cbbViTri.SelectedIndexChanged += cbbViTri_SelectedIndexChanged;
            cbbPhuCap.SelectedIndexChanged += cbbPhuCap_SelectedIndexChanged;
            chkTimKiem_CheckedChanged(sender, e);
            loadDataTimKiem();
            dgvBangLuong.Columns["MATHE"].HeaderText = "Mã thẻ";
            dgvBangLuong.Columns["HOVATEN"].HeaderText = "Họ và Tên";
            dgvBangLuong.Columns["NGHENGHIEP"].HeaderText = "Nghề nghiệp";
            dgvBangLuong.Columns["VITRI"].HeaderText = "Vị trí";
            dgvBangLuong.Columns["THANHTICH"].HeaderText = "Thành tích";
            dgvBangLuong.Columns["TIENTHUONGTT"].HeaderText = "Tiền thưởng thành tích";
            dgvBangLuong.Columns["PHUCAP"].HeaderText = "Phụ cấp";
            dgvBangLuong.Columns["TIENPC"].HeaderText = "Tiền phụ cấp";
            dgvBangLuong.Columns["LUONGCB"].HeaderText = "Lương cơ bản";
            dgvBangLuong.Columns["LUONGTHUCLINH"].HeaderText = "Lương thực lĩnh";

            Edit();
        }
        private void dgvBangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvBangLuong.CurrentRow;

                txtMaThe.Text = row.Cells["MATHE"].Value.ToString();
                txtHoVaTen.Text = row.Cells["HOVATEN"].Value.ToString();
                cbbNgheNghiep.Text = row.Cells["NGHENGHIEP"].Value.ToString();
                cbbViTri.Text = row.Cells["VITRI"].Value.ToString();
                cbbThanhTich.Text = row.Cells["THANHTICH"].Value.ToString();
                txtTienThuongTT.Text = row.Cells["TIENTHUONGTT"].Value.ToString();
                decimal tienThuongTT = decimal.Parse(row.Cells["TIENTHUONGTT"].Value.ToString());
                txtTienThuongTT.Text = FormatCurrency(tienThuongTT);
                cbbPhuCap.Text = row.Cells["PHUCAP"].Value.ToString();
                decimal tienPC = decimal.Parse(row.Cells["TIENPC"].Value.ToString());
                txtTienPhuCap.Text = FormatCurrency(tienPC);
                decimal luongCB = decimal.Parse(row.Cells["LUONGCB"].Value.ToString());
                txtLuongCB.Text = FormatCurrency(luongCB);
                decimal luongThucLinh = decimal.Parse(row.Cells["LUONGTHUCLINH"].Value.ToString());
                txtLuongThucLinh.Text = FormatCurrency(luongThucLinh);
            }

            btnThem.Enabled = false;
            btnHuy.Enabled = true;

            txtMaThe.Enabled = false;
            txtHoVaTen.Enabled = true;
            cbbNgheNghiep.Enabled = true;
            cbbViTri.Enabled = true;
            cbbThanhTich.Enabled = true;
            txtTienThuongTT.Enabled = true;
            cbbPhuCap.Enabled = true;
            txtTienPhuCap.Enabled = true;
            txtLuongCB.Enabled = true;
            txtLuongThucLinh.Enabled = true;
        }
        private string FormatCurrency(decimal value)
        {
            return string.Format("{0:#,##0} VNĐ", value);
        }
        private void cbbViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal luongCB = 0;
            if (cbbViTri.SelectedItem != null)
            {
                String selectOption = cbbViTri.SelectedItem.ToString();
                if (selectOption == "Thủ môn")
                {
                    luongCB = 20000000;
                }
                else if (selectOption == "Hậu vệ")
                {
                    luongCB = 12000000;
                }
                else if (selectOption == "Tiền vệ")
                {
                    luongCB = 15000000;
                }
                else if (selectOption == "Tiền đạo")
                {
                    luongCB = 25000000;
                }
                else if (selectOption == "HLV thủ môn")
                {
                    luongCB = 15000000;
                }
                else if (selectOption == "HLV cầu thủ")
                {
                    luongCB = 22000000;
                }
                else if (selectOption == "Bác sĩ chăm sóc")
                {
                    luongCB = 12000000;
                }
                else if (selectOption == "Bác sĩ trong mỗi trận đấu")
                {
                    luongCB = 18000000;
                }
                else if (selectOption == "Lao công")
                {
                    luongCB = 9000000;

                }
                txtLuongCB.Text = luongCB.ToString("#,##0") + "VNĐ";
                CalculateLuongThucLinh();
            }
            else
            {
                txtLuongCB.Text = "";
            }
        }
        private void cbbThanhTich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThanhTich.SelectedItem != null)
            {
                String selectOption = cbbThanhTich.SelectedItem.ToString();
                decimal tienThanhTich = 0;
                if (selectOption == "Thành tích cá nhân")
                {
                    tienThanhTich = 10000000;
                }
                else if (selectOption == "Thành tích đội bóng")
                {
                    tienThanhTich = 20000000;
                }
                else if (selectOption == "Sự ổn định và đóng góp cho đội bóng")
                {
                    tienThanhTich = 30000000;
                }
                else if (selectOption == "#")
                {
                    tienThanhTich = 0;
                }
                txtTienThuongTT.Text = tienThanhTich.ToString("#,##0") + "VNĐ";
                CalculateLuongThucLinh();
            }
            else
            {
                txtTienThuongTT.Text = "";
            }
        }
        private void cbbPhuCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPhuCap.SelectedItem != null)
            {
                String selectOption = cbbPhuCap.SelectedItem.ToString();
                decimal tienPhuCap = 0;

                if (selectOption == "Tiền ăn")
                {
                    tienPhuCap = 500000;
                }
                else if (selectOption == "Tiền xăng xe")
                {
                    tienPhuCap = 500000;
                }
                else if (selectOption == "Tiền chỗ ở")
                {
                    tienPhuCap = 500000;
                }
                else if (selectOption == "Tổng cả 3 phụ cấp trên")
                {
                    tienPhuCap = 1500000;
                }
                else if (selectOption == "#")
                {
                    tienPhuCap = 0;
                }
                txtTienPhuCap.Text = tienPhuCap.ToString("#,##0") + "VNĐ";

                CalculateLuongThucLinh();
            }
            else
            {
                txtTienPhuCap.Text = "";
            }
        }
        private void CalculateLuongThucLinh()
        {
            decimal tienThuongTT;
            decimal tienPhuCap;
            decimal luongCB;
            string tienThuongTTText = Regex.Replace(txtTienThuongTT.Text, "[^0-9.]", "");
            string tienPhuCapText = Regex.Replace(txtTienPhuCap.Text, "[^0-9.]", "");
            string luongCBText = Regex.Replace(txtLuongCB.Text, "[^0-9.]", "");
            if (decimal.TryParse(tienThuongTTText, out tienThuongTT) &&
                decimal.TryParse(tienPhuCapText, out tienPhuCap) &&
                decimal.TryParse(luongCBText, out luongCB))
            {
                decimal luongThucLinh = tienThuongTT + tienPhuCap + luongCB;
                txtLuongThucLinh.Text = luongThucLinh.ToString("#,##0") + " VNĐ";
            }      
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaThe.Text == "" || txtHoVaTen.Text == "" || cbbNgheNghiep.Text == "" || cbbViTri.Text == "" || cbbThanhTich.Text == "" || txtTienThuongTT.Text == "" || cbbPhuCap.Text == "" || txtTienPhuCap.Text == "" || txtLuongCB.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "INSERT INTO BANGLUONG (MATHE, HOVATEN, NGHENGHIEP, VITRI, THANHTICH, TIENTHUONGTT, PHUCAP, TIENPC, LUONGCB, LUONGTHUCLINH) VALUES (@MATHE, @HOVATEN, @NGHENGHIEP, @VITRI, @THANHTICH, @TIENTHUONGTT, @PHUCAP, @TIENPC, @LUONGCB, @LUONGTHUCLINH)";
                    SqlCommand sqlCommand = new SqlCommand(query, Connect);
                    sqlCommand.Parameters.AddWithValue("@MATHE", txtMaThe.Text);
                    sqlCommand.Parameters.AddWithValue("@HOVATEN", txtHoVaTen.Text);
                    if (cbbNgheNghiep.Text != "")
                    {
                        sqlCommand.Parameters.AddWithValue("@NGHENGHIEP", cbbNgheNghiep.Text);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@NGHENGHIEP", cbbNgheNghiep.SelectedItem.ToString());
                    }

                    if (cbbViTri.Text != "")
                    {
                        sqlCommand.Parameters.AddWithValue("@VITRI", cbbViTri.Text);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@VITRI", cbbViTri.SelectedItem.ToString());
                    }

                    if (cbbThanhTich.Text != "")
                    {
                        sqlCommand.Parameters.AddWithValue("@THANHTICH", cbbThanhTich.Text);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@THANHTICH", cbbThanhTich.SelectedItem.ToString());
                    }
                    // Chuyển đổi chuỗi thành số và loại bỏ ký tự không phải số
                    decimal tienThuongTT;
                    decimal tienPhuCap;
                    decimal luongCB;
                    if (decimal.TryParse(Regex.Replace(txtTienThuongTT.Text, "[^0-9.]", ""), out tienThuongTT) &&
                        decimal.TryParse(Regex.Replace(txtTienPhuCap.Text, "[^0-9.]", ""), out tienPhuCap) &&
                        decimal.TryParse(Regex.Replace(txtLuongCB.Text, "[^0-9.]", ""), out luongCB))
                    {
                        decimal luongThucLinh = tienThuongTT + tienPhuCap + luongCB;
                        txtLuongThucLinh.Text = luongThucLinh.ToString("#,##0") + " VNĐ";
                        sqlCommand.Parameters.AddWithValue("@TIENTHUONGTT", tienThuongTT);
                        sqlCommand.Parameters.AddWithValue("@PHUCAP", cbbPhuCap.Text);
                        sqlCommand.Parameters.AddWithValue("@TIENPC", tienPhuCap);
                        sqlCommand.Parameters.AddWithValue("@LUONGCB", luongCB);
                        sqlCommand.Parameters.AddWithValue("@LUONGTHUCLINH", luongThucLinh);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Lưu dữ liệu thành công!");
                        loadDataTimKiem();
                        Reset();
                        Connect.Close();
                        connectBangLuong();
                        CalculateLuongThucLinh();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số hợp lệ cho các trường Tiền thưởng TT, Tiền phụ cấp và Lương cơ bản");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Trùng mã thẻ, hãy nhập lại");
                    Connect.Close();
                }
            }
            Insert();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                string query = "UPDATE BANGLUONG SET MATHE = @MATHE, HOVATEN = @HOVATEN, NGHENGHIEP = @NGHENGHIEP, VITRI = @VITRI, THANHTICH = @THANHTICH, TIENTHUONGTT = @TIENTHUONGTT, PHUCAP = @PHUCAP, TIENPC = @TIENPC, LUONGCB = @LUONGCB, LUONGTHUCLINH = @LUONGTHUCLINH WHERE MATHE = @MATHE";
                SqlCommand sqlCommand = new SqlCommand(query, Connect);
                sqlCommand.Parameters.AddWithValue("@MATHE", txtMaThe.Text);
                sqlCommand.Parameters.AddWithValue("@HOVATEN", txtHoVaTen.Text);
                if (cbbNgheNghiep.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@NGHENGHIEP", cbbNgheNghiep.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@NGHENGHIEP", cbbNgheNghiep.SelectedItem.ToString());
                }

                if (cbbViTri.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@VITRI", cbbViTri.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@VITRI", cbbViTri.SelectedItem.ToString());
                }

                if (cbbThanhTich.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@THANHTICH", cbbThanhTich.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@THANHTICH", cbbThanhTich.SelectedItem.ToString());
                }
                // Chuyển đổi chuỗi thành số và loại bỏ ký tự không phải số
                decimal tienThuongTT;
                decimal tienPhuCap;
                decimal luongCB;
                if (decimal.TryParse(Regex.Replace(txtTienThuongTT.Text, "[^0-9.]", ""), out tienThuongTT) &&
                    decimal.TryParse(Regex.Replace(txtTienPhuCap.Text, "[^0-9.]", ""), out tienPhuCap) &&
                    decimal.TryParse(Regex.Replace(txtLuongCB.Text, "[^0-9.]", ""), out luongCB))
                {
                    decimal luongThucLinh = tienThuongTT + tienPhuCap + luongCB;
                    txtLuongThucLinh.Text = luongThucLinh.ToString("#,##0") + " VNĐ";
                    sqlCommand.Parameters.AddWithValue("@TIENTHUONGTT", tienThuongTT);
                    sqlCommand.Parameters.AddWithValue("@PHUCAP", cbbPhuCap.Text);
                    sqlCommand.Parameters.AddWithValue("@TIENPC", tienPhuCap);
                    sqlCommand.Parameters.AddWithValue("@LUONGCB", luongCB);
                    sqlCommand.Parameters.AddWithValue("@LUONGTHUCLINH", luongThucLinh);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Sửa dữ liệu thành công!");
                    loadDataTimKiem();
                    Reset();
                    Connect.Close();
                    connectBangLuong();
                    CalculateLuongThucLinh();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho các trường Tiền thưởng TT, Tiền phụ cấp và Lương cơ bản");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!");
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
                    string query = "DELETE FROM BANGLUONG WHERE MATHE = @MATHE";
                    SqlCommand sqlCommand = new SqlCommand(query, Connect);
                    sqlCommand.Parameters.AddWithValue("@MATHE", txtMaThe.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    loadDataTimKiem();
                    Reset();
                    Connect.Close();
                    connectBangLuong();
                    CalculateLuongThucLinh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!", ex.Message);
            }
        }
        private void chkTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTimKiem.Checked == true)
            {
                lblTimKiem.Visible = true;
                cbbTimKiem.Visible = true;
                btnTimKiem.Visible = true;
            }
            else
            {
                lblTimKiem.Visible = false;
                cbbTimKiem.Visible = false;
                btnTimKiem.Visible = false;
            }
            connectBangLuong();
        }
        private void loadDataTimKiem()
        {
            cbbTimKiem.Items.Clear();
            string query = "SELECT HOVATEN FROM BANGLUONG";
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
            string query = "SELECT * FROM BANGLUONG WHERE HOVATEN LIKE '%' + @HOVATEN + '%' ";
            SqlCommand sqlCommand = new SqlCommand(query, Connect);
            string TimKiemHoVaTen;
            if (cbbTimKiem.Text == null)
            {
                TimKiemHoVaTen = cbbTimKiem.SelectedItem.ToString();
            }
            else
            {
                TimKiemHoVaTen = cbbTimKiem.Text;
            }
            sqlCommand.Parameters.AddWithValue("@HOVATEN", TimKiemHoVaTen);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvBangLuong.DataSource = dataTable;
            Connect.Close();
            ResetSearch();
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if(dgvBangLuong.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)xcelApp.ActiveSheet;
                for (int j = 0; j < dgvBangLuong.Columns.Count; j++)
                {
                    string columnName = dgvBangLuong.Columns[j].HeaderText;
                    xcelApp.Cells[1, j + 1] = columnName;
                }
                for (int i = 0; i < dgvBangLuong.Rows.Count; i++)
                {
                    for(int j = 0; j < dgvBangLuong.Columns.Count; j++)
                    {
                        DataGridViewCell cell = dgvBangLuong.Rows[i].Cells[j];
                        if (cell.Value != null)
                        {
                            xcelApp.Cells[i + 2, j + 1] = cell.Value.ToString();
                        }
                        else
                        {
                            xcelApp.Cells[i + 2, j + 1] = string.Empty;
                        }
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
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
