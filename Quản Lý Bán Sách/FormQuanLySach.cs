using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quản_Lý_Bán_Sách
{
    public partial class FormQuanLySach : Form
    {
        public FormQuanLySach()
        {
            InitializeComponent();
        }
        string ChuoiKetNoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True";
        string sql;
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader DocDuLieu;
        int TongTien = 0;
        private void FormQuanLySach_Load(object sender, EventArgs e)
        {           
            this.nhaXuatBanTableAdapter.Fill(this.quanLyBanSachDataSet.NhaXuatBan);
            KetNoi = new SqlConnection(ChuoiKetNoi);
            HienDuLieu();
        }
        void HienDuLieu()
        {
            sql = @"SELECT TenNXB FROM NhaXuatBan";
            ThucHien = new SqlCommand(sql, KetNoi);
            KetNoi.Open();
            DocDuLieu = ThucHien.ExecuteReader();
            while (DocDuLieu.Read())
            {
                treeView.Nodes.Add(DocDuLieu[0].ToString());
            }
            KetNoi.Close();


            listView.Items.Clear();
            int i = 0;
            TongTien = 0;
            sql = @"SELECT Sach.MaSach, Sach.Ten, Sach.SoLuong, Sach.DonGia, Sach.SoLuong*Sach.DonGia, NhaXuatBan.TenNXB FROM Sach INNER JOIN NhaXuatBan ON Sach.MaNXB = NhaXuatBan.MaNXB";
            ThucHien = new SqlCommand(sql, KetNoi);
            KetNoi.Open();
            DocDuLieu = ThucHien.ExecuteReader();
            while (DocDuLieu.Read())
            {
                listView.Items.Add(DocDuLieu[0].ToString());
                listView.Items[i].SubItems.Add(DocDuLieu[1].ToString());
                listView.Items[i].SubItems.Add(DocDuLieu[2].ToString());
                listView.Items[i].SubItems.Add(DocDuLieu[3].ToString());                
                listView.Items[i].SubItems.Add(DocDuLieu[4].ToString());
                listView.Items[i].SubItems.Add(DocDuLieu[5].ToString());
                TongTien = TongTien + int.Parse(DocDuLieu[4].ToString());                
                i++;
            }
            textBoxTongTien.Text = TongTien.ToString();
            KetNoi.Close();
            textBoxMaSach.ReadOnly = true;
            textBoxTenSach.ReadOnly = true;
            textBoxSoLuong.ReadOnly = true;
            textBoxDonGia.ReadOnly = true;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            textBoxMaSach.ReadOnly = false;
            textBoxTenSach.ReadOnly = false;
            textBoxSoLuong.ReadOnly = false;
            textBoxDonGia.ReadOnly = false;
            textBoxMaSach.Focus();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            string MaNXB="";
            sql = @"SELECT MaNXB FROM NhaXuatBan WHERE (TenNXB = N'"+comboBoxNXB.Text+"')";
            ThucHien = new SqlCommand(sql, KetNoi);
            KetNoi.Open();
            DocDuLieu = ThucHien.ExecuteReader();
            while (DocDuLieu.Read())
                MaNXB = DocDuLieu[0].ToString();
            KetNoi.Close();


            sql = @"INSERT INTO Sach(MaSach, Ten, SoLuong, DonGia, MaNXB) VALUES (N'"+textBoxMaSach.Text+@"',N'"+textBoxTenSach.Text+@"',"+textBoxSoLuong.Text+@","+textBoxDonGia.Text+@",N'" + MaNXB + "')";
            KetNoi = new SqlConnection(ChuoiKetNoi);
            ThucHien = new SqlCommand(sql, KetNoi);
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienDuLieu();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn thoát chương trình?","Thoát chương trình", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(D == DialogResult.Yes)
            {
                this.Close();//thoát Form
                Application.Exit();//Thoát ứng dụng
            }
        }

        private void treeView_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(treeView.SelectedNode.Text);
            sql = @"SELECT Sach.Ten FROM Sach INNER JOIN NhaXuatBan ON Sach.MaNXB = NhaXuatBan.MaNXB WHERE (NhaXuatBan.TenNXB = N'" + treeView.SelectedNode.Text + "')";
            ThucHien = new SqlCommand(sql, KetNoi);
            KetNoi.Open();
            DocDuLieu = ThucHien.ExecuteReader();
            treeView.SelectedNode.Nodes.Clear();
            while (DocDuLieu.Read())
            {
                treeView.SelectedNode.Nodes.Add(DocDuLieu[0].ToString());
            }
            KetNoi.Close();
        }

    }
}
