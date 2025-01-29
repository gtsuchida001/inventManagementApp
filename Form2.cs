using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace inventManagementApp
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        private int currentId;
        //private bool isBackButtonPressed = false;
        private string dbPath = "num_database.db"; // SQLite データベースのパス

        public Form2(Form1 parent, int id)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.currentId = id;
            label1.Text = id.ToString();
            LoadImage(id);
            this.FormClosing += Form2_FormClosing;
            this.buttonBack.Click += buttonBack_Click;
            this.imageUploadButton.Click += (sender, e) => imageUploadButton_Click(sender, e);
            this.imageDeleteButton.Click += (sender, e) => imageDeleteButton_Click(sender, e);//
        }
    }
}
