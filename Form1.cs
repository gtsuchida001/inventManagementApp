namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //�t�H�[���̏�����
            textBox1.KeyDown += TextBox1_KeyDown; // �e�L�X�g�{�b�N�X�̒l�̎擾�A�͈͏����A��������
        }
        public string TextBoxValue
        {
            get => textBox1.Text; // �l���擾
            set => textBox1.Text = value; // �l��ݒ�
        }
    }
}
