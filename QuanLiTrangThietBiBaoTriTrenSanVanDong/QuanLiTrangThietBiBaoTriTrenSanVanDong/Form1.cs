using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiTrangThietBiBaoTriTrenSanVanDong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String chuoiketnoi = @"Data Source=KIENPC;Initial Catalog=C#;Integrated Security=True";
        String sql;
        SqlConnection con;//ketnoi
        SqlCommand cmd;//thuchien
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        String status;
        void Loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select*from thietbibaotri";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dtmain.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(chuoiketnoi);
            con.Open();
            chktimdulieu_CheckedChanged(sender, e);
            status = "Hienthi";
            Choose(status);
            Loaddata();

        }
        public void Choose(string status)
        {
            switch (status)
            {
                case "Hienthi":
                    txtmathietbi.Enabled = false;
                    cbtrangthietbi.Enabled = false;
                    dtpngay.Enabled = false;
                    txtsoluongtrangthietbi.Enabled = false;
                    txtngansachbaotri.Enabled = false;
                    txtthanhtien.Enabled = false;
                    txttencongtybaotri.Enabled = false;
                    txtsoluongnhanvien.Enabled = false;
                    txtngansachnhanvien.Enabled = false;
                    txttiennhanvien.Enabled = false;
                    txtnhataitro.Enabled = false;

                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = false;
                    btnhuy.Enabled = true;

                    chktimthietbi.Enabled = false;
                    chktimdulieu.Enabled = true;
                    chktimngay.Enabled = false;
                    cbtimtranthietbi.Enabled = false;
                    dtptimngay.Enabled = false;
                    btntimkiem.Enabled = false;
                    btntimkiemngay.Enabled = false;
                    break;
                case "Them":
                    txtmathietbi.Enabled = true;
                    cbtrangthietbi.Enabled = true;
                    dtpngay.Enabled = true;
                    txtsoluongtrangthietbi.Enabled = true;
                    txtngansachbaotri.Enabled = true;
                    txtthanhtien.Enabled = true;
                    txttencongtybaotri.Enabled = true;
                    txtsoluongnhanvien.Enabled = true;
                    txtngansachnhanvien.Enabled = true;
                    txttiennhanvien.Enabled = true;
                    txtnhataitro.Enabled = true;

                    btnthem.Enabled = true;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnluu.Enabled = true;
                    btnhuy.Enabled = true;


                    chktimthietbi.Enabled = false;
                    chktimdulieu.Enabled = false;
                    chktimngay.Enabled = false;
                    cbtimtranthietbi.Enabled = false;
                    dtptimngay.Enabled = false;
                    btntimkiem.Enabled = false;
                    btntimkiemngay.Enabled = false;
                    txtmathietbi.Focus();
                    cbtrangthietbi.Text = " ";
                    
                    txtsoluongtrangthietbi.Text = " ";
                    txtngansachbaotri.Text=" ";
                    txtthanhtien.Text=" ";
                    txttencongtybaotri.Text = " ";
                    txtsoluongnhanvien.Text = " ";
                    txtngansachnhanvien.Text = " ";
                    txttiennhanvien.Text = " ";
                    txtnhataitro.Text = " ";

                    break;
                case "Sua":
                    txtmathietbi.Enabled = true;
                    cbtrangthietbi.Enabled = true;
                    dtpngay.Enabled = true;
                    txtsoluongtrangthietbi.Enabled = true;
                    txtngansachbaotri.Enabled = true;
                    txtthanhtien.Enabled = true;
                    txttencongtybaotri.Enabled = true;
                    txtsoluongnhanvien.Enabled = true;
                    txtngansachnhanvien.Enabled = true;
                    txttiennhanvien.Enabled = true;
                    txtnhataitro.Enabled = true;

                    btnthem.Enabled = false;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnluu.Enabled = true;
                    btnhuy.Enabled = true;


                    chktimthietbi.Enabled = false;
                    chktimdulieu.Enabled = false;
                    chktimngay.Enabled = false;
                    cbtimtranthietbi.Enabled = false;
                    dtptimngay.Enabled = false;
                    btntimkiem.Enabled = false;
                    btntimkiemngay.Enabled = false;
                    break;
                case "Timkiem":
                    txtmathietbi.Enabled = false;
                    cbtrangthietbi.Enabled = false;
                    dtpngay.Enabled = false;
                    txtsoluongtrangthietbi.Enabled = false;
                    txtngansachbaotri.Enabled = false;
                    txtthanhtien.Enabled = false;
                    txttencongtybaotri.Enabled = false;
                    txtsoluongnhanvien.Enabled = false;
                    txtngansachnhanvien.Enabled = false;
                    txttiennhanvien.Enabled = false;
                    txtnhataitro.Enabled = false;

                    btnthem.Enabled = false;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnluu.Enabled = false;
                    btnhuy.Enabled = true;

                    chktimthietbi.Enabled = true;
                    chktimdulieu.Enabled = true;
                    chktimngay.Enabled = true;
                    cbtimtranthietbi.Enabled = true;
                    dtptimngay.Enabled = true;
                    btntimkiem.Enabled = true;
                    btntimkiemngay.Enabled = true;
                    break;
                case "Xoa":
                    txtmathietbi.Enabled = true;
                    cbtrangthietbi.Enabled = true;
                    dtpngay.Enabled = true;
                    txtsoluongtrangthietbi.Enabled = true;
                    txtngansachbaotri.Enabled = true;
                    txtthanhtien.Enabled = true;
                    txttencongtybaotri.Enabled = true;
                    txtsoluongnhanvien.Enabled = true;
                    txtngansachnhanvien.Enabled = true;
                    txttiennhanvien.Enabled = true;
                    txtnhataitro.Enabled = true;

                    btnthem.Enabled = false;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = false;
                    btnhuy.Enabled = true;


                    chktimthietbi.Enabled = false;
                    chktimdulieu.Enabled = false;
                    chktimngay.Enabled = false;
                    cbtimtranthietbi.Enabled = false;
                    dtptimngay.Enabled = false;
                    btntimkiem.Enabled = false;
                    btntimkiemngay.Enabled = false;
                    break;
            }

        }
       
   
        private void btnthem_Click(object sender, EventArgs e)
        {
            status = "Them";
            Choose(status);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            status = "Sua";
            Choose(status);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            status = "Xoa";
            Choose(status);
            try
            {
                var result = MessageBox.Show("Bạn có muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(chuoiketnoi);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd = con.CreateCommand();
                    cmd.CommandText = "Delete from thietbibaotri where MaTBBT =N'" +txtmathietbi.Text.Trim() + "'";
                    var resultDelete = cmd.ExecuteNonQuery();
                    Loaddata();
                    if (resultDelete > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa lỗi!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (status == "Them")
            {
                if (txtmathietbi.Text.Equals("") || cbtrangthietbi.Text.Equals("") || txtsoluongtrangthietbi.Text.Equals("") || txtngansachbaotri.Text.Equals("") || txtthanhtien.Text.Equals("") || txttencongtybaotri.Text.Equals("") || txtsoluongnhanvien.Text.Equals("") || txtngansachnhanvien.Text.Equals("") || txttiennhanvien.Text.Equals("")|| txtnhataitro.Text.Equals(""))
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                    return;
                }
                else
                {
                    float SoLuongThietBi = 0;
                    if (!float.TryParse(txtsoluongtrangthietbi.Text, out SoLuongThietBi))
                    {
                        MessageBox.Show("Số lượng thiết bị không hợp lệ", "Thông báo");
                        return;
                    }
                    decimal NganSachBaoTri = 0;
                    if (!decimal.TryParse(txtngansachbaotri.Text, out NganSachBaoTri))
                    {
                        MessageBox.Show("Ngân sách bảo trì không hợp lệ", "Thông báo");
                        return;
                    }
                    decimal ThanhTienTrangThietBi = 0;
                    if (!decimal.TryParse(txtthanhtien.Text, out ThanhTienTrangThietBi))
                    {
                        MessageBox.Show("Thành tiền trang thiết bị không hợp lệ", "Thông báo");
                        return;
                    }
                    float SoLuongNhanVien = 0;
                    if (!float.TryParse(txtsoluongnhanvien.Text, out SoLuongNhanVien))
                    {
                        MessageBox.Show("Số lượng nhân viên không hợp lệ", "Thông báo");
                        return;
                    }
                    decimal nganSachNhanVien = 0;
                    if (!decimal.TryParse(txtngansachnhanvien.Text, out nganSachNhanVien))
                    {
                        MessageBox.Show("Ngân sách nhân viên không hợp lệ", "Thông báo");
                        return;
                    }
                    decimal thanhTienChoNhanVien = 0;
                    if (!decimal.TryParse(txttiennhanvien.Text, out thanhTienChoNhanVien))
                    {
                        MessageBox.Show("Thành tiền cho nhân viên không hợp lệ", "Thông báo");
                        return;
                    }


                    SqlCommand cmd = new SqlCommand("INSERT INTO thietbibaotri (MaTBBT, TrangThietBiCanBaoTri, ThoiGianBaoTri, SoLuongThietBi, NganSachBaoTri, ThanhTienTrangThietBi, TenCongTyBaoTri, SoLuongNhanVien, NganSachNhanVien, ThanhTienChoNhanVien, nhataitro) VALUES (@MaTBBT, @TrangThietBiCanBaoTri, @ThoiGianBaoTri, @SoLuongThietBi, @NganSachBaoTri, @ThanhTienTrangThietBi, @TenCongTyBaoTri, @SoLuongNhanVien, @NganSachNhanVien, @ThanhTienChoNhanVien,@nhataitro)", con);
                    cmd.Parameters.AddWithValue("@MaTBBT", txtmathietbi.Text);
                    cmd.Parameters.AddWithValue("@TrangThietBiCanBaoTri", cbtrangthietbi.Text);
                    DateTime ThoiGianBaoTri = dtpngay.Value;
                    String strThoiGianBaoTri = ThoiGianBaoTri.ToString("yyyy/MM/dd");
                    cmd.Parameters.AddWithValue("@ThoiGianBaoTri", strThoiGianBaoTri);
                    cmd.Parameters.AddWithValue("@SoLuongThietBi", txtsoluongtrangthietbi.Text);
                    cmd.Parameters.AddWithValue("@NganSachBaoTri", txtngansachbaotri.Text);
                    cmd.Parameters.AddWithValue("@ThanhTienTrangThietBi", txtthanhtien.Text);
                    cmd.Parameters.AddWithValue("@TenCongTyBaoTri", txttencongtybaotri.Text);
                    cmd.Parameters.AddWithValue("@SoLuongNhanVien", txtsoluongnhanvien.Text);
                    cmd.Parameters.AddWithValue("@NganSachNhanVien", txtngansachnhanvien.Text);
                    cmd.Parameters.AddWithValue("@ThanhTienChoNhanVien", txttiennhanvien.Text);
                    cmd.Parameters.AddWithValue("@nhataitro", txtnhataitro.Text);



                    cmd.ExecuteNonQuery();
                    Loaddata();

                    MessageBox.Show("Thêm thành công");
                }
                
              

            }
            if (status == "Sua")
            {
                try
                {
                    // Tạo SqlCommand object với truy vấn UPDATE và SqlConnection object đã được khởi tạo
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE thietbibaotri SET TrangThietBiCanBaoTri=@TrangThietBiCanBaoTri, ThoiGianBaoTri=@ThoiGianBaoTri, SoLuongThietBi=@SoLuongThietBi, NganSachBaoTri=@NganSachBaoTri, ThanhTienTrangThietBi=@ThanhTienTrangThietBi, TenCongTyBaoTri=@TenCongTyBaoTri, SoLuongNhanVien=@SoLuongNhanVien, NganSachNhanVien=@NganSachNhanVien, ThanhTienChoNhanVien=@ThanhTienChoNhanVien,nhataitro=@nhataitro WHERE MaTBBT=@MaTBBT";

                    // Thêm các tham số vào SqlCommand object
                    cmd.Parameters.AddWithValue("@TrangThietBiCanBaoTri", cbtrangthietbi.Text);
                    DateTime ThoiGianBaoTri = dtpngay.Value;
                    String strThoiGianBaoTri = ThoiGianBaoTri.ToString("yyyy/MM/dd");
                    cmd.Parameters.AddWithValue("@ThoiGianBaoTri", strThoiGianBaoTri);
                    cmd.Parameters.AddWithValue("@SoLuongThietBi", txtsoluongtrangthietbi.Text);
                    cmd.Parameters.AddWithValue("@NganSachBaoTri", txtngansachbaotri.Text);
                    cmd.Parameters.AddWithValue("@ThanhTienTrangThietBi", txtthanhtien.Text);
                    cmd.Parameters.AddWithValue("@TenCongTyBaoTri", txttencongtybaotri.Text);
                    cmd.Parameters.AddWithValue("@SoLuongNhanVien", txtsoluongnhanvien.Text);
                    cmd.Parameters.AddWithValue("@NganSachNhanVien", txtngansachnhanvien.Text);
                    cmd.Parameters.AddWithValue("@ThanhTienChoNhanVien", txttiennhanvien.Text);
                    cmd.Parameters.AddWithValue("@nhataitro", txtnhataitro.Text);
                    cmd.Parameters.AddWithValue("@MaTBBT", txtmathietbi.Text);

                    // Thực thi truy vấn UPDATE và kiểm tra kết quả
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        Loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi có mã " + txtmathietbi.Text + " để sửa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi  " + ex.Message);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            status = "Hienthi";
            Choose(status);
        }

        private void chktimdulieu_CheckedChanged(object sender, EventArgs e)
        {
            status = "Timkiem";
            Choose(status);


            if (chktimdulieu.Checked == true)
            {
                chktimthietbi.Visible = true;
                chktimngay.Visible = true;

            }
            else
            {
                chktimthietbi.Visible = false;
                chktimngay.Visible = false;
                cbtimtranthietbi.Visible = false;
                dtptimngay.Visible = false;
                btntimkiem.Visible = false;
                btntimkiemngay.Visible = false;
               


            }
            Loaddata();
        }

        private void chktimthietbi_CheckedChanged(object sender, EventArgs e)
        {

            if (chktimthietbi.Checked == true)
            {
                cbtimtranthietbi.Visible = true;
                
                btntimkiem.Visible = true;
                chktimngay.Checked = false; // Tự động tắt checkbox 
                chktimngay.Visible = true;
                dtptimngay.Visible = false;
                btntimkiemngay.Visible = false;
            }
            else
            {
                cbtimtranthietbi.Visible = false;
                btntimkiem.Visible = false;
                chktimngay.Visible = true;
            }
        }

        private void chktimngay_CheckedChanged(object sender, EventArgs e)
        {

            if (chktimngay.Checked == true)
            {
                dtptimngay.Visible = true;
                
                btntimkiemngay.Visible = true;
                chktimthietbi.Checked = false; // Tự động tắt checkbox
                chktimthietbi.Visible = true;
                cbtimtranthietbi.Visible = false;
                btntimkiem.Visible = false;
            }
            else
            {
                dtptimngay.Visible = false;
                btntimkiemngay.Visible = false;
                chktimthietbi.Visible = true;
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM thietbibaotri WHERE TrangThietBiCanBaoTri =N'" + cbtimtranthietbi.Text.Trim() + "'";
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();//tạo bảng mới để load bảng
                dt.Load(dr); // load lại data
                dtmain.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btntimkiemngay_Click(object sender, EventArgs e)
        {
            try
            {
                
                cmd.CommandText = "SELECT * FROM thietbibaotri WHERE ThoiGianBaoTri = @ThoiGianBaoTri";
                cmd.Parameters.AddWithValue("@ThoiGianBaoTri", dtptimngay.Value.Date);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dtmain.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void txtsoluongtrangthietbi_TextChanged(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(txtsoluongtrangthietbi.Text, out num1) && int.TryParse(txtngansachbaotri.Text, out num2))
            {
               

                int result = num1 * num2;
                txtthanhtien.Text = result.ToString();
               
            }
            else
            {
                txtthanhtien.Text = "";
                
            }
        }

        private void txtngansachbaotri_TextChanged(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(txtsoluongtrangthietbi.Text, out num1) && int.TryParse(txtngansachbaotri.Text, out num2))
            {
               
                int result = num1 * num2;
                txtthanhtien.Text = result.ToString();
                
            }
            else
            {
                txtthanhtien.Text = "";
                
            }
        }

        private void txtsoluongnhanvien_TextChanged(object sender, EventArgs e)
        {
            int num3, num4;

            if (int.TryParse(txtsoluongnhanvien.Text, out num3) && int.TryParse(txtngansachnhanvien.Text, out num4))
            {
               

                int result = num3 * num4;
                txttiennhanvien.Text = result.ToString();
                
            }
            else
            {
                txttiennhanvien.Text = "";
               
            }
        }

        private void txtngansachnhanvien_TextChanged(object sender, EventArgs e)
        {
            int num3, num4;
            if (int.TryParse(txtsoluongnhanvien.Text, out num3) && int.TryParse(txtngansachnhanvien.Text, out num4))
            {
              
                int result = num3 * num4;
                txttiennhanvien.Text = result.ToString();
               
            }
            else
            {
                txttiennhanvien.Text = "";
               
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dtmain.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application bangexcel = new Microsoft.Office.Interop.Excel.Application();
                bangexcel.Application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)bangexcel.ActiveSheet;

                for (int j = 0; j < dtmain.Columns.Count; j++)
                {
                    string columnName = dtmain.Columns[j].HeaderText;
                    bangexcel.Cells[1, j + 1] = columnName;
                }

                for (int i = 0; i < dtmain.Rows.Count; i++)
                {
                    for (int j = 0; j < dtmain.Columns.Count; j++)
                    {
                        DataGridViewCell cell = dtmain.Rows[i].Cells[j];
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

        private void dtmain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dtmain.Rows[e.RowIndex];

                    if (row.Cells["MaTBBT"].Value != null)
                    {
                        txtmathietbi.Text = row.Cells["MaTBBT"].Value.ToString();
                    }
                    else
                    {
                        txtmathietbi.Text = "";
                    }

                    if (row.Cells["TrangThietBiCanBaoTri"].Value != null)
                    {
                        cbtrangthietbi.Text = row.Cells["TrangThietBiCanBaoTri"].Value.ToString();
                    }
                    else
                    {
                        cbtrangthietbi.Text = "";
                    }

                    if (row.Cells["ThoiGianBaoTri"].Value != null)
                    {
                        dtpngay.Value = Convert.ToDateTime(row.Cells["ThoiGianBaoTri"].Value);
                    }
                    else
                    {
                        dtpngay.Value = DateTime.Now;
                    }

                    if (row.Cells["SoLuongThietBi"].Value != null)
                    {
                        txtsoluongtrangthietbi.Text = row.Cells["SoLuongThietBi"].Value.ToString();
                    }
                    else
                    {
                        txtsoluongtrangthietbi.Text = "";
                    }

                    if (row.Cells["NganSachBaoTri"].Value != null && decimal.TryParse(row.Cells["NganSachBaoTri"].Value.ToString(), out decimal nganSachBaoTri))
                    {
                        txtngansachbaotri.Text = nganSachBaoTri.ToString("N0") + " VND";
                    }
                    else
                    {
                        txtngansachbaotri.Text = "";
                    }

                    if (row.Cells["ThanhTienTrangThietBi"].Value != null && decimal.TryParse(row.Cells["ThanhTienTrangThietBi"].Value.ToString(), out decimal thanhTienTrangThietBi))
                    {
                        txtthanhtien.Text = thanhTienTrangThietBi.ToString("N0") + " VND";
                    }
                    else
                    {
                        txtthanhtien.Text = "";
                    }

                    if (row.Cells["TenCongTyBaoTri"].Value != null)
                    {
                        txttencongtybaotri.Text = row.Cells["TenCongTyBaoTri"].Value.ToString();
                    }
                    else
                    {
                        txttencongtybaotri.Text = "";
                    }

                    if (row.Cells["SoLuongNhanVien"].Value != null)
                    {
                        txtsoluongnhanvien.Text = row.Cells["SoLuongNhanVien"].Value.ToString();
                    }
                    else
                    {
                        txtsoluongnhanvien.Text = "";
                    }

                    if (row.Cells["NganSachNhanVien"].Value != null && decimal.TryParse(row.Cells["NganSachNhanVien"].Value.ToString(), out decimal nganSachNhanVien))
                    {
                        txtngansachnhanvien.Text = nganSachNhanVien.ToString("N0") + " VND";
                    }
                    else
                    {
                        txtngansachnhanvien.Text = "";
                    }

                    if (row.Cells["ThanhTienChoNhanVien"].Value != null && decimal.TryParse(row.Cells["ThanhTienChoNhanVien"].Value.ToString(), out decimal thanhTienChoNhanVien))
                    {
                        txttiennhanvien.Text = thanhTienChoNhanVien.ToString("N0") + " VND";
                    }
                    else
                    {
                        txttiennhanvien.Text = "";
                    }
                if (row.Cells["nhataitro"].Value != null)
                {
                    txtnhataitro.Text = row.Cells["nhataitro"].Value.ToString();
                }
                else
                {
                    txtnhataitro.Text = "";
                }
            }
            }
    }
    }
    

