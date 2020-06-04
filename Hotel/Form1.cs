using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["HotelManage"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Display();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void Display()
        {
            string sql = "SELECT * FROM Hotels";
            SqlCommand sc = new SqlCommand(sql, con);
            SqlDataReader sd = sc.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sd);
            tblHotel.DataSource = dataTable;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlAdd = ("INSERT INTO Hotels VALUES (@MaPhong, @MaKhachHang, @TenPhong ,@Gia, @LoaiPhong,@TinhTrang, @CheckIn,@CheckOut )");
            SqlCommand sc = new SqlCommand(sqlAdd, con);
            sc.Parameters.AddWithValue("MaPhong", txtMaPhong.Text);
            sc.Parameters.AddWithValue("MaKhachHang", txtMaKhachHang.Text);
            sc.Parameters.AddWithValue("TenPhong", txtTenPhong.Text);
            sc.Parameters.AddWithValue("Gia", txtGia.Text);
            sc.Parameters.AddWithValue("LoaiPhong", cbxLoaiPhong.Text);
            sc.Parameters.AddWithValue("TinhTrang", cbxTinhTrang.Text);
            sc.Parameters.AddWithValue("CheckIn", dtCheckIn.Text);
            sc.Parameters.AddWithValue("CheckOut", dtCheckOut.Text);
            sc.ExecuteNonQuery();
            Display();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlEdit = ("UPDATE Hotels SET  MaKhachHang = @MaKhachHang, TenPhong = @TenPhong ,Gia = @Gia, LoaiPhong = @LoaiPhong, TinhTrang = @TinhTrang ,CheckIn = @CheckIn,CheckOut = @CheckOut where MaPhong = @MaPhong");
            SqlCommand sc = new SqlCommand(sqlEdit, con);
            sc.Parameters.AddWithValue("MaPhong", txtMaPhong.Text);
            sc.Parameters.AddWithValue("MaKhachHang", txtMaKhachHang.Text);
            sc.Parameters.AddWithValue("TenPhong", txtTenPhong.Text);
            sc.Parameters.AddWithValue("Gia", txtGia.Text);
            sc.Parameters.AddWithValue("LoaiPhong", cbxLoaiPhong.Text);
            sc.Parameters.AddWithValue("TinhTrang", cbxTinhTrang.Text);
            sc.Parameters.AddWithValue("CheckIn", dtCheckIn.Text);
            sc.Parameters.AddWithValue("CheckOut", dtCheckOut.Text);
            sc.ExecuteNonQuery();
            Display();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlEdit = ("DELETE  FROM Hotels where MaPhong = @MaPhong");
            SqlCommand sc = new SqlCommand(sqlEdit, con);
            sc.Parameters.AddWithValue("MaPhong", txtMaPhong.Text);
            sc.Parameters.AddWithValue("MaKhachHang", txtMaKhachHang.Text);
            sc.Parameters.AddWithValue("TenPhong", txtTenPhong.Text);
            sc.Parameters.AddWithValue("Gia", txtGia.Text);
            sc.Parameters.AddWithValue("LoaiPhong", cbxLoaiPhong.Text);
            sc.Parameters.AddWithValue("TinhTrang", cbxTinhTrang.Text);
            sc.Parameters.AddWithValue("CheckIn", dtCheckIn.Text);
            sc.Parameters.AddWithValue("CheckOut", dtCheckOut.Text);
            sc.ExecuteNonQuery();
            Display();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            string sqlFind = ("SELECT  * FROM Hotels where MaPhong =  @MaPhong");
            SqlCommand sc = new SqlCommand(sqlFind, con);
            sc.Parameters.AddWithValue("MaPhong", txtMaPhong.Text);
            sc.Parameters.AddWithValue("MaKhachHang", txtMaKhachHang.Text);
            sc.Parameters.AddWithValue("TenPhong", txtTenPhong.Text);
            sc.Parameters.AddWithValue("Gia", txtGia.Text);
            sc.Parameters.AddWithValue("LoaiPhong", cbxLoaiPhong.Text);
            sc.Parameters.AddWithValue("TinhTrang", cbxTinhTrang.Text);
            sc.Parameters.AddWithValue("CheckIn", dtCheckIn.Text);
            sc.Parameters.AddWithValue("CheckOut", dtCheckOut.Text);
            sc.ExecuteNonQuery();
            SqlDataReader sd = sc.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sd);
            tblHotel.DataSource = dataTable;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtMaKhachHang.Text = "";
            txtTenPhong.Text = "";
            txtGia.Text = "";
            cbxTinhTrang.Text = "";
            cbxLoaiPhong.Text = "";
            dtCheckIn.Text = "";
            dtCheckOut.Text = "";

        }

        
    }
}
