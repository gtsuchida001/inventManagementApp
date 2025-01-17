using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


class DatabaseManager
{
    public static void InitializeDatabase()
    {
        string dbPath = "image_database.db";
        string connectionString = $"Data Source={dbPath};Version=3;";

        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS images (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT,
                    image_data BLOB
                );";

            SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn);
            cmd.ExecuteNonQuery();
        }
    }
}

class ImageUploader
{
    public static void SaveImageToDatabase(string imagePath)
    {
        string dbPath = "image_database.db";
        string connectionString = $"Data Source={dbPath};Version=3;";

        byte[] imageBytes = File.ReadAllBytes(imagePath);

        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            string insertQuery = "INSERT INTO images (name, image_data) VALUES (@name, @image)";
            using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@name", Path.GetFileName(imagePath));
                cmd.Parameters.AddWithValue("@image", imageBytes);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
class ImageRetriever
{
    public static Image GetImageFromDatabase(int imageId)
    {
        string dbPath = "image_database.db";
        string connectionString = $"Data Source={dbPath};Version=3;";

        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            string selectQuery = "SELECT image_data FROM images WHERE id = @id";

            using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", imageId);
                byte[] imageBytes = (byte[])cmd.ExecuteScalar();

                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
        }

        return null;
    }
}

