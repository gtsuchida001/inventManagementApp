namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //フォームの初期化
            this.AutoScaleMode = AutoScaleMode.None;
            textBoxQuantity.KeyDown += TextBox1_KeyDown; // テキストボックスの値の取得、範囲処理、書き換え
            addButton.Click += addButton_Click; // +ボタンのクリック処理
            decreaseButton.Click += decreaseButton_Click; // -ボタンのクリック処理
            createButton.Click += createbutton_Click; // 追加ボタンのクリック処理
            clearbutton.Click += clearbutton_Click; // クリアボタンのクリック処理
            combinedbutton.Click += combinedbutton_Click; // 合算ボタンのクリック処理


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

        
    }
}
