namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //�t�H�[���̏�����
            this.AutoScaleMode = AutoScaleMode.None;
            textBoxQuantity.KeyDown += TextBox1_KeyDown; // �e�L�X�g�{�b�N�X�̒l�̎擾�A�͈͏����A��������
            addButton.Click += addButton_Click; // +�{�^���̃N���b�N����
            decreaseButton.Click += decreaseButton_Click; // -�{�^���̃N���b�N����
            createButton.Click += createbutton_Click; // �ǉ��{�^���̃N���b�N����
            clearbutton.Click += clearbutton_Click; // �N���A�{�^���̃N���b�N����
            combinedbutton.Click += combinedbutton_Click; // ���Z�{�^���̃N���b�N����


            // **�T���v���f�[�^
            //if (tableLayoutPanel.Controls.Count == 0)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        var newItem = new ListItemControl($"�T���v���R�����g {i + 1}");
            //        tableLayoutPanel.RowCount++;
            //        tableLayoutPanel.Controls.Add(newItem, 0, tableLayoutPanel.RowCount - 1);
            //    }
            //}
        }
        public string TextBoxValue
        {
            get => textBoxQuantity.Text; // �l���擾
            set => textBoxQuantity.Text = value; // �l��ݒ�
        }

        
    }
}
