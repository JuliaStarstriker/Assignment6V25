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
        public bool SaveTransactionListToFile(List<Transaction> transactions, string fileName)
        {
            try
            {
                var lines = transactions.Select(tx =>
                    $"{tx.Date:o},{tx.Amount},{tx.Category.Name},{tx.Category.Type},{tx.Description}"
                );
                File.WriteAllLines(fileName, lines);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transactions: " + ex.Message);
                return false;
            }
        }

        public bool ReadTransactionListFromFile(List<Transaction> transactions, string fileName)
        {
            if (!File.Exists(fileName))
                return false;

            try
            {
                string[] lines = File.ReadAllLines(fileName);
                transactions.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length < 5)
                    {
                        MessageBox.Show("Invalid line format.");
                        continue;
                    }

                    if (!DateTime.TryParse(parts[0], null, System.Globalization.DateTimeStyles.RoundtripKind, out DateTime date))
                    {
                        MessageBox.Show("Invalid date format.");
                        continue;
                    }

                    if (!decimal.TryParse(parts[1], out decimal amount))
                    {
                        MessageBox.Show("Invalid amount.");
                        continue;
                    }

                    string categoryName = parts[2];

                    if (!Enum.TryParse(parts[3], out CategoryType categoryType))
                    {
                        MessageBox.Show("Invalid category type.");
                        continue;
                    }

                    string description = string.Join(",", parts.Skip(4));

                    var category = new Category(categoryName, categoryType);
                    var transaction = new Transaction(date, amount, category, description);

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
