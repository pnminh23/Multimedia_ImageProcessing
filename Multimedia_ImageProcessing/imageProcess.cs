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

    }
}
