using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Лаб5._Бүртгэлийн_программ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (textBox1 != null) textBox1.TextChanged += Input_Changed;
            if (maskedTextBox1 != null) maskedTextBox1.TextChanged += Input_Changed;
            if (comboBox1 != null) comboBox1.SelectedIndexChanged += Input_Changed;
            if (dateTimePicker2 != null) dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            if (button1 != null) button1.Click += button1_Click;
            if (linkLabel2 != null) linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            if (pictureBox1 != null) pictureBox1.Click += pictureBox1_Click;
            if (listView1 != null) listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            if (treeView1 != null) treeView1.AfterSelect += treeView1_AfterSelect;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Оюутны бүртгэлийн программ";
            if (button1 != null) button1.Text = "Бүртгэх";
            if (maskedTextBox1 != null) maskedTextBox1.Mask = "0000-0000";

            if (comboBox1 != null && comboBox1.Items.Count == 0)
            {
                comboBox1.Items.AddRange(new object[] {
                    "-- Тэнхим сонгох --",
                    "Компьютерын ухаан",
                    "Мэдээллийн технологи",
                    "Программ хангамж"
                });
                comboBox1.SelectedIndex = 0;
            }

            UpdateProgress();
        }

        private void Input_Changed(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2 != null && numericUpDown1 != null)
            {
                int age = DateTime.Today.Year - dateTimePicker2.Value.Year;
                if (dateTimePicker2.Value.Date > DateTime.Today.AddYears(-age)) age--;

                if (age >= numericUpDown1.Minimum && age <= numericUpDown1.Maximum)
                {
                    numericUpDown1.Value = age;
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && comboBox1 != null)
            {
                int idx = comboBox1.Items.IndexOf(e.Node.Text);
                if (idx >= 0)
                {
                    comboBox1.SelectedIndex = idx;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Зураг|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image?.Dispose();
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    UpdateProgress();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Warn("Овог нэр эсвэл кодоо оруулна уу.");
                textBox1.Focus();
                return;
            }

            if (maskedTextBox1 != null && !maskedTextBox1.MaskCompleted)
            {
                Warn("Утасны дугаараа бүрэн оруулна уу.");
                maskedTextBox1.Focus();
                return;
            }

            string courses = checkedListBox1 != null ?
                string.Join(", ", checkedListBox1.CheckedItems.Cast<string>()) : "";

            string language = listBox1?.SelectedItem != null ? listBox1.SelectedItem.ToString() : "Сонгоогүй";

            Student student = new Student
            {
                Code = textBox1?.Text,
                Phone = maskedTextBox1?.Text,
                Department = comboBox1?.SelectedItem?.ToString() ?? comboBox1?.Text,
                Age = numericUpDown1 != null ? (int)numericUpDown1.Value : 0,
                BirthDate = dateTimePicker2 != null ? dateTimePicker2.Value.ToString("yyyy-MM-dd") : "",
                IsScholarship = checkBox1 != null && checkBox1.Checked,
                StudyType = radioButton1 != null && radioButton1.Checked ? "Өдрийн" : "Бусад",
                Courses = courses,
                Language = language
            };

            if (listView1 != null)
            {
                // Хүснэгтийн багануудад утгыг шууд массив хэлбэрээр өгөх
                ListViewItem item = new ListViewItem(new string[] { student.Code, student.Phone, student.Age.ToString() });
                item.Tag = student;
                listView1.Items.Add(item);
                listView1.Refresh(); // Дэлгэцийг шинэчлэх

                if (label1 != null)
                {
                    label1.Text = $"Нийт: {listView1.Items.Count}";
                }
            }

            ShowInRichText(student);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1 != null && listView1.SelectedItems.Count == 1 &&
                listView1.SelectedItems[0].Tag is Student s)
            {
                ShowInRichText(s);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox1 != null) textBox1.Clear();
            if (maskedTextBox1 != null) maskedTextBox1.Clear();
            if (comboBox1 != null && comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            if (richTextBox1 != null) richTextBox1.Clear();
            if (checkBox1 != null) checkBox1.Checked = false;
            if (listBox1 != null) listBox1.ClearSelected();
            if (checkedListBox1 != null)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
            }
            if (pictureBox1 != null)
            {
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = null;
            }

            UpdateProgress();
        }

        private void UpdateProgress() { }

        private void Warn(string msg)
        {
            MessageBox.Show(msg, "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInRichText(Student s)
        {
            if (richTextBox1 == null) return;

            richTextBox1.Clear();

            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Navy;
            richTextBox1.AppendText("ОЮУТНЫ БҮРТГЭЛ\n");

            richTextBox1.SelectionColor = Color.DarkGray;
            richTextBox1.AppendText("------------------------------------\n");

            AppendRichLine("Код/Нэр: ", s.Code, Color.Black, Color.DarkSeaGreen);
            AppendRichLine("Утас: ", s.Phone, Color.Black, Color.DarkSeaGreen);
            AppendRichLine("Нас: ", s.Age.ToString(), Color.Black, Color.DarkSeaGreen);
            AppendRichLine("Төрсөн өдөр: ", s.BirthDate, Color.Black, Color.DarkSeaGreen);
            AppendRichLine("Сургалт: ", s.StudyType, Color.Black, Color.DarkSeaGreen);
            AppendRichLine("Тэнхим: ", s.Department, Color.Black, Color.DarkSeaGreen);
            AppendRichLine("Тэтгэлэг: ", s.IsScholarship ? "Тийм" : "Үгүй", Color.Black, Color.DarkSeaGreen);
            AppendRichLine("Хичээл: ", s.Courses, Color.Black, Color.DarkSeaGreen);
            AppendRichLine("Хэл: ", s.Language, Color.Black, Color.DarkSeaGreen);
        }

        private void AppendRichLine(string label, string value, Color labelColor, Color valueColor)
        {
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Bold);
            richTextBox1.SelectionColor = labelColor;
            richTextBox1.AppendText(label);

            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.SelectionColor = valueColor;
            richTextBox1.AppendText(value + "\n");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }

    public class Student
    {
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }
        public bool IsScholarship { get; set; }
        public string StudyType { get; set; }
        public string Courses { get; set; }
        public string Language { get; set; }
    }
}