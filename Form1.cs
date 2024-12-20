namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //フォームの初期化
            textBox1.KeyDown += TextBox1_KeyDown; // テキストボックスの値の取得、範囲処理、書き換え
        }
        public string TextBoxValue
        {
            get => textBox1.Text; // 値を取得
            set => textBox1.Text = value; // 値を設定
        }
    }
}
