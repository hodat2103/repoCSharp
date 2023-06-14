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
using ThuVienWinform.Report.ExtensionMethod;
using Word = Microsoft.Office.Interop.Word;

namespace KhamSucKhoe1
{
    public partial class Form1 : Form //"partial" cho phép lớp này chia nhiều phần định nghĩa trong các file khác nhau.
    {
        SqlConnection conn; //đối tượng kết nối đến csdl máy chủ SQL
        SqlCommand cmd; //đối tượng thực thi các câu lệnh SQL trên csdl.
        public static string connectionString = @"Data Source=HP\MAYAO;Initial Catalog=KhamSucKhoe;Integrated Security=True"; //chuỗi kết nối đến csdl.
        SqlDataAdapter da = new SqlDataAdapter(); // đối tượng thực hiện các thao tác trên csdl, như thêm, sửa, xóa và truy vấn dữ liệu.
        DataTable dt = new DataTable(); // đối tượng lưu trữ dữ liệu trả về từ csdl.
        string Status; // Biến lưu trữ trạng thái của một đối tượng.

        //KẾT NỐI MÁY CHỦ - THỰC THI CÂU LỆNH - CHUỖI KẾT NỐI - TRUY VẤN DỮ LIỆU - LƯU TRỮ BIẾN TRẢ VỀ - BIẾN LƯU TRẠNG THÁI.

        // SqlConnection conn;
        // Sql Command cmd;
        // public static string connectionString = "";
        // SqlDataTable da = new SqlDataAdapter();
        // DataTable dt = new DataTable();
        // string Status;

        public Form1()
        {
            InitializeComponent();
        }
        public void SetControlStatus(string State) //Phương thức này ktra gtrị của tham số State câu lệnh switch-case.
                                                   //Nếu gtrị State là "RESET", các control sẽ được đặt lại về trạng thái ban đầu.
                                                   //Nếu gtrị State là "INSERT", các control sẽ được thiết lập để cho phép thêm mới bản ghi vào csdl.
                                                   //Nếu gtrị State là "EDIT", các control sẽ được thiết lập để cho phép chỉnh sửa bản ghi được chọn từ csdl.
        {
            switch (State) //Tham số State 
            {
                case "RESET":
                    //Các control đc thiết lập bao gồm các button, combobox, checkbox, textbox, datetimepicker.
                    btnThem.Enabled = true; 
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = true;
                    btnHuyBo.Enabled = true;

                    chkTimKiemDuLieu.Visible = true; //visible khi false sẽ mất hẳn, enabled khi false vẫn còn mờ
                    btnTimKiem.Visible = false;
                    chkTimTenCauThu.Visible = false;
                    chkTimNgayKham.Visible = false;
                    txtTimTenCauThu.Visible = false;
                    dtpTimNgayKham.Visible = false;

                    txtTenCauThu.Enabled = false;
                    txtTenNVBacSi.Enabled = false;
                    dtpNgayKham.Enabled = false;
                    cboKhoa.Enabled = false;
                    txtTinhTrang.Enabled = false;
                    txtTGBinhPhuc.Enabled = false;
                    break;

                case "INSERT":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuyBo.Enabled = true;
                    btnTimKiem.Enabled = true;

                    txtTenCauThu.Enabled = true;
                    txtTenNVBacSi.Enabled = true;
                    dtpNgayKham.Enabled = true;
                    cboKhoa.Enabled = true;
                    txtTinhTrang.Enabled = true;
                    txtTGBinhPhuc.Enabled = true;
                    chkTimKiemDuLieu.Visible = false;

                    btnTimKiem.Enabled = false;
                    chkTimTenCauThu.Enabled = false;
                    chkTimNgayKham.Enabled = false;
                    txtTimTenCauThu.Enabled = false;
                    dtpTimNgayKham.Enabled = false;

                    txtTenCauThu.Text = "";
                    txtTenNVBacSi.Text = "";
                    cboKhoa.Text = "";
                    txtTinhTrang.Text = "";
                    txtTGBinhPhuc.Text = "";
                    txtTenCauThu.Focus(); //giúp người dùng có thể bắt đầu nhập liệu vào control này mà không phải click vào nó.
                    break;

                case "EDIT":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuyBo.Enabled = true;

                    chkTimKiemDuLieu.Visible = false;
                    btnTimKiem.Visible = false;
                    chkTimTenCauThu.Visible = false;
                    chkTimNgayKham.Visible = false;
                    txtTimTenCauThu.Visible = false;
                    dtpTimNgayKham.Visible = false;

                    txtTenCauThu.Enabled = false;
                    txtTenNVBacSi.Enabled = true;
                    dtpNgayKham.Enabled = true;
                    cboKhoa.Enabled = true;
                    txtTinhTrang.Enabled = true;
                    txtTGBinhPhuc.Enabled = true;
                    break;
            }
        }

        public void LoadData()
        {
            cmd = conn.CreateCommand(); //Tạo đối tượng Command (cmd) từ đối tượng kết nối (conn) đã được khởi tạo.
            cmd.CommandText = "SELECT * FROM YTE"; //câu lệnh lấy tất cả các bản ghi từ bảng YTE trong csdl.
            da.SelectCommand = cmd; //Tạo đối tượng DataAdapter (da) với câu lệnh SQL được chỉ định trong đối tượng Command.
            dt.Clear(); //Xóa bỏ tất cả các bản ghi hiện có trong DataTable (dt).
            da.Fill(dt); // Phương thức để đưa dữ liệu từ csdl vào DataTable.
            dgvMain.DataSource = dt; // Gán DataTable vào DataSource của DataGridView để hiển thị dữ liệu lên giao diện người dùng.
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khamSucKhoeDataSet.YTE' table. You can move, or remove it, as needed.
             //tải dữ liệu từ bảng YTE trong cơ sở dữ liệu vào trong DataSet.
            conn = new SqlConnection(connectionString); //Khởi tạo đối tượng SqlConnection(conn) với chuỗi kết nối(connectionString) đã được khai báo.
            if (conn.State == ConnectionState.Closed) //Kiểm tra trạng thái kết nối hiện tại của đối tượng SqlConnection.
                                                      //Nếu trạng thái là Closed, mở kết nối bằng phương thức conn.Open().
            {
                conn.Open();
            }
            Status = "RESET"; //Khởi tạo để đặt trạng thái ban đầu của các control trên form.
            SetControlStatus(Status); //Thiết lập trạng thái của các control trên form tùy vào giá trị của biến Status.
            LoadData(); // Tải dữ liệu từ csdl lên DataGridView.
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
            var resultDelete = MessageBox.Show(" BẠN CÓ MUỐN XÓA KHÔNG ? ", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultDelete == DialogResult.Yes) //Hiển thị hộp thoại xác nhận, nếu Yes thì tiếp tục thực hiện các bước tiếp theo để xoá
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM YTE WHERE TENCAUTHU = '" + txtTenCauThu.Text + "' ";
                var result = cmd.ExecuteNonQuery(); //thực thi câu lệnh SQL và lấy số bản ghi bị ảnh hưởng.
                if (result > 0) //Nếu số bản ghi bị ảnh hưởng > 0, tức câu lệnh SQL đã xóa thành công ít nhất một bản ghi từ bảng YTE.
                {
                    MessageBox.Show("DELETE SUCESS");
                    Status = "RESET"; //reset trạng thái của các control trên form
                    SetControlStatus(Status);//tải lại dữ liệu lên DataGridView bằng phương thức LoadData().
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
                DateTime date = dtpNgayKham.Value; //Dòng lệnh trên khai báo biến date kiểu DateTime, gán cho nó gtrị thuộc tính Value của đối tượng DateTimePicker (dtpNgayKham).
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO YTE VALUES (N'" + txtTenCauThu.Text.Trim() + "',N'" + txtTenNVBacSi.Text.Trim() + "', '" + date + "', N'" + cboKhoa.Text.Trim() + "', N'" + txtTinhTrang.Text.Trim() + "', N'" + txtTGBinhPhuc.Text.Trim() + "')";
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
                DateTime date = dtpNgayKham.Value;
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE YTE SET TENNVBACSI = N'" + txtTenNVBacSi.Text.Trim() + "', NGAYKHAM = '" + date + "', KHOA = N'" + cboKhoa.Text.Trim() + "', TINHTRANG = N'" + txtTinhTrang.Text.Trim() + "', TGBINHPHUC = N'" + txtTGBinhPhuc.Text.Trim() + "' WHERE TENCAUTHU = N'" + txtTenCauThu.Text.Trim() + "' ";
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
            DateTime date = dtpTimNgayKham.Value;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM YTE WHERE TENCAUTHU LIKE N'%" + txtTimTenCauThu.Text.Trim() + "%' AND NGAYKHAM = '" + date + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader(); //đọc các bản ghi trả về từ câu lệnh SQL.
            DataTable dt = new DataTable(); //Tạo một đối tượng DataTable (dt)
            dt.Load(rd); // đọc các bản ghi từ đối tượng SqlDataReader và đổ vào DataTable dt.
            dgvMain.DataSource = dt; //Gán DataTable dt vào thuộc tính DataSource của DataGridView dgvMain để hiển thị các bản ghi tìm được trên DataGridView.
        }


        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvMain.CurrentRow.Index; //Lấy chỉ số của bản ghi được chọn bằng cách gọi thuộc tính CurrentRow.Index của đối tượng DataGridView dgvMain.
            txtTenCauThu.Text = dgvMain.Rows[i].Cells[0].Value.ToString(); //Tótring(): chuyển đổi đối tượng thành chuỗi.
            txtTenNVBacSi.Text = dgvMain.Rows[i].Cells[1].Value.ToString();
            dtpNgayKham.Text = dgvMain.Rows[i].Cells[2].Value.ToString();
            cboKhoa.Text = dgvMain.Rows[i].Cells[3].Value.ToString();
            txtTinhTrang.Text = dgvMain.Rows[i].Cells[4].Value.ToString();
            txtTGBinhPhuc.Text = dgvMain.Rows[i].Cells[5].Value.ToString();
        }


        private void chkTimKiemDuLieu_CheckedChanged(object sender, EventArgs e)
        {

            if (chkTimKiemDuLieu.Checked == true)
            {
                chkTimTenCauThu.Visible = true;
                chkTimNgayKham.Visible = true;
            }
            else
            {
                chkTimTenCauThu.Visible = false;
                chkTimNgayKham.Visible = false;
                LoadData();
            }
        }


        private void chkTimTenCauThu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimTenCauThu.Checked == true)
            {
                txtTimTenCauThu.Visible = true;
                txtTimTenCauThu.Text = "";
                txtTimTenCauThu.Focus();

                if (chkTimNgayKham.Checked == true)
                    btnTimKiem.Visible = true;
                else
                    btnTimKiem.Visible = false;
            }
            else
            {
                txtTimTenCauThu.Visible = false;
                btnTimKiem.Visible = false;
            }
        }


        private void chkTimNgayKham_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimNgayKham.Checked == true)
            {
                dtpTimNgayKham.Visible = true;

                if (chkTimTenCauThu.Checked == true)
                    btnTimKiem.Visible = true;
                else
                    btnTimKiem.Visible = false;
            }
            else
            {
                dtpTimNgayKham.Visible = false;
                btnTimKiem.Visible = false;
            }
        }


        private void txtTimTenCauThu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM YTE WHERE TENCAUTHU LIKE '%" + txtTimTenCauThu.Text.Trim() + "%'";
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


        private void dtpTimNgayKham_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dtpTimNgayKham.Value;
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM YTE WHERE NGAYKHAM = '" + date + "'";
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

        private void btnXuatWord_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvMain.SelectedCells[0].RowIndex; //là một tập hợp các ô (cells) đang đc chọn trong Datagridview "dgvMain".x

                string TenCauThu = dgvMain.Rows[rowIndex].Cells["TENCAUTHU"].Value?.ToString();
                string TenNVBacSi = dgvMain.Rows[rowIndex].Cells["TENNVBACSI"].Value?.ToString();
                string NgayKham = dgvMain.Rows[rowIndex].Cells["NGAYKHAM"].Value?.ToString();
                string Khoa = dgvMain.Rows[rowIndex].Cells["KHOA"].Value?.ToString();
                string TinhTrang = dgvMain.Rows[rowIndex].Cells["TINHTRANG"].Value?.ToString();
                string TGBinhPhuc = dgvMain.Rows[rowIndex].Cells["TGBINHPHUC"].Value?.ToString();
            
            string filePath = @"D:\This Document all dead\Word\PKSK.docx";
            if (File.Exists(filePath))
            {
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = true;
                Word.Document doc = wordApp.Documents.Add(filePath);

                FindAndReplace(wordApp, "<<TENCAUTHU>>", TenCauThu);
                FindAndReplace(wordApp, "<<TENNVBACSI>>", TenNVBacSi);
                FindAndReplace(wordApp, "<<NGAYKHAM>>", NgayKham);
                FindAndReplace(wordApp, "<<KHOA>>", Khoa);
                FindAndReplace(wordApp, "<<TINHTRANG>>", TinhTrang);
                FindAndReplace(wordApp, "<<TGBINHPHUC>>", TGBinhPhuc);
            }
            else{
                MessageBox.Show("Không tìm thấy tệp: " + filePath);
            }
        }
        private void FindAndReplace(Word.Application wordApp, string findText, string replaceText)
        {
            object missing = Type.Missing;
            object replaceObject = Word.WdReplace.wdReplaceAll;
            wordApp.Selection.Find.ClearFormatting();
            wordApp.Selection.Find.Execute(findText, missing, missing, missing, missing, missing, missing, missing, missing, replaceText, replaceObject, missing, missing, missing, missing);
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


   



 
    
        
