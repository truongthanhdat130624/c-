using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace bai_kt
{
    public partial class Form2 : Form
    {
        int rowindex = -1;
        string[] listkhoa = { "Công nghệ thông tin", "Kế Toán", "Ngoại Ngữ", "Điện tử" };
        private string selectedImagePath; // Biến lưu tên tệp ảnh

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = listkhoa;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;

            // Kiểm tra và tạo thư mục lưu trữ hình ảnh nếu chưa tồn tại
            string imageFolder = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }
        }

        // Hàm chọn ảnh sinh viên
        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy tên tệp ảnh
                selectedImagePath = Path.GetFileName(openFileDialog.FileName);

                // Tạo đường dẫn đích trong thư mục "Images"
                string destinationPath = Path.Combine(Application.StartupPath, "Images", selectedImagePath);

                // Sao chép tệp ảnh vào thư mục "Images" nếu chưa tồn tại
                if (!File.Exists(destinationPath))
                {
                    File.Copy(openFileDialog.FileName, destinationPath);
                }

                // Hiển thị ảnh đã chọn
                pictureBoxStudent.Image = Image.FromFile(destinationPath);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;

            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                // Hiển thị dữ liệu của hàng đã chọn
                mtxtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value.ToString();
                string ngaySinhString = dgvDanhSach.Rows[rowindex].Cells["NgaySinh"].Value.ToString();
                DateTime ngaySinh;

                if (DateTime.TryParse(ngaySinhString, out ngaySinh))
                {
                    dtpNgaySinh.Value = ngaySinh; // Nếu chuyển đổi thành công, gán giá trị cho DateTimePicker
                }

                string gioiTinh = dgvDanhSach.Rows[rowindex].Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rbNam.Checked = true;
                }
                else
                {
                    rbNu.Checked = true;
                }

                // Hiển thị lại hình ảnh từ tên tệp nếu có
                string imagePath = dgvDanhSach.Rows[rowindex].Cells["Hinh"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    // Tạo đường dẫn đầy đủ của hình ảnh
                    string fullImagePath = Path.Combine(Application.StartupPath, "Images", imagePath);
                    if (File.Exists(fullImagePath))
                    {
                        pictureBoxStudent.Image = Image.FromFile(fullImagePath); // Hiển thị ảnh từ đường dẫn đầy đủ
                    }
                    else
                    {
                        pictureBoxStudent.Image = null; // Nếu không có hình ảnh thì xóa hình ảnh khỏi PictureBox
                    }
                }
                else
                {
                    pictureBoxStudent.Image = null; // Nếu không có hình ảnh thì xóa hình ảnh khỏi PictureBox
                }

                // Cập nhật trạng thái nút
                btnThem.Enabled = false;    // Vô hiệu hóa nút Thêm
                btnCapNhat.Enabled = true;  // Kích hoạt nút Cập nhật
                btnXoa.Enabled = true;      // Kích hoạt nút Xóa
            }
        }

        // Hàm thêm sinh viên (bao gồm cả hình ảnh)
        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (!mtxtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên phải có 10 ký tự");
                }

                if (this.checkMaSV(mtxtMaSV.Text) == false)
                {
                    throw new Exception("Mã sinh viên đã tồn tại");
                }

                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không được để trống");
                }

                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Điểm trung bình phải là số");
                }

                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;
                string ngaysinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
                string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";

                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[row].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[row].Cells["DiemTB"].Value = diemtb;
                dgvDanhSach.Rows[row].Cells["Khoa"].Value = khoa;
                dgvDanhSach.Rows[row].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[row].Cells["GioiTinh"].Value = gioiTinh;

                // Lưu tên tệp hình ảnh
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    dgvDanhSach.Rows[row].Cells["Hinh"].Value = selectedImagePath; // Chỉ lưu tên tệp
                }

                ResetData(); // Reset dữ liệu sau khi thêm
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
                btnThem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        public bool checkMaSV(string masv)
        {
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSV"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần sửa");
                }

                if (!mtxtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên phải có 10 ký tự");
                }

                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Điểm trung bình phải là số");
                }

                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;
                string ngaysinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
                string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";

                // Cập nhật các thông tin cơ bản
                dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value = diemtb;
                dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value = khoa;
                dgvDanhSach.Rows[rowindex].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowindex].Cells["GioiTinh"].Value = gioiTinh;

                // Kiểm tra nếu người dùng có chọn ảnh mới
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    dgvDanhSach.Rows[rowindex].Cells["Hinh"].Value = selectedImagePath; // Chỉ lưu tên tệp hình ảnh mới
                }

                ResetData(); // Reset dữ liệu sau khi cập nhật
                btnThem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần xóa");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);

                ResetData(); // Reset dữ liệu sau khi xóa
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
                btnThem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Bạn có muốn thoát không?",
             "Thông báo",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ResetData()
        {
            mtxtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false;
            pictureBoxStudent.Image = null; // Xóa hình ảnh khỏi PictureBox
            selectedImagePath = null; // Reset lại tên tệp ảnh
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string khoaLoc = cbKhoaLoc.SelectedItem?.ToString();  // Khoa được chọn
            string gioiTinhLoc = cbGioiTinhLoc.SelectedItem?.ToString(); // Giới tính được chọn
            string diemLoc = cbDiemLoc.SelectedItem?.ToString();  // Điểm được chọn

            foreach (DataGridViewRow row in dgvDanhSach.Rows)
            {
                if (row.IsNewRow)  // Kiểm tra nếu hàng mới chưa được commit
                {
                    continue;  // Bỏ qua hàng mới chưa được commit
                }

                bool visible = true;

                // Lọc theo Khoa nếu có chọn
                if (!string.IsNullOrEmpty(khoaLoc) && row.Cells["Khoa"].Value?.ToString() != khoaLoc)
                {
                    visible = false;
                }

                // Lọc theo Giới tính nếu có chọn
                if (!string.IsNullOrEmpty(gioiTinhLoc) && row.Cells["GioiTinh"].Value?.ToString() != gioiTinhLoc)
                {
                    visible = false;
                }

                // Lọc theo Điểm nếu có chọn
                if (!string.IsNullOrEmpty(diemLoc))
                {
                    double diemTB = Convert.ToDouble(row.Cells["DiemTB"].Value);
                    switch (diemLoc)
                    {
                        case "Dưới 5":
                            if (diemTB >= 5)
                                visible = false;
                            break;
                        case "5 đến 7":
                            if (diemTB < 5 || diemTB > 7)
                                visible = false;
                            break;
                        case "Trên 7":
                            if (diemTB <= 7)
                                visible = false;
                            break;
                    }
                }

                // Cập nhật hàng ẩn hoặc hiển thị
                row.Visible = visible;
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
