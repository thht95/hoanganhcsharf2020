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
    public partial class GV_CV : Form
    {
        Giaovien f;
        public GV_CV()
        {
            InitializeComponent();
        }

        public GV_CV(Giaovien f)
        {
            this.f = f;
            InitializeComponent();
        }

        int flag;
        connect con = new connect();
        public static string maGV;

        private DataTable data()
        {
            con.connection();
            SqlCommand cmd = con.cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "select_CV_by_GV";
            cmd.Parameters.AddWithValue("@maGV", maGV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void binding()
        {
            DataTable dt = new DataTable();
            dt = data();
            if (dt.Rows.Count > 0)
            {
                int index = dgvchucvu.CurrentRow.Index;
                cboChucvu.Text = dgvchucvu.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void loaddata()
        {
            con.connection();
            DataTable dt = new DataTable();
            dt = data();
            if (dt.Rows.Count > 0)
            {
                dgvchucvu.DataSource = dt;
            }
            else
            {
                dgvchucvu.DataSource = null;
            }
            con.Load_cbo("select_CV", cboChucvu);
        }

        private void dis_end(bool e)
        {
            cboChucvu.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GV_CV_Load(object sender, EventArgs e)
        {
            loaddata();
            binding();
            dis_end(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                SqlCommand cmd = con.cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_CV_GV";
                cmd.Parameters.AddWithValue("@maCV", cboChucvu.SelectedValue);
                cmd.Parameters.AddWithValue("@maGV", maGV);
                cmd.ExecuteNonQuery();
                GV_CV_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvchucvu.CurrentRow.Index;
            con.connection();
            SqlCommand cmd = con.cnn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_CV_GV";
            cmd.Parameters.AddWithValue("@ma", dgvchucvu.Rows[index].Cells[1].Value);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                GV_CV_Load(sender, e);
            }
        }
    }
}
