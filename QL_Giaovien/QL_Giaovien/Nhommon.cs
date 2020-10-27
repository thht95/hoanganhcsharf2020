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
    public partial class Nhommon : Form
    {
        public Nhommon()
        {
            InitializeComponent();
        }

        int flag;
        connect con = new connect();

        private void data()
        {
            con.data("select_NM", dgvnhommon);
            con.Load_cbo("cbo_Khoa", cboKhoa);
        }

        private void binding()
        {
            int index = dgvnhommon.CurrentRow.Index;
            txtTennhommon.Text = dgvnhommon.Rows[index].Cells[1].Value.ToString();
            cboKhoa.Text = dgvnhommon.Rows[index].Cells[2].Value.ToString();
        }

        private void Nhommon_Load(object sender, EventArgs e)
        {
            dgvnhommon.AutoGenerateColumns = false;
            data();
            binding();
            dis_end_luu(false);
            dis_end(false);
        }

        private void dis_end(bool e)
        {
            txtTennhommon.Enabled = e;
            cboKhoa.Enabled = e;
            btnHuy.Enabled = e;
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
                    cmd.CommandText = "insert_NM";
                    cmd.Parameters.AddWithValue("@ten", txtTennhommon.Text);
                    cmd.Parameters.AddWithValue("@makhoa", cboKhoa.SelectedValue);
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Nhommon_Load(sender, e);
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
                    int index = dgvnhommon.CurrentRow.Index;
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_NM";
                    cmd.Parameters.AddWithValue("@ten", txtTennhommon.Text);
                    cmd.Parameters.AddWithValue("@makhoa", cboKhoa.SelectedValue);
                    cmd.Parameters.AddWithValue("@ma", dgvnhommon.Rows[index].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Nhommon_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTennhommon.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
