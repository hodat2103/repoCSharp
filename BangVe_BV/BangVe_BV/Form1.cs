using Aspose.Words;
using Aspose.Words.Tables;
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
using ThuVienWinform.Report.AsposeWordExtension;

namespace BangVe_BV
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
                    chkTimKiemDuLieu.Enabled = true;

                    btnTimKiem.Visible = false;
                    chkTimNgayThiDau.Visible = false;
                    dtpTimNgayThiDau.Visible = false;
                    chkTimTenKhanDai.Visible = false;
                    cboTimTenKhanDai.Visible = false;

                    txtMaVe.Enabled = false;
                    txtDoiThu.Enabled = false;
                    cboKhanDai.Enabled = false;
                    txtGiaVe.Enabled = false;
                    dtpNgayThiDau.Enabled = false;
                    
                    break;

                case "INSERT":
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuyBo.Enabled = true;
                    btnTimKiem.Enabled = true;

                    txtMaVe.Enabled = true;
                    txtDoiThu.Enabled = true;
                    cboKhanDai.Enabled = true;
                    txtGiaVe.Enabled = true;
                    dtpNgayThiDau.Enabled = true;

                    chkTimKiemDuLieu.Visible = false;
                    btnTimKiem.Visible = false;
                    chkTimNgayThiDau.Visible = false;
                    chkTimTenKhanDai.Visible = false;
                    dtpNgayThiDau.Visible = true;
                    cboKhanDai.Visible = true;

                    txtMaVe.Text = "";
                    txtDoiThu.Text = "";
                    cboKhanDai.Text = "";
                    txtGiaVe.Text = "";
                    txtMaVe.Focus();
                    break;

                case "EDIT":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuyBo.Enabled = true;
                    chkTimKiemDuLieu.Visible = false;

                    btnTimKiem.Visible = false;
                    chkTimNgayThiDau.Visible = false;
                    chkTimTenKhanDai.Visible = false;
                    dtpTimNgayThiDau.Visible = true;
                    cboTimTenKhanDai.Visible = true;

                    txtMaVe.Enabled = false;
                    txtDoiThu.Enabled = true;
                    cboKhanDai.Enabled = true;
                    txtGiaVe.Enabled = true;
                    dtpNgayThiDau.Enabled = true;
                    txtDoiThu.Focus();
                    break;
            }
        }
        public void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM VE";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgvMain.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khamSucKhoeDataSet1.VE' table. You can move, or remove it, as needed.
            this.vETableAdapter.Fill(this.khamSucKhoeDataSet1.VE);
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
            var resultDelete = MessageBox.Show("BẠN CÓ MUỐN XÓA KHÔNG ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultDelete == DialogResult.Yes)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM VE WHERE DOITHU = N'" + txtDoiThu.Text.Trim() + "' ";
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
                DateTime date = dtpNgayThiDau.Value;
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO VE VALUES (N'"+txtMaVe.Text.Trim()+"',N'" + txtDoiThu.Text.Trim() + "', N'" + cboKhanDai.Text.Trim() + "', N'" + txtGiaVe.Text.Trim() + "', '" + date + "')";
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
                DateTime date = dtpNgayThiDau.Value;
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE VE SETDOITHU = N'" + txtDoiThu.Text.Trim() + "', KHANDAI = N'" + cboKhanDai.Text.Trim() + "', GIAVE = '" + txtGiaVe.Text.Trim() + "', NGAYTHIDAU = '" + date + "' WHERE MAVE = N'"+txtMaVe.Text.Trim()+"' ";
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
            DateTime date = dtpTimNgayThiDau.Value;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM VE WHERE NGAYTHIDAU = '" + date + "' AND KHANDAI = N'" + cboTimTenKhanDai.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dgvMain.DataSource = dt;
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvMain.CurrentRow.Index;
            txtDoiThu.Text = dgvMain.Rows[i].Cells[0].Value.ToString();
            cboKhanDai.Text = dgvMain.Rows[i].Cells[1].Value.ToString();
            txtGiaVe.Text = dgvMain.Rows[i].Cells[2].Value.ToString();
            dtpNgayThiDau.Text = (string)dgvMain.Rows[i].Cells[3].Value.ToString();
        }

        private void chkTimKiemDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiemDuLieu.Checked == true)
            {
                chkTimNgayThiDau.Visible = true;
                chkTimTenKhanDai.Visible = true;
            }
            else
            {
                chkTimNgayThiDau.Visible = false;
                chkTimTenKhanDai.Visible = false;
                LoadData();
            }
        }

        private void chkTimTenKhanDai_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimTenKhanDai.Checked == true)
            {
                cboTimTenKhanDai.Visible = true;

                if (chkTimNgayThiDau.Checked == true)
                    btnTimKiem.Visible = true;
                else
                    btnTimKiem.Visible = false;
            }
            else
            {
                cboTimTenKhanDai.Visible = false;
                btnTimKiem.Visible = false;
            }
        }

        private void chkTimNgayThiDau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimNgayThiDau.Checked == true)
            {
                dtpTimNgayThiDau.Visible = true;

                if (chkTimTenKhanDai.Checked == true)
                    btnTimKiem.Visible = true;
                else
                    btnTimKiem.Visible = false;
            }
            else
            {
                dtpTimNgayThiDau.Visible = false;
                btnTimKiem.Visible = false;
            }
        }

        private void cboTimTenKhanDai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM VE WHERE KHANDAI LIKE '%" + cboTimTenKhanDai.Text.Trim() + "%'";
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

        private void dtpTimNgayThiDau_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dtpTimNgayThiDau.Value;
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM VE WHERE NGAYTHIDAU = '" + date + "'";
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
                                                                                                                             //workbook.Close();//đóng tập tin                                                                                                        //excel.Quit();//thoát khỏi excel
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

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document BANG_VE = new Document("Template\\BANG_VE.doc");

            //Bước 2: Điền các thông tin cố định
            BANG_VE.MailMerge.Execute(new[] { "Ngay_Thang_Nam_" }, new[] { string.Format("Hà Nội, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            BANG_VE.MailMerge.Execute(new[] { "Ma_Ve" }, new[] { txtMaVe.Text });
            BANG_VE.MailMerge.Execute(new[] { "Doi_Thu" }, new[] { txtDoiThu.Text });
            BANG_VE.MailMerge.Execute(new[] { "Khan_Dai" }, new[] { cboKhanDai.Text });
            BANG_VE.MailMerge.Execute(new[] { "Gia_Ve" }, new[] { txtGiaVe.Text });
            BANG_VE.MailMerge.Execute(new[] { "Ngay_Thi_Dau" }, new[] { dtpNgayThiDau.Value.ToString("dd/MM/yyyy") });

            //Bước 3: Điền thông tin lên bảng
            Table bangThongTin = BANG_VE.GetChild(NodeType.Table, 1, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            int hangHienTai = 1;
            bangThongTin.InsertRows(hangHienTai, hangHienTai, 3);
            for (int i = 1; i <= 5; i++)
            {
                bangThongTin.PutValue(hangHienTai, 0, i.ToString());//Cột STT
                bangThongTin.PutValue(hangHienTai, 1, "Trung");//Cột Đối Thủ
                bangThongTin.PutValue(hangHienTai, 2, "T1");//Cột Khán Đài
                bangThongTin.PutValue(hangHienTai, 3, "3000000");//Cột Giá Vé
                bangThongTin.PutValue(hangHienTai, 4, "5/3/2022");//Cột Ngày Thi Đấu
                hangHienTai++;
            }

            //Bước 4: Lưu và mở file
            BANG_VE.SaveAndOpenFile("BANG_VE.doc");
        }

    }
}
