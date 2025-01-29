using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace inventManagementApp
{
    public partial class Form2 : Form
    {
        private void InitializeComponent()
        {
            buttonBack = new Button();
            imageUploadButton = new Button();
            imageDeleteButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            time = new TextBox();
            quantity = new TextBox();
            comment = new TextBox();
            reroad = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = SystemColors.Window;
            buttonBack.Location = new Point(0, -5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(405, 91);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // imageUploadButton
            // 
            imageUploadButton.BackColor = SystemColors.Window;
            imageUploadButton.Location = new Point(0, 459);
            imageUploadButton.Name = "imageUploadButton";
            imageUploadButton.Size = new Size(247, 84);
            imageUploadButton.TabIndex = 1;
            imageUploadButton.Text = "imageUploadButton";
            imageUploadButton.UseVisualStyleBackColor = false;
            // 
            // imageDeleteButton
            // 
            imageDeleteButton.BackColor = SystemColors.Window;
            imageDeleteButton.Location = new Point(247, 459);
            imageDeleteButton.Name = "imageDeleteButton";
            imageDeleteButton.Size = new Size(253, 84);
            imageDeleteButton.TabIndex = 2;
            imageDeleteButton.Text = "imageDeleteButton";
            imageDeleteButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 364);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Desktop;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(411, 89);
            label1.Name = "label1";
            label1.Size = new Size(89, 91);
            label1.TabIndex = 4;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            time.Font = new Font("Yu Gothic UI", 14F);
            time.Location = new Point(12, 549);
            time.Name = "time";
            time.Size = new Size(146, 45);
            time.TabIndex = 5;
            // 
            // quantity
            // 
            quantity.Font = new Font("Yu Gothic UI", 14F);
            quantity.Location = new Point(164, 549);
            quantity.Name = "quantity";
            quantity.Size = new Size(130, 45);
            quantity.TabIndex = 6;
            // 
            // comment
            // 
            comment.Font = new Font("Yu Gothic UI", 14F);
            comment.Location = new Point(299, 549);
            comment.Name = "comment";
            comment.Size = new Size(189, 45);
            comment.TabIndex = 7;
            // 
            // reroad
            // 
            reroad.Location = new Point(411, -5);
            reroad.Name = "reroad";
            reroad.Size = new Size(89, 88);
            reroad.TabIndex = 8;
            reroad.Text = "更新";
            reroad.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(500, 606);
            Controls.Add(reroad);
            Controls.Add(comment);
            Controls.Add(quantity);
            Controls.Add(time);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(imageUploadButton);
            Controls.Add(imageDeleteButton);
            Controls.Add(buttonBack);
            Name = "Form2";
            Text = "Detail Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void Form2reroad_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isBackButtonPressed && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // ×ボタンが押された場合のみアプリ全体を終了
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            isBackButtonPressed = true; // フラグをセット
            parentForm.Show(); //  `Form1` を再表示
            this.Close(); //  `Form2` を閉じる
        }
        // 🔹 画像をデータベースに保存する処理
        // 🔹 データベースに画像を保存する処理
        private void SaveImageToDatabase(int id, Image image)
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();

                    // 画像をバイト配列に変換
                    byte[] imageData = ImageToByteArray(image);

                    using (var command = new SQLiteCommand("UPDATE images SET image_data = @imageData WHERE id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@imageData", imageData.Length > 0 ? (object)imageData : DBNull.Value); // 空データ対応
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("画像のデータベース保存に失敗しました。\n" + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        // 🔹 画像をアップロードする処理
        private void imageUploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "画像ファイル (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image originalImage = Image.FromFile(openFileDialog.FileName);
                    Image resizedImage = ResizeImageToFit(originalImage, pictureBox1.Width, pictureBox1.Height);

                    pictureBox1.Image = resizedImage; // リサイズした画像をセット
                    SaveImageToDatabase(currentId, originalImage); // 現在の ID を使用
                }
            }
        }

        // 🔹 画像を削除する処理
        private void imageDeleteButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                using (var command = new SQLiteCommand("UPDATE images SET image_data = @emptyBlob WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@emptyBlob", new byte[0]); // 空の BLOB
                    command.Parameters.AddWithValue("@id", currentId);
                    command.ExecuteNonQuery();
                }
            }
            pictureBox1.Image = null; // UI 側の画像をクリア
        }



        // 🔹 ID に基づいて画像を取得する
        public Image GetImageById(int id)
        {
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT image_data FROM images WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    var result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        byte[] imageData = (byte[])result;
                        return ByteArrayToImage(imageData); // 画像データを変換して返す
                    }

                    // **画像がない場合は透明な1x1ピクセルの画像を返す**
                    return new Bitmap(1, 1);
                }

            }
            return null; // データがない場合は何も表示しない
        }

        // 🔹 バイト配列を Image に変換
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        // 🔹 Image をバイト配列に変換
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        // 🔹 画像を読み込んで表示する//
        private void LoadImage(int id)
        {
            Image originalImage = GetImageById(id);
            if (originalImage != null)
            {
                pictureBox1.Image = ResizeImageToFit(originalImage, pictureBox1.Width, pictureBox1.Height);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        // 🔹 `PictureBox` に収まるように画像をリサイズ（縦横比維持）
        private Image ResizeImageToFit(Image image, int maxWidth, int maxHeight)
        {
            if (image == null) return null;

            // 元の画像サイズ
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // 比率を計算
            float ratioX = (float)maxWidth / originalWidth;
            float ratioY = (float)maxHeight / originalHeight;
            float ratio = Math.Min(ratioX, ratioY); // どちらか小さい比率を適用

            // 新しいサイズを計算（縦横比を維持）
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // 新しい画像を適切なサイズで作成（maxWidth, maxHeight を使用しない）
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.Clear(Color.Transparent);
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }


        private Button buttonBack;
        private Button imageUploadButton;
        private Button imageDeleteButton;
        private PictureBox pictureBox1;
        private Label label1;
        private bool isBackButtonPressed = false;
        private TextBox time;
        private TextBox quantity;
        private TextBox comment;
        private Button reroad;
    }
}
