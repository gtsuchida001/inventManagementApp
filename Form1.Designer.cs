
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.ComponentModel;
using DatabaseHelper;

namespace inventManagementApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //public List<int> newIds = new List<int>(); // newId を保持するリスト
        public int newIds = 0; // **ID を保持するメンバ変数**

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
            allReset = new Button();
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
            tableLayoutPanel.AutoSize = true;  // **自動サイズ調整を有効化**
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;  // **サイズをコンテンツに合わせる**
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel.Location = new Point(14, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(407, 267);
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
            // allReset
            // 
            allReset.Location = new Point(0, 0);
            allReset.Name = "allReset";
            allReset.Size = new Size(107, 36);
            allReset.TabIndex = 14;
            allReset.Text = "all reset";
            allReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(500, 606);
            Controls.Add(allReset);
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
            //int newId = DatabaseHelper.DatabaseHelper.GetNewId(); // **新しい ID を取得**
            string record_day = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            var newItem = new ListItemControl(textBoxQuantity.Text, commentbox.Text, record_day , 0);

            // TableLayoutPanel に追加
            tableLayoutPanel.RowCount++; //色用のカウント
            tableLayoutPanel.Controls.Add(newItem, 0, tableLayoutPanel.RowCount - 1);
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // **高さを自動調整**

            // レイアウトを更新
            tableLayoutPanel.PerformLayout();
            tableLayoutPanel.Invalidate();

            //パネルサイズの更新
            AdjustTableLayoutSize();

            // 最下部にスクロール
            panelcontain.VerticalScroll.Value = panelcontain.VerticalScroll.Maximum;

        }
        public static Color GetColor(int rowCount)
        {
            if (rowCount % 2 == 0)
            {
                return Color.LightGray;
            }
            else
            {
                return Color.White;
            }
        }
        private bool isUserScrolling = false;
        private void AdjustTableLayoutSize()
        {
            if (tableLayoutPanel == null || panelcontain == null)
            {
                MessageBox.Show("tableLayoutPanel または panelContainer が見つかりません。");
                return;
            }
            // **最初の行の RowStyle を AutoSize に設定**
            if (tableLayoutPanel.RowStyles.Count > 0)
            {
                tableLayoutPanel.RowStyles[0] = new RowStyle(SizeType.AutoSize);
            }
            // **リストアイテムの高さを基に計算**
            // **自動サイズ調整を有効化**
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            // **スクロール領域を適切に設定**
            panelcontain.AutoScroll = false; // **一度無効化**
            int calculatedHeight = tableLayoutPanel.PreferredSize.Height; // **200増やして確実にスクロール可能に**
            panelcontain.AutoScrollMinSize = new Size(0, calculatedHeight);
            panelcontain.AutoScroll = true; // **再度有効化**

            // **Margin と Padding をゼロにする**
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Padding = new Padding(0);

            // **レイアウトを更新**
            tableLayoutPanel.PerformLayout();
            panelcontain.PerformLayout();
            panelcontain.Update();
            panelcontain.Invalidate();

            // **手動スクロール中でなければ最下部にスクロール**
            if (!isUserScrolling)
            {
                panelcontain.VerticalScroll.Value = panelcontain.VerticalScroll.Maximum;
                panelcontain.AutoScrollPosition = new Point(0, panelcontain.VerticalScroll.Maximum);
            }
        }
        // **スクロールイベントを追加**
        private void panelcontain_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.ThumbTrack || e.Type == ScrollEventType.ThumbPosition)
            {
                isUserScrolling = true; // **手動スクロール中**
            }
            else
            {
                isUserScrolling = false; // **スクロールを手放したら通常の処理に戻る**
            }
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
    Form1 parentForm = this.FindForm() as Form1;
    if (parentForm == null)
    {
        MessageBox.Show("親フォームが見つかりません");
        return;
    }

    // **すべての ListItemControl を取得し、論理削除**
    foreach (Control control in parentForm.tableLayoutPanel.Controls)
    {
        if (control is ListItemControl itemControl && itemControl.idnum != 0)
        {
            DatabaseHelper.DatabaseHelper.SoftDeleteId(itemControl.idnum);
        }
    }

    // **すべてのコントロールを削除**
    parentForm.tableLayoutPanel.Controls.Clear();

    // **行数をリセット**
    parentForm.tableLayoutPanel.RowCount = 0;

    // **レイアウトを更新**
    parentForm.tableLayoutPanel.PerformLayout();

    // **スクロール領域をリセット**
    parentForm.AdjustTableLayoutSize();
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
            private Button detailButton;
            private int rowIndex;
            public int idnum;
            public int Id { get; private set; } // **データベースの ID を保持**
            public event EventHandler DeleteClicked; // 削除ボタンが押されたときのイベント

            public ListItemControl(string Quantitytext, string commentText, string record_day, int flag)
            {
                // コントロールの初期化
                this.Width = 400; // 幅を固定（必要に応じて変更）
                this.Height = 40; // 高さを固定
                this.BackColor = Color.White;
                this.Padding = new Padding(0);
                if (flag == 0)
                {
                    // **新しいIDを取得し、データベースに追加**
                    this.idnum = DatabaseHelper.DatabaseHelper.GetNewId();
                    DatabaseHelper.DatabaseHelper.InsertNewItem(this.idnum, Quantitytext, commentText, record_day);
                }
                else
                {
                    // **フラグが0以外なら、その値をIDとして使用**
                    this.idnum = flag;
                }

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
                    Text = record_day,
                    Font = new Font("Yu Gothic UI", 12F, GraphicsUnit.Pixel),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Width = 70, // **時間の幅を固定**
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
                    Width = 80, // **コメントの幅を固定**
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
                    Width = 50,
                    Height = 30
                };

                detailButton = new Button
                {
                    Font = new Font("Yu Gothic UI", 12F, GraphicsUnit.Pixel),
                    Text = "詳細",
                    Width = 50,
                    Height = 30,
                };

                detailButton.Click += DetailButton_Click;
                deleteButton.Click += DeleteButton_Click;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                // FlowLayoutPanel に追加**
                layoutPanel.Controls.Add(checkBox);
                layoutPanel.Controls.Add(timelabel);
                layoutPanel.Controls.Add(Quantitylabel);
                layoutPanel.Controls.Add(commentlabel);
                layoutPanel.Controls.Add(deleteButton);
                layoutPanel.Controls.Add(detailButton);

                // この UserControl に FlowLayoutPanel を追加**
                this.Controls.Add(layoutPanel);

                //色を設定
                this.BackColor = GetColor(idnum);
            }
            private void CheckBox_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox.Checked)
                {
                    this.BackColor = Color.LightGreen; // チェック時は緑
                }
                else
                {
                    if (idnum % 2 == 1) //生成時の参照からずらす
                    {
                        this.BackColor = Color.White;
                    }
                    else
                    {
                        this.BackColor = Color.LightGray;
                    }
                }
            }

            private void DetailButton_Click(object sender, EventArgs e)
            {
                Form1 parentForm = this.FindForm() as Form1;
                if (parentForm == null)
                {
                    MessageBox.Show("親フォームが見つかりません");
                    return;
                }

                Button clickedButton = sender as Button;
                if (clickedButton == null) return;

                // **クリックされたボタンの親（ListItemControl）を取得**
                ListItemControl itemControl = FindParentListItemControl(clickedButton);
                if (itemControl == null)
                {
                    MessageBox.Show("エラー: アイテムが見つかりません。");
                    return;
                }

                int idnum = itemControl.idnum; // **リストアイテムごとのIDを取得**

                // **リストに保存されたIDを確認**
                if (idnum == 0)
                {
                    MessageBox.Show("エラー: ID が未登録です。");
                    return;
                }

                Form2 detailForm = new Form2(parentForm, idnum); // **ID を渡す**
                detailForm.StartPosition = FormStartPosition.Manual; // 手動で位置を設定
                detailForm.Location = parentForm.Location; // **Form1 の位置を適用**
                detailForm.Size = parentForm.Size; // **Form1 のサイズを適用（必要なら）**

                detailForm.Show();
                parentForm.Hide(); // Form1 を非表示
            }


            // **削除イベント**
            private void DeleteButton_Click(object sender, EventArgs e)
            {
                Form1 parentForm = this.FindForm() as Form1;
                if (parentForm == null)
                {
                    MessageBox.Show("親フォームが見つかりません");
                    return;
                }
                Button clickedButton = sender as Button;
                if (clickedButton == null) return;
                // **クリックされたボタンの親（ListItemControl）を取得**
                ListItemControl itemControl = FindParentListItemControl(clickedButton);
                if (itemControl == null)
                {
                    MessageBox.Show("エラー: アイテムが見つかりません。");
                    return;
                }
                int idnum = itemControl.idnum;
                // **リストに保存されたIDを確認**
                if (idnum == 0)
                {
                    MessageBox.Show("エラー: ID が未登録です。");
                    return;
                }
                int is_deleted_id = itemControl.idnum;
                DatabaseHelper.DatabaseHelper.SoftDeleteId(idnum); // **ID をソフトデリート**
                // **アイテムを削除**
                parentForm.tableLayoutPanel.Controls.Remove(itemControl);
                parentForm.tableLayoutPanel.RowCount--;
                // **すべてのアイテムを上に詰める**
                parentForm.RearrangeTableLayoutPanel();
                parentForm.AdjustTableLayoutSize();
            }
            private ListItemControl FindParentListItemControl(Control control)
            {
                while (control != null && !(control is ListItemControl))
                {
                    control = control.Parent; // **親をたどる**
                }
                return control as ListItemControl; // **見つかったら返す**
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
        private System.Windows.Forms.Timer timer;

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
        private Button allReset;
    }
}
