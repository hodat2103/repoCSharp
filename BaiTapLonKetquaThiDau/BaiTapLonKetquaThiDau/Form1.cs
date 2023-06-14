using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BaiTapLonKetquaThiDau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String chuoiketnoi = @"Data Source=KIENPC;Initial Catalog=KetThucMon;Integrated Security=True";
        String sql;
        SqlConnection con;//ketnoi
        SqlCommand cmd;//thuchien
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        String status;
        void Loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select*from ketquathidau";
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
        public void Choose(String status)
        {
            switch (status)
            {
                case "Hienthi":
                    txtdoithu.Enabled = false;
                    txtsanvandong.Enabled = false;
                    txtngaythidau.Enabled = false;
                    cbgiaidau.Enabled = false;
                    txttyso.Enabled = false;
                    txtcauthuxuatsac.Enabled = false;
                    txtvideo.Enabled = false;

                    txttimdoithu.Enabled = false;
                    cbtimgiaidau.Enabled = false;
                    btntimkiemgiaidau.Enabled = false;
                    btntimkiem.Enabled = false;
                    chktimdoithu.Enabled = false;
                    chktimgiaidau.Enabled = false;
                    chktimdulieu.Enabled = true;
                    btnvideo.Enabled = false;
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = false;
                    btnhuy.Enabled = true;
                    
                  
                    break;

                case "Them":
                    txtdoithu.Enabled = true;
                    txtsanvandong.Enabled = true;
                    txtngaythidau.Enabled = true;
                    cbgiaidau.Enabled = true;
                    txttyso.Enabled = true;
                    txtcauthuxuatsac.Enabled = true;
                    btnvideo.Enabled = true;
                    chktimdoithu.Enabled = false;
                    chktimgiaidau.Enabled = false;
                    chktimdulieu.Enabled = false;
                    btntimkiemgiaidau.Enabled = false;
                    btntimkiem.Enabled = false;
                    txttimdoithu.Enabled = false;
                    cbtimgiaidau.Enabled = false;
                    btnthem.Enabled = true;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnluu.Enabled = true;
                    btnhuy.Enabled = true;
                    txtdoithu.Text = " ";
                    txtsanvandong.Text = " ";
                    txtngaythidau.Text = " ";
                    cbgiaidau.Text = " ";
                    txttyso.Text = " ";

                    break;

                case "Sua":
                    txtdoithu.Enabled = true;
                    txtsanvandong.Enabled = true;
                    txtngaythidau.Enabled = true;
                    cbgiaidau.Enabled = true;
                    txttyso.Enabled = true;
                    txtcauthuxuatsac.Enabled = true;
                    chktimdoithu.Enabled = false;
                    chktimgiaidau.Enabled = false;
                    chktimdulieu.Enabled = false;
                    btntimkiemgiaidau.Enabled = false;
                    btntimkiem.Enabled = false;

                    txttimdoithu.Enabled = false;
                    cbtimgiaidau.Enabled = false;
                    btnvideo.Enabled = true;
                    txtvideo.Enabled = true;
                    btnthem.Enabled = false;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnluu.Enabled = true;
                    btnhuy.Enabled = true;

                    break;
                case "Xoa":
                    txtdoithu.Enabled = true;
                    txtsanvandong.Enabled = true;
                    txtngaythidau.Enabled = true;
                    cbgiaidau.Enabled = true;
                    txttyso.Enabled = true;
                    txtcauthuxuatsac.Enabled = true;
                    chktimdoithu.Enabled = false;
                    chktimgiaidau.Enabled = false;
                    chktimdulieu.Enabled = false;
                    btntimkiemgiaidau.Enabled = false;
                    btntimkiem.Enabled = false;

                    txttimdoithu.Enabled = false;
                    cbtimgiaidau.Enabled = false;
                    btnvideo.Enabled = false;
                    txtvideo.Enabled = false;
                    btnthem.Enabled = false;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = false;
                    btnhuy.Enabled = true;
                    break;
                case "TimKiem":
                    txtdoithu.Enabled = false;
                    txtsanvandong.Enabled = false;
                    txtngaythidau.Enabled = false;
                    cbgiaidau.Enabled = false;
                    txttyso.Enabled = false;
                    txtcauthuxuatsac.Enabled = false;
                    chktimdoithu.Enabled = true;
                    chktimgiaidau.Enabled = true;
                    chktimdulieu.Enabled = true;
                    btntimkiemgiaidau.Enabled = true;
                    btntimkiem.Enabled = true;

                    txttimdoithu.Enabled = true;
                    cbtimgiaidau.Enabled = true;
                    btnvideo.Enabled = false;
                    txtvideo.Enabled = false;
                    btnthem.Enabled = false;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnluu.Enabled = false;
                    btnhuy.Enabled = true;
                    break;



            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            status="Them";
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
                    cmd.CommandText = "Delete from ketquathidau where DoiThu=N'" + txtdoithu.Text.Trim()+ "'";
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
                if (txtdoithu.Text.Equals("") || txtsanvandong.Text.Equals("") || txtngaythidau.Text.Equals("") || cbgiaidau.Text.Equals("") || txttyso.Text.Equals("") || txtcauthuxuatsac.Text.Equals("")||txtvideo.Text.Equals(""))
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "thông báo");
                }
                else
                {

                    cmd = con.CreateCommand();
                    cmd.CommandText = "Insert into ketquathidau values(N'" + txtdoithu.Text.Trim() + "',N'" + txtsanvandong.Text.Trim() + "',N'" + txtngaythidau.Text.Trim() + "',N'" + cbgiaidau.Text.Trim()+ "',N'" + txttyso.Text.Trim() + "',N'" + txtcauthuxuatsac.Text.Trim()+"',N'"+txtvideo.Text.Trim() + "')";
                    cmd.ExecuteNonQuery();
                    Loaddata();

                    {
                        MessageBox.Show("Thêm thành công");
                    }

                }
            }
            if (status == "Sua")
            {
                try
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "Update ketquathidau set DoiThu=N'" + txtdoithu.Text.Trim() + "',SanVanDong=N'" + txtsanvandong.Text.Trim() + "',GiaiDau=N'" + cbgiaidau.Text.Trim() + "',TySo=N'" + txttyso.Text.Trim() + "',CauThuXuatSac=N'" + txtcauthuxuatsac.Text.Trim()+"'video=N'"+txtvideo.Text.Trim() + "'where NgayThiDau=N'" + txtngaythidau.Text.Trim() + "' ";
                    var result = cmd.ExecuteNonQuery();
                    Loaddata();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            status = "TimKiem";
            Choose(status);
            if (chktimdulieu.Checked == true)
            {
                chktimdoithu.Visible = true;
                chktimgiaidau.Visible = true;

            }
            else
            {
                chktimdoithu.Visible = false;
                chktimgiaidau.Visible = false;
                txttimdoithu.Visible = false;
                cbtimgiaidau.Visible = false;
                btntimkiem.Visible = false;
                btntimkiemgiaidau.Visible = false;

            }
            Loaddata();
        }

        private void chktimdoithu_CheckedChanged(object sender, EventArgs e)
        {

            if (chktimdoithu.Checked == true)
            {
                txttimdoithu.Visible = true;
                txttimdoithu.Focus();
                btntimkiem.Visible = true;
                chktimgiaidau.Checked = false; // Tự động tắt checkbox chkgiaidau
                chktimgiaidau.Visible = true;
                cbtimgiaidau.Visible = false;
                btntimkiemgiaidau.Visible = false;
            }
            else
            {
                txttimdoithu.Visible = false;
                btntimkiem.Visible = false;
                chktimgiaidau.Visible = true;
            }
        }

        private void chktimgiaidau_CheckedChanged(object sender, EventArgs e)
        {
            if (chktimgiaidau.Checked == true)
            {
                cbtimgiaidau.Visible = true;
                btntimkiemgiaidau.Visible = true;
                btntimkiem.Visible = false;
                chktimdoithu.Checked = false; // Tự động tắt checkbox chkdoithu
                chktimdoithu.Visible = true;
                txttimdoithu.Visible = false;
            }
            else
            {
                cbtimgiaidau.Visible = false;
                btntimkiemgiaidau.Visible = false;

                chktimdoithu.Visible = true;

            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM ketquathidau WHERE DoiThu = N'" + txttimdoithu.Text.Trim() + "'";
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

        private void btntimkiemgiaidau_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM ketquathidau WHERE GiaiDau = N'" + cbtimgiaidau.Text.Trim() + "'";
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

        private void dtmain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dtmain.Rows[e.RowIndex];
                txtdoithu.Text = row.Cells["DoiThu"].Value.ToString();
                txtsanvandong.Text = row.Cells["SanVanDong"].Value.ToString();
                txtngaythidau.Text = row.Cells["NgayThiDau"].Value.ToString();
                cbgiaidau.Text = row.Cells["GiaiDau"].Value.ToString();
                txttyso.Text = row.Cells["TySo"].Value.ToString();
                txtcauthuxuatsac.Text = row.Cells["CauThuXuatSac"].Value.ToString();
                txttimdoithu.Text = row.Cells["DoiThu"].Value.ToString();
                cbtimgiaidau.Text = row.Cells["GiaiDau"].Value.ToString();
                txtvideo.Text = row.Cells["linkvideo"].Value.ToString();
                if (!string.IsNullOrEmpty(txtvideo.Text))
                {
                    //tai video len va hien thi
                    axWindowsMediaPlayer1.URL = txtvideo.Text;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxuatexcel_Click(object sender, EventArgs e)
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
        //khai bao xuat video
       

        private void btnvideo_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            //thiết lập thuộc tính  
            openFileDialog.Filter = "video Files|*.mp4;*.avi;*.wmv";
            openFileDialog.Title = "Select a Video File";
            //Hiển thị file  openFileDialog
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                txtvideo.Text = openFileDialog.FileName;
                axWindowsMediaPlayer1.URL = txtvideo.Text;
            }    
        }
    }
}
