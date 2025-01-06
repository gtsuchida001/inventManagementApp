﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;

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
            components = new System.ComponentModel.Container();
            labelQuantity = new Label();
            textBoxQuantity = new TextBox();
            addButton = new Button();
            decreaseButton = new Button();
            commentbox = new TextBox();
            time = new Label();
            title = new Label();
            timer = new System.Windows.Forms.Timer(components);
            createButton = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            panelcontain = new Panel();
            panelcontain.SuspendLayout();
            SuspendLayout();
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.BackColor = Color.Transparent;
            labelQuantity.Font = new Font("Yu Gothic UI", 20F);
            labelQuantity.Location = new Point(12, 107);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(103, 54);
            labelQuantity.TabIndex = 0;
            labelQuantity.Text = "数量";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.BackColor = SystemColors.Control;
            textBoxQuantity.Font = new Font("Yu Gothic UI", 20F);
            textBoxQuantity.Location = new Point(121, 104);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(103, 61);
            textBoxQuantity.TabIndex = 1;
            textBoxQuantity.Text = "0";
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
            commentbox.BackColor = SystemColors.Control;
            commentbox.Font = new Font("Yu Gothic UI", 13F);
            commentbox.Location = new Point(174, 183);
            commentbox.Name = "commentbox";
            commentbox.Size = new Size(146, 42);
            commentbox.TabIndex = 4;
            commentbox.Text = "コメント";
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Yu Gothic UI", 13F);
            time.Location = new Point(40, 183);
            time.Name = "time";
            time.Size = new Size(119, 36);
            time.TabIndex = 5;
            time.Text = "現在時刻";
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
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            // 
            // createButton
            // 
            createButton.Location = new Point(340, 183);
            createButton.Name = "createButton";
            createButton.Size = new Size(112, 42);
            createButton.TabIndex = 9;
            createButton.Text = "追加";
            createButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel.Location = new Point(14, 12);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(407, 273);
            tableLayoutPanel.TabIndex = 8;
            // 
            // panelcontain
            // 
            panelcontain.Controls.Add(tableLayoutPanel);
            panelcontain.Location = new Point(26, 240);
            panelcontain.Name = "panelcontain";
            panelcontain.Size = new Size(450, 300);
            panelcontain.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 569);
            Controls.Add(createButton);
            Controls.Add(title);
            Controls.Add(time);
            Controls.Add(commentbox);
            Controls.Add(decreaseButton);
            Controls.Add(addButton);
            Controls.Add(textBoxQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(panelcontain);
            Name = "Form1";
            Text = "mainForm";
            Paint += MainForm_Paint;
            panelcontain.ResumeLayout(false);
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
        private void Timer_Tick(object sender, EventArgs e)
        {
            // 現在時刻を取得して表示
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public void createbutton_Click(object sender, EventArgs e)
        {
            {
                // **空欄の場合の処理**
                string commentText = string.IsNullOrWhiteSpace(commentbox.Text) ? "blank comment" : commentbox.Text;

                // 新しいリストアイテムを作成
                var newItem = new ListItemControl(commentbox.Text);

                // 削除イベントの設定
                newItem.DeleteClicked += (s, args) =>
                {
                    tableLayoutPanel.Controls.Remove((Control)s);
                    tableLayoutPanel.RowCount--;
                    // **すべてのアイテムを上に詰める**
                    RearrangeTableLayoutPanel();
                    // スクロール領域を更新
                    AdjustTableLayoutSize();
                };

                // TableLayoutPanel に追加
                tableLayoutPanel.RowCount++; //色用のカウント
                tableLayoutPanel.Controls.Add(newItem, 0, tableLayoutPanel.RowCount - 1);
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // 行の高さを40に設定

                //色を設定
                newItem.BackColor = GetColor();

                // レイアウトを更新
                tableLayoutPanel.PerformLayout();
                tableLayoutPanel.Invalidate();

                //パネルサイズの更新
                AdjustTableLayoutSize();

                // 最下部にスクロール
                panelcontain.VerticalScroll.Value = panelcontain.VerticalScroll.Maximum;
            }
        }
        private Color GetColor()
        {
            if (tableLayoutPanel.RowCount % 2 == 0)
            {
                return Color.LightGray;
            }
            else
            {
                return Color.White;
            }
        }
        private void AdjustTableLayoutSize() //パネルサイズ拡張
        {
            if (tableLayoutPanel == null || panelcontain == null)
            {
                MessageBox.Show("tableLayoutPanel または panelContainer が見つかりません。");
                return;
            }

            // `TableLayoutPanel` の高さを行数に合わせて調整
            tableLayoutPanel.Height = tableLayoutPanel.RowCount * 40 + 10;

            // `panelContainer` のスクロールを維持
            panelcontain.AutoScroll = true;

            // スクロール位置を最上部に戻す
            // スクロール領域を適切に設定（TableLayoutPanelの高さ分）
            panelcontain.AutoScrollMinSize = new Size(0, tableLayoutPanel.Height);

            // レイアウトの更新
            panelcontain.PerformLayout();
            panelcontain.Update();

            panelcontain.Invalidate();

            // **スクロールバーのハンドル位置を更新**
            panelcontain.VerticalScroll.Value = panelcontain.VerticalScroll.Maximum;
        }
        private void RearrangeTableLayoutPanel()
        {
            if (tableLayoutPanel == null)
            {
                return;
            }

            // 既存のアイテムをリストに保存
            List<Control> controls = new List<Control>();
            foreach (Control control in tableLayoutPanel.Controls)
            {
                controls.Add(control);
            }

            // すべてのアイテムを一度削除
            tableLayoutPanel.Controls.Clear();

            // 行数をリセット
            tableLayoutPanel.RowCount = 0;

            // すべてのアイテムを再配置
            foreach (Control control in controls)
            {
                tableLayoutPanel.RowCount++;
                tableLayoutPanel.Controls.Add(control, 0, tableLayoutPanel.RowCount - 1);
            }

            // スクロールバーを更新
            AdjustTableLayoutSize();
        }

        public class ListItemControl : UserControl
        {
            private CheckBox checkBox;
            private Label label;
            private Button deleteButton;

            public event EventHandler DeleteClicked; // 削除ボタンが押されたときのイベント

            public ListItemControl(string text)
            {
                // コントロールの初期化
                this.Width = 400; // 幅を固定（必要に応じて変更）
                this.Height = 40; // 高さを固定
                //this.Margin = new Padding(5); // 間隔
                this.BackColor = Color.White;
                //コメントボックスの取得
                

                checkBox = new CheckBox
                {
                    Dock = DockStyle.Left,
                    Width = 20,
                };

                label = new Label
                {
                    Text = text,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                deleteButton = new Button
                {
                    Text = "削除",
                    Dock = DockStyle.Right,
                    Width = 60,
                };

                deleteButton.Click += (s, e) => DeleteClicked?.Invoke(this, EventArgs.Empty);

                this.Controls.Add(deleteButton);
                this.Controls.Add(label);
                this.Controls.Add(checkBox);
            }
        }
        

        #endregion
        private const int maxQuantity = 9999;
        private const int minQuantity = 0;
        private const int FixedHeight = 100;
        private System.Windows.Forms.Timer timer;

        private Label labelQuantity;
        private TextBox textBoxQuantity;
        private Button addButton;
        private Button decreaseButton;
        private TextBox commentbox;
        private Label time;
        private Label title;
        private Button createButton;
        private TableLayoutPanel tableLayoutPanel;
        private Panel panelcontain;
    }
}


