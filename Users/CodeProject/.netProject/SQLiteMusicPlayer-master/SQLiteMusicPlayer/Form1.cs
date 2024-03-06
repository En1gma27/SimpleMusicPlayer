using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Data.SQLite;
using MetroFramework;
using System.Drawing;
using NAudio.Wave;
using NAudio.Gui;

namespace SQLiteMusicPlayer
{
    public partial class Form1 : MetroForm
    {
        SQLiteConnection con = null;
        String file = "";
        private WaveOutEvent waveOut;
        private BufferedWaveProvider bufferedWaveProvider;
        private WaveViewer waveViewer;
        public Form1()
        {
            InitializeComponent();
            if (!checkDatabase())
            {
                createDatabase();
            }
            else
            {
                loadSongs();
             
            }
            waveOut = new WaveOutEvent();

        }

        private void loadSongs()
        {
            try
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT rowid,artist,title,category FROM song", con);
                SQLiteDataReader reader = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String artist = reader.GetString(1);
                    String title = reader.GetString(2);
                    String category = reader.GetString(3);
                    ListViewItem item = new ListViewItem(new String[] { "" + id, artist, title,category });
                    listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
                    listView1.Items.Add(item);
                } 
                con.Close();
            }
            catch (Exception)
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private bool checkDatabase()
        {
            try
            {
                con = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
                con.Open();
                SQLiteCommand cmd1 = new SQLiteCommand("SELECT rowid,artist,title,category,data FROM song", con);
                SQLiteDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String artist = reader.GetString(1);
                    String title = reader.GetString(2);
                    String category = reader.GetString(3);
                    SQLiteCommand cmd2 = new SQLiteCommand("SELECT data FROM song WHERE rowid="+id, con);
                    byte[] data = (byte[])cmd2.ExecuteScalar();
                }
                reader.Close();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                if (con != null)
                {
                    con.Close();
                }
                return false;
            }
        }

        private void createDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile("db.sqlite");
                SQLiteConnection con = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
                con.Open();
                String query = "CREATE TABLE SONG(ARTIST VARCHAR(50),TITLE VARCHAR(50),CATEGORY VARCHAR(50),DATA BLOB);";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
            }
        }
        //hàm chọn c
        private void browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files|*.mp3;*.wav;";
            dialog.Title = "Please select an audio file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = dialog.FileName;
            }
        }
        //hàm load song
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                String ar = artist.Text;
                String tl = title.Text;
                String ct = category.Text;
                if (ar.Trim().Equals("") || tl.Trim().Equals(""))
                {
                    MetroMessageBox.Show(this, "Some fields are missing", "Fields missing");
                }
                else if (!file.Trim().EndsWith("mp3") && !file.Trim().EndsWith("wav"))
                {
                    MetroMessageBox.Show(this, "Please select a valid audio file", "Invalid file");
                }
                else
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO song (artist,title,data,category) VALUES (@artist,@title,@data,@category)", con);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@artist", ar);
                    cmd.Parameters.AddWithValue("@title", tl);
                    cmd.Parameters.AddWithValue("@category", ct);
                    cmd.Parameters.AddWithValue("@data", File.ReadAllBytes(file));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadSongs();
                    artist.Text = "";
                    title.Text = "";
                    category.Text = "";
                }
            }
            catch (Exception)
            {
                if(con!=null)
                {
                    con.Close();
                }
            }
        }
        //Hàm play nhạc
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MetroMessageBox.Show(this, "Please select a song to play", "No song selected");
                }
                else
                {
                    int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                    String artist = listView1.SelectedItems[0].SubItems[1].Text;
                    String title = listView1.SelectedItems[0].SubItems[2].Text;
                    String category = listView1.SelectedItems[0].SubItems[3].Text;
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT data FROM song WHERE rowid=" + id, con);
                    byte[] data = (byte[])cmd.ExecuteScalar();
                    con.Close();
                    audio1.playSong(artist, title, data);
                    
                 
                }
            }
            catch (Exception)
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        //Hàm xóa nhạc
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MetroMessageBox.Show(this, "Please select a song to delete", "No song selected");
                }
                else
                {
                    DialogResult dr = MetroMessageBox.Show(this, "Are you sure you want to delete the song?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand("DELETE FROM song WHERE rowid=" + id + ";" + "VACUUM", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        loadSongs();
                    }
                }
            }
            catch (Exception)
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void audio1_Load(object sender, EventArgs e)
        {
            waveViewer = new WaveViewer();
            waveViewer.Dock = DockStyle.Bottom; // Đặt vị trí của nó trong form
            Controls.Add(waveViewer);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreatePlayList_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void category_TextChanged(object sender, EventArgs e)
        {

        }


        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi người dùng chọn một category trong ListBox
            if (listBoxCategories.SelectedItem != null)
            {
                string selectedCategory = listBoxCategories.SelectedItem.ToString();
                // Hiển thị bài hát thuộc category được chọn trong ListView
                DisplaySongsByCategory(selectedCategory);
            }
            
        }

 
        private void DisplaySongsByCategory(string selectedCategory)
        {
            try
            {
                con.Open();

                // Sử dụng tham số để tránh tình trạng SQL injection
                string query = "SELECT rowid, artist, title, category FROM song WHERE category = @category";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@category", selectedCategory.ToString());

                SQLiteDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string artist = reader.GetString(1);
                    string title = reader.GetString(2);
                    string category = reader.GetString(3);

                    ListViewItem item = new ListViewItem(new string[] { "" + id, artist, title, category });
                    listView1.Items.Add(item);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }

                // Xử lý ngoại lệ nếu cần
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                foreach (ListViewItem item in listView1.Items)
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    string artist = item.SubItems[1].Text;
                    string title = item.SubItems[2].Text;
                    string category = item.SubItems[3].Text;

                    // Cập nhật thông tin trong cơ sở dữ liệu
                    string query = "UPDATE song SET artist = @artist, title = @title, category = @category WHERE rowid = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@artist", artist);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {    // Lấy item được chọn trong ListView
            ListViewItem item = listView1.GetItemAt(e.X, e.Y);

            if (item != null)
            {
                // Tạo TextBox để chỉnh sửa artist
                TextBox textBoxArtist = new TextBox();
                textBoxArtist.Text = item.SubItems[1].Text;
                textBoxArtist.Bounds = item.SubItems[1].Bounds;
                textBoxArtist.KeyDown += (s, args) =>
                {
                    if (args.KeyCode == Keys.Enter)
                    {
                        item.SubItems[1].Text = textBoxArtist.Text;
                    }
                };

                // Tạo TextBox để chỉnh sửa title
                TextBox textBoxTitle = new TextBox();
                textBoxTitle.Text = item.SubItems[2].Text;
                textBoxTitle.Bounds = item.SubItems[2].Bounds;
                textBoxTitle.KeyDown += (s, args) =>
                {
                    if (args.KeyCode == Keys.Enter)
                    {
                        item.SubItems[2].Text = textBoxTitle.Text;
                    }
                };

                // Tạo TextBox để chỉnh sửa category
                TextBox textBoxCategory = new TextBox();
                textBoxCategory.Text = item.SubItems[3].Text;
                textBoxCategory.Bounds = item.SubItems[3].Bounds;
                textBoxCategory.KeyDown += (s, args) =>
                {
                    if (args.KeyCode == Keys.Enter)
                    {
                        item.SubItems[3].Text = textBoxCategory.Text;
                    }
                };

                // Thêm TextBox vào ListView
                listView1.Controls.Add(textBoxArtist);
                listView1.Controls.Add(textBoxTitle);
                listView1.Controls.Add(textBoxCategory);

                // Tự động chọn TextBox để bắt đầu chỉnh sửa
                textBoxArtist.Focus();

                // Gắn sự kiện Click cho PictureBox4
                pictureBox4.Click += (s, args) =>
                {
                    try
                    {
                        con.Open();

                        // Lấy thông tin từ ListViewItem và cập nhật vào cơ sở dữ liệu
                        int id = int.Parse(item.SubItems[0].Text);
                        string artist = item.SubItems[1].Text;
                        string title = item.SubItems[2].Text;
                        string category = item.SubItems[3].Text;

                        string query = "UPDATE song SET artist = @artist, title = @title, category = @category WHERE rowid = @id";
                        SQLiteCommand cmd = new SQLiteCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@artist", artist);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        if (con != null)
                        {
                            con.Close();
                        }
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        // Xóa TextBox sau khi lưu vào cơ sở dữ liệu
                        listView1.Controls.Remove(textBoxArtist);
                        listView1.Controls.Remove(textBoxTitle);
                        listView1.Controls.Remove(textBoxCategory);
                    }
                };
            }
        }

        private void SearchmetroTextBox_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Sử dụng tham số để tránh tình trạng SQL injection
                string query = "SELECT title FROM song WHERE title=title";
                SQLiteCommand cmd = new SQLiteCommand(query, con);

                SQLiteDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string artist = reader.GetString(1);
                    string title = reader.GetString(2);
                    string category = reader.GetString(3);

                    ListViewItem item = new ListViewItem(new string[] { "" + id, artist, title, category });
                    listView1.Items.Add(item);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                if (con != null)
                {
                    con.Close();
                }

                // Xử lý ngoại lệ nếu cần
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DownloadForm downloadForm = new DownloadForm();
            downloadForm.ShowDialog();
        }
    }
}
