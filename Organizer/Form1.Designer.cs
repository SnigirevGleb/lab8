namespace Organizer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OrgTabControl = new System.Windows.Forms.TabControl();
            this.WorkTabPage = new System.Windows.Forms.TabPage();
            this.listBox0 = new System.Windows.Forms.ListBox();
            this.PersonalTabPage = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CongrTabPage = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.BuyTabPage = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RecordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripDateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.OrgTabControl.SuspendLayout();
            this.WorkTabPage.SuspendLayout();
            this.PersonalTabPage.SuspendLayout();
            this.CongrTabPage.SuspendLayout();
            this.BuyTabPage.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OrgTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.CloseButton);
            this.splitContainer1.Panel2.Controls.Add(this.ClearButton);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteButton);
            this.splitContainer1.Panel2.Controls.Add(this.ChangeButton);
            this.splitContainer1.Panel2.Controls.Add(this.AddButton);
            this.splitContainer1.Panel2.Controls.Add(this.RecordTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(684, 361);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 0;
            // 
            // OrgTabControl
            // 
            this.OrgTabControl.Controls.Add(this.WorkTabPage);
            this.OrgTabControl.Controls.Add(this.PersonalTabPage);
            this.OrgTabControl.Controls.Add(this.CongrTabPage);
            this.OrgTabControl.Controls.Add(this.BuyTabPage);
            this.OrgTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrgTabControl.Location = new System.Drawing.Point(0, 0);
            this.OrgTabControl.Name = "OrgTabControl";
            this.OrgTabControl.SelectedIndex = 0;
            this.OrgTabControl.Size = new System.Drawing.Size(446, 357);
            this.OrgTabControl.TabIndex = 0;
            // 
            // WorkTabPage
            // 
            this.WorkTabPage.Controls.Add(this.listBox0);
            this.WorkTabPage.Location = new System.Drawing.Point(4, 22);
            this.WorkTabPage.Name = "WorkTabPage";
            this.WorkTabPage.Size = new System.Drawing.Size(438, 331);
            this.WorkTabPage.TabIndex = 0;
            this.WorkTabPage.Text = "Работа";
            this.WorkTabPage.UseVisualStyleBackColor = true;
            // 
            // listBox0
            // 
            this.listBox0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox0.FormattingEnabled = true;
            this.listBox0.Location = new System.Drawing.Point(0, 0);
            this.listBox0.Name = "listBox0";
            this.listBox0.Size = new System.Drawing.Size(438, 331);
            this.listBox0.TabIndex = 0;
            this.listBox0.Click += new System.EventHandler(this.ListBox0_Click);
            // 
            // PersonalTabPage
            // 
            this.PersonalTabPage.Controls.Add(this.listBox1);
            this.PersonalTabPage.Location = new System.Drawing.Point(4, 22);
            this.PersonalTabPage.Name = "PersonalTabPage";
            this.PersonalTabPage.Size = new System.Drawing.Size(438, 331);
            this.PersonalTabPage.TabIndex = 1;
            this.PersonalTabPage.Text = "Личное";
            this.PersonalTabPage.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(438, 331);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.ListBox0_Click);
            // 
            // CongrTabPage
            // 
            this.CongrTabPage.Controls.Add(this.listBox2);
            this.CongrTabPage.Location = new System.Drawing.Point(4, 22);
            this.CongrTabPage.Name = "CongrTabPage";
            this.CongrTabPage.Size = new System.Drawing.Size(438, 331);
            this.CongrTabPage.TabIndex = 2;
            this.CongrTabPage.Text = "Поздравить";
            this.CongrTabPage.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(438, 331);
            this.listBox2.TabIndex = 2;
            this.listBox2.Click += new System.EventHandler(this.ListBox0_Click);
            // 
            // BuyTabPage
            // 
            this.BuyTabPage.Controls.Add(this.listBox3);
            this.BuyTabPage.Location = new System.Drawing.Point(4, 22);
            this.BuyTabPage.Name = "BuyTabPage";
            this.BuyTabPage.Size = new System.Drawing.Size(438, 331);
            this.BuyTabPage.TabIndex = 3;
            this.BuyTabPage.Text = "Купить";
            this.BuyTabPage.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(0, 0);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(438, 331);
            this.listBox3.TabIndex = 1;
            this.listBox3.Click += new System.EventHandler(this.ListBox0_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(65, 303);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(110, 30);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(65, 267);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(110, 30);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(65, 196);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 30);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(65, 160);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(110, 30);
            this.ChangeButton.TabIndex = 3;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(65, 124);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 30);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RecordTextBox
            // 
            this.RecordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordTextBox.Location = new System.Drawing.Point(27, 80);
            this.RecordTextBox.Name = "RecordTextBox";
            this.RecordTextBox.Size = new System.Drawing.Size(189, 22);
            this.RecordTextBox.TabIndex = 1;
            this.RecordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecordTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сообщение";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDateLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 339);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripDateLabel
            // 
            this.toolStripDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDateLabel.Margin = new System.Windows.Forms.Padding(6, 3, 0, 2);
            this.toolStripDateLabel.Name = "toolStripDateLabel";
            this.toolStripDateLabel.Size = new System.Drawing.Size(22, 17);
            this.toolStripDateLabel.Text = "txt";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ежедневник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.OrgTabControl.ResumeLayout(false);
            this.WorkTabPage.ResumeLayout(false);
            this.PersonalTabPage.ResumeLayout(false);
            this.CongrTabPage.ResumeLayout(false);
            this.BuyTabPage.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl OrgTabControl;
        private System.Windows.Forms.TabPage WorkTabPage;
        private System.Windows.Forms.ListBox listBox0;
        private System.Windows.Forms.TabPage PersonalTabPage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage CongrTabPage;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox RecordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TabPage BuyTabPage;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDateLabel;
        private System.Windows.Forms.Timer timer;
    }
}

