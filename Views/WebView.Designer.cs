namespace FinalTest.Views
{
    partial class WebView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRefresh = new Button();
            lbTitle = new Label();
            richTextBox1 = new RichTextBox();
            btnSearch = new Button();
            button2 = new Button();
            button1 = new Button();
            searchValue = new TextBox();
            tabPage2 = new TabPage();
            btnGoToFav = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridView3 = new DataGridView();
            tabPage3 = new TabPage();
            btnGoToHistory = new Button();
            dataGridView4 = new DataGridView();
            tabPage4 = new TabPage();
            txtDownload = new TextBox();
            button3 = new Button();
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            btnClear = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRefresh);
            tabPage1.Controls.Add(lbTitle);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(searchValue);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 409);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(680, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(104, 35);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "&Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(130, 78);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(0, 25);
            lbTitle.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Bottom;
            richTextBox1.Location = new Point(3, 95);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(786, 311);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(8, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 35);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(557, 17);
            button2.Name = "button2";
            button2.Size = new Size(104, 35);
            button2.TabIndex = 2;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(434, 17);
            button1.Name = "button1";
            button1.Size = new Size(104, 35);
            button1.TabIndex = 1;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // searchValue
            // 
            searchValue.Location = new Point(8, 17);
            searchValue.Name = "searchValue";
            searchValue.Size = new Size(409, 31);
            searchValue.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnGoToFav);
            tabPage2.Controls.Add(btnRemove);
            tabPage2.Controls.Add(btnEdit);
            tabPage2.Controls.Add(btnAdd);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Favourites";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGoToFav
            // 
            btnGoToFav.Location = new Point(337, 342);
            btnGoToFav.Name = "btnGoToFav";
            btnGoToFav.Size = new Size(95, 47);
            btnGoToFav.TabIndex = 4;
            btnGoToFav.Text = "Go To";
            btnGoToFav.UseVisualStyleBackColor = true;
            btnGoToFav.Click += button4_Click_1;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(221, 346);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(95, 44);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += button8_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(109, 340);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 47);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button7_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 47);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button6_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeight = 34;
            dataGridView3.Dock = DockStyle.Top;
            dataGridView3.GridColor = SystemColors.Control;
            dataGridView3.Location = new Point(3, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RightToLeft = RightToLeft.No;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(786, 330);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnClear);
            tabPage3.Controls.Add(btnGoToHistory);
            tabPage3.Controls.Add(dataGridView4);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 409);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "History";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGoToHistory
            // 
            btnGoToHistory.Location = new Point(633, 356);
            btnGoToHistory.Name = "btnGoToHistory";
            btnGoToHistory.Size = new Size(151, 47);
            btnGoToHistory.TabIndex = 1;
            btnGoToHistory.Text = "Go To";
            btnGoToHistory.UseVisualStyleBackColor = true;
            btnGoToHistory.Click += button5_Click_1;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Top;
            dataGridView4.Location = new Point(3, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(786, 338);
            dataGridView4.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtDownload);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(richTextBox2);
            tabPage4.Location = new Point(4, 37);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 409);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Download";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtDownload
            // 
            txtDownload.Location = new Point(176, 34);
            txtDownload.Name = "txtDownload";
            txtDownload.Size = new Size(486, 31);
            txtDownload.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(676, 33);
            button3.Name = "button3";
            button3.Size = new Size(109, 39);
            button3.TabIndex = 2;
            button3.Text = "Download";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter File Path:";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(3, 100);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(786, 306);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(445, 356);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 47);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear History";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // WebView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "WebView";
            Text = "WebView";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSearch;
        private Button button2;
        private Button button1;
        private TextBox searchValue;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView3;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        private Label lbTitle;
        private Button btnRefresh;
        private TabPage tabPage3;
        private DataGridView dataGridView4;
        private TabPage tabPage4;
        private Label label1;
        private RichTextBox richTextBox2;
        private TextBox txtDownload;
        private Button button3;
        private Button btnGoToFav;
        private Button btnGoToHistory;
        private Button btnClear;
    }
}