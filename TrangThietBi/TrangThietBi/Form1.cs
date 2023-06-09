using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrangThietBi
{
    public partial class Form1 : Form
    {
        private static string stringKetNoi = @"Data Source=DESKTOP-E8CIT9F\SQLEXPRESS;Initial Catalog=TRANGTHIETBI;Integrated Security=True";
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

            txtMaCungCap.Enabled = true;
            cbbTrangThietBi.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            dtpNgayCungCap.Enabled = true;
            txtTongChiPhi.Enabled = false;
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

            txtMaCungCap.Enabled = true;
            cbbTrangThietBi.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            dtpNgayCungCap.Enabled = true;
            txtTongChiPhi.Enabled = false;
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

            txtMaCungCap.Enabled = false;
            cbbTrangThietBi.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            dtpNgayCungCap.Enabled = false;
            txtTongChiPhi.Enabled = false;
        }
        private void connectTrangthietbi()
        {
            connect.Open();

            string query = "SELECT * FROM TBLTRANGTHIETBI";

            SqlCommand cmd = new SqlCommand(query, connect);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new System.Data.DataTable();

            adapter.Fill(dt);

            dgvTrangThietBi.DataSource = dt;

            connect.Close();
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectTrangthietbi();
            Edit();
            chkDuLieu_CheckedChanged(sender, e);
            Loadcbb();
            dgvTrangThietBi.Columns["MACUNGCAP"].HeaderText = "Mã cung cấp";
            dgvTrangThietBi.Columns["TRANGTHIETBI"].HeaderText = "Trang thiết bị";
            dgvTrangThietBi.Columns["SOLUONG"].HeaderText = "Số lượng";
            dgvTrangThietBi.Columns["DONGIA"].HeaderText = "Đơn giá";
            dgvTrangThietBi.Columns["NGAYCUNGCAP"].HeaderText = "Ngày cung cấp";
            dgvTrangThietBi.Columns["TONGCHIPHI"].HeaderText = "Tổng chi phí";
        }

       
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtMaCungCap.Text == "" || cbbTrangThietBi.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "" || dtpNgayCungCap.Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                connect.Open();

                string query = "INSERT INTO TBLTRANGTHIETBI(MACUNGCAP, TRANGTHIETBI, SOLUONG, DONGIA, NGAYCUNGCAP, TONGCHIPHI) VALUES (@MACUNGCAP, @TRANGTHIETBI, @SOLUONG, @DONGIA, @NGAYCUNGCAP, @TONGCHIPHI)";

                SqlCommand cmd = new SqlCommand(query, connect);


                cmd.Parameters.AddWithValue("@MACUNGCAP", txtMaCungCap.Text);
                cmd.Parameters.AddWithValue("@TRANGTHIETBI", cbbTrangThietBi.Text);
                cbbTrangThietBi.Items.Add(cbbTrangThietBi.Text);
                Properties.Settings.Default.Save();
                cmd.Parameters.AddWithValue("@SOLUONG", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@DONGIA", txtDonGia.Text);
                DateTime NgayCungCap = dtpNgayCungCap.Value;
                string strNgayCungCap = NgayCungCap.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@NGAYCUNGCAP", strNgayCungCap);
                string dongia = txtDonGia.Text;
                decimal DONGIA = decimal.Parse(dongia);
                string soluong = txtSoLuong.Text;
                decimal SOLUONG = decimal.Parse(soluong);
                decimal chiphi = (DONGIA) * (SOLUONG);
                cmd.Parameters.AddWithValue("@TONGCHIPHI", chiphi);

                cmd.ExecuteNonQuery();

                connect.Close();

                connectTrangthietbi();
            }
            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMaCungCap.Text == "" || cbbTrangThietBi.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "" || dtpNgayCungCap.Value.ToString() == "" || txtTongChiPhi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                connect.Open();

                string query = "UPDATE TBLTRANGTHIETBI SET MACUNGCAP = @MACUNGCAP, TRANGTHIETBI = @TRANGTHIETBI, SOLUONG = @SOLUONG, DONGIA = @DONGIA, NGAYCUNGCAP = @NGAYCUNGCAP, TONGCHIPHI = @TONGCHIPHI WHERE MACUNGCAP = @MACUNGCAP";

                SqlCommand cmd = new SqlCommand(query, connect);


                cmd.Parameters.AddWithValue("@MACUNGCAP", txtMaCungCap.Text);
                cmd.Parameters.AddWithValue("@TRANGTHIETBI", cbbTrangThietBi.Text);
                cmd.Parameters.AddWithValue("@SOLUONG", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@DONGIA", txtDonGia.Text);
                DateTime NgayCungCap = dtpNgayCungCap.Value;
                string strNgayCungCap = NgayCungCap.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@NGAYCUNGCAP", strNgayCungCap);
                string dongia = txtDonGia.Text;
                decimal DONGIA = decimal.Parse(dongia);
                string soluong = txtSoLuong.Text;
                decimal SOLUONG = decimal.Parse(soluong);
                decimal chiphi = (DONGIA) * (SOLUONG);
                cmd.Parameters.AddWithValue("@TONGCHIPHI", chiphi);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thông tin thành công");

                connect.Close();

                connectTrangthietbi();
            }
            Insert();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect.Open();

            string query = "DELETE FROM TBLTRANGTHIETBI WHERE MACUNGCAP = @MACUNGCAP";

            SqlCommand cmd = new SqlCommand(query, connect);

            cmd.Parameters.AddWithValue("@MACUNGCAP", txtMaCungCap.Text);

            cmd.ExecuteNonQuery();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowIndex = dgvTrangThietBi.CurrentCell.RowIndex;
                dgvTrangThietBi.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }

            connect.Close();

            connectTrangthietbi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Insert();
            txtMaCungCap.Text = "";
            cbbTrangThietBi.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            dtpNgayCungCap.Value.ToString();
            txtTongChiPhi.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cbbTrangThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbTrangThietBi.SelectedItem != null)
            {
                String selectOption = cbbTrangThietBi.SelectedItem.ToString();
                if (selectOption == "Tất")
                {
                    txtDonGia.Text = "200000";
                }
                else if (selectOption == "Giày")
                {
                    txtDonGia.Text = "2000000";
                }
                else if (selectOption == "Bóng")
                {
                    txtDonGia.Text = "1200000";
                }
                else if (selectOption == "Đồ bảo hộ")
                {
                    txtDonGia.Text = "5000000";
                }
                else if (selectOption == "Quần áo đấu")
                {
                    txtDonGia.Text = "800000";
                }
                else if (selectOption == "Găng tay thủ môn")
                {
                    txtDonGia.Text = "1000000";
                }
                else if (selectOption == "Dụng cụ huấn luyện")
                {
                    txtDonGia.Text = "6000000";
                }
                else
                {
                    txtDonGia.Text = "";
                }

            }
            else
            {
                txtDonGia.Text = "";
            }
        }

        private void chkDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuLieu.Checked == true)
            {
                chkTimKiemTheoMaCungCap.Visible = true;
                cbbTimKiemTheoMaCungCap.Visible = true;
                chkTimKiemTheoNgayCungCap.Visible = true;
                txtTimKiemTheoNgayCungCap.Visible = true;
            }
            else
            {
                chkTimKiemTheoMaCungCap.Visible = false;
                cbbTimKiemTheoMaCungCap.Visible = false;
                chkTimKiemTheoNgayCungCap.Visible = false;
                txtTimKiemTheoNgayCungCap.Visible = false;
            }
            connectTrangthietbi();
        }
        private void Loadcbb()
        {
            string query = "SELECT MACUNGCAP FROM TBLTRANGTHIETBI";
            //lay ra thong tin id nguoi dung
            using (SqlConnection conn = new SqlConnection(stringKetNoi))
            {
                conn.Open();

                SqlCommand cm = new SqlCommand(query, conn);

                SqlDataReader reader = cm.ExecuteReader();

                while (reader.Read())
                {
                    cbbTimKiemTheoMaCungCap.Items.Add(reader.GetString(0));
                }

                reader.Close();

                cm.Dispose();

                conn.Close();
            }
        }

        private void chkTimKiemTheoMaCungCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiemTheoMaCungCap.Checked == true)
            {
                connect.Open();

                string query = "SELECT * FROM TBLTRANGTHIETBI WHERE MACUNGCAP =@MACUNGCAP ";

                SqlCommand cmd = new SqlCommand(query, connect);

                string Timkiemmacungcap;

                if (cbbTimKiemTheoMaCungCap.Text == null)
                {
                    Timkiemmacungcap = cbbTimKiemTheoMaCungCap.SelectedItem.ToString();
                }
                else
                {
                    Timkiemmacungcap = cbbTimKiemTheoMaCungCap.Text;
                }

                cmd.Parameters.AddWithValue("@MACUNGCAP", Timkiemmacungcap);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                System.Data.DataTable dt = new System.Data.DataTable();

                adapter.Fill(dt);

                dgvTrangThietBi.DataSource = dt;

                connect.Close();
            }
            else
            {
                dgvTrangThietBi.DataSource = null;
            }
        }

        private void chkTimKiemTheoNgayCungCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimKiemTheoNgayCungCap.Checked == true)
            {

                connect.Open();

                string query = "SELECT * FROM TBLTRANGTHIETBI WHERE NGAYCUNGCAP =@NGAYCUNGCAP ";

                SqlCommand cmd = new SqlCommand(query, connect);

                string Timkiemngaycungcap;

                Timkiemngaycungcap = txtTimKiemTheoNgayCungCap.Text;

                DateTime.TryParse(Timkiemngaycungcap, out DateTime searchDate);

                cmd.Parameters.AddWithValue("@NGAYCUNGCAP", searchDate);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                System.Data.DataTable dt = new System.Data.DataTable();

                adapter.Fill(dt);

                dgvTrangThietBi.DataSource = dt;

                connect.Close();
            }
            else
            {
                dgvTrangThietBi.DataSource = null;
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvTrangThietBi.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application bangexcel = new Microsoft.Office.Interop.Excel.Application();
                bangexcel.Application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)bangexcel.ActiveSheet;

                for (int j = 0; j < dgvTrangThietBi.Columns.Count; j++)
                {
                    string columnName = dgvTrangThietBi.Columns[j].HeaderText;
                    bangexcel.Cells[1, j + 1] = columnName;
                }

                for (int i = 0; i < dgvTrangThietBi.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvTrangThietBi.Columns.Count; j++)
                    {
                        DataGridViewCell cell = dgvTrangThietBi.Rows[i].Cells[j];
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

       

        private void dgvTrangThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvTrangThietBi.CurrentRow;

                txtMaCungCap.Text = row.Cells["MACUNGCAP"].Value.ToString();
                cbbTrangThietBi.Text = row.Cells["TRANGTHIETBI"].Value.ToString();
                txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                txtDonGia.Text = row.Cells["DONGIA"].Value.ToString();
                dtpNgayCungCap.Value = Convert.ToDateTime(row.Cells["NGAYCUNGCAP"].Value);
                txtTongChiPhi.Text = row.Cells["TONGCHIPHI"].Value.ToString();
            }
        }
    }
}
