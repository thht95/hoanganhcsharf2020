namespace QL_BaoHanhTTDT
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGiaovien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNhommon = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLophoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLoptinchi = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMonhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.mniThongtin,
            this.mniLophoc,
            this.mniMonhoc,
            this.mniLoptinchi,
            this.mniOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // mniThongtin
            // 
            this.mniThongtin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGiaovien,
            this.mniKhoa,
            this.mniNhommon});
            this.mniThongtin.Name = "mniThongtin";
            this.mniThongtin.Size = new System.Drawing.Size(70, 20);
            this.mniThongtin.Text = "Thông tin";
            // 
            // mniGiaovien
            // 
            this.mniGiaovien.Name = "mniGiaovien";
            this.mniGiaovien.Size = new System.Drawing.Size(188, 22);
            this.mniGiaovien.Text = "Thông tin Giáo viên";
            this.mniGiaovien.Click += new System.EventHandler(this.mniGiaovien_Click);
            // 
            // mniKhoa
            // 
            this.mniKhoa.Name = "mniKhoa";
            this.mniKhoa.Size = new System.Drawing.Size(188, 22);
            this.mniKhoa.Text = "Thông tin Khoa";
            this.mniKhoa.Click += new System.EventHandler(this.mniKhoa_Click);
            // 
            // mniNhommon
            // 
            this.mniNhommon.Name = "mniNhommon";
            this.mniNhommon.Size = new System.Drawing.Size(188, 22);
            this.mniNhommon.Text = "Thông tin nhóm môn";
            this.mniNhommon.Click += new System.EventHandler(this.mniNhommon_Click);
            // 
            // mniLophoc
            // 
            this.mniLophoc.Name = "mniLophoc";
            this.mniLophoc.Size = new System.Drawing.Size(62, 20);
            this.mniLophoc.Text = "Lớp học";
            this.mniLophoc.Click += new System.EventHandler(this.mniLophoc_Click);
            // 
            // mniLoptinchi
            // 
            this.mniLoptinchi.Name = "mniLoptinchi";
            this.mniLoptinchi.Size = new System.Drawing.Size(75, 20);
            this.mniLoptinchi.Text = "Lớp tín chỉ";
            this.mniLoptinchi.Click += new System.EventHandler(this.mniLoptinchi_Click);
            // 
            // mniOut
            // 
            this.mniOut.Name = "mniOut";
            this.mniOut.Size = new System.Drawing.Size(49, 20);
            this.mniOut.Text = "Thoát";
            // 
            // mniMonhoc
            // 
            this.mniMonhoc.Name = "mniMonhoc";
            this.mniMonhoc.Size = new System.Drawing.Size(67, 20);
            this.mniMonhoc.Text = "môn học";
            this.mniMonhoc.Click += new System.EventHandler(this.mniMonhoc_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1026, 559);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniThongtin;
        private System.Windows.Forms.ToolStripMenuItem mniLophoc;
        private System.Windows.Forms.ToolStripMenuItem mniLoptinchi;
        private System.Windows.Forms.ToolStripMenuItem mniGiaovien;
        private System.Windows.Forms.ToolStripMenuItem mniKhoa;
        private System.Windows.Forms.ToolStripMenuItem mniNhommon;
        private System.Windows.Forms.ToolStripMenuItem mniOut;
        private System.Windows.Forms.ToolStripMenuItem mniMonhoc;
    }
}

