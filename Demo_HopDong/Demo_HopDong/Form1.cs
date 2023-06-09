using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Demo_HopDong
{
    public partial class Form1 : Form
    {
        private static string stringKetNoi = @"Data Source=DESKTOP-EBFVT45\SQLSERVER;Initial Catalog=DEMO_HOPDONG;Integrated Security=True";
        SqlConnection Connect = new SqlConnection(stringKetNoi);
        private object wordApp;

        private void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtID.Enabled = true;
            txtHoVaTen.Enabled = true;
            txtQuocTich.Enabled = true;
            txtSDT.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            dtpNgayKy.Enabled = true;
            dtpThoiHan.Enabled = true;
            cbbLoaiHD.Enabled = true;
            txtGiaTriHD.Enabled = true;
            txtID.Text = "";
            txtHoVaTen.Text = "";
            txtQuocTich.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            dtpNgayKy.Text = "";
            dtpThoiHan.Text = "";
            cbbLoaiHD.Text = "";
            txtGiaTriHD.Text = "";
        }
        private void Insert()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtID.Enabled = true;
            txtHoVaTen.Enabled = true;
            txtQuocTich.Enabled = true;
            txtSDT.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            dtpNgayKy.Enabled = true;
            dtpThoiHan.Enabled = true;
            cbbLoaiHD.Enabled = true;
            txtGiaTriHD.Enabled = true;
            txtID.Text = "";
            txtHoVaTen.Text = "";
            txtQuocTich.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            dtpNgayKy.Text = "";
            dtpThoiHan.Text = "";
            cbbLoaiHD.Text = "";
            txtGiaTriHD.Text = "";
        }
        private void Edit()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtID.Enabled = false;
            txtHoVaTen.Enabled = false;
            txtQuocTich.Enabled = false;
            txtSDT.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            dtpNgayKy.Enabled = false;
            dtpThoiHan.Enabled = false;
            cbbLoaiHD.Enabled = false;
            txtGiaTriHD.Enabled = false;
        }
        private void resetSearch()
        {
            cbbTimKiem.Text = "";
        }
        private void connectHopDong()
        {
            try
            {
                Connect.Open();
                string query = "SELECT * FROM HOPDONG";
                SqlCommand sqlCommand = new SqlCommand(query, Connect);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvHopDong.DataSource = dataTable;
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
            connectHopDong();
            loadDataTimKiem();
            chkTimKiem_CheckedChanged(sender, e);
            dgvHopDong.CellFormatting += dgvHopDong_CellFormatting;
            btnWord.Click += btnWord_Click;
            dgvHopDong.Columns["ID"].HeaderText = "Id";
            dgvHopDong.Columns["HOVATEN"].HeaderText = "Họ và tên";
            dgvHopDong.Columns["QUOCTICH"].HeaderText = "Quốc tịch";
            dgvHopDong.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvHopDong.Columns["CMND"].HeaderText = "Chứng minh nhân dân";
            dgvHopDong.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvHopDong.Columns["NGAYKY"].HeaderText = "Ngày ký";
            dgvHopDong.Columns["THOIHAN"].HeaderText = "Thời hạn";
            dgvHopDong.Columns["LOAIHD"].HeaderText = "Loại hợp đồng";
            dgvHopDong.Columns["GIATRIHD"].HeaderText = "Giá trị hợp đồng";
            Edit();
        }
        private string FormatCurrency(decimal value)
        {
            return string.Format("{0:#,##0} VNĐ", value);
        }
        private void dgvHopDong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHopDong.Columns[e.ColumnIndex].Name == "GIATRIHD" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal giaTriHD))
                {
                    e.Value = FormatCurrency(giaTriHD);
                    e.FormattingApplied = true;
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtHoVaTen.Text == "" || txtQuocTich.Text == "" || txtSDT.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "" || dtpNgayKy.Value.ToString() == "" || dtpThoiHan.Value.ToString() == "" || cbbLoaiHD.Text == "" || txtGiaTriHD.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy ddie thông tin!");
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "INSERT INTO HOPDONG (ID, HOVATEN, QUOCTICH, SDT, CMND, DIACHI, NGAYKY, THOIHAN, LOAIHD, GIATRIHD) VALUES (@ID, @HOVATEN, @QUOCTICH, @SDT, @CMND, @DIACHI, @NGAYKY, @THOIHAN, @LOAIHD, @GIATRIHD)";
                    SqlCommand sqlCommand = new SqlCommand(query, Connect);
                    sqlCommand.Parameters.AddWithValue("@ID", txtID.Text);
                    sqlCommand.Parameters.AddWithValue("@HOVATEN", txtHoVaTen.Text);
                    sqlCommand.Parameters.AddWithValue("QUOCTICH", txtQuocTich.Text);
                    sqlCommand.Parameters.AddWithValue("SDT", txtSDT.Text);
                    sqlCommand.Parameters.AddWithValue("CMND", txtCMND.Text);
                    sqlCommand.Parameters.AddWithValue("DIACHI", txtDiaChi.Text);
                    DateTime NGAYKY = dtpNgayKy.Value;
                    string strNgayKy = NGAYKY.ToString("yyyy/MM/dd");
                    sqlCommand.Parameters.AddWithValue("@NGAYKY", strNgayKy);
                    DateTime THOIHAN = dtpThoiHan.Value;
                    string strThoiHan = THOIHAN.ToString("yyyy/MM.dd");
                    sqlCommand.Parameters.AddWithValue("@THOIHAN", strThoiHan);
                    if (cbbLoaiHD.Text != "")
                    {
                        sqlCommand.Parameters.AddWithValue("@LOAIHD", cbbLoaiHD.Text);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@LOAIHD", cbbLoaiHD.SelectedItem.ToString());
                    }
                    sqlCommand.Parameters.AddWithValue("GIATRIHD", txtGiaTriHD.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Lưu dữ liệu thành công!");
                    loadDataTimKiem();
                    Reset();
                    Connect.Close();
                    connectHopDong();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Trùng id, hãy nhập lại!");
                    Connect.Close();
                }
            }
            Insert();
        }
        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex - 1 >= 0 || e.ColumnIndex - 1 >= 0)
            {
                DataGridViewRow row = dgvHopDong.CurrentRow;
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtHoVaTen.Text = row.Cells["HOVATEN"].Value.ToString();
                txtQuocTich.Text = row.Cells["QUOCTICH"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtCMND.Text = row.Cells["CMND"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
                dtpNgayKy.Value = Convert.ToDateTime(row.Cells["NGAYKY"].Value);
                dtpThoiHan.Value = Convert.ToDateTime(row.Cells["THOIHAN"].Value);
                cbbLoaiHD.Text = row.Cells["LOAIHD"].Value.ToString();
                //txtGiaTriHD.Text = row.Cells["GIATRIHD"].Value.ToString();
                decimal giaTriHD = decimal.Parse(row.Cells["GIATRIHD"].Value.ToString());
                txtGiaTriHD.Text = FormatCurrency(giaTriHD);
            }
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            txtID.Enabled = false;
            txtHoVaTen.Enabled = true;
            txtQuocTich.Enabled = true;
            txtSDT.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            dtpNgayKy.Enabled = true;
            dtpThoiHan.Enabled = true;
            cbbLoaiHD.Enabled = true;
            txtGiaTriHD.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                string query = "UPDATE HOPDONG SET ID = @ID, HOVATEN = @HOVATEN, QUOCTICH = @QUOCTICH, SDT = @SDT, CMND = @CMND, DIACHI = @DIACHI, NGAYKY = @NGAYKY, THOIHAN = @THOIHAN, LOAIHD = @LOAIHD, GIATRIHD = @GIATRIHD WHERE ID = @ID";
                SqlCommand sqlCommand = new SqlCommand(query, Connect);
                sqlCommand.Parameters.AddWithValue("@ID", txtID.Text);
                sqlCommand.Parameters.AddWithValue("@HOVATEN", txtHoVaTen.Text);
                sqlCommand.Parameters.AddWithValue("QUOCTICH", txtQuocTich.Text);
                sqlCommand.Parameters.AddWithValue("SDT", txtSDT.Text);
                sqlCommand.Parameters.AddWithValue("CMND", txtCMND.Text);
                sqlCommand.Parameters.AddWithValue("DIACHI", txtDiaChi.Text);
                DateTime NGAYKY = dtpNgayKy.Value;
                string strNgayKy = NGAYKY.ToString("yyyy/MM/dd");
                sqlCommand.Parameters.AddWithValue("@NGAYKY", strNgayKy);
                DateTime THOIHAN = dtpThoiHan.Value;
                string strThoiHan = THOIHAN.ToString("yyyy/MM.dd");
                sqlCommand.Parameters.AddWithValue("@THOIHAN", strThoiHan);
                if (cbbLoaiHD.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@LOAIHD", cbbLoaiHD.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@LOAIHD", cbbLoaiHD.SelectedItem.ToString());
                }
                //sqlCommand.Parameters.AddWithValue("GIATRIHD", txtGiaTriHD.Text);
                decimal giatriHD;
                if (decimal.TryParse(txtGiaTriHD.Text.Replace(" VNĐ", "").Replace(",", ""), out giatriHD))
                {
                    sqlCommand.Parameters.AddWithValue("@GIATRIHD", giatriHD);
                }
                else
                {
                    // Xử lý trường hợp nhập giá trị không hợp lệ
                    MessageBox.Show("Giá trị HĐ không hợp lệ!");
                    Connect.Close();
                    return;
                }
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Sửa dữ liệu thành công!");
                loadDataTimKiem();
                Reset();
                Connect.Close();
                connectHopDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
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
            connectHopDong();
        }

        private void loadDataTimKiem()
        {
            string query = "SELECT HOVATEN FROM HOPDONG";
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
            string query = "SELECT * FROM HOPDONG WHERE HOVATEN LIKE '%' + @HOVATEN + '%' ";
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
            sqlCommand.Parameters.AddWithValue("@HOVATEN", TimKiemHVT);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvHopDong.DataSource = dataTable;
            Connect.Close();
            resetSearch();
        }
        private void btnWord_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvHopDong.SelectedCells[0].RowIndex;

            string ngayKy = dgvHopDong.Rows[rowIndex].Cells["NGAYKY"].Value?.ToString();
            string loaiHD = dgvHopDong.Rows[rowIndex].Cells["LOAIHD"].Value?.ToString();
            string tenDaiDien = dgvHopDong.Rows[rowIndex].Cells["HOVATEN"].Value?.ToString();
            string quocTich = dgvHopDong.Rows[rowIndex].Cells["QUOCTICH"].Value?.ToString();
            string sdt = dgvHopDong.Rows[rowIndex].Cells["SDT"].Value?.ToString();
            string cmnd = dgvHopDong.Rows[rowIndex].Cells["CMND"].Value?.ToString();
            string diaChi = dgvHopDong.Rows[rowIndex].Cells["DIACHI"].Value?.ToString();
            string thoiHan = dgvHopDong.Rows[rowIndex].Cells["THOIHAN"].Value?.ToString();
            string giaTriHD = dgvHopDong.Rows[rowIndex].Cells["GIATRIHD"].Value?.ToString();

            string filePath = @"D:\The Document all dead\Word\HĐ_2.docx";
            if (File.Exists(filePath))
            {
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = true;
                Word.Document doc = wordApp.Documents.Add(filePath);
                 FindAndReplace(wordApp, "<<NGAYKY>>", ngayKy);
                 FindAndReplace(wordApp, "<<LOAIHD>>", loaiHD);
                 FindAndReplace(wordApp, "<<HOVATEN>>", tenDaiDien);
                 FindAndReplace(wordApp, "<<QUOCTICH>>", quocTich);
                 FindAndReplace(wordApp, "<<SDT>>", sdt);
                 FindAndReplace(wordApp, "<<CMND>>", cmnd);
                 FindAndReplace(wordApp, "<<DIACHI>>", diaChi);
                 FindAndReplace(wordApp, "<<THOIHAN>>", thoiHan);
                 FindAndReplace(wordApp, "<<GIATRIHD>>", giaTriHD);

            }
            else
            {
                MessageBox.Show("Không tìm thấy tệp tin: " + filePath);
            }
        }
        private void FindAndReplace(Word.Application wordApp, string findText, string replaceText)
        {
            object missing = Type.Missing;
            object replaceObject = Word.WdReplace.wdReplaceAll;
            wordApp.Selection.Find.ClearFormatting();
            wordApp.Selection.Find.Execute(findText, missing, missing, missing, missing, missing, missing, missing, missing, replaceText, replaceObject, missing, missing, missing, missing);

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Connect.Open();
                    string query = "DELETE FROM HOPDONG WHERE ID = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, Connect);
                    sqlCommand.Parameters.AddWithValue("@ID", txtID.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    loadDataTimKiem();
                    Reset();
                    Connect.Close();
                    connectHopDong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}

