using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Exceptions;
using YoutubeExplode.Models.MediaStreams;

namespace SQLiteMusicPlayer
{
    public partial class DownloadForm : Form
    {
        public DownloadForm()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            // Lấy đường dẫn URL từ TextBox txtUrl
            var youtubeUrl = txtUrl.Text;

            try
            {
                // Kiểm tra xem URL có đúng định dạng không
                if (!IsValidYoutubeUrl(youtubeUrl))
                {
                    MessageBox.Show("Invalid YouTube URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Sử dụng biểu thức chính quy để trích xuất ID của video từ URL
                var match = Regex.Match(youtubeUrl, @"(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/)([a-zA-Z0-9_-]{11})", RegexOptions.IgnoreCase);

                // Kiểm tra xem có phải là một ID hợp lệ hay không
                if (!match.Success)
                {
                    MessageBox.Show("Invalid YouTube URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Khởi tạo một đối tượng YoutubeClient để tương tác với YouTube
                var youtubeClient = new YoutubeClient();

                // Sử dụng đối tượng YoutubeClient để lấy thông tin về video từ URL
                var videoInfo = await youtubeClient.GetVideoAsync(youtubeUrl);

                // Lấy ID của video từ thông tin video
                var videoId = videoInfo.Id;

                // Lấy thông tin về các luồng (streams) có thể tải về từ video
                var streamInfos = await youtubeClient.GetVideoMediaStreamInfosAsync(videoId);

                // Chọn luồng âm thanh có tỷ lệ bit (bitrate) cao nhất
                var audioStream = streamInfos.Audio.WithHighestBitrate();

                // Lấy tiêu đề của video
                var videoTitle = videoInfo.Title;

                // Tạo tên file mới sử dụng tiêu đề và thời gian hiện tại
                var fileName = $"{videoTitle}_{DateTime.Now:yyyyMMddHHmmss}";

                // Sử dụng đối tượng YoutubeClient để lấy thông tin về luồng âm thanh được chọn
                var audioStreamInfo = await youtubeClient.GetMediaStreamAsync(audioStream);

                // Đoạn mã ở đây để download audioStreamInfo
                // ...

                // Hiển thị thông báo thành công khi quá trình tải về hoàn tất
                MessageBox.Show("Audio downloaded successfully!", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidYoutubeUrl(string url)
        {
            return url.StartsWith("https://www.youtube.com/") || url.StartsWith("https://youtu.be/");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
