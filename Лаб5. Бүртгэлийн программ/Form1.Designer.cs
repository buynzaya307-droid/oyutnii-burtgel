namespace Лаб5._Бүртгэлийн_программ
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            TreeNode treeNode13 = new TreeNode("Компьютерын ухаан");
            TreeNode treeNode14 = new TreeNode("Мэдээллийн технологи");
            TreeNode treeNode15 = new TreeNode("Программ хангамж");
            TreeNode treeNode16 = new TreeNode("Математик");
            TreeNode treeNode17 = new TreeNode("Физик");
            TreeNode treeNode18 = new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] { treeNode16, treeNode17 });
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            linkLabel2 = new LinkLabel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            treeView1 = new TreeView();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "M.SW24D005";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(31, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Тэтгэлэгтэй";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(27, 92);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Өдрийн сургалт";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Программчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", " Сүлжээ" });
            checkedListBox1.Location = new Point(26, 137);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(25, 257);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 19, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 299);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Мэдээллийн техн";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(25, 345);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.Text = "98989898";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(24, 381);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(143, 27);
            dateTimePicker2.TabIndex = 8;
            dateTimePicker2.Value = new DateTime(2007, 2, 11, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(25, 414);
            button1.Name = "button1";
            button1.Size = new Size(150, 38);
            button1.TabIndex = 9;
            button1.Text = "Бүртгэх";
            button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            listBox1.Location = new Point(206, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Цээж_зураг;
            pictureBox1.Location = new Point(206, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(642, 12);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(73, 20);
            linkLabel2.TabIndex = 13;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Цэвэрлэх";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(389, 45);
            listView1.Name = "listView1";
            listView1.Size = new Size(327, 95);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Овог нэр";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Утас";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Нас";
            columnHeader3.Width = 85;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(389, 150);
            treeView1.Name = "treeView1";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Компьютерын ухаан";
            treeNode14.Name = "Node1";
            treeNode14.Text = "Мэдээллийн технологи";
            treeNode15.Name = "Node2";
            treeNode15.Text = "Программ хангамж";
            treeNode16.Name = "Node4";
            treeNode16.Text = "Математик";
            treeNode17.Name = "Node5";
            treeNode17.Text = "Физик";
            treeNode18.Name = "Node3";
            treeNode18.Text = "Байгалийн ухааны сургууль";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode13, treeNode14, treeNode15, treeNode18 });
            treeView1.Size = new Size(327, 85);
            treeView1.TabIndex = 15;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(389, 245);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(327, 175);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 12);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 17;
            label1.Text = "Нийт: 0";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 470);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(linkLabel2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(checkedListBox1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Оюутны бүртгэлийн программ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TreeView treeView1;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}