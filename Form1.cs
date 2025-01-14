namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        private static string logFilePath = Path.Combine(Application.StartupPath, "inventManagementApp.log");

        public Form1()
        {
<<<<<<< HEAD
            InitializeComponent();
=======
            InitializeComponent(); //フォームの初期化
            this.Shown += Form1_Shown;

            // タイトルバーは残しつつ、ウィンドウの枠を消す
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ControlBox = true;  // 閉じるボタン（×）を有効化
            this.Text = "mainForm";  // タイトルバーのテキストを指定
            this.Padding = new Padding(0); // 枠線を削除してもレイアウトが崩れないように

            // ウィンドウを中央に配置
            this.StartPosition = FormStartPosition.CenterScreen;

            this.AutoScaleMode = AutoScaleMode.None;
            textBoxQuantity.KeyPress += textBoxQuantity_KeyPress; // テキストボックスの値の取得、範囲処理、書き換え
            addButton.Click += addButton_Click; // +ボタンのクリック処理
            decreaseButton.Click += decreaseButton_Click; // -ボタンのクリック処理
            createButton.Click += createbutton_Click; // 追加ボタンのクリック処理
            clearbutton.Click += clearbutton_Click; // クリアボタンのクリック処理
            combinedbutton.Click += combinedbutton_Click; // 合算ボタンのクリック処理

            //this.Font = new Font("Yu Gothic UI", 6F);

            LogApplication(); // アプリケーション起動時のログ出力


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

        // フォームの枠だけを削除（タイトルバーは残す）
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.Style &= ~0x00800000; // WS_BORDERを削除（枠だけ消す）
        //        cp.ExStyle &= ~0x00020000; // WS_EX_CLIENTEDGEを削除（影を消す）
        //        return cp;
        //    }
        //}
        public string TextBoxValue
        {
            get => textBoxQuantity.Text; // 値を取得
            set => textBoxQuantity.Text = value; // 値を設定
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // **アプリ終了時のログを記録**
            LogApplication();
        }

        public static string GetControlPositionLog(string timestamp, Control control, string name)
        {
            if (control == null)
            {
                return $"{timestamp} - {name}: 存在しません\n";
            }
            return $"{timestamp} - {name}の位置: X={control.Location.X}, Y={control.Location.Y}\n";
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string logContent = $"{timestamp} - 実行後の呼ばれるログ\n";
            logContent += $"{timestamp} - フォームサイズ: 幅={this.Width}, 高さ={this.Height}\n";
            logContent += GetControlPositionLog(timestamp, this, "背景");
            logContent += GetControlPositionLog(timestamp, title, "アプリタイトル（freemake）");
            logContent += GetControlPositionLog(timestamp, labelQuantity, "数量ラベル");
            logContent += GetControlPositionLog(timestamp, textBoxQuantity, "数量テキストボックス");
            logContent += GetControlPositionLog(timestamp, addButton, "＋ボタン");
            logContent += GetControlPositionLog(timestamp, decreaseButton, "－ボタン");
            logContent += GetControlPositionLog(timestamp, time, "時刻ラベル");

            // **ログをファイルに書き込み**
            File.AppendAllText(logFilePath, logContent + Environment.NewLine);
            Console.WriteLine("showの後にログが正常に出力されました。");
        }

        /// <summary>
        /// **アプリ起動時のログを記録**
        /// </summary>
        public static void LogApplication()
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // **フォームの情報を取得する**
                Form1? mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (mainForm == null)
                {
                    return;
                }

                string logContent = $"{timestamp} - 画面終了後に呼ばれるログ\n";
                logContent += $"{timestamp} - フォームサイズ: 幅={mainForm.Width}, 高さ={mainForm.Height}\n";
                logContent += GetControlPositionLog(timestamp, mainForm, "背景");
                logContent += GetControlPositionLog(timestamp, mainForm.title, "アプリタイトル（freemake）");
                logContent += GetControlPositionLog(timestamp, mainForm.labelQuantity, "数量ラベル");
                logContent += GetControlPositionLog(timestamp, mainForm.textBoxQuantity, "数量テキストボックス");
                logContent += GetControlPositionLog(timestamp, mainForm.addButton, "＋ボタン");
                logContent += GetControlPositionLog(timestamp, mainForm.decreaseButton, "－ボタン");
                logContent += GetControlPositionLog(timestamp, mainForm.time, "時刻ラベル");

                // **ログをファイルに記録**
                File.AppendAllText(logFilePath, logContent + Environment.NewLine);
                Console.WriteLine("アプリ終了ログが記録されました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ログの出力に失敗しました: " + ex.Message);
            }
>>>>>>> stage
        }
    }
}
    
