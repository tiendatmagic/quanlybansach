namespace Quản_Lý_Bán_Sách
{
    partial class FormQuanLySach
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNXB = new System.Windows.Forms.ComboBox();
            this.nhaXuatBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanSachDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanSachDataSet = new Quản_Lý_Bán_Sách.QuanLyBanSachDataSet();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            this.textBoxMaSach = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNhaXuatBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nhaXuatBanTableAdapter = new Quản_Lý_Bán_Sách.QuanLyBanSachDataSetTableAdapters.NhaXuatBanTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanSachDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 64);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(267, 240);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.Click += new System.EventHandler(this.treeView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonThoat);
            this.groupBox1.Controls.Add(this.buttonLuu);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxNXB);
            this.groupBox1.Controls.Add(this.textBoxDonGia);
            this.groupBox1.Controls.Add(this.textBoxSoLuong);
            this.groupBox1.Controls.Add(this.textBoxTenSach);
            this.groupBox1.Controls.Add(this.textBoxMaSach);
            this.groupBox1.Location = new System.Drawing.Point(285, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập sách";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(421, 108);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(72, 27);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(421, 77);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(72, 27);
            this.buttonLuu.TabIndex = 5;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(421, 46);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(72, 27);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhà Xuất Bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đơn Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sách:";
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.DataSource = this.nhaXuatBanBindingSource;
            this.comboBoxNXB.DisplayMember = "TenNXB";
            this.comboBoxNXB.FormattingEnabled = true;
            this.comboBoxNXB.Location = new System.Drawing.Point(135, 168);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(358, 29);
            this.comboBoxNXB.TabIndex = 4;
            // 
            // nhaXuatBanBindingSource
            // 
            this.nhaXuatBanBindingSource.DataMember = "NhaXuatBan";
            this.nhaXuatBanBindingSource.DataSource = this.quanLyBanSachDataSetBindingSource;
            // 
            // quanLyBanSachDataSetBindingSource
            // 
            this.quanLyBanSachDataSetBindingSource.DataSource = this.quanLyBanSachDataSet;
            this.quanLyBanSachDataSetBindingSource.Position = 0;
            // 
            // quanLyBanSachDataSet
            // 
            this.quanLyBanSachDataSet.DataSetName = "QuanLyBanSachDataSet";
            this.quanLyBanSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(135, 133);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(280, 29);
            this.textBoxDonGia.TabIndex = 3;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(135, 98);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(280, 29);
            this.textBoxSoLuong.TabIndex = 2;
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.Location = new System.Drawing.Point(135, 63);
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.Size = new System.Drawing.Size(280, 29);
            this.textBoxTenSach.TabIndex = 1;
            // 
            // textBoxMaSach
            // 
            this.textBoxMaSach.Location = new System.Drawing.Point(135, 28);
            this.textBoxMaSach.Name = "textBoxMaSach";
            this.textBoxMaSach.Size = new System.Drawing.Size(280, 29);
            this.textBoxMaSach.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaSach,
            this.columnHeaderTenSach,
            this.columnHeaderSoLuong,
            this.columnHeaderDonGia,
            this.columnHeaderThanhTien,
            this.columnHeaderNhaXuatBan});
            this.listView.Location = new System.Drawing.Point(12, 310);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(772, 223);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMaSach
            // 
            this.columnHeaderMaSach.Text = "Mã Sách";
            this.columnHeaderMaSach.Width = 81;
            // 
            // columnHeaderTenSach
            // 
            this.columnHeaderTenSach.Text = "Tên Sách";
            this.columnHeaderTenSach.Width = 199;
            // 
            // columnHeaderSoLuong
            // 
            this.columnHeaderSoLuong.Text = "Số Lượng";
            this.columnHeaderSoLuong.Width = 90;
            // 
            // columnHeaderDonGia
            // 
            this.columnHeaderDonGia.Text = "Đơn Giá";
            this.columnHeaderDonGia.Width = 80;
            // 
            // columnHeaderThanhTien
            // 
            this.columnHeaderThanhTien.Text = "Thành Tiền";
            this.columnHeaderThanhTien.Width = 100;
            // 
            // columnHeaderNhaXuatBan
            // 
            this.columnHeaderNhaXuatBan.Text = "Nhà Xuất Bản";
            this.columnHeaderNhaXuatBan.Width = 200;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Location = new System.Drawing.Point(420, 275);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.ReadOnly = true;
            this.textBoxTongTien.Size = new System.Drawing.Size(358, 29);
            this.textBoxTongTien.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tổng Tiền Sách:";
            // 
            // nhaXuatBanTableAdapter
            // 
            this.nhaXuatBanTableAdapter.ClearBeforeFill = true;
            // 
            // FormQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 545);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormQuanLySach";
            this.Text = "FormQuanLySach";
            this.Load += new System.EventHandler(this.FormQuanLySach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaXuatBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanSachDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanSachDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNXB;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxTenSach;
        private System.Windows.Forms.TextBox textBoxMaSach;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderMaSach;
        private System.Windows.Forms.ColumnHeader columnHeaderTenSach;
        private System.Windows.Forms.ColumnHeader columnHeaderSoLuong;
        private System.Windows.Forms.ColumnHeader columnHeaderDonGia;
        private System.Windows.Forms.ColumnHeader columnHeaderThanhTien;
        private System.Windows.Forms.ColumnHeader columnHeaderNhaXuatBan;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource quanLyBanSachDataSetBindingSource;
        private QuanLyBanSachDataSet quanLyBanSachDataSet;
        private System.Windows.Forms.BindingSource nhaXuatBanBindingSource;
        private QuanLyBanSachDataSetTableAdapters.NhaXuatBanTableAdapter nhaXuatBanTableAdapter;
    }
}