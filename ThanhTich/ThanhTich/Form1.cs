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

namespace ThanhTich
{
    public partial class Form1 : Form
    {
        private static string stringKetNoi = "Data Source=DESKTOP-E8CIT9F\\SQLEXPRESS;Initial Catalog=THANHTICH;Integrated Security=True";
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

            txtMaGiaiDau.Enabled = true;
            cbbNam.Enabled = true;
            cbbGiaiDau.Enabled = true;
            txtThanhTichDatDuoc.Enabled = true;
            dtpNgayDatGiai.Enabled = true;

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

            txtMaGiaiDau.Enabled = true;
            cbbNam.Enabled = true;
            cbbGiaiDau.Enabled = true;
            txtThanhTichDatDuoc.Enabled = true;

            dtpNgayDatGiai.Enabled = true;

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

            txtMaGiaiDau.Enabled = false;
            cbbNam.Enabled = false;
            cbbGiaiDau.Enabled = false;
            txtThanhTichDatDuoc.Enabled = false;

            dtpNgayDatGiai.Enabled = false;

        }
        private void connectThanhTich()
        {
            connect.Open();

            string query = "SELECT * FROM TBLTHANHTICH";

            SqlCommand cmd = new SqlCommand(query, connect);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvThanhTich.DataSource = dt;

            connect.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            connectThanhTich();
            Edit();
            chkTimKiem_CheckedChanged(sender, e);
            Loadcbb();
            dgvThanhTich.Columns["MAGIAIDAU"].HeaderText = "Mã giải đấu";
            dgvThanhTich.Columns["NAM"].HeaderText = "Năm";
            dgvThanhTich.Columns["GIAIDAU"].HeaderText = "Giải đấu";
            dgvThanhTich.Columns["THANHTICHDATDUOC"].HeaderText = "Thành tích đạt được";
            dgvThanhTich.Columns["NGAYDATGIAI"].HeaderText = "Ngày đạt giải";
        }

    
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaGiaiDau.Text == "" || cbbNam.Text == "" || cbbGiaiDau.Text == "" || txtThanhTichDatDuoc.Text == "" || dtpNgayDatGiai.Value.ToString() == "")
            {

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {

                    connect.Open();

                    string query = "INSERT INTO TBLTHANHTICH (MAGIAIDAU, NAM, GIAIDAU, THANHTICHDATDUOC, NGAYDATGIAI) VALUES (@MAGIAIDAU, @NAM, @GIAIDAU, @THANHTICHDATDUOC, @NGAYDATGIAI)";

                    SqlCommand cmd = new SqlCommand(query, connect);

                    cmd.Parameters.AddWithValue("@MAGIAIDAU", txtMaGiaiDau.Text);
                    cmd.Parameters.AddWithValue("@NAM", cbbNam.Text);
                    cmd.Parameters.AddWithValue("@GIAIDAU", cbbGiaiDau.Text);
                    cmd.Parameters.AddWithValue("@THANHTICHDATDUOC", txtThanhTichDatDuoc.Text);
                    DateTime NgayDatGiai = dtpNgayDatGiai.Value;
                    string strNgayDatGiai = NgayDatGiai.ToString("dd-MM-yyyy");
                    cmd.Parameters.AddWithValue("@NGAYDATGIAI", strNgayDatGiai);

                    cmd.ExecuteNonQuery();

                    connect.Close();

                    connectThanhTich();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Trùng ID, vui lòng nhập lại!");
                }
            }
            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaGiaiDau.Text == "" || cbbNam.Text == "" || cbbGiaiDau.Text == "" || txtThanhTichDatDuoc.Text == "" || dtpNgayDatGiai.Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                connect.Open();

                string query = "UPDATE TBLTHANHTICH SET MAGIAIDAU = @MAGIAIDAU, NAM = @NAM, GIAIDAU = @GIAIDAU, THANHTICHDATDUOC = @THANHTICHDATDUOC, NGAYDATGIAI = @NGAYDATGIAI";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@MAGIAIDAU", txtMaGiaiDau.Text);
                cmd.Parameters.AddWithValue("@NAM", cbbNam.Text);
                cmd.Parameters.AddWithValue("@GIAIDAU", cbbGiaiDau.Text);
                cmd.Parameters.AddWithValue("@THANHTICHDATDUOC", txtThanhTichDatDuoc.Text);
                DateTime NgayDatGiai = dtpNgayDatGiai.Value;
                string strNgayDatGiai = NgayDatGiai.ToString("dd-MM-yyyy");
                cmd.Parameters.AddWithValue("@NGAYDATGIAI", strNgayDatGiai);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thông tin thành công!");

                connect.Close();

                connectThanhTich();
            }
            Insert();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect.Open();

            string query = "DELETE FROM TBLTHANHTICH WHERE MAGIAIDAU = @MAGIAIDAU";

            SqlCommand cmd = new SqlCommand(query, connect);

            cmd.Parameters.AddWithValue("@MAGIAIDAU", txtMaGiaiDau.Text);

            cmd.ExecuteNonQuery();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowIndex = dgvThanhTich.CurrentCell.RowIndex;
                dgvThanhTich.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }

            connect.Close();

            connectThanhTich();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Insert();
            txtMaGiaiDau.Text = "";
            cbbNam.Text = "";
            cbbGiaiDau.Text = "";
            txtThanhTichDatDuoc.Text = "";
            dtpNgayDatGiai.Value.ToString();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cbbGiaiDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGiaiDau.SelectedItem == "Giải bóng đá Cúp Quốc gia")
            {
                String selectOption = cbbNam.SelectedItem.ToString();

                if (selectOption == "2015")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhì";
                }
                else if (selectOption == "2016")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhì";
                }
                else if (selectOption == "2017")
                {
                    txtThanhTichDatDuoc.Text = "Không có hạng";
                }
                else if (selectOption == "2018")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Ba";
                }

                else if (selectOption == "2019")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhất";
                }
                else if (selectOption == "2020")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhất";
                }
                else if (selectOption == "2021")
                {
                    txtThanhTichDatDuoc.Text = "Không đá(dịch bệnh)";
                }
                else if (selectOption == "2022")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhất";
                }
                else
                {
                    txtThanhTichDatDuoc.Text = "";
                }
            }
            else if (cbbGiaiDau.SelectedItem == "Giải bóng đá Vô địch Quốc gia Việt Nam (V. League 1)")
            {
                String selectOption = cbbNam.SelectedItem.ToString();

                if (selectOption == "2015")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhì";
                }
                else if (selectOption == "2016")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhất";
                }
                else if (selectOption == "2017")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Ba";
                }
                else if (selectOption == "2018")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhất";
                }

                else if (selectOption == "2019")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhất";
                }
                else if (selectOption == "2020")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhì";
                }
                else if (selectOption == "2021")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Bảy";
                }
                else if (selectOption == "2022")
                {
                    txtThanhTichDatDuoc.Text = "Hạng Nhất";
                }
                else
                {
                    txtThanhTichDatDuoc.Text = "";
                }
            }
            else
            {
                txtThanhTichDatDuoc.Text = "";
            }
        }

        private void chkTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiem.Checked == true)
            {
                chkTimKiemTheoMaGiaiDau.Visible = true;
                cbbTimKiemTheoMaGiaiDau.Visible = true;
                chkTimKiemTheoNgayDatGiai.Visible = true;
                txtTimKiemTheoNgayDatGiai.Visible = true;
            }
            else
            {
                chkTimKiemTheoMaGiaiDau.Visible = false;
                cbbTimKiemTheoMaGiaiDau.Visible = false;
                chkTimKiemTheoNgayDatGiai.Visible = false;
                txtTimKiemTheoNgayDatGiai.Visible = false;
            }
            connectThanhTich();
        }
        private void Loadcbb()
        {
            string query = "SELECT MAGIAIDAU FROM TBLTHANHTICH";
            //lay ra thong tin id nguoi dung
            using (SqlConnection conn = new SqlConnection(stringKetNoi))
            {
                conn.Open();

                SqlCommand cm = new SqlCommand(query, conn);

                SqlDataReader reader = cm.ExecuteReader();

                while (reader.Read())
                {
                    cbbTimKiemTheoMaGiaiDau.Items.Add(reader.GetString(0));
                }

                reader.Close();

                cm.Dispose();

                conn.Close();
            }
        }

        private void chkTimKiemTheoMaGiaiDau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiemTheoMaGiaiDau.Checked == true)
            {
                connect.Open();

                string query = "SELECT * FROM TBLTHANHTICH WHERE MAGIAIDAU =@MAGIAIDAU ";

                SqlCommand cmd = new SqlCommand(query, connect);

                string TimKiemTheoMaGiaiDau;

                if (cbbTimKiemTheoMaGiaiDau.Text == null)
                {
                    TimKiemTheoMaGiaiDau = cbbTimKiemTheoMaGiaiDau.SelectedItem.ToString();
                }
                else
                {
                    TimKiemTheoMaGiaiDau = cbbTimKiemTheoMaGiaiDau.Text;
                }

                cmd.Parameters.AddWithValue("@MAGIAIDAU", TimKiemTheoMaGiaiDau);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                System.Data.DataTable dt = new System.Data.DataTable();

                adapter.Fill(dt);

                dgvThanhTich.DataSource = dt;

                connect.Close();
            }
            else
            {
                dgvThanhTich.DataSource = null;
            }
        }

        private void chkTimKiemTheoNgayDatGiai_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiemTheoNgayDatGiai.Checked == true)
            {

                connect.Open();

                string query = "SELECT * FROM TBLTHANHTICH WHERE NGAYDATGIAI =@NGAYDATGIAI ";

                SqlCommand cmd = new SqlCommand(query, connect);

                string TimKiemTheoNgayDatGiai;

                TimKiemTheoNgayDatGiai = txtTimKiemTheoNgayDatGiai.Text;

                DateTime.TryParse(TimKiemTheoNgayDatGiai, out DateTime searchDate);

                cmd.Parameters.AddWithValue("@NGAYDATGIAI", searchDate);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                System.Data.DataTable dt = new System.Data.DataTable();

                adapter.Fill(dt);

                dgvThanhTich.DataSource = dt;

                connect.Close();
            }
            else
            {
                dgvThanhTich.DataSource = null;
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvThanhTich.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application bangexcel = new Microsoft.Office.Interop.Excel.Application();
                bangexcel.Application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)bangexcel.ActiveSheet;

                for (int j = 0; j < dgvThanhTich.Columns.Count; j++)
                {
                    string columnName = dgvThanhTich.Columns[j].HeaderText;
                    bangexcel.Cells[1, j + 1] = columnName;
                }

                for (int i = 0; i < dgvThanhTich.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvThanhTich.Columns.Count; j++)
                    {
                        DataGridViewCell cell = dgvThanhTich.Rows[i].Cells[j];
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

        private void dgvThanhTich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvThanhTich.CurrentRow;

                txtMaGiaiDau.Text = row.Cells["MAGIAIDAU"].Value.ToString();
                cbbNam.Text = row.Cells["NAM"].Value.ToString();
                cbbGiaiDau.Text = row.Cells["GIAIDAU"].Value.ToString();
                txtThanhTichDatDuoc.Text = row.Cells["THANHTICHDATDUOC"].Value.ToString();

                dtpNgayDatGiai.Value = Convert.ToDateTime(row.Cells["NGAYDATGIAI"].Value);

            }
        }
    }
}
