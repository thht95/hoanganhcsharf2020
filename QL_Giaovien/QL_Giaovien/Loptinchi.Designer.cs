namespace QL_BaoHanhTTDT
{
    partial class Loptinchi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvlophoc = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTgh = new System.Windows.Forms.TextBox();
            this.txtTgHoc = new System.Windows.Forms.Label();
            this.txtHocky1 = new System.Windows.Forms.TextBox();
            this.txtHocky = new System.Windows.Forms.Label();
            this.txtNamhoc1 = new System.Windows.Forms.TextBox();
            this.txtNamhoc = new System.Windows.Forms.Label();
            this.cboGiaovien = new System.Windows.Forms.ComboBox();
            this.cboMonhoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.maLTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlophoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(487, 450);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 43);
            this.btnHuy.TabIndex = 62;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvlophoc
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlophoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLTC,
            this.tenMon,
            this.hoTen,
            this.namHoc,
            this.hocKy,
            this.tgHoc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlophoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlophoc.Location = new System.Drawing.Point(382, 123);
            this.dgvlophoc.Name = "dgvlophoc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlophoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvlophoc.Size = new System.Drawing.Size(562, 299);
            this.dgvlophoc.TabIndex = 57;
            this.dgvlophoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlophoc_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(622, 450);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 43);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTgh);
            this.groupBox1.Controls.Add(this.txtTgHoc);
            this.groupBox1.Controls.Add(this.txtHocky1);
            this.groupBox1.Controls.Add(this.txtHocky);
            this.groupBox1.Controls.Add(this.txtNamhoc1);
            this.groupBox1.Controls.Add(this.txtNamhoc);
            this.groupBox1.Controls.Add(this.cboGiaovien);
            this.groupBox1.Controls.Add(this.cboMonhoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 299);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // txtTgh
            // 
            this.txtTgh.Location = new System.Drawing.Point(116, 197);
            this.txtTgh.Name = "txtTgh";
            this.txtTgh.Size = new System.Drawing.Size(175, 24);
            this.txtTgh.TabIndex = 24;
            // 
            // txtTgHoc
            // 
            this.txtTgHoc.AutoSize = true;
            this.txtTgHoc.Location = new System.Drawing.Point(11, 197);
            this.txtTgHoc.Name = "txtTgHoc";
            this.txtTgHoc.Size = new System.Drawing.Size(97, 18);
            this.txtTgHoc.TabIndex = 23;
            this.txtTgHoc.Text = "Thời gian học";
            // 
            // txtHocky1
            // 
            this.txtHocky1.Location = new System.Drawing.Point(116, 155);
            this.txtHocky1.Name = "txtHocky1";
            this.txtHocky1.Size = new System.Drawing.Size(175, 24);
            this.txtHocky1.TabIndex = 24;
            // 
            // txtHocky
            // 
            this.txtHocky.AutoSize = true;
            this.txtHocky.Location = new System.Drawing.Point(11, 155);
            this.txtHocky.Name = "txtHocky";
            this.txtHocky.Size = new System.Drawing.Size(59, 18);
            this.txtHocky.TabIndex = 23;
            this.txtHocky.Text = "Học kỳ:";
            // 
            // txtNamhoc1
            // 
            this.txtNamhoc1.Location = new System.Drawing.Point(116, 120);
            this.txtNamhoc1.Name = "txtNamhoc1";
            this.txtNamhoc1.Size = new System.Drawing.Size(175, 24);
            this.txtNamhoc1.TabIndex = 21;
            // 
            // txtNamhoc
            // 
            this.txtNamhoc.AutoSize = true;
            this.txtNamhoc.Location = new System.Drawing.Point(11, 120);
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.Size = new System.Drawing.Size(69, 18);
            this.txtNamhoc.TabIndex = 20;
            this.txtNamhoc.Text = "Năm học";
            // 
            // cboGiaovien
            // 
            this.cboGiaovien.FormattingEnabled = true;
            this.cboGiaovien.Location = new System.Drawing.Point(117, 74);
            this.cboGiaovien.Name = "cboGiaovien";
            this.cboGiaovien.Size = new System.Drawing.Size(175, 26);
            this.cboGiaovien.TabIndex = 18;
            // 
            // cboMonhoc
            // 
            this.cboMonhoc.FormattingEnabled = true;
            this.cboMonhoc.Location = new System.Drawing.Point(116, 28);
            this.cboMonhoc.Name = "cboMonhoc";
            this.cboMonhoc.Size = new System.Drawing.Size(175, 26);
            this.cboMonhoc.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Môn học";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 22);
            this.label8.TabIndex = 55;
            this.label8.Text = "THÔNG TIN LỚP HỌC";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(223, 450);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 43);
            this.btnSua.TabIndex = 60;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(357, 450);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 43);
            this.btnLuu.TabIndex = 59;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(84, 450);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 43);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // maLTC
            // 
            this.maLTC.DataPropertyName = "maLTC";
            this.maLTC.HeaderText = "Mã lớp học";
            this.maLTC.Name = "maLTC";
            // 
            // tenMon
            // 
            this.tenMon.DataPropertyName = "tenMon";
            this.tenMon.HeaderText = "Tên Môn học";
            this.tenMon.Name = "tenMon";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Tên giáo viên";
            this.hoTen.Name = "hoTen";
            // 
            // namHoc
            // 
            this.namHoc.DataPropertyName = "namHoc";
            this.namHoc.HeaderText = "Năm học";
            this.namHoc.Name = "namHoc";
            // 
            // hocKy
            // 
            this.hocKy.DataPropertyName = "hocKy";
            this.hocKy.HeaderText = "Học kỳ";
            this.hocKy.Name = "hocKy";
            // 
            // tgHoc
            // 
            this.tgHoc.DataPropertyName = "tgHoc";
            this.tgHoc.HeaderText = "Thời gian học";
            this.tgHoc.Name = "tgHoc";
            // 
            // Loptinchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 547);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvlophoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Name = "Loptinchi";
            this.Text = "Loptinchi";
            this.Load += new System.EventHandler(this.Loptinchi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlophoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvlophoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGiaovien;
        private System.Windows.Forms.ComboBox cboMonhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHocky1;
        private System.Windows.Forms.Label txtHocky;
        private System.Windows.Forms.Label txtNamhoc;
        private System.Windows.Forms.Label txtTgHoc;
        private System.Windows.Forms.TextBox txtTgh;
        private System.Windows.Forms.TextBox txtNamhoc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn namHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgHoc;
    }
}