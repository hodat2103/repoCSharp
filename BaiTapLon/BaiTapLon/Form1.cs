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
using System.Security.Cryptography.X509Certificates;

namespace BaiTapLon
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
            cmd.CommandText = "select*from lichthidau";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dtmain.DataSource = dt;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(chuoiketnoi);
            con.Open();
            chkdulieu_CheckedChanged(sender, e);
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
                    txtsove.Enabled = false;
                    txtgiave.Enabled = false;
                    txtanh.Enabled = false;
                    btnOpenImg.Enabled = false;
                    chkdulieu.Enabled = true;

                    txttimdoithu.Enabled = true;
                    cbtimgiaidau.Enabled = true;
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = true;
                    btnhuy.Enabled = true;
                   
                   
                    break;

                case "Them":
                    txtdoithu.Enabled = true;
                    txtsanvandong.Enabled = true;
                    txtngaythidau.Enabled = true;
                    cbgiaidau.Enabled = true;
                    txtsove.Enabled = true;
                    txtgiave.Enabled = true;
                    txtanh.Enabled = true;
                    btnOpenImg.Enabled = true;
                    chkdulieu.Enabled = false;

                    txttimdoithu.Enabled = false;
                    cbtimgiaidau.Enabled = false;
                    btnthem.Enabled = true;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnluu.Enabled = true;
                    btnhuy.Enabled = true;
                    txtdoithu.Text=" ";
                    txtsanvandong.Text = " ";
                    txtngaythidau.Text = " ";
                    cbgiaidau.Text = " ";
                    txtsove.Text = " ";
                    txtgiave.Text = " ";
                    txtanh.Text = " ";
                    
                    break;

                case "Sua":
                    txtdoithu.Enabled = true;
                    txtsanvandong.Enabled = true;
                    txtngaythidau.Enabled = true;
                    cbgiaidau.Enabled = true;
                    txtsove.Enabled = true;
                    txtgiave.Enabled = true;
                    txtanh.Enabled = true;
                    btnOpenImg.Enabled = true;
                    chkdulieu.Enabled = false;

                    txttimdoithu.Enabled = false;
                    cbtimgiaidau.Enabled = false;
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
                    txtsove.Enabled = true;
                    txtgiave.Enabled = true;
                    chkdulieu.Enabled = false;


                    txttimdoithu.Enabled = false;
                    cbtimgiaidau.Enabled = false;
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
                    txtsove.Enabled = false;
                    txtgiave.Enabled = false;
                    txtanh.Enabled = false;
                    btnOpenImg.Enabled = false;
                    chkdulieu.Enabled = true;
                    chkgiaidau.Enabled = true;
                    chkdoithu.Enabled = true;
                    btntimkiem.Enabled = true;
                    btntimkiemgiaidau.Enabled = true;


                    txttimdoithu.Enabled = true;
                    cbtimgiaidau.Enabled = true;
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
                    cmd.CommandText = "Delete from lichthidau where DoiThu=N'" + txtdoithu.Text + "'";
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
                if (txtdoithu.Text.Equals("") || txtsanvandong.Text.Equals("") || txtngaythidau.Text.Equals("") || cbgiaidau.Text.Equals("") || txtsove.Text.Equals("") || txtgiave.Text.Equals("")||txtanh.Text.Equals(""))
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "thông báo");
                }
                else
                {

                    cmd = con.CreateCommand();
                    cmd.CommandText = "Insert into lichthidau values(N'" + txtdoithu.Text.Trim() + "',N'" + txtsanvandong.Text.Trim() + "',N'" + txtngaythidau.Text.Trim() + "',N'" + cbgiaidau.Text.Trim() + "',N'" + txtsove.Text.Trim() + "',N'" + txtgiave.Text.Trim() + "',N'"+txtanh.Text.Trim()+"')";
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
                    cmd.CommandText = "Update lichthidau set DoiThu=N'" + txtdoithu.Text.Trim()+ "',SanVanDong=N'"+ txtsanvandong.Text.Trim()+ "',GiaiDau=N'" + cbgiaidau.Text.Trim() + "',SoVe=N'" + txtsove.Text.Trim() + "',GiaVe=N'" + txtgiave.Text.Trim()+"',anhthe='"+txtanh.Text.Trim() + "'where NgayThiDau=N'" + txtngaythidau.Text.Trim() + "' ";
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

        

        private void chkdoithu_CheckedChanged(object sender, EventArgs e)
        {

       
            if (chkdoithu.Checked == true)
            {
                txttimdoithu.Visible = true;
                txttimdoithu.Focus();
                btntimkiem.Visible = true;
                chkgiaidau.Checked = false; // Tự động tắt checkbox chkgiaidau
                chkgiaidau.Visible = true;
                cbtimgiaidau.Visible = false;
                btntimkiemgiaidau.Visible = false;
            }
            else
            {
                txttimdoithu.Visible = false;
                btntimkiem.Visible = false;
                chkgiaidau.Visible = true;
            }
        }





        private void chkdulieu_CheckedChanged(object sender, EventArgs e)
        {
            status = "TimKiem";
            Choose(status);


            if (chkdulieu.Checked == true)
            {
                chkdoithu.Visible = true;
                chkgiaidau.Visible = true;

            }
            else
            {
                chkdoithu.Visible = false;
                chkgiaidau.Visible = false;
                txttimdoithu.Visible = false;
                cbtimgiaidau.Visible = false;
                btntimkiem.Visible = false;
                btntimkiemgiaidau.Visible = false;

            }
            Loaddata();
        }

        private void chkgiaidau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkgiaidau.Checked == true)
            {
                cbtimgiaidau.Visible = true;
                btntimkiemgiaidau.Visible = true;
                btntimkiem.Visible = false;
                chkdoithu.Checked = false; // Tự động tắt checkbox chkdoithu
                chkdoithu.Visible = true;
                txttimdoithu.Visible = false;
            }
            else
            {
                cbtimgiaidau.Visible = false;
                btntimkiemgiaidau.Visible = false;
                
                chkdoithu.Visible = true;
                
            }
        }

        

        private void btnecxel_Click(object sender, EventArgs e)
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

                for (int i = 0; i <dtmain.Rows.Count; i++)
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
    


        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //check điều kiện lọc file
            openFile.Filter = "File anh|*.jpg;*.png;*.gif;|All File|*.*";
            //check xem nguoi dung da chon file hay chưa
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                txtanh.Text = openFile.FileName;
                ptbanh.Image = Image.FromFile(txtanh.Text);
            }    

        }

      

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM lichthidau WHERE DoiThu =N'" + txttimdoithu.Text.Trim() + "'";
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

        private void btntimkiemgiaidau_Click_1(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM lichthidau WHERE GiaiDau  = N'" + cbtimgiaidau.Text.Trim() + "'";
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

        private void dtmain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dtmain.Rows[e.RowIndex];
                txtdoithu.Text = row.Cells["DoiThu"].Value.ToString();
                txtsanvandong.Text = row.Cells["SanVanDong"].Value.ToString();
                txtngaythidau.Text = row.Cells["NgayThiDau"].Value.ToString();
                cbgiaidau.Text = row.Cells["GiaiDau"].Value.ToString();
                txtsove.Text = row.Cells["SoVe"].Value.ToString();
                txtgiave.Text = row.Cells["GiaVe"].Value.ToString();
                txttimdoithu.Text = row.Cells["DoiThu"].Value.ToString();
                cbtimgiaidau.Text = row.Cells["GiaiDau"].Value.ToString();
                txtanh.Text = row.Cells["anhthe"].Value.ToString();
                if (!string.IsNullOrEmpty(txtanh.Text))
                {
                    //tai anh len va hien thi
                    ptbanh.Image = Image.FromFile(txtanh.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
