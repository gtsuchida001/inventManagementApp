namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //フォームの初期化
            textBoxQuantity.KeyDown += TextBox1_KeyDown; // テキストボックスの値の取得、範囲処理、書き換え
            addButton.Click += addButton_Click; // +ボタンのクリック処理
            decreaseButton.Click += decreaseButton_Click; // -ボタンのクリック処理
            createButton.Click += createbutton_Click; // 追加ボタンのクリック処理
        }
        public string TextBoxValue
        {
            get => textBoxQuantity.Text; // 値を取得
            set => textBoxQuantity.Text = value; // 値を設定
        }
    }
}
