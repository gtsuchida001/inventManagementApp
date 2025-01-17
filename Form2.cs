using System;
using System.Drawing;
using System.Windows.Forms;

namespace inventManagementApp
{
    public partial class Form2 : Form
    {
        private Form1 parentForm; // `Form1` の参照を保持
        private Button buttonBack;

        public Form2(Form1 form1)
        {
            InitializeComponent(); // ✅ 修正
            parentForm = form1;
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            buttonBack = new Button
            {
                Text = "Back",
                Location = new Point(12, 12),
                Size = new Size(79, 37),
            };
            buttonBack.Click += buttonBack_Click; // ✅ イベントを登録

            Controls.Add(buttonBack);

            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(284, 261);
            Name = "Form2";
            Text = "Detail Form";
            ResumeLayout(false);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parentForm.Show(); // ✅ `Form1` を再表示
            this.Close(); // ✅ `Form2` を閉じる
        }
    }
}
