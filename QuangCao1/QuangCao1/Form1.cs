using Aspose.Words;
using ThuVienWinform.Report.AsposeWordExtension;
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
using Aspose.Words.Tables;

namespace QuangCao1
{
    public partial class Form1 : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        public static string connectionString = @"Data Source=HP\MAYAO;Initial Catalog=KhamSucKhoe;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string Status;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetControlStatus(string State)
        {
            switch (State)
            {
                case "RESET":
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = true;
                    btnHuyBo.Enabled = true;
                    btnTimKiem.Enabled = true;
                    chkTimKiemDuLieu.Visible = true;

                    btnTimKiem.Visible = false;
                    chkTimTenDaiDien.Visible = false;
                    txtTimTenDaiDien.Visible = false;
                    chkTimSanPham.Visible = false;
                    cboTimSanPham.Visible = false;

                    txtTenDaiDien.Enabled = false;
                    cboSanPham.Enabled = false;
                    cboMangXaHoi.Enabled = false;
                    txtNoiDung.Enabled = false;
                    txtTimTenDaiDien.Visible = false;
                    cboTimSanPham.Visible = false;
                    break;

                case "INSERT":
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuyBo.Enabled = true;
                    btnTimKiem.Enabled = true;

                    txtTenDaiDien.Enabled = true;
                    cboSanPham.Enabled = true;
                    cboMangXaHoi.Enabled = true;
                    txtNoiDung.Enabled = true;
                    chkTimKiemDuLieu.Visible = false;

                    btnTimKiem.Visible = false;
                    chkTimTenDaiDien.Visible = false;
                    txtTimTenDaiDien.Visible = false;
                    chkTimSanPham.Visible = false;
                    cboTimSanPham.Visible = false;

                    txtTenDaiDien.Text = "";
                    cboSanPham.Text = "";
                    cboMangXaHoi.Text = "";
                    txtNoiDung.Text = "";
                    txtTenDaiDien.Focus();
                    break;

                case "EDIT":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuyBo.Enabled = true;
                    chkTimKiemDuLieu.Visible = false;

                    btnTimKiem.Visible = false;
                    chkTimTenDaiDien.Visible = false;
                    chkTimSanPham.Visible = false;
                    txtTimTenDaiDien.Visible = false;
                    cboTimSanPham.Visible = false;

                    txtTenDaiDien.Enabled = true;
                    cboSanPham.Enabled = true;
                    cboMangXaHoi.Enabled = true;
                    txtNoiDung.Enabled = true;
                    txtTenDaiDien.Focus();
                    break;
            }
        }
        public void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM QUANGCAO";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgvMain.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khamSucKhoeDataSet.QUANGCAO' table. You can move, or remove it, as needed.
            this.qUANGCAOTableAdapter.Fill(this.khamSucKhoeDataSet.QUANGCAO);
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            Status = "RESET";
            SetControlStatus(Status);
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Status = "INSERT";
            SetControlStatus(Status);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Status = "EDIT";
            SetControlStatus(Status);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var resultDelete = MessageBox.Show(" BẠN CÓ MUỐN XÓA KHÔNG ? ", " THÔNG BÁO ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultDelete == DialogResult.Yes)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM QUANGCAO WHERE TENDAIDIEN = N '" + txtTenDaiDien.Text.Trim() + "' ";
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("DELETE SUCCESS");
                    Status = "RESET";
                    SetControlStatus(Status);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("DELETE ERROR");
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Status == "INSERT")
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO QUANGCAO VALUES (N'" + txtTenDaiDien.Text.Trim() + "', N'" + cboSanPham.Text.Trim() + "', N'" + cboMangXaHoi.Text.Trim() + "', N'" + txtNoiDung.Text.Trim() + "')";
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("INSERT SUCCESS");
                    Status = "RESET";
                    SetControlStatus(Status);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("INSERT ERROR");
                }
            }
            else if (Status == "EDIT")
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE QUANGCAO SET SANPHAM = N'" + cboSanPham.Text.Trim() + "', MANGXAHOI = N'" + cboMangXaHoi.Text.Trim() + "', NOIDUNG = N'" + txtNoiDung.Text.Trim() + "' WHERE TENDAIDIEN = N'" + txtTenDaiDien.Text.Trim() + "' ";
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("UPDATE SUCCESS");
                    Status = "RESET";
                    SetControlStatus(Status);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("UPDATE ERROR");
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

            Status = "RESET";
            SetControlStatus(Status);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM QUANGCAO WHERE TENDAIDIEN like  N'%" + txtTimTenDaiDien.Text.Trim() + "%' AND SANPHAM = N'" + cboTimSanPham.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvMain.DataSource = dt;
        }

        private void chkTimKiemDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiemDuLieu.Checked == true)
            {
                chkTimTenDaiDien.Visible = true;
                chkTimSanPham.Visible = true;
            }
            else
            {
                chkTimTenDaiDien.Visible = false;
                chkTimSanPham.Visible = false;
                LoadData();
            }
        }

        private void chkTimTenDaiDien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimTenDaiDien.Checked == true)
            {
                txtTimTenDaiDien.Visible = true;
                txtTimTenDaiDien.Text = "";
                txtTimTenDaiDien.Focus();

                if (chkTimSanPham.Checked == true)
                    btnTimKiem.Visible = true;
                else
                    btnTimKiem.Visible = false;
            }
            else
            {
                txtTimTenDaiDien.Visible = false;
                btnTimKiem.Visible = false;
            }
        }

        private void chkTimSanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimSanPham.Checked == true)
            {
                cboTimSanPham.Visible = true;

                if (chkTimSanPham.Checked == true)
                    btnTimKiem.Visible = true;
                else
                    btnTimKiem.Visible = false;
            }
            else
            {
                cboTimSanPham.Visible = false;
                btnTimKiem.Visible = false;
            }
        }

        private void txtTimTenDaiDien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM QUANGCAO WHERE TENDAIDIEN LIKE '%" + txtTimTenDaiDien.Text.Trim() + "%'";
                    cmd.ExecuteNonQuery();
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgvMain.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void cboTimSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM QUANGCAO WHERE SANPHAM LIKE '%" + cboTimSanPham.Text.Trim() + "%'";
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dgvMain.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvMain.CurrentRow.Index;
            txtTenDaiDien.Text = dgvMain.Rows[i].Cells[0].Value.ToString();
            cboSanPham.Text = dgvMain.Rows[i].Cells[1].Value.ToString();
            cboMangXaHoi.Text = dgvMain.Rows[i].Cells[2].Value.ToString();
            txtNoiDung.Text = dgvMain.Rows[i].Cells[3].Value.ToString();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);//tạo mới một Workbooks bằng phương thức add()
                worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                //xuất danh sách tiêu đề cột
                for (int i = 0; i < dgvMain.ColumnCount; i++)//tạo dòng tiêu đề từ cột trong DataGridView
                {
                    worksheet.Cells[1, i + 1] = dgvMain.Columns[i].HeaderText;
                }
                //xuất danh sách nội dung dòng
                for (int i = 0; i < dgvMain.RowCount; i++)//xuất nội dung các dòng tiếp theo
                {
                    for (int j = 0; j < dgvMain.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = "'" + dgvMain.Rows[i].Cells[j].Value.ToString();
                    }
                }

                //thay đổi độ rộng cột theo dữ liệu - tạo đường khung viền cho bảng
                excelCellrange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[dgvMain.RowCount + 1, dgvMain.ColumnCount]];
                excelCellrange.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;
                //tô màu chữ, màu nền cho dòng đầu tiên
                excelCellrange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgvMain.ColumnCount]];
                excelCellrange.Interior.Color = System.Drawing.Color.Blue;
                excelCellrange.Font.Color = System.Drawing.Color.White;

                workbook.SaveAs(Application.StartupPath + "\\Export\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss_") + "D://");//lưu tập tin
                //workbook.Close();//đóng tập tin
                //excel.Quit();//thoát khỏi excel
                //Process.Start("Explorer.exe", fileName);//mở tập tin trên máy qua đường dẫn
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                worksheet = null;
                workbook = null;
            }
        }
    }
}
