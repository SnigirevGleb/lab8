using System;
using System.IO;
using System.Windows.Forms;

namespace Organizer
{
    public partial class MainForm : Form
    {
        private string FileName;
        private string dir = Directory.GetCurrentDirectory() + "\\data\\";

        private void setTime(ToolStripStatusLabel toolStripDateLabel)
        {
            toolStripDateLabel.Text = DateTime.Now.ToString("dddd") + ", " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            FileName = dir + dateTimePicker1.Text + "org";
            LoadFromFile(FileName);
            setTime(toolStripDateLabel);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile(FileName);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            //ПЕРВЫЙ СПОСОБ. РАСКОМЕНТИТЬ, ЕСЛИ ТРЕБУЕТСЯ

            //switch (OrgTabControl.SelectedIndex)
            //{
            //    case 0:
            //        {
            //            listBox0.Items.Add(RecordTextBox.Text);
            //            break;
            //        }
            //    case 1:
            //        {
            //            listBox1.Items.Add(RecordTextBox.Text);
            //            break;
            //        }
            //    case 2:
            //        {
            //            listBox2.Items.Add(RecordTextBox.Text);
            //            break;
            //        }
            //}
            //RecordTextBox.Text = "";

            //ВТОРОЙ СПОСОБ. РАСКОМЕНТИТЬ, ЕСЛИ ТРЕБУЕТСЯ

            string chosenOne = "listBox" + OrgTabControl.SelectedIndex.ToString();
            ListBox CurrentListBox = (ListBox)Controls.Find(chosenOne, true)[0];
            CurrentListBox.Items.Add(RecordTextBox.Text);
            RecordTextBox.Text = "";

        }

        private void ListBox0_Click(object sender, EventArgs e)
        {
            string chosenOne = "listBox" + OrgTabControl.SelectedIndex.ToString();
            ListBox CurrentListBox = (ListBox)Controls.Find(chosenOne, true)[0];
            try
            {
                RecordTextBox.Text = CurrentListBox.SelectedItem.ToString();
            }
            catch { }
        }

        private void SaveToFile(string FileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    for (int i = 0; i < OrgTabControl.TabCount; i++)
                    {
                        ListBox CurrentListBox = (ListBox)Controls.Find("listBox" + i, true)[0];
                        sw.WriteLine(CurrentListBox.Items.Count.ToString());
                        for (int j = 0; j < CurrentListBox.Items.Count; j++)
                            sw.WriteLine(CurrentListBox.Items[j]);
                        CurrentListBox.Items.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFromFile(string FileName)
        {
            if (!File.Exists(FileName))
            {
                FileStream tmp = File.Create(FileName);
                tmp.Close();
            }
            for (int i = 0; i < OrgTabControl.TabCount; i++)
            {
                ListBox CurrentListBox = (ListBox)Controls.Find("listBox" + i, true)[0];
                CurrentListBox.Items.Clear();
            }
            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    for (int i = 0; i < OrgTabControl.TabCount; i++)
                    {
                        ListBox CurrentListBox = (ListBox)Controls.Find("listBox" + i, true)[0];
                        int itemsCount = Convert.ToInt32(sr.ReadLine());
                        for (int j = 0; j < itemsCount; j++)
                            CurrentListBox.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SaveToFile(FileName);
            FileName = dir + dateTimePicker1.Text + "org";
            LoadFromFile(FileName);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string chosenOne = "listBox" + OrgTabControl.SelectedIndex.ToString();
            ListBox CurrentListBox = (ListBox)Controls.Find(chosenOne, true)[0];
            if (CurrentListBox.SelectedItem == null)
                MessageBox.Show("Не была выбрана строка для изменения!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else CurrentListBox.Items[CurrentListBox.SelectedIndex] = RecordTextBox.Text;
            RecordTextBox.Text = CurrentListBox.SelectedItem.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string chosenOne = "listBox" + OrgTabControl.SelectedIndex.ToString();
            ListBox CurrentListBox = (ListBox)Controls.Find(chosenOne, true)[0];
            if (CurrentListBox.SelectedItem == null)
                MessageBox.Show("Не была выбрана строка для удаления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int selected = CurrentListBox.SelectedIndex;
                CurrentListBox.Items.RemoveAt(selected);
                if (CurrentListBox.Items.Count == selected) selected--;
                CurrentListBox.SelectedIndex = selected;
            }
            RecordTextBox.Text = CurrentListBox.SelectedItem.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            string chosenOne = "listBox" + OrgTabControl.SelectedIndex.ToString();
            ListBox CurrentListBox = (ListBox)Controls.Find(chosenOne, true)[0];
            CurrentListBox.Items.Clear();
        }

        private void RecordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddButton_Click(sender, e);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //SaveToFile(FileName);
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            setTime(toolStripDateLabel);
        }
    }
}