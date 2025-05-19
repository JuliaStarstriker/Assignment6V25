namespace Assigment6
{
    public record Category(string Name, CategoryType Type);

    public record Transaction(
        DateTime Date,
        decimal Amount,
        Category Category,
        string Description
    );

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

        

        public void testCAtegory()
        {
            var rent = new Category("Rent", CategoryType.Expense);
            var salary = new Category("Salary", CategoryType.Revenue);

            MessageBox.Show(rent.Name);
            
        }


        private void InitializeGUI()
        {
            taskManager = new TaskManager();

            lstEconomy.Items.Clear();

            cmbType.Items.Clear();

            cmbType.Items.AddRange(Enum.GetNames(typeof(CategoryType)));


            cmbType.SelectedIndex = (int)CategoryType.Revenue;

            txtToDo.Text = string.Empty;

            txtAmount.Text = string.Empty;
        }

        private void UpdateGUI()
        {
            lstEconomy.Items.Clear();
            string[] infoStrings = taskManager.GetInfoStringsList();
            if (infoStrings != null)
            {
                lstEconomy.Items.AddRange(infoStrings);
            }
        }

        private Transaction ReadInput()
        {
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount < 0)
            {
                MessageBox.Show("Please enter a valid (non-negative) amount.");
                return null;
            }

            if (dateTimePicker.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please select a valid date.");
                return null;
            }

            string name = txtName.Text?.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.");
                return null;
            }

            if (!Enum.TryParse(cmbType.Text, out CategoryType type))
            {
                MessageBox.Show("Please select a valid category type.");
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtToDo.Text))
            {
                MessageBox.Show("Description cannot be empty.");
                return null;
            }
            string desc = txtToDo.Text.Trim();

            var category = new Category(name, type);

            return new Transaction(dateTimePicker.Value, (decimal)amount, category, desc);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you really want to exit my program? hope to se you again if you want to",
                "Think twice", MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";

            bool ok = taskManager.WriteDataToFile(fileName);
            if (!ok)
                MessageBox.Show(errMessage);
            else
                MessageBox.Show(" Data saved to file:" + Environment.NewLine + fileName);
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
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
            Transaction transaction = ReadInput();
            if (transaction != null && taskManager.AddNewTransaction(transaction))
            {
                UpdateGUI();
            }
        }

        private void lstEconomy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
