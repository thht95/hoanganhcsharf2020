using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BaoHanhTTDT
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		public Boolean kiemtraHienMotform(string sFormname)
		{

			foreach (Form f in this.MdiChildren)
			{
				if (f.Name.Equals(sFormname))
				{
					f.Activate();
					return true;
				}
			}
			return false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void mniSearch_Click(object sender, EventArgs e)
		{
			//if (kiemtraHienMotform("Timkiem")) return;
			//else
			//{
			//	Timkiem search = new Timkiem();
			//	search.MdiParent = this;
			//	search.Show();
			//}
		}

        private void mniGiaovien_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Giaovien")) return;
            else
            {
                Giaovien giaovien = new Giaovien();
                giaovien.MdiParent = this;
                giaovien.Show();
            }
        }

        private void mniKhoa_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Khoa")) return;
            else
            {
                Khoa khoa = new Khoa();
                khoa.MdiParent = this;
                khoa.Show();
            }
        }

        private void mniLophoc_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Lophoc")) return;
            else
            {
                Lophoc x = new Lophoc();
                x.MdiParent = this;
                x.Show();
            }
        }

        private void mniLoptinchi_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Loptinchi")) return;
            else
            {
                Loptinchi x = new Loptinchi();
                x.MdiParent = this;
                x.Show();
            }
        }

        private void mniMonhoc_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Monhoc")) return;
            else
            {
                Monhoc monhoc = new Monhoc();
                monhoc.MdiParent = this;
                monhoc.Show();
            }
        }

        private void mniNhommon_Click(object sender, EventArgs e)
        {
            if (kiemtraHienMotform("Monhoc")) return;
            else
            {
                Nhommon monhoc = new Nhommon();
                monhoc.MdiParent = this;
                monhoc.Show();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void mniOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
