namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //�t�H�[���̏�����
            textBoxQuantity.KeyDown += TextBox1_KeyDown; // �e�L�X�g�{�b�N�X�̒l�̎擾�A�͈͏����A��������
            addButton.Click += addButton_Click; // +�{�^���̃N���b�N����
            decreaseButton.Click += decreaseButton_Click; // -�{�^���̃N���b�N����
        }
        public string TextBoxValue
        {
            get => textBoxQuantity.Text; // �l���擾
            set => textBoxQuantity.Text = value; // �l��ݒ�
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
