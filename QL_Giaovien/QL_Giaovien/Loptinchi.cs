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
    public partial class Loptinchi : Form
    {
        public Loptinchi()
        {
            InitializeComponent();
        }

        int flag;
        connect con = new connect();

        private void data()
        {
            con.data("select_LTC", dgvlophoc);
            con.Load_cbo("cbo_MH", cboMonhoc);
            con.Load_cbo("cbo_giaovien", cboGiaovien);
        }

        private void binding()
        {
            int index = dgvlophoc.CurrentRow.Index;
            cboMonhoc.Text = dgvlophoc.Rows[index].Cells[1].Value.ToString();
            cboGiaovien.Text = dgvlophoc.Rows[index].Cells[2].Value.ToString();
            txtNamhoc1.Text = dgvlophoc.Rows[index].Cells[3].Value.ToString();
            txtHocky1.Text = dgvlophoc.Rows[index].Cells[4].Value.ToString();
            txtTgh.Text = dgvlophoc.Rows[index].Cells[5].Value.ToString();
        }

        private void Loptinchi_Load(object sender, EventArgs e)
        {
            dgvlophoc.AutoGenerateColumns = false;
            data();
            binding();
            dis_end_luu(false);
            dis_end(false);
        }

        private void dis_end(bool e)
        {
            txtNamhoc1.Enabled = e;
            txtHocky1.Enabled = e;
            txtTgh.Enabled = e;
            cboMonhoc.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }

        private void dis_end_luu(bool e)
        {
            btnLuu.Enabled = e;
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
                    cmd.CommandText = "insert_LTC";
                    cmd.Parameters.AddWithValue("@maMH", cboMonhoc.SelectedValue);
                    cmd.Parameters.AddWithValue("@maGV", cboGiaovien.SelectedValue);
                    cmd.Parameters.AddWithValue("@namHoc", txtNamhoc1.Text);
                    cmd.Parameters.AddWithValue("@hocKy", txtHocky1.Text);
                    cmd.Parameters.AddWithValue("@tghoc", txtTgh.Text);
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Loptinchi_Load(sender, e);
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
                    cmd.CommandText = "update_LTC";
                    cmd.Parameters.AddWithValue("@nam", txtNamhoc1.Text);
                    cmd.Parameters.AddWithValue("@Ky", txtHocky1.Text);
                    cmd.Parameters.AddWithValue("@tghoc", txtTgh.Text);
                    cmd.Parameters.AddWithValue("@ma", dgvlophoc.Rows[index].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Loptinchi_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtNamhoc1.Text = txtHocky1.Text = txtTgh.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvlophoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }
    }
}
