using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_DoiMatKhau
{
    public partial class Form1 : Form
    {

        private static string stringKetNoi = @"Data Source=DESKTOP-EBFVT45\SQLSERVER;Initial Catalog=DEMO_DOIMATKHAU;Integrated Security=True";
        SqlConnection Connect = new SqlConnection(stringKetNoi);

        private void Reset()
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLaiMKM.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTaiKhoan.Text;
            string mkCu = txtMatKhauCu.Text;
            string mkMoi = txtMatKhauMoi.Text;
            string nhaplaiMKM = txtNhapLaiMKM.Text;

                if(txtTenTaiKhoan.Text == "" || txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLaiMKM.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    Reset();
                    return;
                }

                if (mkCu == mkMoi)
                {
                    MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ");
                    Reset();
                    return;

                }
                if (nhaplaiMKM != mkMoi)
                {
                    MessageBox.Show("Xác nhận mật khẩu mới không đúng");
                    Reset();
                    return;

                }

                if (!KiemTraDangNhap(tenTK, mkCu))
                {
                    MessageBox.Show("Tên tài khoản và mật khẩu cũ không đúng");
                    Reset();
                    return;
                }

                if (!IsValidPassword(mkMoi))
                {
                    MessageBox.Show("Mật khẩu mới không hợp lệ. Mật khẩu phải chứa ít nhất 8 ký tự, có ít nhất một ký tự viết hoa, một số và một ký tự đặc biệt");
                    Reset();
                    return;
                }

                if (CapNhatMK(tenTK, mkMoi))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Không đổi được mật khẩu");
                }

                Reset();
            }

            private bool KiemTraDangNhap(string tenTK, string mkCu)
            {
                return (tenTK == "Nhom5" && mkCu == "123456");
            }

        private bool CapNhatMK(string tenTK, string mkMoi)
        {
            try
            {
                Connect.Open();

                string query = "UPDATE DOIMATKHAU SET MATKHAUMOI = @MATKHAUMOI WHERE TENTAIKHOAN = @TENTAIKHOAN";

                using (SqlCommand sqlCommand = new SqlCommand(query, Connect))
                {
                    sqlCommand.Parameters.AddWithValue("@TENTAIKHOAN", tenTK);
                    sqlCommand.Parameters.AddWithValue("@MATKHAUMOI", mkMoi);

                    int row = sqlCommand.ExecuteNonQuery();

                    return row > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật mật khẩu: " + ex.Message);
                return false;
            }
            finally
            {
                Connect.Close();
            }
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btneye1_Click(object sender, EventArgs e)
        {
            if(txtMatKhauCu.PasswordChar == '*')
            {
                btneyehide1.BringToFront();
                txtMatKhauCu.PasswordChar = '\0';
            }
        }

        private void btneyehide1_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.PasswordChar == '\0')
            {
                btneye1.BringToFront();
                txtMatKhauCu.PasswordChar = '*';
            }
        }

        private void btneye_Click(object sender, EventArgs e)
        {
            if(txtMatKhauCu.PasswordChar == '*')
            {
                btneyehide.BringToFront();
                txtMatKhauCu.PasswordChar= '\0';
            }
        }

        private void btneyehide_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.PasswordChar == '\0')
            {
                btneye.BringToFront();
                txtMatKhauCu.PasswordChar = '*';
            }
        }

        private void btneye1_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == '*')
            {
                btneyehide1.BringToFront();
                txtMatKhauMoi.PasswordChar = '\0';
            }
        }

        private void btneyehide1_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == '\0')
            {
                btneye1.BringToFront();
                txtMatKhauMoi.PasswordChar = '*';
            }
        }

        private void btneye2_Click(object sender, EventArgs e)
        {
            if (txtNhapLaiMKM.PasswordChar == '*')
            {
                btneyehide2.BringToFront();
                txtNhapLaiMKM.PasswordChar = '\0';
            }
        }

        private void btneyehide2_Click(object sender, EventArgs e)
        {
            if (txtNhapLaiMKM.PasswordChar == '\0')
            {
                btneye2.BringToFront();
                txtNhapLaiMKM.PasswordChar = '*';
            }
        }
    }
}
