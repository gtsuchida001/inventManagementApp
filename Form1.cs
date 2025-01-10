namespace inventManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //�t�H�[���̏�����
            this.AutoScaleMode = AutoScaleMode.None;
            textBoxQuantity.KeyPress += textBoxQuantity_KeyPress; // �e�L�X�g�{�b�N�X�̒l�̎擾�A�͈͏����A��������
            addButton.Click += addButton_Click; // +�{�^���̃N���b�N����
            decreaseButton.Click += decreaseButton_Click; // -�{�^���̃N���b�N����
            createButton.Click += createbutton_Click; // �ǉ��{�^���̃N���b�N����
            clearbutton.Click += clearbutton_Click; // �N���A�{�^���̃N���b�N����
            combinedbutton.Click += combinedbutton_Click; // ���Z�{�^���̃N���b�N����

            LogApplicationStartup(); // �A�v���P�[�V�����N�����̃��O�o��


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

        private string logFilePath = Path.Combine(Application.StartupPath, "inventManagementApp.log");

        private void LogApplicationStartup()
        {
            try
            {
                // **���ݎ������擾**
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // **���O�f�[�^���쐬**
                string logContent = $"{timestamp} - �A�v���N��\n";
                logContent += GetControlPositionLog(timestamp, this, "�w�i");
                logContent += GetControlPositionLog(timestamp, title, "�A�v���^�C�g���ifreemake�j");
                logContent += GetControlPositionLog(timestamp, labelQuantity, "���ʃ��x��");
                logContent += GetControlPositionLog(timestamp, textBoxQuantity, "���ʃe�L�X�g�{�b�N�X");
                logContent += GetControlPositionLog(timestamp, addButton, "�{�{�^��");
                logContent += GetControlPositionLog(timestamp, decreaseButton, "�|�{�^��");
                logContent += GetControlPositionLog(timestamp, time, "�������x��");

                // **���O���t�@�C���ɏ�������**
                File.AppendAllText(logFilePath, logContent + Environment.NewLine);

                Console.WriteLine("���O������ɏo�͂���܂����B");
            }
            catch (Exception ex)
            {
                MessageBox.Show("���O�̏o�͂Ɏ��s���܂���: " + ex.Message);
            }
        }

        private string GetControlPositionLog(string timestamp, Control control, string name)
        {
            if (control == null)
            {
                return $"{timestamp} - {name}: ���݂��܂���\n";
            }

            return $"{timestamp} - {name}�̈ʒu: X={control.Location.X}, Y={control.Location.Y}\n";
        }
    }
}
