using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace inventManagementApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelQuantity = new Label();
            textBoxQuantity = new TextBox();
            addButton = new Button();
            decreaseButton = new Button();
            commentbox = new TextBox();
            time = new Label();
            createbutton = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Yu Gothic UI", 20F);
            labelQuantity.Location = new Point(12, 107);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(103, 54);
            labelQuantity.TabIndex = 0;
            labelQuantity.Text = "数量";
            labelQuantity.BackColor = Color.Transparent;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Font = new Font("Yu Gothic UI", 20F);
            textBoxQuantity.Location = new Point(121, 104);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(103, 61);
            textBoxQuantity.TabIndex = 1;
            textBoxQuantity.Text = "0";
            textBoxQuantity.BackColor = this.BackColor;
            // 
            // addButton
            // 
            addButton.Location = new Point(246, 104);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 61);
            addButton.TabIndex = 2;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            // 
            // decreaseButton
            // 
            decreaseButton.Location = new Point(364, 104);
            decreaseButton.Name = "decreaseButton";
            decreaseButton.Size = new Size(112, 61);
            decreaseButton.TabIndex = 3;
            decreaseButton.Text = "-";
            decreaseButton.UseVisualStyleBackColor = true;
            // 
            // commentbox
            // 
            commentbox.Font = new Font("Yu Gothic UI", 13F);
            commentbox.Location = new Point(174, 183);
            commentbox.Name = "commentbox";
            commentbox.Size = new Size(146, 42);
            commentbox.TabIndex = 4;
            commentbox.Text = "コメント";
            commentbox.BackColor = this.BackColor;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Yu Gothic UI", 13F);
            time.Location = new Point(40, 183);
            time.Name = "time";
            time.Size = new Size(119, 36);
            time.TabIndex = 5;
            time.Text = "現在時刻";
            time.Click += label1_Click;
            time.BackColor = Color.Transparent;
            // 
            // createbutton
            // 
            createbutton.Location = new Point(340, 183);
            createbutton.Name = "createbutton";
            createbutton.Size = new Size(112, 42);
            createbutton.TabIndex = 6;
            createbutton.Text = "追加";
            createbutton.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Yu Gothic UI", 14F);
            title.ForeColor = Color.White;
            title.Location = new Point(12, 54);
            title.Name = "title";
            title.Size = new Size(133, 38);
            title.TabIndex = 7;
            title.Text = "freemake";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 450);
            Controls.Add(title);
            Controls.Add(createbutton);
            Controls.Add(time);
            Controls.Add(commentbox);
            Controls.Add(decreaseButton);
            Controls.Add(addButton);
            Controls.Add(textBoxQuantity);
            Controls.Add(labelQuantity);
            Name = "Form1";
            Text = "mainForm";
            Paint += MainForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textboxCheck()
        {
            if (int.TryParse(textBoxQuantity.Text.Replace(",", ""), out int inputQuantity))
            {
                int checkedQuantity = CheckQuantityRange(inputQuantity);

                // チェック後の値をテキストボックスに反映
                textBoxQuantity.Text = checkedQuantity.ToString("N0");
            }
            else
            {
                // 無効な入力の場合のエラー表示
                MessageBox.Show("有効な数値を入力してください(0~9999)");
                textBoxQuantity.Text = minQuantity.ToString(); // 最小値を設定
            }
        }
        public int CheckQuantityRange(int argindex)
        {
            

            if (argindex <= minQuantity)
            {
                return minQuantity;
            }
            else if (argindex >= maxQuantity)
            {
                return maxQuantity;
            }
            else
            {
            return argindex;
            }
        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // エンターキーが押された場合にチェックを実行
            if (e.KeyCode == Keys.Enter)
            {
                textboxCheck();
                e.Handled = true;         // 既定のエンターキー動作を無効化
                e.SuppressKeyPress = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxQuantity.Text.Replace(",", ""), out int inputQuantity))
            {
                int checkedQuantity = CheckQuantityRange(inputQuantity + 1);
                // チェック後の値をテキストボックスに反映
                textBoxQuantity.Text = checkedQuantity.ToString("N0");
            }
            else
            {
                // 無効な入力の場合のエラー表示
                MessageBox.Show("有効な数値を入力してください(0~9999)");
                textBoxQuantity.Text = minQuantity.ToString(); // 最小値を設定
            }
        }
        private void decreaseButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxQuantity.Text.Replace(",", ""), out int inputQuantity))
            {
                int checkedQuantity = CheckQuantityRange(inputQuantity - 1);
                // チェック後の値をテキストボックスに反映
                textBoxQuantity.Text = checkedQuantity.ToString("N0");
            }
            else
            {
                // 無効な入力の場合のエラー表示
                //MessageBox.Show("有効な数値を入力してください(0~9999)");
                MessageBox.Show("debug");
                textBoxQuantity.Text = minQuantity.ToString(); // 最小値を設定
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // ウィンドウの幅を取得
            int width = this.ClientSize.Width;

            // 背景色（固定高さ）
            g.FillRectangle(Brushes.LightBlue, 0, 0, width, FixedHeight);
        }

        #endregion
        private const int maxQuantity = 9999;
        private const int minQuantity = 0;
        private const int FixedHeight = 100;

        private Label labelQuantity;
        private TextBox textBoxQuantity;
        private Button addButton;
        private Button decreaseButton;
        private TextBox commentbox;
        private Label time;
        private Button createbutton;
        private Label title;
    }
}

