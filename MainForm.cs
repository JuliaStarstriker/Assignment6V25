namespace Assigment6
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;

        string fileName = Application.StartupPath + "\\Task.txt";

        public MainForm()
        {
            InitializeComponent();

            InitializeGUI();

            taskManager = new TaskManager();
        }

        private void InitializeGUI()
        {
            taskManager = new TaskManager();

            // Clear the ListBox
            lstTask.Items.Clear();

            // clear the priority box
            cmbPriority.Items.Clear();

            // Fill the ComboBox
            cmbPriority.Items.AddRange(Enum.GetNames(typeof(PriorityType)));

            //set Standard Value to ComboBox
            cmbPriority.SelectedIndex = (int)PriorityType.Normal;

            //make sure listbox is empty
            txtToDo.Text = string.Empty;
        }

        /// <summary>
        /// pdates the graphical user interface (GUI) with the latest task information
        /// </summary>
        private void UpdateGUI()
        {
            lstTask.Items.Clear();
            string[] infoStrings = taskManager.GetInfoStringsList();
            if (infoStrings != null)
            {
                lstTask.Items.AddRange(infoStrings);
            }
        }


        /// <summary>
        /// Read Input from user (Date and time, priority, description)
        /// </summary>
        /// <returns>ReadInputTask</returns>
        private Task ReadInput()
        {
            Task ReadInputTask = new Task();

            if (dateTimePicker.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please select a valid date.");
                return null;
            }

            ReadInputTask.DateAndTime = dateTimePicker.Value;

            if (Enum.TryParse(cmbPriority.Text, out PriorityType priority))
            {
                ReadInputTask.Priority = priority;
            }
            else
            {
                MessageBox.Show("Pleas provide priority type", "Error");
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtToDo.Text))
            {
                MessageBox.Show("Description cannot be empty.");
                return null;
            }
            else
            {
                ReadInputTask.Description = txtToDo.Text;
            }

            return ReadInputTask;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            //displays a confirmation message box when the user attempts to exit the program
            DialogResult dlgResult = MessageBox.Show("Do you really want to exit my program? hope to se you again if you want to",
                "Think twice", MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            //attempts to save the task data to a file and displays a message box based on the result
            string errMessage = "Something went wrong while saving data to file";

            bool ok = taskManager.WriteDataToFile(fileName);
            if (!ok)
                MessageBox.Show(errMessage);
            else
                MessageBox.Show(" Data saved to file:" + Environment.NewLine + fileName);
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            //attempts to read data from a file and updates the GUI based on the result
            string errMessage = "Something went wrong while opening data to file";

            bool ok = taskManager.ReadDataFromFile(fileName);
            if (!ok)
                MessageBox.Show(errMessage);
            else
                UpdateGUI();
        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            Task task = ReadInput();
            if (taskManager.AddNewTask(task))
            {
                UpdateGUI();
            }
        }

        private void lstTask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
