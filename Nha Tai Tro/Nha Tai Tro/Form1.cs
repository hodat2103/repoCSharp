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
using System.IO;

namespace Nha_Tai_Tro
{
    public partial class Form1 : Form
    {
        private static string stringKetNoi = @"Data Source=DESKTOP-E8CIT9F\SQLEXPRESS;Initial Catalog=NHATAITRO;Integrated Security=True";
        SqlConnection connect = new SqlConnection(stringKetNoi);

        private void Reset()
        {
            //mo
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            //khoa
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            txtMaNhaTaiTro.Enabled = true;
            cbbTenNhaTaiTro.Enabled = true;
            cbbLoaiHopDong.Enabled = true;
            txtGiaTriHopDong.Enabled = false;
            txtThongTinLienHe.Enabled = false;
            dtpThoiGianKiHopDong.Enabled = true;
        }

        private void Insert()
        {
            //mo
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //khoa
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

            txtMaNhaTaiTro.Enabled = true;
            cbbTenNhaTaiTro.Enabled = true;
            cbbLoaiHopDong.Enabled = true;
            txtGiaTriHopDong.Enabled = false;
            txtThongTinLienHe.Enabled = false;
            dtpThoiGianKiHopDong.Enabled = true;
        }

        private void Edit()
        {
            //mo
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //khoa
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            txtMaNhaTaiTro.Enabled = false;
            cbbTenNhaTaiTro.Enabled = false;
            cbbLoaiHopDong.Enabled = false;
            txtGiaTriHopDong.Enabled = false;
            txtThongTinLienHe.Enabled = false;
            dtpThoiGianKiHopDong.Enabled = false;
        }
        private void connectNhaTaiTro()
        {
            connect.Open();

            string query = "SELECT * FROM TBLNHATAITRO";

            SqlCommand cmd = new SqlCommand(query, connect);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvNhaTaiTro.DataSource = dt;

            connect.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectNhaTaiTro();
            Edit();
            chkTimKiem_CheckedChanged(sender, e);
            Loadcbb();
            dgvNhaTaiTro.Columns["MANHATAITRO"].HeaderText = "Mã nhà tài trợ";
            dgvNhaTaiTro.Columns["TENNHATAITRO"].HeaderText = "Tên nhà tài trợ";
            dgvNhaTaiTro.Columns["LOAIHOPDONG"].HeaderText = "Loại hợp đồng";
            dgvNhaTaiTro.Columns["GIATRIHOPDONG"].HeaderText = "Giá trị hợp đồng";
            dgvNhaTaiTro.Columns["THONGTINLIENHE"].HeaderText = "Thông tin liên hệ";
            dgvNhaTaiTro.Columns["THOIGIANHOPDONG"].HeaderText = "Thời gian kí hợp đồng";
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNhaTaiTro.Text == "" || cbbTenNhaTaiTro.Text == "" || cbbLoaiHopDong.Text == "" || txtGiaTriHopDong.Text == "" || txtGiaTriHopDong.Text == "" || dtpThoiGianKiHopDong.Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    connect.Open();

                    string query = "INSERT INTO TBLNHATAITRO(MANHATAITRO, TENNHATAITRO, LOAIHOPDONG, GIATRIHOPDONG, THONGTINLIENHE, THOIGIANHOPDONG) VALUES (@MANHATAITRO, @TENNHATAITRO, @LOAIHOPDONG, @GIATRIHOPDONG, @THONGTINLIENHE, @THOIGIANHOPDONG)";

                    SqlCommand cmd = new SqlCommand(query, connect);


                    cmd.Parameters.AddWithValue("@MANHATAITRO", txtMaNhaTaiTro.Text);
                    cmd.Parameters.AddWithValue("@TENNHATAITRO", cbbTenNhaTaiTro.Text);
                    cmd.Parameters.AddWithValue("@LOAIHOPDONG", cbbLoaiHopDong.Text);
                    cmd.Parameters.AddWithValue("@GIATRIHOPDONG", txtGiaTriHopDong.Text);
                    cmd.Parameters.AddWithValue("@THONGTINLIENHE", txtThongTinLienHe.Text);
                    DateTime ThoiGianHopDong = dtpThoiGianKiHopDong.Value;
                    string strThoiGianHopDong = ThoiGianHopDong.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@THOIGIANHOPDONG", strThoiGianHopDong);

                    cmd.ExecuteNonQuery();

                    connect.Close();

                    connectNhaTaiTro();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Trùng ID, vui lòng nhập lại!");
                }
            }
            picLogo.Visible = false;
            Reset();
            MessageBox.Show("Thêm mới thành công");
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhaTaiTro.Text == "" || cbbTenNhaTaiTro.Text == "" || cbbLoaiHopDong.Text == "" || txtGiaTriHopDong.Text == "" || txtGiaTriHopDong.Text == "" || dtpThoiGianKiHopDong.Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                connect.Open();

                string query = "UPDATE TBLNHATAITRO SET MANHATAITRO = @MANHATAITRO, TENNHATAITRO = @TENNHATAITRO, LOAIHOPDONG = @LOAIHOPDONG, GIATRIHOPDONG = @GIATRIHOPDONG, THONGTINLIENHE = @THONGTINLIENHE, THOIGIANHOPDONG = @THOIGIANHOPDONG WHERE MANHATAITRO = @MANHATAITRO";

                SqlCommand cmd = new SqlCommand(query, connect);


                cmd.Parameters.AddWithValue("@MANHATAITRO", txtMaNhaTaiTro.Text);
                cmd.Parameters.AddWithValue("@TENNHATAITRO", cbbTenNhaTaiTro.Text);
                cmd.Parameters.AddWithValue("@LOAIHOPDONG", cbbLoaiHopDong.Text);
                cmd.Parameters.AddWithValue("@GIATRIHOPDONG", txtGiaTriHopDong.Text);
                cmd.Parameters.AddWithValue("@THONGTINLIENHE", txtThongTinLienHe.Text);
                DateTime ThoiGianHopDong = dtpThoiGianKiHopDong.Value;
                string strThoiGianHopDong = ThoiGianHopDong.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@THOIGIANHOPDONG", strThoiGianHopDong);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thông tin thành công");

                connect.Close();

                connectNhaTaiTro();
            }
            Insert();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect.Open();

            string query = "DELETE FROM TBLNHATAITRO WHERE MANHATAITRO = @MANHATAITRO";

            SqlCommand cmd = new SqlCommand(query, connect);

            cmd.Parameters.AddWithValue("@MANHATAITRO", txtMaNhaTaiTro.Text);

            cmd.ExecuteNonQuery();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowIndex = dgvNhaTaiTro.CurrentCell.RowIndex;
                dgvNhaTaiTro.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }

            connect.Close();

            connectNhaTaiTro();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Insert();
            txtMaNhaTaiTro.Text = "";
            cbbTenNhaTaiTro.Text = "";
            cbbLoaiHopDong.Text = "";
            txtGiaTriHopDong.Text = "";
            txtThongTinLienHe.Text = "";
            dtpThoiGianKiHopDong.Value.ToString();
            picLogo.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void chkTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiem.Checked == true)
            {
                chkTimKiemMaNhaTaiTro.Visible = true;
                cbbTimKiemMaNhaTaiTro.Visible = true;
                chkTimKiemThoiGianKiHopDong.Visible = true;
                txtTimKiemThoiGianKiHopDong.Visible = true;
            }
            else
            {
                chkTimKiemMaNhaTaiTro.Visible = false;
                cbbTimKiemMaNhaTaiTro.Visible = false;
                chkTimKiemThoiGianKiHopDong.Visible = false;
                txtTimKiemThoiGianKiHopDong.Visible = false;
            }
            connectNhaTaiTro();
        }
        private void Loadcbb()
        {
            string query = "SELECT MANHATAITRO FROM TBLNHATAITRO";
       
            using (SqlConnection conn = new SqlConnection(stringKetNoi))
            {
                conn.Open();

                SqlCommand cm = new SqlCommand(query, conn);

                SqlDataReader reader = cm.ExecuteReader();

                while (reader.Read())
                {
                    cbbTimKiemMaNhaTaiTro.Items.Add(reader.GetString(0));
                }

                reader.Close();

                cm.Dispose();

                conn.Close();
            }
        }

        private void chkTimKiemMaNhaTaiTro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiemMaNhaTaiTro.Checked == true)
            {
                connect.Open();

                string query = "SELECT * FROM TBLNHATAITRO WHERE MANHATAITRO =@MANHATAITRO ";

                SqlCommand cmd = new SqlCommand(query, connect);

                string Timkiemmanhataitro;

                if (cbbTimKiemMaNhaTaiTro.Text == null)
                {
                    Timkiemmanhataitro = cbbTimKiemMaNhaTaiTro.SelectedItem.ToString();
                }
                else
                {
                    Timkiemmanhataitro = cbbTimKiemMaNhaTaiTro.Text;
                }

                cmd.Parameters.AddWithValue("@MANHATAITRO", Timkiemmanhataitro);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                System.Data.DataTable dt = new System.Data.DataTable();

                adapter.Fill(dt);

                dgvNhaTaiTro.DataSource = dt;

                connect.Close();
            }
            else
            {
                dgvNhaTaiTro.DataSource = null;
            }
        }

        private void chkTimKiemThoiGianKiHopDong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiemThoiGianKiHopDong.Checked == true)
            {

                connect.Open();

                string query = "SELECT * FROM TBLNHATAITRO WHERE THOIGIANHOPDONG =@THOIGIANHOPDONG ";

                SqlCommand cmd = new SqlCommand(query, connect);

                string Timkiemthoigianhopdong;

                Timkiemthoigianhopdong = txtTimKiemThoiGianKiHopDong.Text;

                DateTime.TryParse(Timkiemthoigianhopdong, out DateTime searchDate);

                cmd.Parameters.AddWithValue("@THOIGIANHOPDONG", searchDate);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                System.Data.DataTable dt = new System.Data.DataTable();

                adapter.Fill(dt);

                dgvNhaTaiTro.DataSource = dt;

                connect.Close();
            }
            else
            {
                dgvNhaTaiTro.DataSource = null;
            }
        }

        private void cbbTenNhaTaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenNhaTaiTro.SelectedItem != null)
            {
                string selectedImage = cbbTenNhaTaiTro.SelectedItem.ToString();

                if (selectedImage == "Tập đoàn SCG")
                {
                    string imagePath = @"D:\New folder (2)\Tập đoàn SCG.jpg";

                    if (File.Exists(imagePath))
                    {
                        picLogo.Image = Image.FromFile(imagePath);
                    }
                }
                else if (selectedImage == "Động Lực và thương hiệu Jogarbola")
                {
                    string imagePath = @"D:\New folder (2)\Động Lực và thương hiệu Jogarbola.jpg";

                    if (File.Exists(imagePath))
                    {
                        picLogo.Image = Image.FromFile(imagePath);
                    }
                }
                else
                {
                    picLogo.Image = null;
                }
            }
        }

        private void cbbLoaiHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbbLoaiHopDong.SelectedItem != null)
            {
                string selectOption = cbbLoaiHopDong.SelectedItem.ToString();

                if (selectOption == "Hợp đồng nhà tài trợ chính")
                {
                    if (cbbTenNhaTaiTro.SelectedItem != null)
                    {
                        string select = cbbTenNhaTaiTro.SelectedItem.ToString();

                        if (select == "Tập đoàn SCG")
                        {
                            txtGiaTriHopDong.Text = "30000000000";
                            txtThongTinLienHe.Text = "Số điện thoại: 0-2586-3333, 0-2586-4444; Email: contact@scg.com; website: http://www.scg.co.th/";
                        }
                        else
                        {
                            MessageBox.Show("Thông tin không chính xác. Vui lòng nhập lại!");

                            txtGiaTriHopDong.Text = "";
                            txtThongTinLienHe.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn tên nhà tài trợ!");

                        txtGiaTriHopDong.Text = "";
                        txtThongTinLienHe.Text = "";
                    }
                }
                else if (selectOption == "Hợp đồng nhà tài trợ áo đấu, giày, balo, ...")
                {
                    if (cbbTenNhaTaiTro.SelectedItem != null)
                    {
                        string select = cbbTenNhaTaiTro.SelectedItem.ToString();

                        if (select == "Động Lực và thương hiệu Jogarbola")
                        {
                            txtGiaTriHopDong.Text = "20000000000";
                            txtThongTinLienHe.Text = "Số điện thoại: 18000021; Email: donglucshopvn@gmail.com; website: https://donglucsport.vn/";
                        }
                        else
                        {
                            MessageBox.Show("Thông tin không chính xác. Vui lòng nhập lại!");

                            txtGiaTriHopDong.Text = "";
                            txtThongTinLienHe.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn tên nhà tài trợ!");

                        txtGiaTriHopDong.Text = "";
                        txtThongTinLienHe.Text = "";
                    }
                }
                else
                {

                    txtGiaTriHopDong.Text = "";
                    txtThongTinLienHe.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hợp đồng!");
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvNhaTaiTro.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application bangexcel = new Microsoft.Office.Interop.Excel.Application();
                bangexcel.Application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)bangexcel.ActiveSheet;

                for (int j = 0; j < dgvNhaTaiTro.Columns.Count; j++)
                {
                    string columnName = dgvNhaTaiTro.Columns[j].HeaderText;
                    bangexcel.Cells[1, j + 1] = columnName;
                }

                for (int i = 0; i < dgvNhaTaiTro.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvNhaTaiTro.Columns.Count; j++)
                    {
                        DataGridViewCell cell = dgvNhaTaiTro.Rows[i].Cells[j];
                        if (cell.Value != null)
                        {
                            bangexcel.Cells[i + 2, j + 1] = cell.Value.ToString();
                        }
                        else
                        {
                            bangexcel.Cells[i + 2, j + 1] = string.Empty;
                        }
                    }
                }

                bangexcel.Columns.AutoFit();
                bangexcel.Visible = true;
            }
        }

        private void dgvNhaTaiTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvNhaTaiTro.Rows[e.RowIndex];

                txtMaNhaTaiTro.Text = row.Cells["MANHATAITRO"].Value.ToString();
                cbbTenNhaTaiTro.Text = row.Cells["TENNHATAITRO"].Value.ToString();
                cbbLoaiHopDong.Text = row.Cells["LOAIHOPDONG"].Value.ToString();
                txtGiaTriHopDong.Text = row.Cells["GIATRIHOPDONG"].Value.ToString();
                txtThongTinLienHe.Text = row.Cells["THONGTINLIENHE"].Value.ToString();
                dtpThoiGianKiHopDong.Value = Convert.ToDateTime(row.Cells["THOIGIANHOPDONG"].Value);
            }
            Reset();
        }
    }
}

