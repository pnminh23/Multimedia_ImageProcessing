using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Multimedia_ImageProcessing
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            lbl_thongSo.Visible = false;
            tb_thongSo.Visible = false;
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
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
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
                lbl_thongSo.Text = "Độ tương phản";
                appear();

            }
            else if (comboBox1.SelectedIndex == 5)
            {
                lbl_thongSo.Text = "Xoá phông";
                appear();

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

        }
    }
}
