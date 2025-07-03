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
            cmbType = new ComboBox();
            label3 = new Label();
            txtToDo = new TextBox();
            groupBox1 = new GroupBox();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lstEconomy = new ListBox();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newCtrlNToolStripMenuItem = new ToolStripMenuItem();
            menuFileOpen = new ToolStripMenuItem();
            menuFileSave = new ToolStripMenuItem();
            menuFileExit = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuMain = new MenuStrip();
            AddTask = new Button();
            txtName = new TextBox();
            label8 = new Label();
            label10 = new Label();
            txtAmount = new TextBox();
            btnGroupByMonth = new Button();
            lstMonthEconomy = new ListBox();
            groupBox2 = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            cbCampany = new CheckBox();
            cbIndividual = new CheckBox();
            label16 = new Label();
            groupBox1.SuspendLayout();
            menuMain.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 86);
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
            dateTimePicker.Location = new Point(173, 86);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(273, 23);
            dateTimePicker.TabIndex = 1;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(465, 86);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 2;
            label2.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(531, 86);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 176);
            label3.Name = "label3";
            label3.Size = new Size(141, 17);
            label3.TabIndex = 4;
            label3.Text = "transaction description";
            label3.Click += label3_Click;
            // 
            // txtToDo
            // 
            txtToDo.Location = new Point(173, 176);
            txtToDo.Name = "txtToDo";
            txtToDo.Size = new Size(531, 23);
            txtToDo.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lstEconomy);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(40, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 222);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Economy";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(480, 35);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 13;
            label11.Text = "Amount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(209, 35);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 12;
            label9.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(311, 35);
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
            label6.Location = new Point(246, 35);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "(Type)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(150, 35);
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
            label4.Location = new Point(23, 35);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "Date";
            // 
            // lstEconomy
            // 
            lstEconomy.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstEconomy.FormattingEnabled = true;
            lstEconomy.ItemHeight = 13;
            lstEconomy.Location = new Point(23, 53);
            lstEconomy.Name = "lstEconomy";
            lstEconomy.Size = new Size(643, 134);
            lstEconomy.TabIndex = 0;
            lstEconomy.SelectedIndexChanged += lstEconomy_SelectedIndexChanged;
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
            AddTask.Location = new Point(295, 222);
            AddTask.Name = "AddTask";
            AddTask.Size = new Size(75, 23);
            AddTask.TabIndex = 9;
            AddTask.Text = "Add";
            AddTask.UseVisualStyleBackColor = false;
            AddTask.Click += AddTask_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(173, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 23);
            txtName.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 134);
            label8.Name = "label8";
            label8.Size = new Size(127, 17);
            label8.TabIndex = 10;
            label8.Text = "Name of transaction";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(431, 134);
            label10.Name = "label10";
            label10.Size = new Size(53, 17);
            label10.TabIndex = 12;
            label10.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(489, 134);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(215, 23);
            txtAmount.TabIndex = 13;
            // 
            // btnGroupByMonth
            // 
            btnGroupByMonth.BackColor = Color.LightGreen;
            btnGroupByMonth.Location = new Point(431, 222);
            btnGroupByMonth.Name = "btnGroupByMonth";
            btnGroupByMonth.Size = new Size(145, 23);
            btnGroupByMonth.TabIndex = 14;
            btnGroupByMonth.Text = "Groupe by month";
            btnGroupByMonth.UseVisualStyleBackColor = false;
            btnGroupByMonth.Click += button1_Click;
            // 
            // lstMonthEconomy
            // 
            lstMonthEconomy.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstMonthEconomy.FormattingEnabled = true;
            lstMonthEconomy.ItemHeight = 13;
            lstMonthEconomy.Location = new Point(62, 39);
            lstMonthEconomy.Name = "lstMonthEconomy";
            lstMonthEconomy.Size = new Size(266, 316);
            lstMonthEconomy.TabIndex = 14;
            lstMonthEconomy.SelectedIndexChanged += lstMonthEconomy_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(lstMonthEconomy);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            groupBox2.Location = new Point(729, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 391);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Month Economy";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(257, 21);
            label15.Name = "label15";
            label15.Size = new Size(71, 15);
            label15.TabIndex = 14;
            label15.Text = "Description";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(173, 21);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 14;
            label14.Text = "Amount";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(109, 23);
            label13.Name = "label13";
            label13.Size = new Size(40, 15);
            label13.TabIndex = 15;
            label13.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(62, 21);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 14;
            label12.Text = "Day";
            // 
            // cbCampany
            // 
            cbCampany.AutoSize = true;
            cbCampany.Location = new Point(173, 50);
            cbCampany.Name = "cbCampany";
            cbCampany.Size = new Size(78, 19);
            cbCampany.TabIndex = 16;
            cbCampany.Text = "Company";
            cbCampany.UseVisualStyleBackColor = true;
            // 
            // cbIndividual
            // 
            cbIndividual.AutoSize = true;
            cbIndividual.Location = new Point(269, 50);
            cbIndividual.Name = "cbIndividual";
            cbIndividual.Size = new Size(78, 19);
            cbIndividual.TabIndex = 17;
            cbIndividual.Text = "Individual";
            cbIndividual.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(-2, 49);
            label16.Name = "label16";
            label16.Size = new Size(151, 17);
            label16.TabIndex = 18;
            label16.Text = "Are you using this as an ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1163, 612);
            Controls.Add(label16);
            Controls.Add(cbIndividual);
            Controls.Add(cbCampany);
            Controls.Add(groupBox2);
            Controls.Add(btnGroupByMonth);
            Controls.Add(txtAmount);
            Controls.Add(label10);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(AddTask);
            Controls.Add(groupBox1);
            Controls.Add(txtToDo);
            Controls.Add(label3);
            Controls.Add(cmbType);
            Controls.Add(label2);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "MainForm";
            Text = "Economy calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private ComboBox cmbType;
        private Label label3;
        private TextBox txtToDo;
        private GroupBox groupBox1;
        private ListBox lstEconomy;
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
        private TextBox txtName;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtAmount;
        private Label label11;
        private Button btnGroupByMonth;
        private ListBox lstMonthEconomy;
        private GroupBox groupBox2;
        private Label label12;
        private Label label15;
        private Label label14;
        private Label label13;
        private CheckBox cbCampany;
        private CheckBox cbIndividual;
        private Label label16;
    }
}
