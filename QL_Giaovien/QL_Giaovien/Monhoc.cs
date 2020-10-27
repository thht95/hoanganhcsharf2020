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
    public partial class Monhoc : Form
    {
        public Monhoc()
        {
            InitializeComponent();
        }

        int flag;
        connect con = new connect();

        private void data()
        {
            con.data("select_MH", dgvmonhoc);
            con.Load_cbo("cbo_NM", cboNhommon);
        }

        private void binding()
        {
            int index = dgvmonhoc.CurrentRow.Index;
            txtTenmonhoc.Text = dgvmonhoc.Rows[index].Cells[1].Value.ToString();
            txtSotinchi.Text = dgvmonhoc.Rows[index].Cells[2].Value.ToString();
            cboNhommon.Text = dgvmonhoc.Rows[index].Cells[3].Value.ToString();
        }

        private void Monhoc_Load(object sender, EventArgs e)
        {
            dgvmonhoc.AutoGenerateColumns = false;
            data();
            binding();
            dis_end_luu(false);
            dis_end(false);
        }

        private void dis_end(bool e)
        {
            txtTenmonhoc.Enabled = e;
            txtSotinchi.Enabled = e;
            cboNhommon.Enabled = e;
            btnHuy.Enabled = e;
            btnXoa.Enabled = !e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }

        private void dis_end_luu(bool e)
        {
            btnLuu.Enabled = e;
        }

        private void dgvmonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    cmd.CommandText = "insert_MH";
                    cmd.Parameters.AddWithValue("@tenmon", txtTenmonhoc.Text);
                    cmd.Parameters.AddWithValue("@sotin", txtSotinchi.Text);
                    cmd.Parameters.AddWithValue("@maNM", cboNhommon.SelectedValue);
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Monhoc_Load(sender, e);
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
                    int index = dgvmonhoc.CurrentRow.Index;
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_MH";
                    cmd.Parameters.AddWithValue("@tenmon", txtTenmonhoc.Text);
                    cmd.Parameters.AddWithValue("@sotin", txtSotinchi.Text);
                    cmd.Parameters.AddWithValue("@maNM", cboNhommon.SelectedValue);
                    cmd.Parameters.AddWithValue("@ma", dgvmonhoc.Rows[index].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Monhoc_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvmonhoc.CurrentRow.Index;
            con.connection();
            SqlCommand cmd = con.cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_MH";
            cmd.Parameters.AddWithValue("@maMH", dgvmonhoc.Rows[index].Cells[0].Value.ToString());
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                Monhoc_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenmonhoc.Text = txtSotinchi.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
