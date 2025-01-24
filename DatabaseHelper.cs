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
            //if (!File.Exists(dbPath))
            //{
            //    SQLiteConnection.CreateFile(dbPath);
            //}

            try
            {
                // データベースファイルが存在しない場合のみ作成
                if (!File.Exists(dbPath))
                {
                    SQLiteConnection.CreateFile(dbPath);
                }

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();

                    // テーブルが既に存在するかチェック
                    bool tableExists = false;
                    using (var checkCommand = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='images';", connection))
                    {
                        using (var reader = checkCommand.ExecuteReader())
                        {
                            tableExists = reader.HasRows; // データがあればテーブルは既に存在する
                        }
                    }

                    // テーブルが存在しない場合のみ作成
                    if (!tableExists)
                    {
                        string createTableQuery = @"
                        CREATE TABLE images (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            image_data BLOB
                        );";
                        using (var command = new SQLiteCommand(createTableQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"データベースのロードに失敗しました: {ex.Message}");
                MessageBox.Show($"データベースのロードに失敗しました。\n{ex.Message}",
                    "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

