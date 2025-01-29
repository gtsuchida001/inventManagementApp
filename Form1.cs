using System.Data.SQLite;
using System.Diagnostics;
using DatabaseHelper;

namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        private static string logFilePath = Path.Combine(Application.StartupPath, "inventManagementApp.log");
        private ListBox listBoxItems;
        //private Button addButton;
        private TextBox textBoxName;

        public Form1()
        {
            InitializeComponent(); //フォームの初期化
            DatabaseHelper.DatabaseHelper.InitializeDatabase(); // データベースを初期化
            this.Load += new EventHandler(Form1_Load); // `Form1_Load` を登録.
            //this.Shown += Form1_Shown;
            LoadListItemsFromDatabase();

            // タイトルバーは残しつつ、ウィンドウの枠を消す
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ControlBox = true;  // 閉じるボタン（×）を有効化
            this.Text = "mainForm";  // タイトルバーのテキストを指定
            this.Padding = new Padding(0); // 枠線を削除してもレイアウトが崩れないように

            // ウィンドウを中央に配置
            this.StartPosition = FormStartPosition.CenterScreen;

            this.AutoScaleMode = AutoScaleMode.None;
            textBoxQuantity.KeyPress += textBoxQuantity_KeyPress; // テキストボックスの値の取得、範囲処理、書き換え
            addButton.Click += addButton_Click;            // +ボタンのクリック処理
            decreaseButton.Click += decreaseButton_Click; // -ボタンのクリック処理
            createButton.Click += createbutton_Click; // 追加ボタンのクリック処理
            clearbutton.Click += clearbutton_Click; // クリアボタンのクリック処理
            combinedbutton.Click += combinedbutton_Click; // 合算ボタンのクリック処理
            //allReset.Click += resetButton_Click;


            //this.Font = new Font("Yu Gothic UI", 6F);

            //LogApplication(); // アプリケーション起動時のログ出力
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper.DatabaseHelper.InitializeDatabase(); // データベースを初期化
        }
        public void LoadListItemsFromDatabase()
        {
            tableLayoutPanel.Controls.Clear(); // 追加前に一度クリア
            tableLayoutPanel.RowCount = 0;

            using (var connection = new SQLiteConnection($"Data Source={DatabaseHelper.DatabaseHelper.dbPath};Version=3;"))
            {
                connection.Open();

                // **削除されていないデータを取得**
                using (var command = new SQLiteCommand("SELECT id, image_data, record_day, comment, Quantity FROM images WHERE is_deleted_id = 0;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        List<ListItemControl> items = new List<ListItemControl>();
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            byte[] imageData = reader["image_data"] as byte[];
                            string recordDay = reader["record_day"] as string ?? "未設定"; // NULL の場合は "未設定"
                            string comment = reader["comment"] as string ?? "なし"; // NULL の場合は "なし"
                            string quantity = reader["Quantity"] as string ?? "0"; // NULL の場合は "0"

                            // **ListItemControl を作成**
                            ListItemControl item = new ListItemControl(quantity, comment, recordDay, id);
                            items.Add(item);
                        }
                        // **一括で TableLayoutPanel に追加**
                        foreach (var item in items)
                        {
                            tableLayoutPanel.Controls.Add(item);
                        }
                        tableLayoutPanel.RowCount = tableLayoutPanel.Controls.Count;
                    }
                }
            }
            // **レイアウト更新**
            AdjustTableLayoutSize();

            // **確実に最下部にスクロール**
            panelcontain.VerticalScroll.Value = panelcontain.VerticalScroll.Maximum;
            panelcontain.AutoScrollPosition = new Point(0, panelcontain.VerticalScroll.Maximum);

            Task.Run(() =>
            {
                Thread.Sleep(100);
                panelcontain.Invoke(new Action(() =>
                {
                    panelcontain.AutoScrollPosition = new Point(0, panelcontain.VerticalScroll.Maximum);
                    Debug.WriteLine($"After Scroll: Value = {panelcontain.VerticalScroll.Value}, Maximum = {panelcontain.VerticalScroll.Maximum}");
                }));
            });

        }
    }
}

