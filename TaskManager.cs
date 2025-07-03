using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment6
{
    internal class TaskManager
    {

        List<Transaction> transactions;

        private Dictionary<DateTime, List<Transaction>> transactionsByMonth;

        private HashSet<string> uniqueCategories;

        // Constructor initializes collections
        public TaskManager()
        {
            transactions = new List<Transaction>();
            transactionsByMonth = new Dictionary<DateTime, List<Transaction>>();
            uniqueCategories = new HashSet<string>();
        }

        /// <summary>
        ///  Adds a new transaction to the system
        /// </summary>
        /// <param name="newTransaction"></param>
        /// <returns></returns>
        public bool AddNewTransaction(Transaction newTransaction)
        {
            if (newTransaction == null)
                return false;

            // Add to the main transaction list
            transactions.Add(newTransaction);

            // Create a key for the month of this transaction (year-month-01)
            DateTime monthKey = new DateTime(newTransaction.Date.Year, newTransaction.Date.Month, 1);

            // If no transactions exist for this month yet, create a new list for it
            if (!transactionsByMonth.ContainsKey(monthKey))
            {
                transactionsByMonth[monthKey] = new List<Transaction>();
            }

            // Add transaction to the month's list
            transactionsByMonth[monthKey].Add(newTransaction);

            // Add category name to the unique categories set (no duplicates)
            uniqueCategories.Add(newTransaction.Category.Name);

            return true;
        }

        // Returns the dictionary of transactions grouped by month (read-only)
        public IReadOnlyDictionary<DateTime, List<Transaction>> GetTransactionsByMonth()
        {
            return transactionsByMonth;
        }

        // Returns a read-only collection of unique category names
        public IReadOnlyCollection<string> GetUniqueCategories()
        {
            return uniqueCategories;
        }

        // Returns an array of formatted strings describing each transaction for display
        public string[] GetInfoStringsList()
        {
            return transactions.Select(tx =>
                $"{tx.Date:yyyy-MM-dd}   {tx.Date:HH:mm}   " +
                $"{tx.Category.Name} ({tx.Category.Type}),  " +
                $"{tx.Description,-20}  {tx.Amount,10:C}"
            ).ToArray();
        }

        /// <summary>
        ///  Saves all transactions to a file by delegating to FileManager
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTransactionListToFile(transactions, fileName); // update method
        }

        /// <summary>
        /// Reads transactions from a file using FileManager and rebuilds internal collections if successful
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            bool result = fileManager.ReadTransactionListFromFile(transactions, fileName);

            if (result)
            {
                RebuildInternalCollections();
            }

            return result;

        }

        // Returns a dictionary grouping transactions by month, but using tuples
        public Dictionary<DateTime, List<(DateTime Date, string CategoryName, CategoryType CategoryType, decimal Amount, string Description)>> GetTransactionByMonth()
        {
            return transactions
                .GroupBy(tx => new DateTime(tx.Date.Year, tx.Date.Month, 1))
                .ToDictionary(
                    g => g.Key,
                    g => g.Select(tx => (tx.Date, tx.Category.Name, tx.Category.Type, tx.Amount, tx.Description)).ToList()
                );
        }

        // Helper method to rebuild internal collections from the main transaction list
        private void RebuildInternalCollections()
        {
            transactionsByMonth.Clear();
            uniqueCategories.Clear();

            foreach (var tx in transactions)
            {
                // Group by month
                DateTime monthKey = new DateTime(tx.Date.Year, tx.Date.Month, 1);
                if (!transactionsByMonth.ContainsKey(monthKey))
                {
                    transactionsByMonth[monthKey] = new List<Transaction>();
                }
                transactionsByMonth[monthKey].Add(tx);

                // Collect unique categories
                uniqueCategories.Add(tx.Category.Name);
            }
        }

    }
}
