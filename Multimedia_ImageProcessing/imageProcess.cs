using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Python.Runtime;

namespace Multimedia_ImageProcessing
{
    internal class imageProcess
    {
        public imageProcess()
        {
            // Có thể thêm logic khởi tạo nếu cần
        }
        public void RemoveBackground(string inputImage, string outputImage)
        {
            // Đường dẫn tới file Python trong thư mục project
            string pythonScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts", "removeBkg.py");

            try
            {
                // Thiết lập process để gọi Python
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python", // Lệnh gọi Python
                    Arguments = $"\"{pythonScript}\" \"{inputImage}\" \"{outputImage}\"", // Tham số truyền vào script
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    // Đọc kết quả đầu ra
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    //if (process.ExitCode == 0)
                    //{
                    //    MessageBox.Show($"Background removed successfully! Output saved at {outputImage}");
                    //}
                    //else
                    //{
                    //    MessageBox.Show($"Error: {error}");
                    //}
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        public void ChangeDoSang(string inputImage, string outputImage, int brightnessValue)
        {
            string pythonScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts", "chinhDoSang.py");

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{pythonScript}\" \"{inputImage}\" {brightnessValue} \"{outputImage}\"", // Tham số truyền vào script
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void lamMo(string inputImage, string outputImage, int blurValue)
        {
            string pythonScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts", "moAnh.py");

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{pythonScript}\" \"{inputImage}\" {blurValue} \"{outputImage}\"", // Tham số truyền vào script
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        public void thayDoiDoMau(string inputImage, string outputImage, int colorValue)
        {
            string pythonScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts", "doiDoMau.py");

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{pythonScript}\" \"{inputImage}\" {colorValue} \"{outputImage}\"", // Tham số truyền vào script
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public Bitmap ApplySobelFilter(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;

            Bitmap outputImage = new Bitmap(width, height);

            int[,] sobelX = {
                { -1,  0,  1 },
                { -2,  0,  2 },
                { -1,  0,  1 }
            };

            int[,] sobelY = {
                { -1, -2, -1 },
                {  0,  0,  0 },
                {  1,  2,  1 }
            };

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int gradientX = 0;
                    int gradientY = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixelColor = inputImage.GetPixel(x + kx, y + ky);
                            int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                            gradientX += intensity * sobelX[ky + 1, kx + 1];
                            gradientY += intensity * sobelY[ky + 1, kx + 1];
                        }
                    }

                    int magnitude = (int)Math.Sqrt(gradientX * gradientX + gradientY * gradientY);
                    magnitude = Math.Clamp(magnitude, 0, 255);

                    outputImage.SetPixel(x, y, Color.FromArgb(magnitude, magnitude, magnitude));
                }
            }
            return outputImage;
=======

        
        public void xoayAnh(string inputImage, string outputImage, int doXoay)
        {
            string pythonScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts", "xoayAnh.py");

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{pythonScript}\" \"{inputImage}\" {doXoay} \"{outputImage}\"", // Tham số truyền vào script
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void themKhung(string inputImage, string outputImage, string tenMau,int borderSize)
        {
            string pythonScript = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts", "themKhung.py");
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{pythonScript}\" \"{inputImage}\" \"{borderSize}\" \"{tenMau}\" \"{outputImage}\"", // Tham số truyền vào script
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}
