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

namespace QL_BaoHanhTTDT
{
    public partial class Lophoc : Form
    {
        public Lophoc()
        {
            InitializeComponent();
        }

        int flag;
        connect con = new connect();

        private void data()
        {
            con.data("select_LH", dgvlophoc);
            con.Load_cbo("cbo_Khoa", cboKhoa);
            con.Load_cbo("cbo_giaovien", cboGiaovien);
        }

        private void binding()
        {
            int index = dgvlophoc.CurrentRow.Index;
            txtTenlophoc.Text = dgvlophoc.Rows[index].Cells[1].Value.ToString();
            cboKhoa.Text = dgvlophoc.Rows[index].Cells[2].Value.ToString();
            cboGiaovien.Text = dgvlophoc.Rows[index].Cells[3].Value.ToString();
        }

        private void Lophoc_Load(object sender, EventArgs e)
        {
            dgvlophoc.AutoGenerateColumns = false;
            data();
            binding();
            dis_end_luu(false);
            dis_end(false);
        }

        private void dis_end(bool e)
        {
            txtTenlophoc.Enabled = e;
            cboKhoa.Enabled = e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }

        private void dis_end_luu(bool e)
        {
            btnLuu.Enabled = e;
        }

        private void dgvnhommon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end_luu(true);
            dis_end(true);
            btnHuy_Click(sender, e);
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
                    cmd.CommandText = "insert_LH";
                    cmd.Parameters.AddWithValue("@ten", txtTenlophoc.Text);
                    cmd.Parameters.AddWithValue("@makhoa", cboKhoa.SelectedValue);
                    cmd.Parameters.AddWithValue("@maGV", cboGiaovien.SelectedValue);
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Lophoc_Load(sender, e);
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
                    int index = dgvlophoc.CurrentRow.Index;
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_LH";
                    cmd.Parameters.AddWithValue("@ten", txtTenlophoc.Text);
                    cmd.Parameters.AddWithValue("@makhoa", cboKhoa.SelectedValue);
                    cmd.Parameters.AddWithValue("@maGV", cboGiaovien.SelectedValue);
                    cmd.Parameters.AddWithValue("@ma", dgvlophoc.Rows[index].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Lophoc_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvlophoc.CurrentRow.Index;
            con.connection();
            SqlCommand cmd = con.cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_LH";
            cmd.Parameters.AddWithValue("@maLH", dgvlophoc.Rows[index].Cells[0].Value.ToString());
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                Lophoc_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenlophoc.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
