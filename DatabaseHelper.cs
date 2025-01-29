using System;
using System.Data.SQLite;
using static inventManagementApp.Form1;
using System.Windows.Forms;

namespace DatabaseHelper
{
    public static class DatabaseHelper
    {
        public static string dbPath = "num_database.db";
        public static int GetNewId()
        {
            int newId = 1; // 初期値（データがない場合のID）

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                // **NULL の image_data を INSERT して ID を増やす**
                using (var insertCommand = new SQLiteCommand("INSERT INTO images (image_data) VALUES (NULL);", connection))
                {
                    insertCommand.ExecuteNonQuery();
                }

                // **直前に挿入された ID を取得**
                using (var getIdCommand = new SQLiteCommand("SELECT last_insert_rowid();", connection))
                {
                    var result = getIdCommand.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        newId = Convert.ToInt32(result); // **新しい ID を取得**
                    }
                }
            }
            return newId;
        }


        public static void InitializeDatabase()
        {
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
                            id INTEGER PRIMARY KEY AUTOINCREMENT, -- ID（主キー）
                            image_data BLOB, -- 画像データ
                            is_deleted_id INTEGER DEFAULT 0, -- ID の論理削除フラグ（0: 未削除, 1: 削除済み）
                            is_deleted_image INTEGER DEFAULT 0, -- image_data の論理削除フラグ（0: 未削除, 1: 削除済み）
                            record_day TEXT, -- 日付情報（予約語を避けるため `record_day` に変更）
                            comment TEXT, -- コメント
                            Quantity TEXT -- 数量（数値なら INTEGER にする方がよい）
                        );";
                        using (var command = new SQLiteCommand(createTableQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                EnsureTableColumns();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"データベースのロードに失敗しました: {ex.Message}");
                MessageBox.Show($"データベースのロードに失敗しました。\n{ex.Message}",
                    "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void InsertNewItem(int id, string quantity, string comment, string record_day)
        {
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                using (var command = new SQLiteCommand(
                "INSERT OR REPLACE INTO images (id, image_data, Quantity, comment, record_day) VALUES (@id, NULL, @Quantity, @comment, @record_day);",
                connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@comment", comment);
                    command.Parameters.AddWithValue("@record_day", record_day);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void SoftDeleteId(int id) //idの論理削除
        {
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                using (var command = new SQLiteCommand("UPDATE images SET is_deleted_id = 1 WHERE id = @id;", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void EnsureTableColumns()
        {
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                // **カラムが存在しない場合のみ追加**
                using (var command = new SQLiteCommand("PRAGMA table_info(images);", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        bool hasIsDeletedId = false;

                        while (reader.Read())
                        {
                            string columnName = reader["name"].ToString();
                            if (columnName == "is_deleted_id") hasIsDeletedId = true;
                        }

                        // **不足しているカラムを追加**
                        if (!hasIsDeletedId)
                        {
                            using (var alterCmd = new SQLiteCommand("ALTER TABLE images ADD COLUMN is_deleted_id INTEGER DEFAULT 0;", connection))
                            {
                                alterCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
    }
}

