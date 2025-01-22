using System.Data.SQLite;

namespace DatabaseHelper
{
    public static class DatabaseHelper
    {
        private static string dbPath = "image_database.db";
        public static int GetNewId()
        {
            int newId = 1; // 初期値（データがない場合のID）
            string dbPath = "image_database.db"; // SQLite データベースのパス


            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT MAX(id) FROM images", connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        newId = Convert.ToInt32(result) + 1; // 最大 ID に 1 を足す
                    }
                }
            }

            return newId;
        }
        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS images (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    image_data BLOB
                );";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void ResetDatabase()
        {
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                using (var command = new SQLiteCommand("DELETE FROM images;", connection))
                {
                    command.ExecuteNonQuery(); // データをすべて削除
                }

                using (var command = new SQLiteCommand("DELETE FROM sqlite_sequence WHERE name='images';", connection))
                {
                    command.ExecuteNonQuery(); // `AUTOINCREMENT` をリセット
                }
            }
        }
    }
}
//