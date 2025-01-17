using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
//from chinh goc 
namespace Multimedia_ImageProcessing
{
    public partial class Form1 : Form
    {
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void openTSMI_Click(object sender, EventArgs e)
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                lbl_thongSo.Text = "Độ sáng [-100;100]";
                /*appearChinhDoSang();*/ // Gọi hàm để thực hiện các thao tác khác nếu cần
                appear();

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                lbl_thongSo.Text = "Độ mờ lẻ [1;31]";
                appear();

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                lbl_thongSo.Text = "Hệ số bão hoà [-255;255]";
                appear();

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                lbl_thongSo.Text = "Điều chỉnh thông số";
                contrastTracker.Visible = true;

                lbl_thongSo.Visible = true;
                tb_thongSo.Visible = false;

                btn_apDung.Visible = false;


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
                btn_apDung.Visible = true;

            }
            else if (comboBox1.SelectedIndex == 6)
            {
                lbl_thongSo.Text = "Ghép ảnh";
                appear();

            }
            else if (comboBox1.SelectedIndex == 7)
            {
                lbl_thongSo.Text = "Góc xoay";
                appear();

            }
            else if (comboBox1.SelectedIndex == 8)
            {
                lbl_thongSo.Text = "Chiều lật";
                appear();

            }
            else if (comboBox1.SelectedIndex == 9)
            {
                lbl_thongSo.Text = "Thêm khung ảnh";
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
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                lbl_thongSo.Text = "Cắt ảnh";
                appear();

            }
            else
            {
                label6.Visible = false;
                label7.Visible = false;
                btn_apDung.Enabled = false;
                lbl_thongSo.Visible = false;
                tb_thongSo.Visible = false;
                contrastTracker.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
