namespace Assigment6
{
    partial class MainForm
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
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            cmbPriority = new ComboBox();
            label3 = new Label();
            txtToDo = new TextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lstTask = new ListBox();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newCtrlNToolStripMenuItem = new ToolStripMenuItem();
            menuFileOpen = new ToolStripMenuItem();
            menuFileSave = new ToolStripMenuItem();
            menuFileExit = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuMain = new MenuStrip();
            AddTask = new Button();
            groupBox1.SuspendLayout();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 72);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 0;
            label1.Text = "Date and time";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.CustomFormat = "dddd, dd MMMM yyyy HH:mm";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(173, 72);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(273, 23);
            dateTimePicker.TabIndex = 1;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(465, 72);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 2;
            label2.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(531, 72);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(121, 23);
            cmbPriority.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 115);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 4;
            label3.Text = "Expenses";
            label3.Click += label3_Click;
            // 
            // txtToDo
            // 
            txtToDo.Location = new Point(145, 115);
            txtToDo.Name = "txtToDo";
            txtToDo.Size = new Size(531, 23);
            txtToDo.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lstTask);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(50, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 222);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Economy";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(266, 35);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 11;
            label7.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(201, 35);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 10;
            label6.Text = "Priority";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(160, 35);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 9;
            label5.Text = "Hour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(37, 35);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "Date";
            // 
            // lstTask
            // 
            lstTask.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstTask.FormattingEnabled = true;
            lstTask.ItemHeight = 13;
            lstTask.Location = new Point(23, 53);
            lstTask.Name = "lstTask";
            lstTask.Size = new Size(643, 134);
            lstTask.TabIndex = 0;
            lstTask.SelectedIndexChanged += lstTask_SelectedIndexChanged;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCtrlNToolStripMenuItem, menuFileOpen, menuFileSave, menuFileExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newCtrlNToolStripMenuItem
            // 
            newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            newCtrlNToolStripMenuItem.Size = new Size(148, 22);
            newCtrlNToolStripMenuItem.Text = "New  Ctrl+N";
            newCtrlNToolStripMenuItem.Click += newCtrlNToolStripMenuItem_Click;
            // 
            // menuFileOpen
            // 
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.Size = new Size(148, 22);
            menuFileOpen.Text = "Open data file";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.Size = new Size(148, 22);
            menuFileSave.Text = "Save datafile";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // menuFileExit
            // 
            menuFileExit.Name = "menuFileExit";
            menuFileExit.Size = new Size(148, 22);
            menuFileExit.Text = "Exit";
            menuFileExit.Click += menuFileExit_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(1163, 24);
            menuMain.TabIndex = 8;
            menuMain.Text = "menuStrip1";
            menuMain.ItemClicked += menuStrip1_ItemClicked;
            // 
            // AddTask
            // 
            AddTask.BackColor = Color.LightGreen;
            AddTask.Location = new Point(336, 163);
            AddTask.Name = "AddTask";
            AddTask.Size = new Size(75, 23);
            AddTask.TabIndex = 9;
            AddTask.Text = "Add";
            AddTask.UseVisualStyleBackColor = false;
            AddTask.Click += AddTask_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1163, 612);
            Controls.Add(AddTask);
            Controls.Add(groupBox1);
            Controls.Add(txtToDo);
            Controls.Add(label3);
            Controls.Add(cmbPriority);
            Controls.Add(label2);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "MainForm";
            Text = "ToDo Reminder";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private ComboBox cmbPriority;
        private Label label3;
        private TextBox txtToDo;
        private GroupBox groupBox1;
        private ListBox lstTask;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newCtrlNToolStripMenuItem;
        private ToolStripMenuItem menuFileExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private MenuStrip menuMain;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuFileOpen;
        private Button AddTask;
    }
}
