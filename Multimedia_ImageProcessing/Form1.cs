using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
//from chinh goc 
namespace Multimedia_ImageProcessing
{
    public partial class Form1 : Form
    {
        private string tenAnh;
        private string a1, a2;
        private Bitmap bitmap;
        Image Im;
        Image[] arrayImage = new Image[50000];
        Boolean open = false;
        imageProcess imP;
        int counter = 0;


        public Form1()
        {

            InitializeComponent();
            lbl_thongSo.Visible = false;
            tb_thongSo.Visible = false;
            contrastTracker.Visible = false;
            comboBox1.SelectedIndex = 0;
            btn_rotateX.Visible = false;
            btn_rotateY.Visible = false;
        }
        //public void appearChinhDoSang()
        //{
        //    lbl_thongSo.Visible = true; // Hiện Label
        //    listBox1.Visible = true; // Hiện ListBox
        //    tb_thongSo.Visible = false;

        //}
        public void appear()
        {
            label6.Visible = false;
            label7.Visible = false;
            btn_apDung.Visible = true;
            lbl_thongSo.Visible = true;
            tb_thongSo.Visible = true;
            contrastTracker.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            btn_apDung.Enabled = true;

        }
        public void ghepAnh()
        {
            tb_thongSo.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            comboBox4.Visible = true;
            comboBox4.SelectedIndex = 0;
            openTSMI.Enabled = false;
            btn_apDung.Enabled = true;
            btn_apDung.Visible = true;
        }

        public void koghepAnh()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox4.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            openTSMI.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        // hàm của minh
        /*private void openTSMI_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All|*.*"; // Định dạng ảnh hỗ trợ
            openFileDialog.Title = "Select an Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {




                // Tải ảnh từ tệp và hiển thị lên PictureBox
                Im = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = Im;
                open = true;
                counter = 0;
                arrayImage[counter++] = pictureBox1.Image;
                pictureBox1.BackgroundImage = null;
                pictureBox1.BackColor = Color.Black;

                // Phân loại ảnh
                //bitmap = new Bitmap(openFileDialog.FileName);
                //imgProc = new imageProcessing();
                //if (imgProc.IsTextImage(bitmap))
                //{
                //    lb_type.Text = "Ảnh văn bản";
                //}
                //else
                //{


                //    lb_type.Text = "Không phải ảnh văn bản";

                //}
                // Kiểm tra và xóa các tệp

            }
        }*/

        private void openTSMI_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All|*.*"; // Định dạng ảnh hỗ trợ
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                string extension = Path.GetExtension(fileName);
                int counter = 1;
                string newDirectory = @"D:\picvn"; // Thư mục lưu ảnh mới
                string newFileName = "pic_VN";

                // Tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(newDirectory))
                {
                    Directory.CreateDirectory(newDirectory);
                }

                // Kiểm tra tên file có chứa ký tự tiếng Việt hoặc dấu cách
                if (fileName.Any(c => c > 127 || char.IsWhiteSpace(c)))
                {
                    // Tạo tên file mới để tránh trùng lặp
                    string newFilePath;
                    do
                    {
                        newFilePath = Path.Combine(newDirectory, $"{newFileName}{counter}{extension}");
                        counter++;
                    } while (File.Exists(newFilePath));

                    // Sao chép file cũ sang file mới
                    File.Copy(openFileDialog.FileName, newFilePath);

                    // Cập nhật đường dẫn file mới
                    openFileDialog.FileName = newFilePath; // Cập nhật FileName để sử dụng sau này
                }

                // Tải hình ảnh vào PictureBox
                Im = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = Im;
                open = true;

                // Cập nhật mảng ảnh (nếu cần)
                arrayImage[0] = pictureBox1.Image; // Giả sử chỉ lưu ảnh đầu tiên
                pictureBox1.BackgroundImage = null;
                pictureBox1.BackColor = Color.Black;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Nếu có tên file gốc, trả lại tên file
            /*if (!string.IsNullOrEmpty(originalFileName))
            {
                string directory = Path.GetDirectoryName(originalFileName);
                string newFileName = "pic_VN"; // Tên file mới
                string extension = Path.GetExtension(originalFileName);
                string newFilePath = Path.Combine(directory, $"{newFileName}1{extension}"); // Tên file đổi

                // Kiểm tra và đổi tên lại
                if (File.Exists(newFilePath))
                {
                    try
                    {
                        File.Move(newFilePath, originalFileName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Lỗi khi đổi tên file: " + ex.Message);
                    }
                }
            }*/
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                lbl_thongSo.Text = "Độ sáng [-100;100]";
                /*appearChinhDoSang();*/ // Gọi hàm để thực hiện các thao tác khác nếu cần
                appear();
                koghepAnh();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                lbl_thongSo.Text = "Độ mờ lẻ [1;31]";
                appear();
                koghepAnh();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                lbl_thongSo.Text = "Hệ số bão hoà [-255;255]";
                appear();
                koghepAnh();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                koghepAnh();
                lbl_thongSo.Text = "Điều chỉnh thông số";
                contrastTracker.Visible = true;

                lbl_thongSo.Visible = true;
                tb_thongSo.Visible = false;

                btn_apDung.Visible = false;

                btn_rotateX.Visible = false;
                btn_rotateY.Visible = false;
                // Đặt tọa độ mới cho thanh kéo// Đặt khoảng cách mong muốn từ TextBox xuống thanh kéo
                int distanceFromTextBox = 15; // Khoảng cách bạn muốn

                // Đặt vị trí cho contrastTracker dưới TextBox
                contrastTracker.Location = new Point(tb_thongSo.Location.X,
                    tb_thongSo.Location.Y + tb_thongSo.Height + distanceFromTextBox);

            }
            else if (comboBox1.SelectedIndex == 5)
            {
                lbl_thongSo.Text = "Xoá phông";
                lbl_thongSo.Visible = false;
                tb_thongSo.Visible = false;
                contrastTracker.Visible = false;
                btn_apDung.Enabled = true;
                koghepAnh();
                btn_rotateX.Visible = false;
                btn_rotateY.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                lbl_thongSo.Text = "Ghép ảnh";
                //appear();
                ghepAnh();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                lbl_thongSo.Text = "Góc xoay";
                appear();
                koghepAnh();
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                lbl_thongSo.Text = "Chiều lật";
                btn_rotateX.Visible = true;
                btn_rotateY.Visible = true;
                tb_thongSo.Visible = false;
                contrastTracker.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                koghepAnh();
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                lbl_thongSo.Text = "Thêm khung ảnh";
                btn_rotateX.Visible = false;
                btn_rotateY.Visible = false;
                btn_apDung.Visible = true;
                lbl_thongSo.Visible = true;
                contrastTracker.Visible = false;
                btn_apDung.Enabled = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                tb_thongSo.Visible = false;
                label6.Visible = true;
                label7.Visible = true;
                koghepAnh();
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                lbl_thongSo.Text = "Cắt ảnh";
                appear();
                koghepAnh();
            }

            else if (comboBox1.SelectedIndex == 11)
            {
                lbl_thongSo.Text = "Lấy biên ảnh bằng phương pháp sobel";
                lbl_thongSo.Visible = true;
                tb_thongSo.Visible = true;
                koghepAnh();
                contrastTracker.Visible = false;
            }
            else
            {
                btn_rotateX.Visible = false;
                btn_rotateY.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                btn_apDung.Enabled = false;
                lbl_thongSo.Visible = false;
                tb_thongSo.Visible = false;
                contrastTracker.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                koghepAnh();
            }
        }

        private void btn_apDung_Click(object sender, EventArgs e)
        {   //chỉnh sửa button dựa theo chức năng
            if (comboBox1.SelectedIndex == 5)
            {
                string inputImage = openFileDialog.FileName;

                // Lấy đường dẫn thư mục `output` trong dự án
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string outputFolder = Path.Combine(projectDirectory, "output");

                //Tạo thư mục `output` nếu chưa tồn tại
                if (!Directory.Exists(outputFolder))
                {
                    Directory.CreateDirectory(outputFolder);
                }

                // Đường dẫn file đầu ra
                string outputImage = Path.Combine(outputFolder, "removeBkg_output.png");
                imP = new imageProcess();
                // Gọi hàm xử lý
                imP.RemoveBackground(inputImage, outputImage);
                // Hiển thị ảnh đã xử lý lên PictureBox
                if (File.Exists(outputImage)) // Kiểm tra ảnh đã được tạo
                {
                    pictureBox1.Image = new Bitmap(outputImage);
                    arrayImage[counter++] = pictureBox1.Image;

                    //MessageBox.Show("Ảnh đã được xử lý và hiển thị!");
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy ảnh đã xử lý.");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                int brightnessValue;
                if (int.TryParse(tb_thongSo.Text, out brightnessValue)) // Kiểm tra nếu có mục nào được chọn
                {
                    //int brightnessValue = Convert.ToInt32(tb_thongSo.Text);

                    // Kiểm tra điều kiện độ sáng
                    if (brightnessValue < -100 || brightnessValue > 100)
                    {
                        MessageBox.Show("Giá trị độ sáng phải nằm trong khoảng từ -100 đến 100.");
                        return; // Thoát khỏi phương thức nếu điều kiện không hợp lệ
                    }

                    string inputImage = openFileDialog.FileName;

                    // Lấy đường dẫn thư mục `output` trong dự án
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string outputFolder = Path.Combine(projectDirectory, "output");

                    // Tạo thư mục `output` nếu chưa tồn tại
                    if (!Directory.Exists(outputFolder))
                    {
                        Directory.CreateDirectory(outputFolder);
                    }

                    // Đường dẫn file đầu ra
                    string outputImage = Path.Combine(outputFolder, "ChangedoSang.png");

                    // Nếu tệp đầu ra đã tồn tại, chuyển đường dẫn
                    int n = 0;
                    do
                    {
                        n++; // Tăng giá trị n
                        outputImage = Path.Combine(outputFolder, $"ChangedoSang_{brightnessValue + n}.png");
                    } while (File.Exists(outputImage)); // Kiểm tra nếu tệp đã tồn tại

                    imP = new imageProcess();
                    // Gọi hàm xử lý
                    imP.ChangeDoSang(inputImage, outputImage, brightnessValue);

                    // Hiển thị ảnh đã xử lý lên PictureBox
                    if (File.Exists(outputImage)) // Kiểm tra ảnh đã được tạo
                    {
                        pictureBox1.Image = new Bitmap(outputImage);
                        arrayImage[counter++] = pictureBox1.Image;

                        // MessageBox.Show("Ảnh đã được xử lý và hiển thị!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy ảnh đã xử lý.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền hệ số điều chỉnh độ sáng");
                }
            }
            //chỉnh độ mờ
            else if (comboBox1.SelectedIndex == 2)
            {
                int blurValue;
                if (int.TryParse(tb_thongSo.Text, out blurValue)) // Kiểm tra nếu có mục nào được chọn
                {
                    //int brightnessValue = Convert.ToInt32(tb_thongSo.Text);

                    // Kiểm tra điều kiện độ mờ
                    if (blurValue < 1 || blurValue > 31 || blurValue % 2 == 0)
                    {
                        MessageBox.Show("Giá trị độ mờ phải nằm trong khoảng từ 1 đến 31 và phải là số lẻ.");
                        return; // Thoát khỏi phương thức nếu điều kiện không hợp lệ
                    }

                    string inputImage = openFileDialog.FileName;

                    // Lấy đường dẫn thư mục `output` trong dự án
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string outputFolder = Path.Combine(projectDirectory, "output");

                    // Tạo thư mục `output` nếu chưa tồn tại
                    if (!Directory.Exists(outputFolder))
                    {
                        Directory.CreateDirectory(outputFolder);
                    }

                    // Đường dẫn file đầu ra
                    string outputImage = Path.Combine(outputFolder, "ChangedoMo.png");

                    // Nếu tệp đầu ra đã tồn tại, chuyển đường dẫn
                    int n = 0;
                    do
                    {
                        n++; // Tăng giá trị n
                        outputImage = Path.Combine(outputFolder, $"ChangedoMo_{blurValue + n}.png");
                    } while (File.Exists(outputImage)); // Kiểm tra nếu tệp đã tồn tại

                    imP = new imageProcess();
                    // Gọi hàm xử lý
                    imP.lamMo(inputImage, outputImage, blurValue);

                    // Hiển thị ảnh đã xử lý lên PictureBox
                    if (File.Exists(outputImage)) // Kiểm tra ảnh đã được tạo
                    {
                        pictureBox1.Image = new Bitmap(outputImage);
                        arrayImage[counter++] = pictureBox1.Image;

                        // MessageBox.Show("Ảnh đã được xử lý và hiển thị!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy ảnh đã xử lý.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền hệ số điều chỉnh độ mờ");
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                int colorValue;
                if (int.TryParse(tb_thongSo.Text, out colorValue)) // Kiểm tra nếu có mục nào được chọn
                {
                    //int brightnessValue = Convert.ToInt32(tb_thongSo.Text);

                    // Kiểm tra điều kiện độ màu
                    if (colorValue < -255 || colorValue > 255)
                    {
                        MessageBox.Show("Giá trị độ màu phải nằm trong khoảng từ -255 đến 255.");
                        return; // Thoát khỏi phương thức nếu điều kiện không hợp lệ
                    }

                    string inputImage = openFileDialog.FileName;

                    // Lấy đường dẫn thư mục `output` trong dự án
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string outputFolder = Path.Combine(projectDirectory, "output");

                    // Tạo thư mục `output` nếu chưa tồn tại
                    if (!Directory.Exists(outputFolder))
                    {
                        Directory.CreateDirectory(outputFolder);
                    }

                    // Đường dẫn file đầu ra
                    string outputImage = Path.Combine(outputFolder, "ChangedoMau.png");

                    // Nếu tệp đầu ra đã tồn tại, chuyển đường dẫn
                    int n = 0;
                    do
                    {
                        n++; // Tăng giá trị n
                        outputImage = Path.Combine(outputFolder, $"ChangedoMau_{colorValue + n}.png");
                    } while (File.Exists(outputImage)); // Kiểm tra nếu tệp đã tồn tại

                    imP = new imageProcess();
                    // Gọi hàm xử lý
                    imP.thayDoiDoMau(inputImage, outputImage, colorValue);

                    // Hiển thị ảnh đã xử lý lên PictureBox
                    if (File.Exists(outputImage)) // Kiểm tra ảnh đã được tạo
                    {
                        pictureBox1.Image = new Bitmap(outputImage);
                        arrayImage[counter++] = pictureBox1.Image;

                        // MessageBox.Show("Ảnh đã được xử lý và hiển thị!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy ảnh đã xử lý.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền hệ số điều chỉnh độ màu");
                }
            }
            // minh
            else if (comboBox1.SelectedIndex == 4)
            {
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                if (textBox1.Text != textBox2.Text && comboBox4.SelectedItem.ToString() != "Chọn loại ghép")
                {

                    string kieu = "";
                    try
                    {

                        if (comboBox4.SelectedItem.ToString() == "ảnh 1 trái ảnh 2 phải")
                        {
                            kieu = "a1ta2";
                        }
                        if (comboBox4.SelectedItem.ToString() == "ảnh 1 trên ảnh 2 dưới")
                        {
                            kieu = "a1da2";
                        }
                        if (comboBox4.SelectedItem.ToString() == "ảnh 2 trên ảnh 1 dưới")
                        {
                            kieu = "a2da1";
                        }
                        if (comboBox4.SelectedItem.ToString() == "ảnh 2 trái ảnh 1 phải")
                        {
                            kieu = "a2ta1";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi ghép ảnh: {ex.Message}");
                    }
                    string pic1 = a1;

                    string pic2 = a2;

                    if (!File.Exists(pic1) || !File.Exists(pic2))
                    {
                        MessageBox.Show("Một hoặc cả hai tệp hình ảnh không tồn tại.");
                        return;
                    }
                    // Lấy đường dẫn thư mục `output` trong dự án
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string outputFolder = Path.Combine(projectDirectory, "output");

                    // Tạo thư mục `output` nếu chưa tồn tại
                    if (!Directory.Exists(outputFolder))
                    {
                        Directory.CreateDirectory(outputFolder);
                    }

                    // Đường dẫn file đầu ra
                    string output1 = Path.Combine(outputFolder, "ChangeGhep.jpg");

                    // Nếu tệp đầu ra đã tồn tại, chuyển đường dẫn
                    int n = 0;
                    do
                    {
                        n++; // Tăng giá trị n
                        output1 = Path.Combine(outputFolder, $"ChangeGhep_{n}.jpg");
                    } while (File.Exists(output1)); // Kiểm tra nếu tệp đã tồn tại

                    imP = new imageProcess();
                    // Gọi hàm xử lý
                    imP.ghepAnh(pic1, pic2, output1, kieu);

                    // Hiển thị ảnh đã xử lý lên PictureBox
                    if (File.Exists(output1)) // Kiểm tra ảnh đã được tạo
                    {
                        pictureBox1.Image = new Bitmap(output1);
                        arrayImage[counter++] = pictureBox1.Image;

                        // MessageBox.Show("Ảnh đã được xử lý và hiển thị!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy ảnh đã xử lý.");
                    }

                }
                else
                {//ẩn nút áp dụng 
                    MessageBox.Show("Vui lòng thử lại.");
                    return;
                }
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                int doXoay;
                if (int.TryParse(tb_thongSo.Text, out doXoay)) // Kiểm tra nếu có mục nào được chọn
                {
                    //int brightnessValue = Convert.ToInt32(tb_thongSo.Text);

                    // Kiểm tra điều kiện độ màu
                    if (doXoay < -360 || doXoay > 360)
                    {
                        MessageBox.Show("Giá trị độ xoay phải nằm trong khoảng từ -360 đến 360.");
                        return; // Thoát khỏi phương thức nếu điều kiện không hợp lệ
                    }

                    string inputImage = openFileDialog.FileName;

                    // Lấy đường dẫn thư mục `output` trong dự án
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string outputFolder = Path.Combine(projectDirectory, "output");

                    // Tạo thư mục `output` nếu chưa tồn tại
                    if (!Directory.Exists(outputFolder))
                    {
                        Directory.CreateDirectory(outputFolder);
                    }

                    // Đường dẫn file đầu ra
                    string outputImage = Path.Combine(outputFolder, "ChangedoXoay.png");

                    // Nếu tệp đầu ra đã tồn tại, chuyển đường dẫn
                    int n = 0;
                    do
                    {
                        n++; // Tăng giá trị n
                        outputImage = Path.Combine(outputFolder, $"ChangedoXoay_{doXoay + n}.png");
                    } while (File.Exists(outputImage)); // Kiểm tra nếu tệp đã tồn tại

                    imP = new imageProcess();
                    // Gọi hàm xử lý
                    imP.xoayAnh(inputImage, outputImage, doXoay);

                    // Hiển thị ảnh đã xử lý lên PictureBox
                    if (File.Exists(outputImage)) // Kiểm tra ảnh đã được tạo
                    {
                        pictureBox1.Image = new Bitmap(outputImage);
                        arrayImage[counter++] = pictureBox1.Image;

                        // MessageBox.Show("Ảnh đã được xử lý và hiển thị!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy ảnh đã xử lý.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền hệ số điều chỉnh độ xoay");
                }
            }
            else if (comboBox1.SelectedIndex == 8)
            {
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                if (comboBox2.SelectedItem.ToString() != "Chọn màu" &&
                    comboBox3.SelectedItem.ToString() != "Chọn kích cỡ khung")
                {

                    string tenMau = comboBox2.SelectedItem.ToString();

                    string inputImage = openFileDialog.FileName;
                    int borderSize;
                    if (int.TryParse(comboBox3.SelectedItem.ToString(), out borderSize))
                    {
                        // Lấy đường dẫn thư mục `output` trong dự án
                        string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string outputFolder = Path.Combine(projectDirectory, "output");

                        // Tạo thư mục `output` nếu chưa tồn tại
                        if (!Directory.Exists(outputFolder))
                        {
                            Directory.CreateDirectory(outputFolder);
                        }

                        // Đường dẫn file đầu ra
                        string outputImage = Path.Combine(outputFolder, "ChangeKhung.png");

                        // Nếu tệp đầu ra đã tồn tại, chuyển đường dẫn
                        int n = 0;
                        do
                        {
                            n++; // Tăng giá trị n
                            outputImage = Path.Combine(outputFolder, $"ChangeKhung_{borderSize + n}.png");
                        } while (File.Exists(outputImage)); // Kiểm tra nếu tệp đã tồn tại

                        imP = new imageProcess();
                        // Gọi hàm xử lý
                        imP.themKhung(inputImage, outputImage, tenMau, borderSize);

                        // Hiển thị ảnh đã xử lý lên PictureBox
                        if (File.Exists(outputImage)) // Kiểm tra ảnh đã được tạo
                        {
                            pictureBox1.Image = new Bitmap(outputImage);
                            arrayImage[counter++] = pictureBox1.Image;

                            // MessageBox.Show("Ảnh đã được xử lý và hiển thị!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể tìm thấy ảnh đã xử lý.");
                        }
                    }
                }
                else
                {//ẩn nút áp dụng 
                    MessageBox.Show("Vui lòng thử lại.");
                    return;
                }
            }
            else if (comboBox1.SelectedIndex == 10)
            {
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                if (open)
                {
                    //Bitmap original = new Bitmap(openFileDialog.FileName);
                    imP = new imageProcess();
                    Image im = pictureBox1.Image;
                    Bitmap im1 = new Bitmap(im);
                    Bitmap result = imP.ApplySobelFilter(im1);
                    pictureBox1.Image = result;
                    arrayImage[counter++] = pictureBox1.Image;
                }
                else
                {
                    MessageBox.Show("At first Open An Image", "File not Opened ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void contrastTracker_Scroll(object sender, EventArgs e)
        {
            if (!open)
            {
                MessageBox.Show("Hãy mở ảnh để chỉnh sửa", "Ảnh chưa được mở", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float c = Convert.ToSingle(contrastTracker.Value) / 10.0f;
                float t = (1.0f - c) / 2.0f;
                Image img = Im;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{c,0,0,0,0},
                    new float[]{0,c,0,0,0},
                    new float[]{0,0,c,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{t, t, t, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
                arrayImage[counter++] = pictureBox1.Image;


            }
        }

        private void undoTSMI_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--; // Giảm counter để truy cập ảnh trước đó trong mảng
                pictureBox1.Image = arrayImage[counter];
            }
            else
            {
                MessageBox.Show("Không thể hoàn tác nữa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void redoTSMI_Click(object sender, EventArgs e)
        {
            if (arrayImage[counter + 1] != null && counter < arrayImage.Length - 1) // Kiểm tra trạng thái tiếp theo có tồn tại
            {
                counter++; // Tiến tới trạng thái tiếp theo
                pictureBox1.Image = arrayImage[counter]; // Gán ảnh tiếp theo
            }
            else
            {
                MessageBox.Show("Không có trạng thái nào để quay lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--; // Giảm counter để truy cập ảnh trước đó trong mảng
                pictureBox1.Image = arrayImage[counter];
            }
            else
            {
                MessageBox.Show("Không thể hoàn tác nữa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            if (arrayImage[counter + 1] != null && counter < arrayImage.Length - 1) // Kiểm tra trạng thái tiếp theo có tồn tại
            {
                counter++; // Tiến tới trạng thái tiếp theo
                pictureBox1.Image = arrayImage[counter]; // Gán ảnh tiếp theo
            }
            else
            {
                MessageBox.Show("Không có trạng thái nào để quay lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void tb_thongSo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string outputFolder = Path.Combine(projectDirectory, "output");

            // Kiểm tra và xóa các tệp
            if (Directory.Exists(outputFolder))
            {
                //foreach (var file in Directory.GetFiles(outputFolder, "ChangedoSang*.png"))
                foreach (var file in Directory.GetFiles(outputFolder, "Change*.png"))
                {
                    File.Delete(file);
                }
                foreach (var file in Directory.GetFiles(outputFolder, "Change*.jpg"))
                {
                    File.Delete(file);
                }
            }
            string output2 = @"D:\picvn";
            if (Directory.Exists(output2))
            {
                //foreach (var file in Directory.GetFiles(outputFolder, "ChangedoSang*.png"))
                foreach (var file in Directory.GetFiles(output2, "pic_VN*.png"))
                {
                    File.Delete(file);
                }
                foreach (var file in Directory.GetFiles(output2, "pic_VN*.jpg"))
                {
                    File.Delete(file);
                }
            }

        }




        private void tệpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveTSMI_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Thiết lập bộ lọc cho định dạng tệp
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif";
                saveFileDialog.Title = "Save an Image";

                // Hiển thị hộp thoại và kiểm tra nếu người dùng nhấn nút Lưu
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Kiểm tra nếu có ảnh trong PictureBox
                        if (pictureBox1.Image != null)
                        {
                            // Lưu ảnh theo định dạng được chọn
                            string extension = Path.GetExtension(saveFileDialog.FileName).ToLower();
                            System.Drawing.Imaging.ImageFormat format;

                            switch (extension)
                            {
                                case ".jpg":
                                case ".jpeg":
                                    format = System.Drawing.Imaging.ImageFormat.Jpeg;
                                    break;
                                case ".png":
                                    format = System.Drawing.Imaging.ImageFormat.Png;
                                    break;
                                case ".bmp":
                                    format = System.Drawing.Imaging.ImageFormat.Bmp;
                                    break;
                                case ".gif":
                                    format = System.Drawing.Imaging.ImageFormat.Gif;
                                    break;
                                default:
                                    MessageBox.Show("Định dạng tệp không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                            }

                            // Lưu ảnh
                            pictureBox1.Image.Save(saveFileDialog.FileName, format);
                            MessageBox.Show("Ảnh đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có ảnh nào để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void btn_rotateY_Click(object sender, EventArgs e)
        {
            if (open)
            {
                Image im = pictureBox1.Image;
                Bitmap im1 = new Bitmap(im);
                im1.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox1.Image = im1;

            }
            else
            {
                MessageBox.Show("At first Open An Image", "File not Opened ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_rotateX_Click(object sender, EventArgs e)
        {

            if (open)
            {
                Image im = pictureBox1.Image;
                Bitmap im1 = new Bitmap(im);
                im1.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Image = im1;
                arrayImage[counter++] = pictureBox1.Image;
            }
            else
            {
                MessageBox.Show("At first Open An Image", "File not Opened ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sobelTSMI_Click(object sender, EventArgs e)
        {
            if (open)
            {
                //Bitmap original = new Bitmap(openFileDialog.FileName);
                imP = new imageProcess();
                Image im = pictureBox1.Image;
                Bitmap im1 = new Bitmap(im);
                Bitmap result = imP.ApplySobelFilter(im1);
                pictureBox1.Image = result;
                arrayImage[counter++] = pictureBox1.Image;
            }
            else
            {
                MessageBox.Show("At first Open An Image", "File not Opened ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Cài đặt bộ lọc để chỉ cho phép chọn các tệp hình ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn ảnh";

                // Kiểm tra nếu người dùng đã chọn một tệp
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy tên tệp
                    string fileName = openFileDialog.FileName;
                    string newFileName = Path.GetFileName(fileName);
                    string newDirectory = @"D:\picvn"; // Đường dẫn lưu ảnh mới
                    string extension = Path.GetExtension(fileName);
                    int counter = 1;

                    // Kiểm tra xem tên tệp có dấu tiếng Việt hoặc dấu cách không
                    if (fileName.Any(c => c > 127 || char.IsWhiteSpace(c)))
                    {
                        // Tạo thư mục nếu chưa tồn tại
                        if (!Directory.Exists(newDirectory))
                        {
                            Directory.CreateDirectory(newDirectory);
                        }

                        // Tạo tên file mới
                        string newFilePath;
                        do
                        {
                            newFilePath = Path.Combine(newDirectory, $"pic_VN{counter}{extension}");
                            counter++;
                        } while (File.Exists(newFilePath));

                        // Sao chép file cũ sang file mới
                        File.Copy(fileName, newFilePath);

                        // Cập nhật biến a1 thành tên tệp mới
                        a1 = newFilePath; // Hoặc chỉ cần lưu tên file mới: Path.GetFileName(newFilePath)
                        textBox1.Text = Path.GetFileName(fileName); // Hiển thị tên file mới
                    }
                    else
                    {
                        // Nếu không có dấu, chỉ cần cập nhật biến a1 và hiển thị tên tệp
                        a1 = fileName;
                        textBox1.Text = Path.GetFileName(fileName);
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Cài đặt bộ lọc để chỉ cho phép chọn các tệp hình ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn ảnh";

                // Kiểm tra nếu người dùng đã chọn một tệp
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy tên tệp
                    string fileName = openFileDialog.FileName;
                    string newFileName = Path.GetFileName(fileName);
                    string newDirectory = @"D:\picvn"; // Đường dẫn lưu ảnh mới
                    string extension = Path.GetExtension(fileName);
                    int counter = 1;

                    // Kiểm tra xem tên tệp có dấu tiếng Việt hoặc dấu cách không
                    if (fileName.Any(c => c > 127 || char.IsWhiteSpace(c)))
                    {
                        // Tạo thư mục nếu chưa tồn tại
                        if (!Directory.Exists(newDirectory))
                        {
                            Directory.CreateDirectory(newDirectory);
                        }

                        // Tạo tên file mới
                        string newFilePath;
                        do
                        {
                            newFilePath = Path.Combine(newDirectory, $"pic_VN{counter}{extension}");
                            counter++;
                        } while (File.Exists(newFilePath));

                        // Sao chép file cũ sang file mới
                        File.Copy(fileName, newFilePath);

                        // Cập nhật biến a1 thành tên tệp mới
                        a2 = newFilePath; // Hoặc chỉ cần lưu tên file mới: Path.GetFileName(newFilePath)
                        textBox2.Text = Path.GetFileName(fileName); // Hiển thị tên file mới
                    }
                    else
                    {
                        // Nếu không có dấu, chỉ cần cập nhật biến a1 và hiển thị tên tệp
                        a2 = fileName;
                        textBox2.Text = Path.GetFileName(fileName);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tệpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

    }
}