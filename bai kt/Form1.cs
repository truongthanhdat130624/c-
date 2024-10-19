using System;
using System.Windows.Forms;

namespace bai_kt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox của username và password
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Kiểm tra tên đăng nhập và mật khẩu (ở đây chỉ kiểm tra đơn giản)
            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tạo đối tượng của Form2 và hiển thị nó
                Form2 form2 = new Form2();
                form2.Show();

                // Ẩn Form1
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
