<<<<<<< HEAD
﻿namespace inventManagementApp
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.ComponentModel;

namespace inventManagementApp
>>>>>>> stage
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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}
=======
            components = new Container();
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
            clearbutton = new Button();
            combinedbutton = new Button();
            combinedquantitylabel = new Label();
            panelcontain.SuspendLayout();
            SuspendLayout();
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.BackColor = Color.Transparent;
            labelQuantity.Font = new Font("Yu Gothic UI", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelQuantity.Location = new Point(12, 107);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(103, 54);
            labelQuantity.TabIndex = 0;
            labelQuantity.Text = "数量";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.BackColor = SystemColors.Control;
            textBoxQuantity.Font = new Font("Yu Gothic UI", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            commentbox.Font = new Font("Yu Gothic UI", 26F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            time.Font = new Font("Yu Gothic UI", 26F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            title.Font = new Font("Yu Gothic UI", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            createButton.AutoSize = true;
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
            tableLayoutPanel.Size = new Size(407, 241);
            tableLayoutPanel.TabIndex = 8;
            // 
            // panelcontain
            // 
            panelcontain.Controls.Add(tableLayoutPanel);
            panelcontain.Location = new Point(26, 240);
            panelcontain.Name = "panelcontain";
            panelcontain.Size = new Size(450, 267);
            panelcontain.TabIndex = 10;
            // 
            // clearbutton
            // 
            clearbutton.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            clearbutton.Location = new Point(40, 513);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(140, 44);
            clearbutton.TabIndex = 11;
            clearbutton.Text = "クリア";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // combinedbutton
            // 
            combinedbutton.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            combinedbutton.Location = new Point(197, 515);
            combinedbutton.Name = "combinedbutton";
            combinedbutton.Size = new Size(255, 42);
            combinedbutton.TabIndex = 12;
            combinedbutton.Text = "選択された合計数量";
            combinedbutton.UseVisualStyleBackColor = true;
            combinedbutton.Click += combinedbutton_Click;
            // 
            // combinedquantitylabel
            // 
            combinedquantitylabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            combinedquantitylabel.AutoSize = true;
            combinedquantitylabel.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            combinedquantitylabel.Location = new Point(266, 569);
            combinedquantitylabel.Name = "combinedquantitylabel";
            combinedquantitylabel.Size = new Size(92, 28);
            combinedquantitylabel.TabIndex = 13;
            combinedquantitylabel.Text = "合計数：";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(500, 606);
            Controls.Add(combinedquantitylabel);
            Controls.Add(combinedbutton);
            Controls.Add(clearbutton);
            Controls.Add(createButton);
            Controls.Add(title);
            Controls.Add(time);
            Controls.Add(commentbox);
            Controls.Add(decreaseButton);
            Controls.Add(addButton);
            Controls.Add(textBoxQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(panelcontain);
            MaximumSize = new Size(522, 662);
            MinimumSize = new Size(522, 662);
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

        // KeyPress: 入力制限のみ行う（テキストの変更はしない）
        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 数字とバックスペースのみ許可
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // 最大桁数を超える入力を防ぐ
            string rawText = textBoxQuantity.Text.Replace(",", "");
            if (char.IsDigit(e.KeyChar) && rawText.Length >= 4)
            {
                e.Handled = true; // **4桁以上は入力させない**
                return;
            }
        }

        // TextChanged: 入力後に数値を処理する
        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQuantity.Focused) // **ユーザーの手入力のみ処理**
            {
                int cursorPos = textBoxQuantity.SelectionStart; // **カーソル位置を保存**

                string rawText = textBoxQuantity.Text.Replace(",", "");
                if (int.TryParse(rawText, out int inputQuantity))
                {
                    int checkedQuantity = CheckQuantityRange(inputQuantity);
                    textBoxQuantity.Text = checkedQuantity.ToString("N0");

                    // **カーソル位置を適切に復元**
                    int lengthDiff = textBoxQuantity.Text.Length - rawText.Length;
                    cursorPos += lengthDiff; // 変換後のテキスト長との差分を補正
                    textBoxQuantity.SelectionStart = Math.Max(0, cursorPos);
                }
                else
                {
                    textBoxQuantity.Text = minQuantity.ToString(); // **無効な場合は最小値**
                }
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
                MessageBox.Show("有効な数値を入力してください(0~9999)");
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
                    return;
                }

                // **空欄の場合の処理**
                string commentText = string.IsNullOrWhiteSpace(commentbox.Text) ? "blank comment" : commentbox.Text;
                int rowIndex = tableLayoutPanel.RowCount;

                // 新しいリストアイテムを作成
                var newItem = new ListItemControl(textBoxQuantity.Text,commentbox.Text, rowIndex);

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
        public Color GetColor()
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

        private void clearbutton_Click(object sender, EventArgs e)
        {
            // すべてのコントロールを削除
            tableLayoutPanel.Controls.Clear();

            // 行数をリセット
            tableLayoutPanel.RowCount = 0;

            // レイアウトを更新
            tableLayoutPanel.PerformLayout();

            // スクロール領域をリセット
            AdjustTableLayoutSize();
        }

        private void combinedbutton_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is ListItemControl item)
                {
                    // チェックが付いている場合
                    if (item.IsChecked)
                    {
                        // 数量を取得して加算
                        if (int.TryParse(item.QuantityText, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out int quantity))
                        {
                            total += quantity;
                        }
                    }
                }
            }
            if (total >= int.MinValue && total <= int.MaxValue)
            {
                combinedquantitylabel.Text = $"合計数：{total}";
            }
            else
            {
                MessageBox.Show("計算後の値は巨大すぎます");
            }
        }

        public class ListItemControl : UserControl
        {
            private CheckBox checkBox;
            private Label timelabel;
            private Label Quantitylabel;
            private Label commentlabel;
            private Button deleteButton;
            private int rowIndex;

            public event EventHandler DeleteClicked; // 削除ボタンが押されたときのイベント

            public ListItemControl(string Quantitytext, string commentText, int rowIndex)
            {
                // コントロールの初期化
                this.Width = 400; // 幅を固定（必要に応じて変更）
                this.Height = 40; // 高さを固定
                //this.Margin = new Padding(5); // 間隔
                this.BackColor = Color.White;
                this.rowIndex = rowIndex;

                FlowLayoutPanel layoutPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight, // **横方向に並べる**
                    Dock = DockStyle.Fill,
                    AutoSize = false,
                    Width = this.Width,
                    Height = this.Height,
                    WrapContents = false,
                    BackColor = Color.Transparent
                };

                checkBox = new CheckBox
                {
                    Width = 20,
                    Height = 30,
                    Margin = new Padding(5, 5, 5, 5)
                };

                timelabel = new Label
                {
                    Text = DateTime.Now.ToString("HH:mm:ss"),
                    Font = new Font("Yu Gothic UI", 12F, GraphicsUnit.Pixel),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Width = 90, // **時間の幅を固定**
                    Height = 30
                };

                Quantitylabel = new Label
                {
                    Text = Quantitytext,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Width = 60, // **数量の幅を固定**
                    Height = 30,
                    Font = new Font("Yu Gothic UI", 12F, GraphicsUnit.Pixel),
                };

                commentlabel = new Label
                {
                    Font = new Font("Yu Gothic UI", 12F, GraphicsUnit.Pixel),
                    Text = commentText,
                    AutoSize = false,
                    Width = 100, // **コメントの幅を固定**
                    Height = 30,
                    TextAlign = ContentAlignment.MiddleLeft,  // **テキストの位置を左寄せ**
                    AutoEllipsis = true,  // **長いテキストは「...」で省略**
                    MaximumSize = new Size(100, 30),
                    MinimumSize = new Size(100, 30),
                };

                deleteButton = new Button
                {
                    Font = new Font("Yu Gothic UI", 12F, GraphicsUnit.Pixel),
                    Text = "削除",
                    Width = 60,
                    Height = 30
                };
                deleteButton.Click += (s, e) => DeleteClicked?.Invoke(this, EventArgs.Empty);
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                // FlowLayoutPanel に追加**
                layoutPanel.Controls.Add(checkBox);
                layoutPanel.Controls.Add(timelabel);
                layoutPanel.Controls.Add(Quantitylabel);
                layoutPanel.Controls.Add(commentlabel);
                layoutPanel.Controls.Add(deleteButton);

                // この UserControl に FlowLayoutPanel を追加**
                this.Controls.Add(layoutPanel);
            }

            private void CheckBox_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox.Checked)
                {
                    this.BackColor = Color.LightGreen; // チェック時は緑
                }
                else
                {
                    if (rowIndex % 2 == 0) //生成時の参照からずらす
                    {
                        this.BackColor = Color.White;
                    }
                    else
                    {
                        this.BackColor = Color.LightGray;
                    }
                }
            }
            
            // **プロパティ: チェックされているか**
            public bool IsChecked => checkBox.Checked;

            // **プロパティ: 数量のテキスト**
            public string QuantityText => Quantitylabel.Text;
        }
        

        #endregion
        private const int maxQuantity = 9999;
        private const int minQuantity = 0;
        private const int FixedHeight = 100;
        //private const int FixedHeight =50;
        private System.Windows.Forms.Timer timer;

        //private Label labelQuantity;
        //private TextBox textBoxQuantity;
        //private Button addButton;
        //private Button decreaseButton;
        //private TextBox commentbox;
        //private Label time;
        //private Label title;
        //private Button createButton;
        //private TableLayoutPanel tableLayoutPanel;
        //private Panel panelcontain;
        //private Button clearbutton;
        //private Button combinedbutton;
        //private Label combinedquantitylabel;

        public Label labelQuantity;
        public TextBox textBoxQuantity;
        public Button addButton;
        public Button decreaseButton;
        public TextBox commentbox;
        public Label time;
        public Label title;
        public Button createButton;
        public TableLayoutPanel tableLayoutPanel;
        public Panel panelcontain;
        public Button clearbutton;
        public Button combinedbutton;
        public Label combinedquantitylabel;
    }
}


>>>>>>> stage
