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
using System.Windows.Forms.VisualStyles;

namespace Lab_4
{
    public partial class menu : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-JV3D50E\\SQLEXPRESS;Initial Catalog=Lab4;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    DataTable tableKhachHang = new DataTable();
                    DataTable tableDonDatHang = new DataTable();

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from KhachHang";
                        adapter.SelectCommand = cmd;
                        tableKhachHang.Clear();
                        adapter.Fill(tableKhachHang);
                        dataGridViewKhachHang.DataSource = tableKhachHang;

                        cmd.CommandText = "select * from DonDatHang";
                        adapter.SelectCommand = cmd;
                        tableDonDatHang.Clear();
                        adapter.Fill(tableDonDatHang);
                        dataGridViewDonDatHang.DataSource = tableDonDatHang;
                    }
                }
                catch (Exception ex)
                {
                    // Thông báo lỗi cho người dùng
                    MessageBox.Show("Có lỗi xảy ra khi truy vấn dữ liệu: " + ex.Message);
                }
            }
        }



        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab4DataSetDonDatHang.DonDatHang' table. You can move, or remove it, as needed.
            this.donDatHangTableAdapter.Fill(this.lab4DataSetDonDatHang.DonDatHang);
            // TODO: This line of code loads data into the 'lab4DataSetKhachHang.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.lab4DataSetKhachHang.KhachHang);
            conn = new SqlConnection(str);
            conn.Open();
            loadData();
        }
        // Câu 6: Khi xóa thực thể cha ở phía 1(KhachHang) thì phía N(DonDatHang) sẽ xóa theo
        private void btn_XoaKhachHang_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu từ bảng DonDatHang
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from DonDatHang where MaKH = '" + txtMaKhachHangFK.Text + "'";
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu từ bảng KhachHang
            cmd.CommandText = "delete from KhachHang where MaKH = '" + txtMaKhachHang.Text + "'";
            cmd.ExecuteNonQuery();

            // Tải lại dữ liệu
            loadData();
        }

        // Truy vấn dữ liệu ở phía 1 (KhachHang)
        private void dataGridViewKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewKhachHang.CurrentCell.RowIndex;
            txtMaKhachHang.Text = dataGridViewKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dataGridViewKhachHang.Rows[i].Cells[1].Value.ToString();
            txtDiaChiKhachHang.Text = dataGridViewKhachHang.Rows[i].Cells[2].Value.ToString();
            txtSoDienThoaiKhachHang.Text = dataGridViewKhachHang.Rows[i].Cells[3].Value.ToString();
            txtEmailKhachHang.Text = dataGridViewKhachHang.Rows[i].Cells[4].Value.ToString();
        }

        // Thêm dữ liệu ở phía 1(KhachHang)
        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO KhachHang(MaKH, TenKH, DiaChi, SoDienThoai, Email) VALUES(@MaKH, @TenKH, @DiaChi, @SoDienThoai, @Email)";

            cmd.Parameters.AddWithValue("@MaKH", txtMaKhachHang.Text);
            cmd.Parameters.AddWithValue("@TenKH", txtTenKhachHang.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChiKhachHang.Text);
            cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoaiKhachHang.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmailKhachHang.Text);

            cmd.ExecuteNonQuery();
            loadData();
        }

        // Sửa dữ liệu ở phía 1(KhachHang)
        private void btn_SuaKhachHang_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE KhachHang SET MaKH = @MaKH, TenKH = @TenKH, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Email = @Email WHERE MaKH = @MaKH";

            cmd.Parameters.AddWithValue("@MaKH", txtMaKhachHang.Text);
            cmd.Parameters.AddWithValue("@TenKH", txtTenKhachHang.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChiKhachHang.Text);
            cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoaiKhachHang.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmailKhachHang.Text);

            cmd.ExecuteNonQuery();
            loadData();

        }

        // Truy vấn dữ liệu ở phía N(DonDatHang)
        private void dataGridViewDonDatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewDonDatHang.CurrentCell.RowIndex;
            txtMaDatHang.Text = dataGridViewDonDatHang.Rows[i].Cells[0].Value.ToString();
            dateTimeDatHang.Value = DateTime.Parse(dataGridViewDonDatHang.Rows[i].Cells[1].Value.ToString());
            comboBoxTrangThai.Text = dataGridViewDonDatHang.Rows[i].Cells[2].Value.ToString(); 
            txtMaKhachHangFK.Text = dataGridViewDonDatHang.Rows[i].Cells[3].Value.ToString();
            txtMaNhanVien.Text = dataGridViewDonDatHang.Rows[i].Cells[4].Value.ToString();

        }

        // Thêm dữ liệu ở phía N(DonDatHang)
        private void btn_ThemDonDatHang_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO DonDatHang(MaĐH, NgayĐH, TrangThai, MaKH, MaNV) VALUES(@MaĐH, @NgayĐH, @TrangThai, @MaKH, @MaNV)";

            cmd.Parameters.AddWithValue("@MaĐH", txtMaDatHang.Text);
            cmd.Parameters.AddWithValue("@NgayĐH", dateTimeDatHang.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TrangThai", comboBoxTrangThai.Text); 
            cmd.Parameters.AddWithValue("@MaKH", txtMaKhachHangFK.Text);
            cmd.Parameters.AddWithValue("@MaNV", txtMaNhanVien.Text);

            cmd.ExecuteNonQuery();
            loadData();
        }

        // Xóa dữ liệu ở phía N(DonDatHang)
        private void btn_XoaDonDatHang_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM DonDatHang WHERE MaĐH = @MaĐH";

            cmd.Parameters.AddWithValue("@MaĐH", txtMaDatHang.Text);

            cmd.ExecuteNonQuery();
            loadData();
        }

        // Sửa dữ liệu ở phía N(DonDatHang)
        private void btn_SuaDonDatHang_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE DonDatHang SET MaĐH = @MaĐH, NgayĐH = @NgayĐH, TrangThai = @TrangThai, MaKH = @MaKH, MaNV = @MaNV WHERE MaĐH = @MaĐH";

            cmd.Parameters.AddWithValue("@MaĐH", txtMaDatHang.Text);
            cmd.Parameters.AddWithValue("@NgayĐH", dateTimeDatHang.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TrangThai", comboBoxTrangThai.Text); 
            cmd.Parameters.AddWithValue("@MaKH", txtMaKhachHangFK.Text);
            cmd.Parameters.AddWithValue("@MaNV", txtMaNhanVien.Text);

            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}
