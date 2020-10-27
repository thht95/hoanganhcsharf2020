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
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }
        int flag;
        connect con = new connect();

        private void data()
        {
            con.data("select_Khoa", dgvkhoa);
        }

        private void binding()
        {
            int index = dgvkhoa.CurrentRow.Index;
            txtTenkhoa.Text = dgvkhoa.Rows[index].Cells[1].Value.ToString();
            txtDiachi.Text = dgvkhoa.Rows[index].Cells[2].Value.ToString();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            dgvkhoa.AutoGenerateColumns = false;
            data();
            binding();
            dis_end_luu(false);
            dis_end(false);
        }

        private void dis_end(bool e)
        {
            txtTenkhoa.Enabled = e;
            txtDiachi.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }

        private void dis_end_luu(bool e)
        {
            btnLuu.Enabled = e;
        }

        private void dgvhanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    cmd.CommandText = "insert_Khoa";
                    cmd.Parameters.AddWithValue("@tenkhoa", txtTenkhoa.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtTenkhoa.Text);
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Khoa_Load(sender, e);
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
                    int index = dgvkhoa.CurrentRow.Index;
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_Khoa";
                    cmd.Parameters.AddWithValue("@tenkhoa", txtTenkhoa.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("@makhoa", dgvkhoa.Rows[index].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    dis_end_luu(false);
                    Khoa_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenkhoa.Text = txtDiachi.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
