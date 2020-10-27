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

namespace QL_BaoHanhTTDT
{
    public partial class Giaovien : Form
    {
        public Giaovien()
        {
            InitializeComponent();
        }

        int flag;
        connect con = new connect();


        private void data()
        {
            con.data("select_GV", dgvGiaoVien);
            con.Load_cbo("cbo_Khoa", cboKhoa);
        }

        private void binding()
        {
            int index = dgvGiaoVien.CurrentRow.Index;
            txtTenGV.Text = dgvGiaoVien.Rows[index].Cells[1].Value.ToString();
            dtpkNgaysinh.Text = dgvGiaoVien.Rows[index].Cells[2].Value.ToString();




            if (dgvGiaoVien.Rows[index].Cells[3].Value.ToString().Trim().Equals("nam"))
            {
                rdbtNam.Checked = true;
            }
            else
            {
                rdbtNu.Checked = true;
            }
            dtpkNgayvaolam.Text = dgvGiaoVien.Rows[index].Cells[4].Value.ToString();
            txtDiachi.Text = dgvGiaoVien.Rows[index].Cells[5].Value.ToString();
            txtLuong.Text = dgvGiaoVien.Rows[index].Cells[6].Value.ToString();
            cboKhoa.Text = dgvGiaoVien.Rows[index].Cells[7].Value.ToString();
        }

        private void dis_end(bool e)
        {
            txtTenGV.Enabled = e;
            txtDiachi.Enabled = e;
            txtDiachi.Enabled = e;
            txtLuong.Enabled = e;
            cboKhoa.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        private void dis_end_luu(bool e)
        {
            btnLuu.Enabled = e;
        }

        private void Giaovien_Load(object sender, EventArgs e)
        {
            dgvGiaoVien.AutoGenerateColumns = false;
            data();
            binding();
            dis_end_luu(false);
            dis_end(false);
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end_luu(true);
            dis_end(true);
            txtTenGV.Clear();
            txtDiachi.Clear();
            txtLuong.Clear();
            rdbtNam.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end_luu(true);
            dis_end(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                try
                {
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insert_GV";
                    cmd.Parameters.AddWithValue("@hoten", txtTenGV.Text);
                    if (rdbtNam.Checked == true)
                        cmd.Parameters.AddWithValue("@gt", "nam");
                    else if (rdbtNu.Checked == true)
                        cmd.Parameters.AddWithValue("@gt", "nữ");
                    cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("@luong", txtLuong.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dtpkNgaysinh.Value.ToString()));
                    cmd.Parameters.AddWithValue("@ngayvaolam", Convert.ToDateTime(dtpkNgaysinh.Value.ToString()));
                    cmd.Parameters.AddWithValue("@makhoa", cboKhoa.SelectedValue);
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Giaovien_Load(sender, e);

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công");
                }

            }
            else
            {
                try
                {
                    int index = dgvGiaoVien.CurrentRow.Index;
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_GV";
                    cmd.Parameters.AddWithValue("@hoten", txtTenGV.Text);
                    if (rdbtNam.Checked == true)
                        cmd.Parameters.AddWithValue("@gt", 1);
                    else if (rdbtNu.Checked == true)
                        cmd.Parameters.AddWithValue("@gt", 0);
                    cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("@luong", txtLuong.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dtpkNgaysinh.Value.ToString()));
                    cmd.Parameters.AddWithValue("@ngayvaolam", Convert.ToDateTime(dtpkNgaysinh.Value.ToString()));
                    cmd.Parameters.AddWithValue("@magv", dgvGiaoVien.Rows[index].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Giaovien_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Giaovien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvGiaoVien.CurrentRow.Index;
            con.connection();
            SqlCommand cmd = con.cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_NV";
            cmd.Parameters.AddWithValue("@magv", dgvGiaoVien.Rows[index].Cells[0].Value.ToString());
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                Giaovien_Load(sender, e);
            }
        }

        private void btnChucvu_Click(object sender, EventArgs e)
        {
            int index = dgvGiaoVien.CurrentRow.Index;
            GV_CV gvcv = new GV_CV(this);
            GV_CV.maGV = dgvGiaoVien.Rows[index].Cells[0].Value.ToString();
            gvcv.ShowDialog();
        }
    }
}
