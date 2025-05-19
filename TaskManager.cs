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

        public TaskManager()
        {
            transactions = new List<Transaction>();
        }

        public bool AddNewTransaction(Transaction newTransaction)
        {
            if (newTransaction != null)
            {
                transactions.Add(newTransaction);
                return true;
            }
            return false;
        }

        public string[] GetInfoStringsList()
        {
            return transactions.Select(tx =>
                $"{tx.Date:yyyy-MM-dd}   {tx.Date:HH:mm}   " +
                $"{tx.Category.Name} ({tx.Category.Type}),  " +
                $"{tx.Description,-20}  {tx.Amount,10:C}"
            ).ToArray();
        }

        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTransactionListToFile(transactions, fileName); // update method
        }

        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadTransactionListFromFile(transactions, fileName); // update method
        }

    }
}
