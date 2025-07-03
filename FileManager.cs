using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace Assigment6
{
    internal class FileManager
    {
        // Saves the list of transactions to a file
        public bool SaveTransactionListToFile(List<Transaction> transactions, string fileName)
        {
            try
            {
                // Convert each transaction to a CSV line string
                var lines = transactions.Select(tx =>
                    $"{tx.Date:o},{tx.Amount},{tx.Category.Name},{tx.Category.Type},{tx.Description}"
                );
                // Write all lines to the specified file
                File.WriteAllLines(fileName, lines);
                return true;
            }
            catch (Exception ex)
            {
                // Show error message if saving fails
                MessageBox.Show("Error saving transactions: " + ex.Message);
                return false;
            }
        }

        // Reads transactions from a file and populates the provided list
        public bool ReadTransactionListFromFile(List<Transaction> transactions, string fileName)
        {
            if (!File.Exists(fileName))
                return false;

            try
            {
                string[] lines = File.ReadAllLines(fileName);
                transactions.Clear();

                // Process each line representing one transaction
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // Validate that we have at least 5 parts (Date, Amount, CategoryName, CategoryType, Description)
                    if (parts.Length < 5)
                    {
                        MessageBox.Show("Invalid line format.");
                        continue;
                    }

                    // Try to parse the first part as a DateTime
                    if (!DateTime.TryParse(parts[0], null, System.Globalization.DateTimeStyles.RoundtripKind, out DateTime date))
                    {
                        MessageBox.Show("Invalid date format.");
                        continue;
                    }

                    // Try to parse the second part as a decimal amount
                    if (!decimal.TryParse(parts[1], out decimal amount))
                    {
                        MessageBox.Show("Invalid amount.");
                        continue;
                    }

                    // The third part is the category name (string)
                    string categoryName = parts[2];

                    // Try to parse the fourth part as the CategoryType enum
                    if (!Enum.TryParse(parts[3], out CategoryType categoryType))
                    {
                        MessageBox.Show("Invalid category type.");
                        continue;
                    }

                    string description = string.Join(",", parts.Skip(4));

                    var category = new Category(categoryName, categoryType);
                    var transaction = new Transaction(date, amount, category, description);

                    // Add the new transaction to the list
                    transactions.Add(transaction);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading transactions: " + ex.Message);
                return false;
            }
        }
    }
}
