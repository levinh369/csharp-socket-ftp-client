using System;
using System.Windows.Forms;
using FTP_Client; // Đảm bảo namespace này đúng với project của bạn

namespace FTP_Client
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã nhập đủ chưa
            if (string.IsNullOrWhiteSpace(txt_host.Text) ||
                string.IsNullOrWhiteSpace(txt_usename.Text) ||
                string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Host IP, Username và Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Tạo Form1 và TRUYỀN DỮ LIỆU VÀO
                Form1 mainForm = new Form1(txt_host.Text.Trim(), txt_usename.Text.Trim(), txt_pass.Text);

                // 3. Ẩn form đăng nhập
                this.Hide();
                mainForm.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show(); // Hiện lại form nếu lỗi
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Nút thoát
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            // Để trống hoặc cài đặt mặc định nếu muốn
            txt_pass.PasswordChar = '*'; // Che mật khẩu
        }

        // Các hàm thừa do click nhầm, giữ nguyên để không lỗi Designer
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void txt_usename_TextChanged(object sender, EventArgs e) { }
    }
}