using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Numerics;
using System.Text;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Assigment6
{
    //Assignment 6 

    //////////////////////////////////////////////////
    // The main objectives of this assignment are //
    ////////////////////////////////////////////////

    //• To use records to define immutable data structures.
    //• To use tuples to return multiple values from methods.
    //• To practice working with collections (e.g., Lists, Dictionaries, and HashSets) to manage and organize data

    //////////////////
    // Description //
    ////////////////

    //Families and businesses often need to analyze or plan their monthly cash-flow to find a balance
    //between incomes and expenses.In this assignment, you will build an application to track
    //expenses and incomes (revenues) on a monthly basis.The system will help users (individuals
    //or businesses) understand their financial situation by calculating the difference between
    //incomes and expenses for each month.

    //Solution:

    //record representing a category with a name and a type (Revenue or Expense)
    public record Category(string Name, CategoryType Type);

    //record representing a transaction with date, amount, category, and description
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

        /// <summary>
        /// Populates the category list box with unique categories from TaskManager
        /// </summary>
        private void PopulateCategoryListBox()
        {
            var categories = taskManager.GetUniqueCategories();

            lstMonthEconomy.Items.Clear();
            lstMonthEconomy.Items.AddRange(categories.ToArray());
        }

        /// <summary>
        /// Displays transactions grouped by month, including totals and conditional labels based on checkboxes
        /// </summary>
        private void ShowGroupedTransactionsWith()
        {
            var grouped = taskManager.GetTransactionByMonth();

            lstMonthEconomy.Items.Clear();

            var orderedMonths = grouped.Keys.OrderBy(k => k).ToList();

            for (int i = 0; i < orderedMonths.Count; i++)
            {
                var month = orderedMonths[i];
                lstMonthEconomy.Items.Add($"--- {month:yyyy-MM} ---");

                decimal totalRevenue = 0;
                decimal totalExpense = 0;
                decimal sum = 0;

                
                foreach (var tx in grouped[month])
                {
                    string item = $"{tx.Date:dd} - {tx.CategoryName} - {tx.Amount:C} - {tx.Description}";
                    lstMonthEconomy.Items.Add(item);

                    if (tx.CategoryType == CategoryType.Revenue)
                        totalRevenue += tx.Amount;
                    else if (tx.CategoryType == CategoryType.Expense)
                        totalExpense += tx.Amount;

                    sum = totalRevenue - totalExpense;
                }

                lstMonthEconomy.Items.Add($"  Total Revenue: {totalRevenue:C}");
                lstMonthEconomy.Items.Add($"  Total Expense: {totalExpense:C}");

                if (cbCampany.Checked && cbIndividual.Checked)
                {
                    MessageBox.Show($"Choose what you are using this as: Company or Individual in the right corner");
                }
                else if (cbIndividual.Checked)
                {
                    lstMonthEconomy.Items.Add($"Surplus/Deficit: {sum:C}");
                }
                else if (cbCampany.Checked)
                {
                    lstMonthEconomy.Items.Add($"Profit/Loss: {sum:C}");
                }
                else
                {
                    MessageBox.Show($"Choose what you are using this as: Company or Individual in the right corner");
                }

                if (i < orderedMonths.Count - 1)
                {
                    lstMonthEconomy.Items.Add("");
                }
            }
        }


        /// <summary>
        /// Initializes GUI elements with default values and clears lists and textboxes
        /// </summary>
        private void InitializeGUI()
        {
            lstEconomy.Items.Clear();

            cmbType.Items.Clear();

            cmbType.Items.AddRange(Enum.GetNames(typeof(CategoryType)));


            cmbType.SelectedIndex = (int)CategoryType.Revenue;

            txtToDo.Text = string.Empty;

            txtAmount.Text = string.Empty;
        }

        // Updates the economy listbox with transaction info strings or message if none
        private void UpdateGUI()
        {
            lstEconomy.Items.Clear();
            string[] infoStrings = taskManager.GetInfoStringsList();

            if (infoStrings == null || infoStrings.Length == 0)
            {
                lstEconomy.Items.Add("No transactions found.");
            }
            else
            {
                lstEconomy.Items.AddRange(infoStrings);
            }
        }

        /// <summary>
        /// Reads and validates input fields, then creates a Transaction object or shows error messages
        /// </summary>
        /// <returns></returns>
        private Transaction ReadInput()
        {
            // Validate amount input
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount < 0)
            {
                MessageBox.Show("Please enter a valid (non-negative) amount.");
                return null;
            }

            // Validate date input (should not be minimum date)
            if (dateTimePicker.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please select a valid date.");
                return null;
            }

            // Validate category name input
            string name = txtName.Text?.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.");
                return null;
            }

            // Validate category type selection
            if (!Enum.TryParse(cmbType.Text, out CategoryType type))
            {
                MessageBox.Show("Please select a valid category type.");
                return null;
            }

            // Validate description input
            if (string.IsNullOrWhiteSpace(txtToDo.Text))
            {
                MessageBox.Show("Description cannot be empty.");
                return null;
            }
            string desc = txtToDo.Text.Trim();

            // Create Category and Transaction objects
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
                ShowGroupedTransactionsWith();
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


        private void button1_Click(object sender, EventArgs e)
        {
            ShowGroupedTransactionsWith();
        }

        private void lstMonthEconomy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
