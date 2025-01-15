using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
//from chinh
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
        public void appear()
        {
            lbl_thongSo.Visible = true;
            tb_thongSo.Visible = true;
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
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                lbl_thongSo.Text = "Độ sáng";
                appear();

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                lbl_thongSo.Text = "Độ mờ";
                appear();

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                lbl_thongSo.Text = "Hệ số bão hoà";
                appear();

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                lbl_thongSo.Text = "Điều chỉnh thông số";
                lbl_thongSo.Visible = true;
                tb_thongSo.Visible = false;
                contrastTracker.Visible = true;
                btn_apDung.Visible = false;

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
                appear();

            }
            else if (comboBox1.SelectedIndex == 10)
            {
                lbl_thongSo.Text = "Cắt ảnh";
                appear();

            }
        }

        private void btn_apDung_Click(object sender, EventArgs e)
        {
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
    }
}
