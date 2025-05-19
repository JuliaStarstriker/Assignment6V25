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
        /// <summary>
        /// string.Join combines all strings in the collection into a single string
        /// Environment.NewLine creates a new line between each task
        /// task.Tostring creates a string of each task
        /// taskList.Select crates a list of tasks that are strings with help of task.Tostring
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            string content = string.Join(Environment.NewLine, taskList.Select(task => task.ToString()));
            
            try
            {
                // Skriv strängen till filen
                File.WriteAllText(fileName, content);

                Console.WriteLine("Texten har skrivits till filen: " + fileName);
            }
            catch (Exception ex)
            {
                // Hantera eventuella fel
                Console.WriteLine("Ett fel inträffade: " + ex.Message);
            }
            return true;
        }

        public bool ReadTaskListFrFile(List<Task> taskList, string fileName)
        {
            if (!File.Exists(fileName))
                return false;

            string[] lines = File.ReadAllLines(fileName);
            taskList.Clear();

            foreach (string line in lines)
            {
                // Split by comma (but support description containing commas)
                string[] parts = line.Split(',');

                if (parts.Length < 4)
                {
                    MessageBox.Show("Invalid line format.");
                    continue;
                }

                // Try parse date
                if (!DateTime.TryParse(parts[0], out DateTime dateTime))
                {
                    MessageBox.Show("Invalid date format.");
                    continue;
                }

                string name = parts[1];

                if (!Enum.TryParse(parts[2], out CategoryType category))
                {
                    MessageBox.Show("Invalid category.");
                    continue;
                }

                // Combine rest as description (in case it has commas)
                string description = string.Join(",", parts.Skip(3));

                // Create and add Task
                //Task task = new Task(dateTime, name, description, category);
                //taskList.Add(task);
            }

            return true;
        }
    }
}
