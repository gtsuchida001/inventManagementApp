namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //フォームの初期化
            this.AutoScaleMode = AutoScaleMode.None;
            textBoxQuantity.KeyPress += textBoxQuantity_KeyPress; // テキストボックスの値の取得、範囲処理、書き換え
            addButton.Click += addButton_Click; // +ボタンのクリック処理
            decreaseButton.Click += decreaseButton_Click; // -ボタンのクリック処理
            createButton.Click += createbutton_Click; // 追加ボタンのクリック処理
            clearbutton.Click += clearbutton_Click; // クリアボタンのクリック処理
            combinedbutton.Click += combinedbutton_Click; // 合算ボタンのクリック処理

            LogApplicationStartup(); // アプリケーション起動時のログ出力


            // **サンプルデータ
            //if (tableLayoutPanel.Controls.Count == 0)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        var newItem = new ListItemControl($"サンプルコメント {i + 1}");
            //        tableLayoutPanel.RowCount++;
            //        tableLayoutPanel.Controls.Add(newItem, 0, tableLayoutPanel.RowCount - 1);
            //    }
            //}
        }
        public string TextBoxValue
        {
            get => textBoxQuantity.Text; // 値を取得
            set => textBoxQuantity.Text = value; // 値を設定
        }

        private string logFilePath = Path.Combine(Application.StartupPath, "inventManagementApp.log");

        private void LogApplicationStartup()
        {
            try
            {
                // **現在時刻を取得**
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // **ログデータを作成**
                string logContent = $"{timestamp} - アプリ起動\n";
                logContent += GetControlPositionLog(timestamp, this, "背景");
                logContent += GetControlPositionLog(timestamp, title, "アプリタイトル（freemake）");
                logContent += GetControlPositionLog(timestamp, labelQuantity, "数量ラベル");
                logContent += GetControlPositionLog(timestamp, textBoxQuantity, "数量テキストボックス");
                logContent += GetControlPositionLog(timestamp, addButton, "＋ボタン");
                logContent += GetControlPositionLog(timestamp, decreaseButton, "－ボタン");
                logContent += GetControlPositionLog(timestamp, time, "時刻ラベル");

                // **ログをファイルに書き込み**
                File.AppendAllText(logFilePath, logContent + Environment.NewLine);

                Console.WriteLine("ログが正常に出力されました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ログの出力に失敗しました: " + ex.Message);
            }
        }

        private string GetControlPositionLog(string timestamp, Control control, string name)
        {
            if (control == null)
            {
                return $"{timestamp} - {name}: 存在しません\n";
            }

            return $"{timestamp} - {name}の位置: X={control.Location.X}, Y={control.Location.Y}\n";
        }
    }
}
