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
            InitializeComponent(); //�t�H�[���̏�����
            this.Shown += Form1_Shown;

            // �^�C�g���o�[�͎c���A�E�B���h�E�̘g������
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ControlBox = true;  // ����{�^���i�~�j��L����
            this.Text = "mainForm";  // �^�C�g���o�[�̃e�L�X�g���w��
            this.Padding = new Padding(0); // �g�����폜���Ă����C�A�E�g������Ȃ��悤��

            // �E�B���h�E�𒆉��ɔz�u
            this.StartPosition = FormStartPosition.CenterScreen;

            this.AutoScaleMode = AutoScaleMode.None;
            textBoxQuantity.KeyPress += textBoxQuantity_KeyPress; // �e�L�X�g�{�b�N�X�̒l�̎擾�A�͈͏����A��������
            addButton.Click += addButton_Click; // +�{�^���̃N���b�N����
            decreaseButton.Click += decreaseButton_Click; // -�{�^���̃N���b�N����
            createButton.Click += createbutton_Click; // �ǉ��{�^���̃N���b�N����
            clearbutton.Click += clearbutton_Click; // �N���A�{�^���̃N���b�N����
            combinedbutton.Click += combinedbutton_Click; // ���Z�{�^���̃N���b�N����

            //this.Font = new Font("Yu Gothic UI", 6F);

            LogApplication(); // �A�v���P�[�V�����N�����̃��O�o��


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

        // �t�H�[���̘g�������폜�i�^�C�g���o�[�͎c���j
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.Style &= ~0x00800000; // WS_BORDER���폜�i�g���������j
        //        cp.ExStyle &= ~0x00020000; // WS_EX_CLIENTEDGE���폜�i�e�������j
        //        return cp;
        //    }
        //}
        public string TextBoxValue
        {
            get => textBoxQuantity.Text; // �l���擾
            set => textBoxQuantity.Text = value; // �l��ݒ�
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // **�A�v���I�����̃��O���L�^**
            LogApplication();
        }

        public static string GetControlPositionLog(string timestamp, Control control, string name)
        {
            if (control == null)
            {
                return $"{timestamp} - {name}: ���݂��܂���\n";
            }
            return $"{timestamp} - {name}�̈ʒu: X={control.Location.X}, Y={control.Location.Y}\n";
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string logContent = $"{timestamp} - ���s��̌Ă΂�郍�O\n";
            logContent += $"{timestamp} - �t�H�[���T�C�Y: ��={this.Width}, ����={this.Height}\n";
            logContent += GetControlPositionLog(timestamp, this, "�w�i");
            logContent += GetControlPositionLog(timestamp, title, "�A�v���^�C�g���ifreemake�j");
            logContent += GetControlPositionLog(timestamp, labelQuantity, "���ʃ��x��");
            logContent += GetControlPositionLog(timestamp, textBoxQuantity, "���ʃe�L�X�g�{�b�N�X");
            logContent += GetControlPositionLog(timestamp, addButton, "�{�{�^��");
            logContent += GetControlPositionLog(timestamp, decreaseButton, "�|�{�^��");
            logContent += GetControlPositionLog(timestamp, time, "�������x��");

            // **���O���t�@�C���ɏ�������**
            File.AppendAllText(logFilePath, logContent + Environment.NewLine);
            Console.WriteLine("show�̌�Ƀ��O������ɏo�͂���܂����B");
        }

        /// <summary>
        /// **�A�v���N�����̃��O���L�^**
        /// </summary>
        public static void LogApplication()
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // **�t�H�[���̏����擾����**
                Form1? mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (mainForm == null)
                {
                    return;
                }

                string logContent = $"{timestamp} - ��ʏI����ɌĂ΂�郍�O\n";
                logContent += $"{timestamp} - �t�H�[���T�C�Y: ��={mainForm.Width}, ����={mainForm.Height}\n";
                logContent += GetControlPositionLog(timestamp, mainForm, "�w�i");
                logContent += GetControlPositionLog(timestamp, mainForm.title, "�A�v���^�C�g���ifreemake�j");
                logContent += GetControlPositionLog(timestamp, mainForm.labelQuantity, "���ʃ��x��");
                logContent += GetControlPositionLog(timestamp, mainForm.textBoxQuantity, "���ʃe�L�X�g�{�b�N�X");
                logContent += GetControlPositionLog(timestamp, mainForm.addButton, "�{�{�^��");
                logContent += GetControlPositionLog(timestamp, mainForm.decreaseButton, "�|�{�^��");
                logContent += GetControlPositionLog(timestamp, mainForm.time, "�������x��");

                // **���O���t�@�C���ɋL�^**
                File.AppendAllText(logFilePath, logContent + Environment.NewLine);
                Console.WriteLine("�A�v���I�����O���L�^����܂����B");
            }
            catch (Exception ex)
            {
                MessageBox.Show("���O�̏o�͂Ɏ��s���܂���: " + ex.Message);
            }
>>>>>>> stage
        }
    }
}
    
