using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20F);
            label1.Location = new Point(76, 39);
            label1.Name = "label1";
            label1.Size = new Size(103, 54);
            label1.TabIndex = 0;
            label1.Text = "数量";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 20F);
            textBox1.Location = new Point(174, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 61);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "mainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textboxCheck()
        {
            if (int.TryParse(textBox1.Text, out int inputQuantity))
            {
                int checkedQuantity = CheckQuantityRange(inputQuantity);

                // チェック後の値をテキストボックスに反映
                textBox1.Text = checkedQuantity.ToString();
            }
            else
            {
                // 無効な入力の場合のエラー表示
                MessageBox.Show("有効な数値を入力してください(0~9999)");
                textBox1.Text = minQuantity.ToString(); // 最小値を設定
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
        #endregion
        //private int mainQuantity;
        private const int maxQuantity = 9999;
        private const int minQuantity = 0;
        //private int checkedQuantity;

        private Label label1;
        private TextBox textBox1;
    }
}

